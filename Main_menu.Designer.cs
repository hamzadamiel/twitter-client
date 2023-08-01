
namespace twitter_test
{
    partial class Main_menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbx_Profile = new System.Windows.Forms.PictureBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_ScreenName = new System.Windows.Forms.Label();
            this.lbl_FollowCount = new System.Windows.Forms.Label();
            this.btn_HomeTimeline = new System.Windows.Forms.Button();
            this.btn_CreateTweet = new System.Windows.Forms.Button();
            this.btn_SearchTweet = new System.Windows.Forms.Button();
            this.btn_SignOut = new System.Windows.Forms.Button();
            this.pbx_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_PageTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_Profile
            // 
            this.pbx_Profile.Location = new System.Drawing.Point(594, 12);
            this.pbx_Profile.Name = "pbx_Profile";
            this.pbx_Profile.Size = new System.Drawing.Size(132, 115);
            this.pbx_Profile.TabIndex = 0;
            this.pbx_Profile.TabStop = false;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(613, 134);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(45, 16);
            this.lbl_UserName.TabIndex = 1;
            this.lbl_UserName.Text = "label1";
            // 
            // lbl_ScreenName
            // 
            this.lbl_ScreenName.AutoSize = true;
            this.lbl_ScreenName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ScreenName.Location = new System.Drawing.Point(613, 163);
            this.lbl_ScreenName.Name = "lbl_ScreenName";
            this.lbl_ScreenName.Size = new System.Drawing.Size(45, 16);
            this.lbl_ScreenName.TabIndex = 2;
            this.lbl_ScreenName.Text = "label2";
            // 
            // lbl_FollowCount
            // 
            this.lbl_FollowCount.AutoSize = true;
            this.lbl_FollowCount.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FollowCount.Location = new System.Drawing.Point(574, 190);
            this.lbl_FollowCount.Name = "lbl_FollowCount";
            this.lbl_FollowCount.Size = new System.Drawing.Size(45, 16);
            this.lbl_FollowCount.TabIndex = 3;
            this.lbl_FollowCount.Text = "label3";
            // 
            // btn_HomeTimeline
            // 
            this.btn_HomeTimeline.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_HomeTimeline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_HomeTimeline.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HomeTimeline.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_HomeTimeline.Location = new System.Drawing.Point(194, 163);
            this.btn_HomeTimeline.Name = "btn_HomeTimeline";
            this.btn_HomeTimeline.Size = new System.Drawing.Size(128, 71);
            this.btn_HomeTimeline.TabIndex = 4;
            this.btn_HomeTimeline.Text = "Home Timeline";
            this.btn_HomeTimeline.UseVisualStyleBackColor = false;
            this.btn_HomeTimeline.Click += new System.EventHandler(this.btn_HomeTimeline_Click);
            // 
            // btn_CreateTweet
            // 
            this.btn_CreateTweet.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_CreateTweet.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateTweet.Location = new System.Drawing.Point(382, 163);
            this.btn_CreateTweet.Name = "btn_CreateTweet";
            this.btn_CreateTweet.Size = new System.Drawing.Size(128, 71);
            this.btn_CreateTweet.TabIndex = 5;
            this.btn_CreateTweet.Text = "Create Tweet";
            this.btn_CreateTweet.UseVisualStyleBackColor = false;
            this.btn_CreateTweet.Click += new System.EventHandler(this.btn_CreateTweet_Click);
            // 
            // btn_SearchTweet
            // 
            this.btn_SearchTweet.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_SearchTweet.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchTweet.Location = new System.Drawing.Point(12, 163);
            this.btn_SearchTweet.Name = "btn_SearchTweet";
            this.btn_SearchTweet.Size = new System.Drawing.Size(128, 71);
            this.btn_SearchTweet.TabIndex = 6;
            this.btn_SearchTweet.Text = "Search Tweet";
            this.btn_SearchTweet.UseVisualStyleBackColor = false;
            this.btn_SearchTweet.Click += new System.EventHandler(this.btn_SearchTweet_Click);
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_SignOut.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignOut.Location = new System.Drawing.Point(616, 232);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Size = new System.Drawing.Size(95, 75);
            this.btn_SignOut.TabIndex = 8;
            this.btn_SignOut.Text = "Sign Out";
            this.btn_SignOut.UseVisualStyleBackColor = false;
            this.btn_SignOut.Click += new System.EventHandler(this.btn_SignOut_Click);
            // 
            // pbx_Logo
            // 
            this.pbx_Logo.Location = new System.Drawing.Point(7, 12);
            this.pbx_Logo.Name = "pbx_Logo";
            this.pbx_Logo.Size = new System.Drawing.Size(195, 90);
            this.pbx_Logo.TabIndex = 9;
            this.pbx_Logo.TabStop = false;
            // 
            // lbl_PageTitle
            // 
            this.lbl_PageTitle.AutoSize = true;
            this.lbl_PageTitle.Font = new System.Drawing.Font("Verdana", 20F);
            this.lbl_PageTitle.Location = new System.Drawing.Point(208, 31);
            this.lbl_PageTitle.Name = "lbl_PageTitle";
            this.lbl_PageTitle.Size = new System.Drawing.Size(94, 32);
            this.lbl_PageTitle.TabIndex = 10;
            this.lbl_PageTitle.Text = "label4";
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(760, 316);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_PageTitle);
            this.Controls.Add(this.pbx_Logo);
            this.Controls.Add(this.btn_SignOut);
            this.Controls.Add(this.btn_SearchTweet);
            this.Controls.Add(this.btn_CreateTweet);
            this.Controls.Add(this.btn_HomeTimeline);
            this.Controls.Add(this.lbl_FollowCount);
            this.Controls.Add(this.lbl_ScreenName);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.pbx_Profile);
            this.Name = "Main_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Main_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_Profile;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_ScreenName;
        private System.Windows.Forms.Label lbl_FollowCount;
        private System.Windows.Forms.Button btn_HomeTimeline;
        private System.Windows.Forms.Button btn_CreateTweet;
        private System.Windows.Forms.Button btn_SearchTweet;
        private System.Windows.Forms.Button btn_SignOut;
        private System.Windows.Forms.PictureBox pbx_Logo;
        private System.Windows.Forms.Label lbl_PageTitle;
    }
}