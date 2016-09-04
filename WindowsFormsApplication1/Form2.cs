using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form2_Load);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(Object sender, EventArgs e)
        {

            //MessageBox.Show("You are in the Form.Shown event.");
            TimeHandler.StopTime();

        }


    }
}
