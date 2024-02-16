using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoInteractiva
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            checkBox2.Appearance = Appearance.Button;
            checkBox2.Font = new Font("Microsoft Sans Serif", 16);
            checkBox2.AutoSize = false;
            checkBox2.Size = new Size(100, 100);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "JAUME" & textBox2.Text == "PASSWORD") { 
                
                MessageBox.Show ("WELCOME");
                //OBRIR NOU FORMULARI PASSANT DADES
                //string value = textBox1.Text;
                Form4 form4 = new Form4(textBox1.Text);
                form4.Show();
                //opcional: per tancar form1:
                this.Hide(); //closes the first form

            }
            else
            {
                MessageBox.Show("WRONG DATA");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            checkBox1.Checked = false;  
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox2.Tag = 0)
            //{
            //    checkBox2.Text = "✅";
            //    checkBox2.Tag = 1;
            //}
            //else
            //{
            //    checkBox2.Text = "☐";
            //    checkBox2.Tag = 0;
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            checkBox1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            checkBox1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Return))
            {


                if (textBox1.Text == "JAUME" & textBox2.Text == "PASSWORD")
                {

                    MessageBox.Show("WELCOME");
                    //OBRIR NOU FORMULARI PASSANT DADES
                    string value = textBox1.Text;
                    Form4 form4 = new Form4(value);
                    form4.Show();
                    //opcional: per tancar form1:
                    this.Hide(); //closes the first form

                }
                else
                {
                    MessageBox.Show("WRONG DATA");
                }
            }
        }
    }
}
