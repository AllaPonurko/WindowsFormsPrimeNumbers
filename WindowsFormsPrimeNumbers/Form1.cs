using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPrimeNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tasks = new List<Task>();
        }
        public MyTask my = new MyTask();
        public List<Task> tasks;
        private void btnGenerete_Click(object sender, EventArgs e)
        {
            if(txtStart.Text.Length!=0)
            {
                MyTask.start = Convert.ToInt32(txtStart.Text);
            }
            if(txtStart.Text.Length == 0)
            {
                MyTask.start = 1;
            }
            if(txtEnd.Text.Length != 0)
            {
                MyTask.end = Convert.ToInt32(txtEnd.Text);
            }
            if(txtEnd.Text.Length==0)
            {
                MessageBox.Show("Не задано конечное значение!! ");
            }
            if(Convert.ToInt32(txtEnd.Text)<Convert.ToInt32(txtStart.Text))
            {
                MessageBox.Show("Задан неверный интервал!!");
                return;
            }
            my.task = new Task(MyTask.Mystart);
            my.task.Start();
            Thread.Sleep(1000);
            tasks.Add(my.task);
            listBoxNum.Items.Clear();
          foreach(var item in MyTask.vs)
            {
                listBoxNum.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxTasks.Items.Clear();
            foreach (var item in tasks)
            {
                listBoxTasks.Items.Add(item.Id + " " + item.Status);
                if (item.IsCompleted == true)
                    listBoxTasks.Items.Add(" Задача завершена успешно!");
            }
        }
    }
}
