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
    public partial class Stacks : Form
    {
        public Stack studentstack;
        public Stacks()
        {
            InitializeComponent();
            studentstack = new Stack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentstack.Push(textBox1.Text);
            DisplayStack(studentstack);
        }

        private void DisplayStack(IEnumerable NoS)
        {
            listView1.Clear();
            foreach (Object obj in NoS)
            {
                listView1.Items.Add("" + obj);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentstack.Pop();
            DisplayStack(studentstack);
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

        private void button7_Click(object sender, EventArgs e)
        {
            Q que = new Q();
            this.Hide();
            que.Show();
        }
    }
}
