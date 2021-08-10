using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaskManager_WinForms.Views
{
    public partial class MainView : Form,IMainView
    {
        public EventHandler<EventArgs> RunNewTask { get; set; }
        public EventHandler<EventArgs> EndTask { get; set; }
        public EventHandler<EventArgs> Exit { get; set; }
        public ObservableCollection<string> Tasks 
        { 
            get { return listBoxTasks.DataSource as ObservableCollection<string>; }
            set 
            {
                listBoxTasks.DataSource = null;
                listBoxTasks.DataSource = value;
            } 
        }

        public MainView()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunNewTask.Invoke(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit.Invoke(sender, e);
        }

        private void btnEndTask_Click(object sender, EventArgs e)
        {
            EndTask.Invoke(sender, e);
        }
    }
}
