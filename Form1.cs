using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace demoInteractiva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string value = textBox1.Text;
            Form2 form2 = new Form2();
            //form2.Show();
            form2.Show();
            //opcional: per tancar form1:
            //this.Close(); //closes the first form
            //Per ocultar form1 en lloc de tancar-lo:
            //this.Hide();
            //tambe es pot fer modificant la propietat visible:
            //this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //obrir form2 MODAL
            Form2 form2 = new Form2();
            form2.ShowDialog();

            //


            /*
             MessageBox.Show("hola");
             
             */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save changes?", "Save Changes",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Changes saved successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Changes discarded!", "Discarded",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Operation cancelled!", "Cancelled",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //obrir un altre formulari a la mateixa posició que el formulari actual
            Form2 form2 = new Form2();
            //
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(this.Left + 0, this.Top + 0);
            //            
            form2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "https://www.vidalibarraquer.net");
        }
    }
}
