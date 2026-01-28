using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListReview
{
    public class Task
    {
        public bool isCompleted { get; set; } = false;
        public string doneOrNot => isCompleted ? "已完成" : "未完成";
        public string time { get; set; }
        public string expire { get; set; }
        public string title { get; set; }
        public string description { get; set; }

        public Task(string time, string expire, string title, string description)
        {
            this.time = time;
            this.expire = expire;
            this.title = title;
            this.description = description;
        }

    }
}
