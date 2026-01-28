using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ToDoListReview
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel viewModel = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Task task = new Task(Time.Text, Expire.Text, Title.Text, Description.Text);
            viewModel.toDoList.Add(task);
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("確定刪除？", "刪除提示", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.No)
                return;
            Button button = (Button)sender;
            //StackPanel panel = button.Parent as StackPanel;
            Task task = (Task)button.DataContext;
            viewModel.toDoList.Remove(task);
        }
    }
}
