using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lista_zadań
{
    // Klasa głównego okna aplikacji
    public partial class MainWindow : Window
    {
        // Tworzenie instancji menedżera zadań
        private TaskManager _taskManager = new TaskManager();
        private System.Windows.Threading.DispatcherTimer _reminderTimer;

        // Konstruktor klasy MainWindow
        public MainWindow()
        {
            InitializeComponent(); // Inicjalizacja komponentów interfejsu użytkownika
            _reminderTimer = new System.Windows.Threading.DispatcherTimer();
            _reminderTimer.Interval = TimeSpan.FromSeconds(2);
            _reminderTimer.Tick += CheckReminders;
            _reminderTimer.Start();
        }

        // Metoda obsługująca dodawanie nowego zadania
        private void Add_Task(object sender, RoutedEventArgs e)
        {
            DateTime? reminderDate = ReminderDatePicker.SelectedDate;
            TimeSpan selectedTime;

            if (TimeSpan.TryParse(ReminderTimeInput.Text, out selectedTime))
            {
                if (reminderDate.HasValue)
                {
                    DateTime reminderDateTime = reminderDate.Value.Date + selectedTime;

                    // Pobranie wybranego priorytetu
                    Priority selectedPriority = (Priority)5;

                    _taskManager.AddTask(TaskInput.Text, reminderDateTime, selectedPriority);

                    TaskInput.Clear();
                    ReminderDatePicker.SelectedDate = null;
                    ReminderTimeInput.Clear();
                    PriorityComboBox.SelectedIndex = 1; // Reset do domyślnego (Średni)

                    RefreshTaskList();
                }

            }
            else
            {
                MessageBox.Show("Wprowadź poprawny format godziny (np. 14:30)", "Błąd", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }


        // Metoda obsługująca usuwanie wybranego zadania
        private void Remove_Task(object sender, RoutedEventArgs e)
        {
          if (TaskList.SelectedItem is Task selectedTask)
          {
              // Usunięcie zadania na podstawie obiektu Task
              _taskManager.RemoveTask(selectedTask);

              // Odświeżenie listy zadań po usunięciu zadania
              RefreshTaskList();
          }
        }

        // Metoda odświeżająca widok listy zadań
        private void RefreshTaskList()
        {
            // Czyszczenie listy zadań w widoku
            TaskList.Items.Clear();

            // Dodanie wszystkich zadań z menedżera do widoku
            foreach (var task in _taskManager.Tasks)
            {
                TaskList.Items.Add(task);
            }
        }

        private void CheckReminders(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            foreach (var task in _taskManager.Tasks)
            {
                if (task.ReminderDate.HasValue && task.ReminderDate.Value <= now && !task.IsReminderTriggered)
                {
                    MessageBox.Show($"Przypomnienie: {task.Name}\nCzas: {task.ReminderDate.Value:g}",
                                    "Powiadomienie",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);
                    task.IsReminderTriggered = true;
                }
            }

            RefreshTaskList();
        }


        // Priorytety dla zadań
        public enum Priority
        {
            Niski,
            Średni,
            Wysoki,
            Krytyczny
        }

        // Klasa reprezentująca pojedyncze zadanie
        public class Task
        {
            public string Name { get; set; } // Nazwa zadania
            public DateTime? ReminderDate { get; set; } // Data i godzina przypomnienia
            public bool IsReminderTriggered { get; set; } // Flaga dla przypomnienia
            public Priority PriorityLevel { get; set; } // Priorytet zadania

            // Konstruktor zadania z priorytetem
            public Task(string name, DateTime? reminderDate = null, Priority priority = Priority.Średni)
            {
                Name = name;
                ReminderDate = reminderDate;
                IsReminderTriggered = false;
                PriorityLevel = priority;
            }

            // Przeciążenie metody ToString() do wyświetlania zadania
            public override string ToString()
            {
                return ReminderDate.HasValue
                    ? $"{Name} [Priorytet: {PriorityLevel}] (Przypomnienie: {ReminderDate.Value:dd.MM.yyyy HH:mm})"
                    : $"{Name} [Priorytet: {PriorityLevel}]";
            }
        }


        // Klasa menedżera zadań, odpowiedzialna za zarządzanie listą zadań
        public class TaskManager
        {
            private List<Task> _tasks = new List<Task>(); // Lista przechowująca wszystkie zadania

            // Metoda dodająca zadanie do listy
            public void AddTask(string taskName, DateTime? reminderDate = null, Priority priority = Priority.Średni)
            {
                if (!string.IsNullOrEmpty(taskName))
                {
                    _tasks.Add(new Task(taskName, reminderDate, priority));
                    _tasks = _tasks.OrderByDescending(t => t.PriorityLevel).ToList(); // Sortowanie po priorytecie
                }
            }

            // Metoda usuwająca zadanie z listy na podstawie jego nazwy
            public void RemoveTask(Task taskToRemove)
            {
                _tasks.Remove(taskToRemove);
            }

            // Właściwość zwracająca listę zadań jako tylko do odczytu
            public IReadOnlyList<Task> Tasks => _tasks.AsReadOnly();
        }

    }

}
