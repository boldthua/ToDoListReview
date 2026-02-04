using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ToDoListReview
{
    internal class DeleteTaskCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public MainViewModel viewModel { get; set; }
        public DeleteTaskCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBoxResult result = MessageBox.Show("確定刪除？", "刪除提示", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.No)
                return;
            var task = (Task)parameter;
            viewModel.toDoList.Remove(task);
        }
    }
}
