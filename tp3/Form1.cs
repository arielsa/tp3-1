using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && listBox1.Items.Count < 5)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Error de Carga");
            }
        }

        private void btn_add_2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && listBox2.Items.Count < 5)
            {
                listBox2.Items.Add(textBox2.Text);
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Error de Carga");
            }
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == listBox2.Items.Count)
            {
                listBox3.Items.Clear();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox3.Items.Add(int.Parse(listBox2.Items[i].ToString()) +
                   int.Parse(listBox1.Items[i].ToString()));
                }
            }
        }
    }
}
