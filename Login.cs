using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;

namespace twitter_test
{
    public partial class Login : Form
    {

        TwitterClient appClient = new TwitterClient(MyClass.Api_key,MyClass.other_key);
        // Start the authentication process
        public Tweetinvi.Models.IAuthenticationRequest authenticationRequest;
        public Tweetinvi.Models.ITwitterCredentials userCredentials;
        public static TwitterClient userClient;
        public static Tweetinvi.Models.IAuthenticatedUser user;
        public static string picpath;


        public Login()
        {
            InitializeComponent();
        }

        public async void btn_Auth_Click(object sender, EventArgs e)
        {
            MyClass.InternetAvailable();
            try
            {
                // Start the authentication process
                authenticationRequest = await appClient.Auth.RequestAuthenticationUrlAsync();

                // Go to the URL so that Twitter authenticates the user and gives him a PIN code

                Process.Start(new ProcessStartInfo(authenticationRequest.AuthorizationURL)
                {
                    UseShellExecute = true
                });
                tbx_Pin.Text = "";
            }
            catch
            {
                MessageBox.Show("There seems to be a problem. Try again later");
                this.Dispose();
            }

            btn_Auth.Enabled = false;


        }




        public async void btn_Login_Click(object sender, EventArgs e)
        {
            MyClass.InternetAvailable();
            var pinCode = tbx_Pin.Text;
            btn_Login.Enabled = false;


            // With this pin code it is now possible to get the credentials back from Twitter
            try
            {
                userCredentials = await appClient.Auth.RequestCredentialsFromVerifierCodeAsync(pinCode, authenticationRequest);


                // You can now save those credentials or use them as followed
                userClient = new TwitterClient(userCredentials);
                user = await userClient.Users.GetAuthenticatedUserAsync();
                MessageBox.Show("Congratulation you have authenticated the user: " + user);




                Main_menu newMain = new Main_menu();
                newMain.Show();
                this.Hide();


            }
            catch
            {
                MessageBox.Show("Authentication error. Try again");
                btn_Auth.Enabled = true;
                btn_Login.Enabled = true;
            }



        }
        
        
        private void Login_Load(object sender, EventArgs e)
        {
            MyClass.InternetAvailable();
            picpath = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
            pbx_Logo.Image = Image.FromFile(picpath+ "/Images/Blackburn uni logo.png");
            pbx_Logo.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}

