using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TaskManager_WinForms.Views
{
    public interface IMainView
    {
        EventHandler<EventArgs> RunNewTask { get; set; }
        EventHandler<EventArgs> EndTask { get; set; }
        EventHandler<EventArgs> Exit { get; set; }
        ObservableCollection<string> Tasks { get; set; }
    }
}
