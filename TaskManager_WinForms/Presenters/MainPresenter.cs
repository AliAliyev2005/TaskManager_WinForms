using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TaskManager_WinForms.Views;

namespace TaskManager_WinForms.Presenters
{
    class MainPresenter
    {
        private IMainView _view;

        public MainPresenter(IMainView view)
        {
            _view = view;
            _view.Tasks = new ObservableCollection<string>();

            _view.RunNewTask += ViewRunNewTask;
            _view.EndTask = ViewEndTask;
            _view.Exit = ViewExit;
        }

        public void ViewRunNewTask(object sender, EventArgs e)
        {
            _view.Tasks.Add("asd");
        }

        public void ViewEndTask(object sender, EventArgs e)
        {

        }

        public void ViewExit(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
