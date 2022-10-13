using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES_CriptorG3x
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCript_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxCriptedText.Text = null;
                textBoxCriptedText.Text=AES.AESCript(textBoxOrigText.Text,textBoxPass.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your data..");
            }
            
        }

        private void buttonDecript_Click(object sender, EventArgs e)
        {
                try
                {
                    textBoxOrigText.Text = null;
                    textBoxOrigText.Text = AES.AESDecript(textBoxCriptedText.Text, textBoxPass.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please check your data..");
                }
        }        
    }
}