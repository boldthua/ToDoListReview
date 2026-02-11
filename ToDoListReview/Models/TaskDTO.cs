using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListReview.Models
{
    internal class TaskDTO
    {
        public bool isCompleted = false;
        public string time { get; set; }
        public string expire { get; set; }
        public string title { get; set; }
        public string description { get; set; }


        public TaskDTO(string time, string expire, string title, string description, bool isCompleted = false)
        {
            this.time = time;
            this.expire = expire;
            this.title = title;
            this.description = description;
            this.isCompleted = isCompleted;
        }
    }
}
