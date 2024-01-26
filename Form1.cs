using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assessement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex > -1)
            { 
                listBox1.Items.RemoveAt(listBox1.SelectedIndex); 
            }
            else
            {
                MessageBox.Show("Select an item from the list");
            }
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                listBox1.Items[listBox1.SelectedIndex] = textBox1.Text;
            }
            else
            {
                MessageBox.Show("Select an Item from the list");
            }
            textBox1.Clear();
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

