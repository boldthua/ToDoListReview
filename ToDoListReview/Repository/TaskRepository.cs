using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListReview.Models;

namespace ToDoListReview.Repository
{
    internal class TaskRepository : IRepository
    {

        public List<TaskDTO> toDoList = new List<TaskDTO>();

        public TaskRepository() { }
        public void AddTask(TaskDTO task)
        {
            toDoList.Add(task);
        }

        public void RemoveTask(string title)
        {

            toDoList.Remove(toDoList.First(x => x.title == title));
        }

        public List<TaskDTO> GetDetas()
        { return toDoList; }
    }
}
