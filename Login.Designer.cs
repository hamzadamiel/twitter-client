
namespace twitter_test
{
    partial class Login
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
            this.btn_Auth = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.tbx_Pin = new System.Windows.Forms.TextBox();
            this.pbx_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_PageTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Auth
            // 
            this.btn_Auth.BackColor = System.Drawing.Color.Transparent;
            this.btn_Auth.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Auth.Location = new System.Drawing.Point(168, 93);
            this.btn_Auth.Name = "btn_Auth";
            this.btn_Auth.Size = new System.Drawing.Size(154, 89);
            this.btn_Auth.TabIndex = 1;
            this.btn_Auth.Text = "Get authenticated pin";
            this.btn_Auth.UseVisualStyleBackColor = false;
            this.btn_Auth.Click += new System.EventHandler(this.btn_Auth_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(97, 242);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(287, 81);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Log in ";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // tbx_Pin
            // 
            this.tbx_Pin.Location = new System.Drawing.Point(136, 201);
            this.tbx_Pin.Name = "tbx_Pin";
            this.tbx_Pin.Size = new System.Drawing.Size(216, 20);
            this.tbx_Pin.TabIndex = 3;
            this.tbx_Pin.Text = "Enter authenticated pin";
            // 
            // pbx_Logo
            // 
            this.pbx_Logo.Location = new System.Drawing.Point(12, 12);
            this.pbx_Logo.Name = "pbx_Logo";
            this.pbx_Logo.Size = new System.Drawing.Size(155, 71);
            this.pbx_Logo.TabIndex = 4;
            this.pbx_Logo.TabStop = false;
            // 
            // lbl_PageTitle
            // 
            this.lbl_PageTitle.AutoSize = true;
            this.lbl_PageTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PageTitle.Location = new System.Drawing.Point(173, 32);
            this.lbl_PageTitle.Name = "lbl_PageTitle";
            this.lbl_PageTitle.Size = new System.Drawing.Size(310, 23);
            this.lbl_PageTitle.TabIndex = 5;
            this.lbl_PageTitle.Text = "Welcome to the Twiiter API";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(484, 352);
            this.Controls.Add(this.lbl_PageTitle);
            this.Controls.Add(this.pbx_Logo);
            this.Controls.Add(this.tbx_Pin);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Auth);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Auth;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox tbx_Pin;
        private System.Windows.Forms.PictureBox pbx_Logo;
        private System.Windows.Forms.Label lbl_PageTitle;
    }
}