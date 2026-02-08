using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ToDoListReview
{
    public class Task : INotifyPropertyChanged
    {
        private bool isCompleted = false;
        public string doneOrNot => isCompleted ? "已完成" : "未完成";
        public Visibility visibility => isCompleted ? Visibility.Visible : Visibility.Hidden;
        public string time { get; set; }
        public string expire { get; set; }
        public string title { get; set; }
        public string description { get; set; }


        public bool IsCompleted
        {
            get { return isCompleted; }
            set
            {
                isCompleted = value;
                OnPropertyChanged(nameof(visibility)); 
                OnPropertyChanged(nameof(doneOrNot));
            }
        }

        public Task(string time, string expire, string title, string description)
        {
            this.time = time;
            this.expire = expire;
            this.title = title;
            this.description = description;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
