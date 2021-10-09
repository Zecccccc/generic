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
    public partial class Sorted : Form
    {
        public SortedList sl;
        public ICollection NoS;
        public int num;
        public Sorted()
        {
            InitializeComponent();
            sl = new SortedList();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            sl.Add(num++, textBox1.Text);
            SortedList();

        }
        private void SortedList()
        {
            NoS = sl.Keys;
            listView1.Items.Clear();
            foreach (int key in NoS)
            {
                listView1.Items.Add(key + ": " + sl[key].ToString());
            }
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
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stacks s = new Stacks();
            s.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Q que = new Q();
            que.Show();
        }
    }
}
