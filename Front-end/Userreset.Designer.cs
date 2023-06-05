namespace DigiSort_Box.Front_end
{
    partial class Userreset
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
            this.smoothedge = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitform = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Reset = new System.Windows.Forms.Label();
            this.btnproceed = new Guna.UI2.WinForms.Guna2Button();
            this.cbusername = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // smoothedge
            // 
            this.smoothedge.BorderRadius = 12;
            this.smoothedge.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(102)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.exitform);
            this.panel1.Controls.Add(this.Reset);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 45);
            this.panel1.TabIndex = 70;
            // 
            // exitform
            // 
            this.exitform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitform.Animated = true;
            this.exitform.FillColor = System.Drawing.Color.Transparent;
            this.exitform.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitform.IconColor = System.Drawing.Color.White;
            this.exitform.Location = new System.Drawing.Point(276, 7);
            this.exitform.Margin = new System.Windows.Forms.Padding(2);
            this.exitform.Name = "exitform";
            this.exitform.PressedColor = System.Drawing.Color.Transparent;
            this.exitform.Size = new System.Drawing.Size(33, 31);
            this.exitform.TabIndex = 13;
            // 
            // Reset
            // 
            this.Reset.AutoSize = true;
            this.Reset.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.Reset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Reset.Location = new System.Drawing.Point(21, 15);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(132, 17);
            this.Reset.TabIndex = 0;
            this.Reset.Text = "Reset Password";
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
            this.btnproceed.Location = new System.Drawing.Point(99, 141);
            this.btnproceed.Margin = new System.Windows.Forms.Padding(2);
            this.btnproceed.Name = "btnproceed";
            this.btnproceed.Size = new System.Drawing.Size(124, 37);
            this.btnproceed.TabIndex = 71;
            this.btnproceed.Text = "Proceed";
            this.btnproceed.Click += new System.EventHandler(this.btnproceed_Click);
            // 
            // cbusername
            // 
            this.cbusername.BackColor = System.Drawing.Color.Transparent;
            this.cbusername.BorderColor = System.Drawing.Color.Black;
            this.cbusername.BorderRadius = 8;
            this.cbusername.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbusername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbusername.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbusername.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.cbusername.ForeColor = System.Drawing.Color.Black;
            this.cbusername.ItemHeight = 30;
            this.cbusername.Location = new System.Drawing.Point(22, 50);
            this.cbusername.Margin = new System.Windows.Forms.Padding(2);
            this.cbusername.Name = "cbusername";
            this.cbusername.Size = new System.Drawing.Size(270, 36);
            this.cbusername.TabIndex = 78;
            this.cbusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbusername.SelectionChangeCommitted += new System.EventHandler(this.cbusername_SelectionChangeCommitted);
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
            this.txtpassword.Enabled = false;
            this.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.Location = new System.Drawing.Point(22, 90);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.PlaceholderText = "";
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(270, 36);
            this.txtpassword.TabIndex = 79;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // Userreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 194);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.cbusername);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnproceed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Userreset";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Userreset";
            this.Load += new System.EventHandler(this.Userreset_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse smoothedge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Reset;
        public Guna.UI2.WinForms.Guna2Button btnproceed;
        private Guna.UI2.WinForms.Guna2ControlBox exitform;
        private Guna.UI2.WinForms.Guna2ComboBox cbusername;
        public Guna.UI2.WinForms.Guna2TextBox txtpassword;
    }
}