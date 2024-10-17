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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Task(object sender, EventArgs e)
        {
            AddTaskToList(TaskInput.Text);
        }

        private void AddTaskToList(string task)
        {
            if (!string.IsNullOrEmpty(task))
            {
                TaskList.Items.Add(task);
                TaskInput.Clear();
            }
        }
    }
}
