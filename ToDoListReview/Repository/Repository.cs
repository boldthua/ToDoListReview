using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListReview.Models;

namespace ToDoListReview.Repository
{
    internal class Repository : IRepository
    {
        public List<TaskDTO> toDoList {  get; set; }
        public void AddTask(TaskDTO task)
        {
            toDoList.Add(task);
        }

        public void RemoveTask(string name)
        {
            throw new NotImplementedException();
        }
    }
}
