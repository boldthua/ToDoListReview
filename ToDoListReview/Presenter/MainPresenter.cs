using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListReview.Models;
using ToDoListReview.Repository;
using static ToDoListReview.Contract.MainContract;

namespace ToDoListReview.Presenter
{
    internal class MainPresenter : IMainPresenter
    {
        IMainView view;
        IRepository repository;

        public MainPresenter(IMainView view)
        {
            this.view = view;
            repository = new TaskRepository();
        }
        public void CreateTask(TaskDTO task)
        {
            repository.AddTask(task);
            view.RenderDatas(repository.GetDetas());
        }

        public void RemoveTask(string title)
        {
            repository.RemoveTask(title);
            view.RenderDatas(repository.GetDetas());
        }
    }
}
