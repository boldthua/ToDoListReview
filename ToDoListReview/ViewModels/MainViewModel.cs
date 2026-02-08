using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ToDoListReview.Models;
using ToDoListReview.Presenter;
using static ToDoListReview.Contract.MainContract;

namespace ToDoListReview
{
    internal class MainViewModel : INotifyPropertyChanged , IMainView
    {
        private string _time;
        public string Expire { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public MainPresenter presenter { get; set; }

        public MainViewModel()
        {
            DeleteCommand = new RelayCommand<Task>(DeleteTask);
            AddTaskCommand = new RelayCommand(AddTask);
        }
        public string Time
        {
            get { return _time; }
            set
            {
                _time = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Task> toDoList { get; set; } = new ObservableCollection<Task>();

        public ICommand AddTaskCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;


        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void AddTask()
        {
            TaskDTO task = new TaskDTO(Time, Expire, Title, Description);
            presenter.CreateTask(task);
            //toDoList.Add(new Task(Time, Expire, Title, Description));
            
        }
        public void DeleteTask(Task task)
        {
            MessageBoxResult result = MessageBox.Show("確定刪除？", "刪除提示", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.No)
                return;
            toDoList.Remove(task);
        }


        public void RenderDatas(List<TaskDTO> tasks)
        {
            throw new NotImplementedException();
        }
    }


}
