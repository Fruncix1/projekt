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
    public partial class MainWindow : Window
    {
        private TaskManager _taskManager = new TaskManager();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Task(object sender, EventArgs e)
        {
            _taskManager.AddTask(TaskInput.Text);
            TaskInput.Clear();
            RefreshTaskList();

            // MessageBox.Show("Zadanie dodane!");
        }

        private void Remove_Task(object sender, EventArgs e)
        {
            if (TaskList.SelectedItem != null)
            {
                _taskManager.RemoveTask(TaskList.SelectedItem.ToString());
                RefreshTaskList();
            }

            // MessageBox.Show("Zadanie usunięte!");
        }

        private void RefreshTaskList()
        {
            TaskList.Items.Clear();
            foreach (var task in _taskManager.Tasks) 
            {
                TaskList.Items.Add(task);
            }
        }

        public class TaskManager
        {
            private List<string> _tasks = new List<string>();

            public void AddTask(string task)
            {
                if (!string.IsNullOrEmpty(task))
                {
                    _tasks.Add(task);
                }
            }

            public void RemoveTask(string task)
            {
                _tasks.Remove(task);
            }

            public IReadOnlyList<string> Tasks => _tasks.AsReadOnly();
        }
    }
}
