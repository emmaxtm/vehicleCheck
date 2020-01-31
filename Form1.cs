using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MotorSUS m1 = new MotorSUS(3, 25, 17);
            Vozilo vp = new Vozilo(m1);
            label3.Text="Registracija ce iznositi " +vp.Registracija();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MotorSUS m2 = new MotorSUS(4, 35, 20);
            Vozilo vt = new Vozilo(m2);
            label4.Text = "Registracija ce iznositi " + vt.Registracija();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox5.Text = (float.Parse(textBox3.Text) + float.Parse(textBox4.Text)).ToString();
            }
            catch
            {
                textBox5.Text = "Morate uneti broj!";
            }
        }
    }
}
