using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace mainForm
{
    
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            newUser n1 = new newUser();
            n1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            existingUser n1 = new existingUser();
            n1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminForm n1 = new adminForm();
            n1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
