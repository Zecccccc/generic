using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsAndGenerics
{
   
    public partial class Arraylist : Form
    { 

         public ArrayList arrayList;

    public Arraylist()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arrayList.Add(textBox1.Text);
            listView1.Clear();

            foreach (Object obj in arrayList)
            {
                listView1.Items.Add(obj.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arrayList.Remove(textBox1.Text);
            displayValue();
        }

        private void displayValue()
        {
            listView1.Clear();
            foreach (Object obj in arrayList)
            {
                listView1.Items.Add(obj.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
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

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Q que = new Q();
            que.Show();
        }
    }
}
