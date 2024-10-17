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

        private void Cos(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TaskInput.Text))
            {
                TaskList.Items.Add(TaskInput.Text);
                TaskInput.Clear();
            }
        }
    }
}
 
