using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListReview.Models;

namespace ToDoListReview.Contract
{
    internal class MainContract
    {
        public interface IMainView 
        {
            // 顯示

            void RenderDatas(List<TaskDTO> tasks);
        }

        public interface IMainPresenter 
        {
            // 讀取

            void CreateTask(TaskDTO task);
            void RemoveTask(string task);
            


        }
    }
}
