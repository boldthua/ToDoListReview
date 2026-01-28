using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListReview
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        public string Time { get; set; }
        public string Expire { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ObservableCollection<Task> toDoList { get; set; } = new ObservableCollection<Task>();

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
