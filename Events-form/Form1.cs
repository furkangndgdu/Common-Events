using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox3.Text = "1";
           textBox4.Enabled = false;    
            textBox5.Enabled = false;
            radioButton1.Checked = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                  
                double birimfiyat = Convert.ToDouble(textBox2.Text);
                double adet = Convert.ToDouble(textBox3.Text);
                double tutar = birimfiyat * adet;
                double kdv = 0;
                if (radioButton1.Checked == true)
                {
                    kdv = tutar * 0.25;
                }
                else if (radioButton2.Checked == true)
                {
                    kdv = tutar * 0.18;
                }
                else if (radioButton3.Checked == true)
                {
                    kdv = tutar * 0.08;
                }
                tutar = kdv + tutar;
                if (checkBox1.Checked==true)
                {
                    tutar = tutar - tutar*0.1;
                }
                textBox4.Text=Convert.ToString(kdv);
                textBox5.Text=Convert.ToString(tutar);   

            }
            catch (Exception)
            {

                
            }
           

        }
    }
}
