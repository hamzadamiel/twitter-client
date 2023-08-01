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
using Newtonsoft.Json;

namespace twitter_test
{
    public partial class Hometimeline : Form
    {
        TwitterClient userClient = Login.userClient;
        Tweetinvi.Models.IAuthenticatedUser user = Login.user;
        public bool ButtonClicked = false;
        public int count = 0;
        public Tweetinvi.Models.ITweet[] tweet;
        public PictureBox[] likepic;
        public PictureBox[] retweetpic;
        public Label[] likecount;
        public Label[] retweetcount;
        dynamic jsonfile;
        string picpath = Login.picpath;
        public Hometimeline()
        {
            InitializeComponent();
        }

        private async void Hometimeline_Load(object sender, EventArgs e)
        {
            MyClass.InternetAvailable();
            Create_Profile();

            tweet = await userClient.Timelines.GetHomeTimelineAsync();
            var json = userClient.Json.Serialize(tweet);

            jsonfile = JsonConvert.DeserializeObject(json);
            //pictureBox1.ImageLocation = jsonfile[0]["user"]["profile_image_url"];
            //Console.WriteLine(jsonfile[0]["user"]["profile_image_url"]);
            Create_Timeline();

        }

        private void Create_Timeline()
        {
            int a = 288;


            likecount = new Label[tweet.Length];
            retweetcount = new Label[tweet.Length];
            likepic = new PictureBox[tweet.Length];
            retweetpic = new PictureBox[tweet.Length];


            for (int i = 0; i < tweet.Length; i++)
            {

                //USERNAME AND SCREENAME

                Label lblname = new Label();
                lblname.Text = jsonfile[i]["user"]["name"];
                lblname.Location = new Point(30, a);
                lblname.Show();
                this.Controls.Add(lblname);

                Label screenlblname = new Label();
                screenlblname.Text = "@" + jsonfile[i]["user"]["screen_name"];
                screenlblname.Location = new Point(30, a + 25);
                screenlblname.Show();
                this.Controls.Add(screenlblname);

                //PROFILE PICTURE 

                PictureBox newpic = new PictureBox();
                newpic.Location = new Point(30, a + 40);
                newpic.Size = new Size(100, 100);
                newpic.SizeMode = PictureBoxSizeMode.StretchImage;
                newpic.ImageLocation = jsonfile[i]["user"]["profile_image_url"];
                this.Controls.Add(newpic);

                //LIKE PIC AND LABEL 


                likecount[i] = new Label();
                likecount[i].Location = new Point(570, a);
                likecount[i].Text = (jsonfile[i]["favorite_count"]) + " Likes";
                this.Controls.Add(likecount[i]);



                likepic[i] = new PictureBox();
                likepic[i].Location = new Point(570, a + 30);
                likepic[i].Size = new Size(70, 50);
                if (jsonfile[i]["favorited"] == true)
                {
                    likepic[i].Image = Image.FromFile(picpath + "/Images/blue_like.png");
                }
                else
                {
                    likepic[i].Image = Image.FromFile(picpath + "/Images/like.png");
                }

                likepic[i].Name = Convert.ToString("btn" + count);
                likepic[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(likepic[i]);
                likepic[i].Click += new EventHandler(like_Click);


                //RETWEET PIC AND LABEL

                retweetpic[i] = new PictureBox();
                retweetpic[i].Location = new Point(700, a + 30);
                if (jsonfile[i]["retweeted"] == true)
                {
                    retweetpic[i].Image = Image.FromFile(picpath + "/Images/blue_retweet.png");
                }
                else
                {
                    retweetpic[i].Image = Image.FromFile(picpath + "/Images/retweet.png");
                }

                retweetpic[i].Size = new Size(50, 50);
                retweetpic[i].Name = Convert.ToString("btn" + count);
                retweetpic[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(retweetpic[i]);
                retweetpic[i].Click += new EventHandler(retweet_Click);

                retweetcount[i] = new Label();
                retweetcount[i].Location = new Point(700, a);
                retweetcount[i].Text = (jsonfile[i]["retweet_count"]) + " Retweets";
                this.Controls.Add(retweetcount[i]);


                Label namelabel = new Label();
                namelabel.Location = new Point(160, a);
                namelabel.MaximumSize = new Size(400, 0);
                namelabel.Text = (tweet[i].Text);
                namelabel.AutoSize = true;
                this.Controls.Add(namelabel);
                namelabel.Font = new Font("Arial", 12, FontStyle.Regular);

                if ((Convert.ToString(tweet[i]).Contains("/t.co")))
                {
                    try
                    {
                        PictureBox imagepic = new PictureBox();
                        imagepic.Size = new Size(150, 150);
                        imagepic.SizeMode = PictureBoxSizeMode.StretchImage;
                        imagepic.ImageLocation = (jsonfile[i]["extended_entities"]["media"][0]["media_url"]);
                        imagepic.Location = new Point(160, a + 30);
                        this.Controls.Add(imagepic);
                        a = a + 30;
                    }
                    catch
                    {

                    }

                }

                a = a + 190;
                count++;
            }
        }

        private void Create_Profile()//CREATES PROFILE
        {
            lbl_Timeline.Text = user.ScreenName + " Timeline";
            pbx_Logo.Image = Image.FromFile(picpath + "/Images/Blackburn uni logo.png");
            pbx_Logo.SizeMode = PictureBoxSizeMode.StretchImage;

            pbx_Profile.ImageLocation = user.ProfileImageUrl;
            pbx_Profile.SizeMode = PictureBoxSizeMode.StretchImage;

            lbl_Name.Text = Convert.ToString(user);
            lbl_Screename.Text = "@" + user.ScreenName;

            lbl_Follow.Text = (Convert.ToString(user.FollowersCount)) + " Followers | " + (Convert.ToString(user.FriendsCount) + " Following");

            pbx_Home.Image = Image.FromFile(picpath + "/Images/home.png");
            pbx_Home.SizeMode = PictureBoxSizeMode.StretchImage;


            btn_refresh.Image = Image.FromFile(picpath + "/Images/refresh.png");
            btn_refresh.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private async void like_Click(object sender, EventArgs e)
        {
            MyClass.InternetAvailable();
            PictureBox pbx = (PictureBox)sender;//control that the action is for. Object that invoked the event that fired the event handler.


            for (int j = 0; j < count; j++)
            {
                if (pbx.Name == ("btn" + j))
                {
                    if (jsonfile[j]["favorited"] == true)
                    {
                        if (jsonfile[j]["favorite_count"] == 0)
                        {
                            likecount[j].Text = (jsonfile[j]["favorite_count"]) + " Likes";
                            likepic[j].Image = Image.FromFile(picpath + "/Images/like.png");
                            await userClient.Tweets.UnfavoriteTweetAsync(tweet[j]);
                            jsonfile[j]["favorited"] = false;
                        }
                        else
                        {
                            likecount[j].Text = (jsonfile[j]["favorite_count"]) + " Likes";
                            likepic[j].Image = Image.FromFile(picpath + "/Images/like.png");
                            await userClient.Tweets.UnfavoriteTweetAsync(tweet[j]);
                            jsonfile[j]["favorited"] = false;
                        }
                    }
                    else
                    {
                        await userClient.Tweets.FavoriteTweetAsync(tweet[j]);
                        likecount[j].Text = (jsonfile[j]["favorite_count"] ) +  1 + " Likes";
                        likepic[j].Image = Image.FromFile(picpath + "/Images/blue_like.png");
                        jsonfile[j]["favorited"] = true;
                    }



                }

            }


        }
        private async void retweet_Click(object sender, EventArgs e)//WHEN RETWEET BUTTON PRESSED
        {
            MyClass.InternetAvailable();
            PictureBox pbx1 = (PictureBox)sender;


            for (int j = 0; j < count; j++)
            {
                if (pbx1.Name == ("btn" + j))
                {

                    if (jsonfile[j]["retweeted"] == true)
                    {
                        if (jsonfile[j]["retweet_count"] == 0)
                        {
                            retweetcount[j].Text = (jsonfile[j]["retweet_count"]) + " Retweets";
                            retweetpic[j].Image = Image.FromFile(picpath + "/Images/retweet.png");
                            await userClient.Tweets.DestroyRetweetAsync(tweet[j]);
                            jsonfile[j]["retweeted"] = false;
                        }
                        else
                        {
                            retweetcount[j].Text = (jsonfile[j]["retweet_count"]) + " Retweets";
                            retweetpic[j].Image = Image.FromFile(picpath + "/Images/retweet.png");
                            await userClient.Tweets.DestroyRetweetAsync(tweet[j]);
                            jsonfile[j]["retweeted"] = false;
                        }

                    }

                    else
                    {
                        await userClient.Tweets.PublishRetweetAsync(tweet[j]);
                        retweetcount[j].Name = "retweeted";
                        retweetpic[j].Image = Image.FromFile(picpath + "/Images/blue_retweet.png");
                        jsonfile[j]["retweeted"] = true;
                        retweetcount[j].Text = (jsonfile[j]["retweet_count"]) + 1 + " Retweets";
                    }


                }

            }


        }

        private void Hometimeline_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_SignOut_Click(object sender, EventArgs e)
        {

            MyClass.SignOut();
        }

        private void pbx_Home_Click(object sender, EventArgs e)
        {
            Main_menu newmain = new Main_menu();
            newmain.Show();
            this.Dispose();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Hometimeline newHT = new Hometimeline();
            newHT.Show();
            this.Dispose();
        }

        private void pbx_Profile_Click(object sender, EventArgs e)
        {

        }
    }
}




