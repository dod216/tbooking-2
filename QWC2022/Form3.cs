using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QWC2022
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            spanal1.Height = hbutton.Height;
            spanal1.Top = hbutton.Top;
            
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void hbutton_Click(object sender, EventArgs e)
        {
            spanal1.Height = hbutton.Height;
            spanal1.Top = hbutton.Top;
            home1.Show();
            sf1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            spanal1.Height = SFbutton.Height;
            spanal1.Top = SFbutton.Top;
            home1.Hide();
            sf1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
