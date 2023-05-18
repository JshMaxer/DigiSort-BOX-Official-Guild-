
namespace DigiSort_Box.Front_end
{
    partial class reset_password
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitform = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Reset = new System.Windows.Forms.Label();
            this.smoothedge = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtretype = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnproceed = new Guna.UI2.WinForms.Guna2Button();
            this.lblusername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.exitform);
            this.panel1.Controls.Add(this.Reset);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 55);
            this.panel1.TabIndex = 10;
            // 
            // exitform
            // 
            this.exitform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitform.Animated = true;
            this.exitform.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.exitform.IconColor = System.Drawing.Color.White;
            this.exitform.Location = new System.Drawing.Point(369, 8);
            this.exitform.Name = "exitform";
            this.exitform.Size = new System.Drawing.Size(44, 38);
            this.exitform.TabIndex = 12;
            // 
            // Reset
            // 
            this.Reset.AutoSize = true;
            this.Reset.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.Reset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Reset.Location = new System.Drawing.Point(28, 18);
            this.Reset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(160, 20);
            this.Reset.TabIndex = 0;
            this.Reset.Text = "Reset Password";
            // 
            // smoothedge
            // 
            this.smoothedge.BorderRadius = 12;
            this.smoothedge.TargetControl = this;
            // 
            // txtpassword
            // 
            this.txtpassword.BorderRadius = 8;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.DefaultText = "";
            this.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.Location = new System.Drawing.Point(12, 69);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.PlaceholderText = "Password";
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(399, 45);
            this.txtpassword.TabIndex = 21;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // txtretype
            // 
            this.txtretype.BorderRadius = 8;
            this.txtretype.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtretype.DefaultText = "";
            this.txtretype.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtretype.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtretype.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtretype.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtretype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtretype.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txtretype.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtretype.Location = new System.Drawing.Point(12, 122);
            this.txtretype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtretype.Name = "txtretype";
            this.txtretype.PasswordChar = '●';
            this.txtretype.PlaceholderText = "Re-type password";
            this.txtretype.SelectedText = "";
            this.txtretype.Size = new System.Drawing.Size(399, 45);
            this.txtretype.TabIndex = 21;
            this.txtretype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtretype.UseSystemPasswordChar = true;
            // 
            // btnproceed
            // 
            this.btnproceed.Animated = true;
            this.btnproceed.BorderRadius = 12;
            this.btnproceed.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnproceed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnproceed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnproceed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnproceed.Enabled = false;
            this.btnproceed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(102)))), ((int)(((byte)(194)))));
            this.btnproceed.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnproceed.ForeColor = System.Drawing.Color.White;
            this.btnproceed.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(92)))), ((int)(((byte)(184)))));
            this.btnproceed.Location = new System.Drawing.Point(129, 174);
            this.btnproceed.Name = "btnproceed";
            this.btnproceed.Size = new System.Drawing.Size(165, 45);
            this.btnproceed.TabIndex = 69;
            this.btnproceed.Text = "Proceed";
            this.btnproceed.Click += new System.EventHandler(this.btnproceed_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Location = new System.Drawing.Point(160, 9);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(70, 16);
            this.lblusername.TabIndex = 70;
            this.lblusername.Text = "Username";
            this.lblusername.Visible = false;
            // 
            // reset_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 239);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnproceed);
            this.Controls.Add(this.txtretype);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtpassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "reset_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Reset;
        private Guna.UI2.WinForms.Guna2Elipse smoothedge;
        private Guna.UI2.WinForms.Guna2ControlBox exitform;
        private Guna.UI2.WinForms.Guna2TextBox txtretype;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        public Guna.UI2.WinForms.Guna2Button btnproceed;
        public System.Windows.Forms.Label lblusername;
    }
}