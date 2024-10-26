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

        // Konstruktor klasy MainWindow
        public MainWindow()
        {
            InitializeComponent(); // Inicjalizacja komponentów interfejsu użytkownika
        }

        // Metoda obsługująca dodawanie nowego zadania
        private void Add_Task(object sender, EventArgs e)
        {
            // Pobranie wybranej daty przypomnienia
            DateTime? reminderDate = ReminderDatePicker.SelectedDate;

            // Dodanie zadania do menedżera zadań
            _taskManager.AddTask(TaskInput.Text, reminderDate);

            // Wyczyść pole tekstowe i datę przypomnienia po dodaniu zadania
            TaskInput.Clear();
            ReminderDatePicker.SelectedDate = null;

            // Odświeżenie listy zadań, aby pokazać nowo dodane zadanie
            RefreshTaskList();
        }

        // Metoda obsługująca usuwanie wybranego zadania
        private void Remove_Task(object sender, EventArgs e)
        {
            // Sprawdzenie, czy zostało wybrane zadanie
            if (TaskList.SelectedItem != null)
            {
                // Usunięcie zadania z menedżera zadań na podstawie jego nazwy
                _taskManager.RemoveTask(TaskList.SelectedItem.ToString());

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

        // Klasa reprezentująca pojedyncze zadanie
        public class Task
        {
            public string Name { get; set; } // Nazwa zadania
            public DateTime? ReminderDate { get; set; } // Opcjonalna data przypomnienia

            // Konstruktor zadania
            public Task(string name, DateTime? reminderDate = null)
            {
                Name = name;
                ReminderDate = reminderDate;
            }

            // Przeciążenie metody ToString() do wyświetlania zadania
            public override string ToString()
            {
                return ReminderDate.HasValue
                    ? $"{Name} (Przypomnienie: {ReminderDate.Value.ToShortDateString()})"
                    : Name;
            }
        }

        // Klasa menedżera zadań, odpowiedzialna za zarządzanie listą zadań
        public class TaskManager
        {
            private List<Task> _tasks = new List<Task>(); // Lista przechowująca wszystkie zadania

            // Metoda dodająca zadanie do listy
            public void AddTask(string taskName, DateTime? reminderDate = null)
            {
                if (!string.IsNullOrEmpty(taskName))
                {
                    _tasks.Add(new Task(taskName, reminderDate));
                }
            }

            // Metoda usuwająca zadanie z listy na podstawie jego nazwy
            public void RemoveTask(string taskName)
            {
                _tasks.RemoveAll(task => task.Name == taskName);
            }

            // Właściwość zwracająca listę zadań jako tylko do odczytu
            public IReadOnlyList<Task> Tasks => _tasks.AsReadOnly();
        }
    }
}
