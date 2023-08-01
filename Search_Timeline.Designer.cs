
namespace twitter_test
{
    partial class Search_Timeline
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
            this.pbx_Logo = new System.Windows.Forms.PictureBox();
            this.pbx_Home = new System.Windows.Forms.PictureBox();
            this.btn_SignOut = new System.Windows.Forms.Button();
            this.pbx_Profile = new System.Windows.Forms.PictureBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Screename = new System.Windows.Forms.Label();
            this.lbl_SearchTimeline = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.PictureBox();
            this.lbl_Follow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_Logo
            // 
            this.pbx_Logo.Location = new System.Drawing.Point(12, 12);
            this.pbx_Logo.Name = "pbx_Logo";
            this.pbx_Logo.Size = new System.Drawing.Size(223, 83);
            this.pbx_Logo.TabIndex = 0;
            this.pbx_Logo.TabStop = false;
            // 
            // pbx_Home
            // 
            this.pbx_Home.Location = new System.Drawing.Point(748, 12);
            this.pbx_Home.Name = "pbx_Home";
            this.pbx_Home.Size = new System.Drawing.Size(100, 83);
            this.pbx_Home.TabIndex = 1;
            this.pbx_Home.TabStop = false;
            this.pbx_Home.Click += new System.EventHandler(this.pbx_Home_Click);
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignOut.Location = new System.Drawing.Point(762, 186);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Size = new System.Drawing.Size(75, 40);
            this.btn_SignOut.TabIndex = 2;
            this.btn_SignOut.Text = "Sign Out";
            this.btn_SignOut.UseVisualStyleBackColor = true;
            this.btn_SignOut.Click += new System.EventHandler(this.btn_SignOut_Click);
            // 
            // pbx_Profile
            // 
            this.pbx_Profile.Location = new System.Drawing.Point(405, 111);
            this.pbx_Profile.Name = "pbx_Profile";
            this.pbx_Profile.Size = new System.Drawing.Size(96, 75);
            this.pbx_Profile.TabIndex = 3;
            this.pbx_Profile.TabStop = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(402, 196);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(45, 16);
            this.lbl_Name.TabIndex = 4;
            this.lbl_Name.Text = "label2";
            // 
            // lbl_Screename
            // 
            this.lbl_Screename.AutoSize = true;
            this.lbl_Screename.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Screename.Location = new System.Drawing.Point(402, 219);
            this.lbl_Screename.Name = "lbl_Screename";
            this.lbl_Screename.Size = new System.Drawing.Size(102, 16);
            this.lbl_Screename.TabIndex = 5;
            this.lbl_Screename.Text = "lbl_Screename";
            // 
            // lbl_SearchTimeline
            // 
            this.lbl_SearchTimeline.AutoSize = true;
            this.lbl_SearchTimeline.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SearchTimeline.Location = new System.Drawing.Point(252, 27);
            this.lbl_SearchTimeline.Name = "lbl_SearchTimeline";
            this.lbl_SearchTimeline.Size = new System.Drawing.Size(249, 35);
            this.lbl_SearchTimeline.TabIndex = 6;
            this.lbl_SearchTimeline.Text = "Search Timeline";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(762, 111);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(73, 56);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.TabStop = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbl_Follow
            // 
            this.lbl_Follow.AutoSize = true;
            this.lbl_Follow.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Follow.Location = new System.Drawing.Point(377, 245);
            this.lbl_Follow.Name = "lbl_Follow";
            this.lbl_Follow.Size = new System.Drawing.Size(70, 16);
            this.lbl_Follow.TabIndex = 8;
            this.lbl_Follow.Text = "lbl_Follow";
            // 
            // Search_Timeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(871, 808);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Follow);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.lbl_SearchTimeline);
            this.Controls.Add(this.lbl_Screename);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.pbx_Profile);
            this.Controls.Add(this.btn_SignOut);
            this.Controls.Add(this.pbx_Home);
            this.Controls.Add(this.pbx_Logo);
            this.Name = "Search_Timeline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Timeline";
            this.Load += new System.EventHandler(this.Search_Timeline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_Logo;
        private System.Windows.Forms.PictureBox pbx_Home;
        private System.Windows.Forms.Button btn_SignOut;
        private System.Windows.Forms.PictureBox pbx_Profile;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Screename;
        private System.Windows.Forms.Label lbl_SearchTimeline;
        private System.Windows.Forms.PictureBox btn_refresh;
        private System.Windows.Forms.Label lbl_Follow;
    }
}