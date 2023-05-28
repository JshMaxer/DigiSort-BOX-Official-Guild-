
namespace DigiSort_Box.Forms
{
    partial class useraccount
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitform = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.smoothedge = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtfirstname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtlastname = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnreset = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtposition = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnuserreset = new Guna.UI2.WinForms.Guna2Button();
            this.btnconcern = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(102)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.exitform);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 45);
            this.panel1.TabIndex = 10;
            // 
            // exitform
            // 
            this.exitform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitform.Animated = true;
            this.exitform.FillColor = System.Drawing.Color.Transparent;
            this.exitform.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitform.IconColor = System.Drawing.Color.White;
            this.exitform.Location = new System.Drawing.Point(240, 4);
            this.exitform.Name = "exitform";
            this.exitform.Size = new System.Drawing.Size(44, 38);
            this.exitform.TabIndex = 12;
            this.exitform.Click += new System.EventHandler(this.exitform_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "User Account";
            // 
            // smoothedge
            // 
            this.smoothedge.BorderRadius = 12;
            this.smoothedge.TargetControl = this;
            // 
            // txtusername
            // 
            this.txtusername.BorderRadius = 8;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.DefaultText = "";
            this.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.Location = new System.Drawing.Point(12, 83);
            this.txtusername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PlaceholderText = "";
            this.txtusername.ReadOnly = true;
            this.txtusername.SelectedText = "";
            this.txtusername.Size = new System.Drawing.Size(259, 38);
            this.txtusername.TabIndex = 11;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtfirstname
            // 
            this.txtfirstname.BorderRadius = 8;
            this.txtfirstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfirstname.DefaultText = "";
            this.txtfirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtfirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtfirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfirstname.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtfirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfirstname.Location = new System.Drawing.Point(12, 156);
            this.txtfirstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.PasswordChar = '\0';
            this.txtfirstname.PlaceholderText = "";
            this.txtfirstname.ReadOnly = true;
            this.txtfirstname.SelectedText = "";
            this.txtfirstname.Size = new System.Drawing.Size(259, 38);
            this.txtfirstname.TabIndex = 11;
            this.txtfirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtlastname
            // 
            this.txtlastname.BorderRadius = 8;
            this.txtlastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlastname.DefaultText = "";
            this.txtlastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtlastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtlastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtlastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtlastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlastname.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtlastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlastname.Location = new System.Drawing.Point(14, 225);
            this.txtlastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.PasswordChar = '\0';
            this.txtlastname.PlaceholderText = "";
            this.txtlastname.ReadOnly = true;
            this.txtlastname.SelectedText = "";
            this.txtlastname.Size = new System.Drawing.Size(259, 38);
            this.txtlastname.TabIndex = 11;
            this.txtlastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnreset
            // 
            this.btnreset.Animated = true;
            this.btnreset.BorderRadius = 20;
            this.btnreset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnreset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnreset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnreset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnreset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(102)))), ((int)(((byte)(194)))));
            this.btnreset.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(92)))), ((int)(((byte)(184)))));
            this.btnreset.Location = new System.Drawing.Point(68, 349);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(151, 45);
            this.btnreset.TabIndex = 12;
            this.btnreset.Text = "Reset Password";
            this.btnreset.Click += new System.EventHandler(this.btnsignin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Position";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtposition
            // 
            this.txtposition.BorderRadius = 8;
            this.txtposition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtposition.DefaultText = "";
            this.txtposition.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtposition.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtposition.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtposition.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtposition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtposition.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtposition.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtposition.Location = new System.Drawing.Point(14, 294);
            this.txtposition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtposition.Name = "txtposition";
            this.txtposition.PasswordChar = '\0';
            this.txtposition.PlaceholderText = "";
            this.txtposition.ReadOnly = true;
            this.txtposition.SelectedText = "";
            this.txtposition.Size = new System.Drawing.Size(259, 38);
            this.txtposition.TabIndex = 11;
            this.txtposition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnuserreset
            // 
            this.btnuserreset.Animated = true;
            this.btnuserreset.BorderRadius = 20;
            this.btnuserreset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnuserreset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnuserreset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnuserreset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnuserreset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(102)))), ((int)(((byte)(194)))));
            this.btnuserreset.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnuserreset.ForeColor = System.Drawing.Color.White;
            this.btnuserreset.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(92)))), ((int)(((byte)(184)))));
            this.btnuserreset.Location = new System.Drawing.Point(68, 349);
            this.btnuserreset.Name = "btnuserreset";
            this.btnuserreset.Size = new System.Drawing.Size(151, 45);
            this.btnuserreset.TabIndex = 13;
            this.btnuserreset.Text = "Reset User Password";
            this.btnuserreset.Visible = false;
            this.btnuserreset.Click += new System.EventHandler(this.btnuserreset_Click);
            // 
            // btnconcern
            // 
            this.btnconcern.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnconcern.HoverState.Image = global::DigiSort_Box.Properties.Resources.bell__1_;
            this.btnconcern.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnconcern.Image = global::DigiSort_Box.Properties.Resources.bell;
            this.btnconcern.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnconcern.ImageRotate = 0F;
            this.btnconcern.ImageSize = new System.Drawing.Size(25, 25);
            this.btnconcern.Location = new System.Drawing.Point(219, 352);
            this.btnconcern.Name = "btnconcern";
            this.btnconcern.PressedState.Image = global::DigiSort_Box.Properties.Resources.bell__1_;
            this.btnconcern.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnconcern.Size = new System.Drawing.Size(52, 42);
            this.btnconcern.TabIndex = 14;
            this.btnconcern.Visible = false;
            this.btnconcern.Click += new System.EventHandler(this.btnconcern_Click);
            // 
            // useraccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(283, 417);
            this.Controls.Add(this.btnconcern);
            this.Controls.Add(this.btnuserreset);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.txtposition);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "useraccount";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USER ACCOUNT";
            this.Load += new System.EventHandler(this.useraccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse smoothedge;
        private Guna.UI2.WinForms.Guna2ControlBox exitform;
        public Guna.UI2.WinForms.Guna2TextBox txtusername;
        public Guna.UI2.WinForms.Guna2TextBox txtlastname;
        public Guna.UI2.WinForms.Guna2TextBox txtfirstname;
        private Guna.UI2.WinForms.Guna2Button btnreset;
        public Guna.UI2.WinForms.Guna2TextBox txtposition;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnuserreset;
        private Guna.UI2.WinForms.Guna2ImageButton btnconcern;
    }
}