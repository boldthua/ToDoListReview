using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListReview.Models;

namespace ToDoListReview.Repository
{
    internal interface IRepository
    {
        void AddTask(TaskDTO task);
        void RemoveTask(string title);
        List<TaskDTO> GetDetas();
    }
}
