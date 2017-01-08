using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class orionStarsForm : Form
    {
        public orionStarsForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exit the application
            this.Close();
        }

        private void showStarsButton_Click(object sender, EventArgs e)
        {
            star1.Visible = true;
            star2.Visible = true;
            star3.Visible = true;
            star4.Visible = true;
            star5.Visible = true;
            star6.Visible = true;
            star7.Visible = true;
        }

        private void hideStarsButton_Click(object sender, EventArgs e)
        {
            star1.Visible = false;
            star2.Visible = false;
            star3.Visible = false;
            star4.Visible = false;
            star5.Visible = false;
            star6.Visible = false;
            star7.Visible = false;
        }
    }
}
