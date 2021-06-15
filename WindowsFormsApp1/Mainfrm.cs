using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Mainfrm : Form
    {
        string full_name;

        public Mainfrm()
        {
            InitializeComponent();
        }
        public Mainfrm(string full_name)
        {
            InitializeComponent();
           
            this.full_name = full_name;
        }
        
        private void label93_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblsec.Text = System.DateTime.Now.ToString();
            lbDayofWeek.Text = System.DateTime.Now.DayOfWeek.ToString();
            lbname.Text = $"Tên : {full_name}";
        }

        private void ava_Click(object sender, EventArgs e)
        {

        }

        private void txtsname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tPSinhVIen_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //lbname.Text = user.full_name;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginFrm lg = new LoginFrm();
            lg.Show();
        }
    }
}
