using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twitter_test
{
    public partial class Search_box : Form
    {
        public static string input;
        string picpath = Login.picpath;
        public Search_box()
        {
            InitializeComponent();
        }

        private void Search_box_Load(object sender, EventArgs e)
        {
            //GETS PROFILE DATA
            pictureBox1.Image = Image.FromFile(picpath + "/Images/Blackburn uni logo.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile(picpath + "/Images/home.png");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void btn_Enter_Click(object sender, EventArgs e)//CREATES NEW FORM SEARCH TIMELINE WHERE THE USER INPUT WILL BE THE SEARCH
        {
            
            input = tbx_Search.Text;
            if (input != null)
            {
                Search_Timeline form1 = new Search_Timeline();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You need to enter something");
            }

        }



        private void homePage()//GOES TO HOMEPAGE
        {
            Main_menu newmain = new Main_menu();
            newmain.Show();
            this.Dispose();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            homePage();
        }

        private void btn_Back_Click(object sender, EventArgs e)//GOES BACK TO HOMEPAGE
        {
            homePage();
        }
    }
}
