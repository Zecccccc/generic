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
    public partial class Hash : Form
    {
        public Hashtable hashTable;
        public ICollection NoS;
        public int num;
        public Hash()
        {
            InitializeComponent();

            hashTable = new Hashtable();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hashTable.Add(num++, textBox1.Text);
            displayValue();

        }
        private void displayValue( ) 
        {
            listView1.Clear();
            NoS = hashTable.Keys;
            foreach (int key in NoS)
            {
                listView1.Items.Add(key + ": " + hashTable[key].ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arraylist al = new Arraylist();
            this.Hide();
            al.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Sorted sl = new Sorted();
            this.Hide();
            sl.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Stacks s = new Stacks();
            this.Hide();
            s.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Q que = new Q();
            this.Hide();
            que.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            hashTable.Remove(Convert.ToInt32(textBox7.Text));
            displayValue();
        }
    }
}
