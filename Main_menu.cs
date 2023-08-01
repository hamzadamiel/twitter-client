using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;

namespace twitter_test
{
    public partial class Main_menu : Form//Main menu inherits from the base class For,
    {
        TwitterClient userClient = Login.userClient;
        Tweetinvi.Models.IAuthenticatedUser user = Login.user;
        string picpath = Login.picpath;
        public Main_menu()
        {
            InitializeComponent();
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {
            Create_Profile();

        }

        private void Create_Profile()//GETS PROFILE DATA
        {
            lbl_PageTitle.Text = user.Name + " Main Menu";
            pbx_Logo.Image = Image.FromFile(picpath + "/Images/Blackburn uni logo.png");
            pbx_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_Profile.ImageLocation = user.ProfileImageUrl;
            pbx_Profile.SizeMode = PictureBoxSizeMode.StretchImage;
            lbl_UserName.Text = user.Name;
            lbl_ScreenName.Text = "@" + user.ScreenName;
            lbl_FollowCount.Text = Convert.ToString(user.FollowersCount + " Followers" + " | " + user.FriendsCount + " Following");
        }

        private void Main_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            MyClass.SignOut();//inherits signout method from myclass and carries out an overriding method which signsout and disposes form 
            this.Dispose();
        }

        private void btn_SearchTweet_Click(object sender, EventArgs e)
        {
            Search_box newSearch = new Search_box();
            newSearch.Show();
            this.Hide();
        }

        private void btn_HomeTimeline_Click(object sender, EventArgs e)
        {
            Hometimeline newHT = new Hometimeline();
            newHT.Show();
            this.Hide();
        }

        private void btn_CreateTweet_Click(object sender, EventArgs e)
        {
            Create_tweet newCT = new Create_tweet();
            newCT.Show();
            this.Hide();
        }
    }
}
