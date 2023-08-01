using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

namespace twitter_test
{
    



    public partial class Create_tweet : Form
    {
        //ASSIGN GLOBAL VARIABLES
        TwitterClient userClient = Login.userClient;//accessing the userClient variable in the login form
        string file ="";
        byte[] copyfile;
        Tweetinvi.Models.IMedia uploadedImage;//assigning uploadedImage to Tweetinvi.Imedia. This will upload the byte stream copyfile  
        Tweetinvi.Models.IAuthenticatedUser user = Login.user;
        string picpath = Login.picpath;//accessing the picpath variable in the login form
        public Create_tweet()
        {
            InitializeComponent();

        }


        public void Create_twet_Load(object sender, EventArgs e)
        {
            MyClass.InternetAvailable();//Checks internet before loading profile information
            Create_Profile();//Profile method called

        }

        private void Create_Profile()
        {
            //GETS SPECIFIC PROFILE DATA OF THE USER 
            lbl_Name.Text = Convert.ToString(user);
            pbx_Profile.ImageLocation = user.ProfileImageUrl;
            pbx_Profile.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_Logo.Image = Image.FromFile(picpath + "/Images/Blackburn uni logo.png");
            pbx_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_Home.Image = Image.FromFile(picpath + "/Images/home.png");
            pbx_Home.SizeMode = PictureBoxSizeMode.StretchImage;

            lbl_Screename.Text = "@" + user.ScreenName;




            lbl_Follower.Text = Convert.ToString(user.FollowersCount + " Followers");
            lbl_Following.Text = Convert.ToString(user.FriendsCount + " Following");
        }

        public async void btn_Tweet_Click(object sender, EventArgs e)//DOES WHEN BUTTON IS CLICKED
        {
            MyClass.InternetAvailable();//Checks internet

            //WILL TRY TO SEND TWEET 
            try{

                if (rtb_Entry.Text != "" && String.IsNullOrEmpty(file) == false)//Checks if the text entered is not null and the string file is also not null
                {
                    copyfile = File.ReadAllBytes(file);//reads the bytes of the variable file which stores the filepath for image

                    uploadedImage = await userClient.Upload.UploadTweetImageAsync(copyfile);//stored into the async variable
                    //CHECK IF THE FILE IS OF CORRECT TYPE
                    if (lbl_FilePath.Text.Substring(lbl_FilePath.Text.Length - 5) == ".jpeg" || lbl_FilePath.Text.Substring(lbl_FilePath.Text.Length - 4) == ".jpg" || lbl_FilePath.Text.Substring(lbl_FilePath.Text.Length - 4) == ".png" || lbl_FilePath.Text.Substring(lbl_FilePath.Text.Length - 5) == ".webp" || lbl_FilePath.Text.Substring(lbl_FilePath.Text.Length - 5) == ".jfif")
                    {

                        var tweetWithImage = await userClient.Tweets.PublishTweetAsync(new PublishTweetParameters(rtb_Entry.Text)//the tweet along with image is sent
                        {
                            Medias = { uploadedImage }
                        });
                        MessageBox.Show("Message successfully sent");//message shown
                        Clear();//objects are cleared
                    }
                    else
                    {
                        MessageBox.Show("Not compatible");
                        Clear();
                    }

                }
                else if (rtb_Entry.Text == "" && String.IsNullOrEmpty(file) == false)//Checks if the text entered is null and the string file is not null
                {
                    //UPLOADS ONLY IMAGE
                    if (lbl_FilePath.Text.Substring(lbl_FilePath.Text.Length - 5) == ".jpeg" || lbl_FilePath.Text.Substring(lbl_FilePath.Text.Length - 4) == ".jpg" || lbl_FilePath.Text.Substring(lbl_FilePath.Text.Length - 4) == ".png" || lbl_FilePath.Text.Substring(lbl_FilePath.Text.Length - 5) == ".webp")
                    {
                        copyfile = File.ReadAllBytes(file);

                        uploadedImage = await userClient.Upload.UploadTweetImageAsync(copyfile);

                        var tweetWithImage = await userClient.Tweets.PublishTweetAsync(new PublishTweetParameters("")
                        {
                            Medias = { uploadedImage }
                        });
                        MessageBox.Show("Image successfully sent");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Not compatible");
                        Clear();
                    }
                }
                else if (rtb_Entry.Text != "" && String.IsNullOrEmpty(file))//Checks if the text entered is not null and the string file is null
                {
                    //UPLOADS TEXT
                    var tweet = await userClient.Tweets.PublishTweetAsync(rtb_Entry.Text);
                    rtb_Entry.Text = "";
                    MessageBox.Show("Tweet successfully sent");

                }
                else
                {
                    MessageBox.Show("Please enter something");//NOTHING HAS BEEN ENTERED
                }
            }//ELSE TWEET IS A DUPLICATE
            catch
            {
                MessageBox.Show("You have already tweeted this");
                Clear();
            }



        }

        private void Clear()//METHOD TO CLEAR DATA AFTER TWEET BEEN SENT
        {
            rtb_Entry.Text = "";
            lbl_FilePath.Text = "";
            pbx_imgAttached.Image = null;
            file = "";
        }

        private void btn_Image_Click(object sender, EventArgs e)//OPENS A FILEDIALOG WHEN USER CLICKS IMAGE BUTTON
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            file = ofd.FileName;
            pbx_imgAttached.ImageLocation = ofd.FileName;//Picturebox loads the picture
            pbx_imgAttached.SizeMode = PictureBoxSizeMode.StretchImage;
            lbl_FilePath.Text = ofd.FileName;//label stored filepath
        }

        private void rtb_Entry_TextChanged(object sender, EventArgs e)//GETS THE LENGTH OF THE TEXT AS COUNT TO DISPLAY
        {
            string count = rtb_Entry.Text;
            lbl_Count.Text = "Character count is " + count.Length + "/280";
            if(rtb_Entry.Text.Length == 280)
            {
                lbl_Count.Text = "MAX length ";
            }
        }

        private void pbx_Home_Click(object sender, EventArgs e)//GOES TO HOME PAGE
        {
            Main_menu newMenu = new Main_menu();
            newMenu.Show();
            this.Dispose();
        }

        private void btn_SignOut_Click(object sender, EventArgs e)//SIGN OUT
        {
            MyClass.SignOut();
        }


    }
    
}



    


