using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CollectionsAndGenerics
{
    public partial class Q : Form
    {
        public Queue studque;
        public Q()
        {
            InitializeComponent();
            studque = new Queue();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studque.Enqueue(textBox1.Text);
            DisplayQueue(studque);

        }

        private void DisplayQueue(IEnumerable NoS)
        {
            listView1.Clear();
            foreach (Object obj in NoS)
            {
                listView1.Items.Add("" + obj);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studque.Dequeue();
            DisplayQueue(studque);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arraylist al = new Arraylist();
            this.Hide();
            al.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hash ht = new Hash();
            ht.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sorted sl = new Sorted();
            sl.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stacks s = new Stacks();
            s.Show();
        }
    }
}
