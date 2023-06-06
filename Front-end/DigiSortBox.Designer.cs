
namespace DigiSort_Box.Forms
{
    partial class DigiSortBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DigiSortBox));
            this.panel1 = new System.Windows.Forms.Panel();
            this.formminimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.exitform = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.smoothedge = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dragcotrol = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnsignin = new Guna.UI2.WinForms.Guna2Button();
            this.btncreateaccount = new Guna.UI2.WinForms.Guna2Button();
            this.shadoow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(102)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.formminimize);
            this.panel1.Controls.Add(this.exitform);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 41);
            this.panel1.TabIndex = 10;
            // 
            // formminimize
            // 
            this.formminimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.formminimize.Animated = true;
            this.formminimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.formminimize.FillColor = System.Drawing.Color.Transparent;
            this.formminimize.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.formminimize.IconColor = System.Drawing.Color.White;
            this.formminimize.Location = new System.Drawing.Point(668, 6);
            this.formminimize.Margin = new System.Windows.Forms.Padding(2);
            this.formminimize.Name = "formminimize";
            this.formminimize.Size = new System.Drawing.Size(33, 31);
            this.formminimize.TabIndex = 11;
            // 
            // exitform
            // 
            this.exitform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitform.Animated = true;
            this.exitform.FillColor = System.Drawing.Color.Transparent;
            this.exitform.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitform.IconColor = System.Drawing.Color.White;
            this.exitform.Location = new System.Drawing.Point(706, 6);
            this.exitform.Margin = new System.Windows.Forms.Padding(2);
            this.exitform.Name = "exitform";
            this.exitform.Size = new System.Drawing.Size(33, 31);
            this.exitform.TabIndex = 11;
            this.exitform.Click += new System.EventHandler(this.exitform_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DigiSortBox";
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // smoothedge
            // 
            this.smoothedge.BorderRadius = 12;
            this.smoothedge.TargetControl = this;
            // 
            // dragcotrol
            // 
            this.dragcotrol.DockIndicatorTransparencyValue = 0.6D;
            this.dragcotrol.TargetControl = this.panel1;
            this.dragcotrol.UseTransparentDrag = true;
            // 
            // btnsignin
            // 
            this.btnsignin.Animated = true;
            this.btnsignin.AutoRoundedCorners = true;
            this.btnsignin.BorderRadius = 16;
            this.btnsignin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsignin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsignin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsignin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsignin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(102)))), ((int)(((byte)(194)))));
            this.btnsignin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnsignin.ForeColor = System.Drawing.Color.White;
            this.btnsignin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnsignin.Location = new System.Drawing.Point(218, 428);
            this.btnsignin.Margin = new System.Windows.Forms.Padding(2);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.Size = new System.Drawing.Size(134, 34);
            this.btnsignin.TabIndex = 11;
            this.btnsignin.Text = "Sign in";
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            // 
            // btncreateaccount
            // 
            this.btncreateaccount.Animated = true;
            this.btncreateaccount.AutoRoundedCorners = true;
            this.btncreateaccount.BorderRadius = 16;
            this.btncreateaccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncreateaccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncreateaccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncreateaccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncreateaccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(102)))), ((int)(((byte)(194)))));
            this.btncreateaccount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btncreateaccount.ForeColor = System.Drawing.Color.White;
            this.btncreateaccount.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btncreateaccount.Location = new System.Drawing.Point(380, 428);
            this.btncreateaccount.Margin = new System.Windows.Forms.Padding(2);
            this.btncreateaccount.Name = "btncreateaccount";
            this.btncreateaccount.Size = new System.Drawing.Size(134, 34);
            this.btncreateaccount.TabIndex = 11;
            this.btncreateaccount.Text = "Create Account";
            this.btncreateaccount.Click += new System.EventHandler(this.btncreateaccount_Click);
            // 
            // shadoow
            // 
            this.shadoow.BorderRadius = 100;
            this.shadoow.TargetForm = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::DigiSort_Box.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(725, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // DigiSortBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 505);
            this.Controls.Add(this.btncreateaccount);
            this.Controls.Add(this.btnsignin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "DigiSortBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DigiSortBox";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse smoothedge;
        private Guna.UI2.WinForms.Guna2DragControl dragcotrol;
        private Guna.UI2.WinForms.Guna2ControlBox exitform;
        private Guna.UI2.WinForms.Guna2ControlBox formminimize;
        private Guna.UI2.WinForms.Guna2Button btnsignin;
        private Guna.UI2.WinForms.Guna2Button btncreateaccount;
        private Guna.UI2.WinForms.Guna2ShadowForm shadoow;
    }
}