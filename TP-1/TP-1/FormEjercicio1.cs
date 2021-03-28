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
            if (listBox_Izq.Items.Count != 0)
            {
                listBox_Der.Items.Add(listBox_Izq.SelectedItem.ToString());
                listBox_Izq.Items.Remove(listBox_Izq.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("La lista esta en blanco");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool repetido=true;
            

            if (textBox1.Text.Trim() != "")
            {

                foreach (var item in listBox_Izq.Items)
                {


                    if (textBox1.Text.Equals(item.ToString())) { repetido = false; break; }

                };

                
                if (repetido) { listBox_Izq.Items.Add(textBox1.Text); };

                textBox1.Text ="";
            }
            else
            {
                MessageBox.Show("Ingrese un nombre");
            }

           
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox_Izq.Items.Count != 0)
            {
                foreach (var item in listBox_Izq.Items)
                {
                    listBox_Der.Items.Add(item);
                }
                listBox_Izq.Items.Clear();
            }
            else
            {
                MessageBox.Show("La lista esta en blanco");
            }
            
        }
    }
}
