using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1
{
    public partial class FormEjercicio1 : Form
    {
        public FormEjercicio1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox_Der.Items.Add(listBox_Izq.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox_Izq.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(var item in listBox_Izq.Items)
            {
                listBox_Der.Items.Add(item);
            }
            
        }
    }
}
