
namespace DigiSort_Box.Forms
{
    partial class Dashboard
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
            this.btnready = new System.Windows.Forms.Button();
            this.btnraw = new System.Windows.Forms.Button();
            this.btnunprinted = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btninventory = new System.Windows.Forms.Button();
            this.btndash = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlogout = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnready
            // 
            this.btnready.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnready.Location = new System.Drawing.Point(13, 340);
            this.btnready.Margin = new System.Windows.Forms.Padding(4);
            this.btnready.Name = "btnready";
            this.btnready.Size = new System.Drawing.Size(106, 103);
            this.btnready.TabIndex = 6;
            this.btnready.Text = "Ready-to-sell items";
            this.btnready.UseVisualStyleBackColor = false;
            this.btnready.Click += new System.EventHandler(this.btnready_Click);
            // 
            // btnraw
            // 
            this.btnraw.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnraw.Location = new System.Drawing.Point(13, 451);
            this.btnraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnraw.Name = "btnraw";
            this.btnraw.Size = new System.Drawing.Size(106, 103);
            this.btnraw.TabIndex = 5;
            this.btnraw.Text = "Raw Materials";
            this.btnraw.UseVisualStyleBackColor = false;
            this.btnraw.Click += new System.EventHandler(this.btnraw_Click);
            // 
            // btnunprinted
            // 
            this.btnunprinted.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnunprinted.Location = new System.Drawing.Point(13, 229);
            this.btnunprinted.Margin = new System.Windows.Forms.Padding(4);
            this.btnunprinted.Name = "btnunprinted";
            this.btnunprinted.Size = new System.Drawing.Size(106, 103);
            this.btnunprinted.TabIndex = 4;
            this.btnunprinted.Text = "Unprinted Shirt";
            this.btnunprinted.UseVisualStyleBackColor = false;
            this.btnunprinted.Click += new System.EventHandler(this.btnunprinted_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::DigiSort_Box.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btninventory
            // 
            this.btninventory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btninventory.Location = new System.Drawing.Point(13, 562);
            this.btninventory.Margin = new System.Windows.Forms.Padding(4);
            this.btninventory.Name = "btninventory";
            this.btninventory.Size = new System.Drawing.Size(106, 103);
            this.btninventory.TabIndex = 5;
            this.btninventory.Text = "Inventory";
            this.btninventory.UseVisualStyleBackColor = false;
            this.btninventory.Click += new System.EventHandler(this.btninventory_Click);
            // 
            // btndash
            // 
            this.btndash.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndash.Location = new System.Drawing.Point(13, 118);
            this.btndash.Margin = new System.Windows.Forms.Padding(4);
            this.btndash.Name = "btndash";
            this.btndash.Size = new System.Drawing.Size(106, 103);
            this.btndash.TabIndex = 4;
            this.btndash.Text = "Dashboard";
            this.btndash.UseVisualStyleBackColor = false;
            this.btndash.Click += new System.EventHandler(this.btndash_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Location = new System.Drawing.Point(134, 53);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1008, 612);
            this.mainpanel.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtlogout);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Location = new System.Drawing.Point(126, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 50);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(938, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "-";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(976, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtlogout
            // 
            this.txtlogout.AutoSize = true;
            this.txtlogout.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogout.Location = new System.Drawing.Point(865, 16);
            this.txtlogout.Name = "txtlogout";
            this.txtlogout.Size = new System.Drawing.Size(58, 24);
            this.txtlogout.TabIndex = 0;
            this.txtlogout.Text = "Log out";
            this.txtlogout.Click += new System.EventHandler(this.txtlogout_Click);
            this.txtlogout.MouseLeave += new System.EventHandler(this.txtlogout_MouseLeave);
            this.txtlogout.MouseHover += new System.EventHandler(this.txtlogout_MouseHover);
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(4, 16);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(48, 24);
            this.txtname.TabIndex = 0;
            this.txtname.Text = "Name";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1158, 682);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnready);
            this.Controls.Add(this.btninventory);
            this.Controls.Add(this.btnraw);
            this.Controls.Add(this.btndash);
            this.Controls.Add(this.btnunprinted);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnready;
        private System.Windows.Forms.Button btnraw;
        private System.Windows.Forms.Button btnunprinted;
        private System.Windows.Forms.Button btninventory;
        private System.Windows.Forms.Button btndash;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label txtname;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label txtlogout;
    }
}