using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagerApi
{   
    public partial class Form1 : Form
    {
        TaskDb db = new TaskDb();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void LoadTasks()
        {
            listTasks.Items.Clear();
            var tasks = db.GetAllTasks();
            foreach(var task in tasks)
            {
                listTasks.Items.Add($"{task.Id} : {task.Title}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.AddTask(txtTitle.Text);
            txtTitle.Clear();
            LoadTasks();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedItem != null)
            {
                string selected = listTasks.SelectedItem.ToString();
                int id = int.Parse(selected.Split(':')[0]);
                db.DeleteTask(id);
                LoadTasks();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
