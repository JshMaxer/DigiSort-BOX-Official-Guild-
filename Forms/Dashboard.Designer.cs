
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
            this.btninventory = new System.Windows.Forms.Button();
            this.btndash = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnready
            // 
            this.btnready.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(138)))), ((int)(((byte)(92)))));
            this.btnready.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnready.ForeColor = System.Drawing.Color.White;
            this.btnready.Location = new System.Drawing.Point(12, 244);
            this.btnready.Name = "btnready";
            this.btnready.Size = new System.Drawing.Size(93, 84);
            this.btnready.TabIndex = 6;
            this.btnready.Text = "Ready-to-sell items";
            this.btnready.UseVisualStyleBackColor = false;
            this.btnready.Click += new System.EventHandler(this.btnready_Click);
            // 
            // btnraw
            // 
            this.btnraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(138)))), ((int)(((byte)(92)))));
            this.btnraw.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnraw.ForeColor = System.Drawing.Color.White;
            this.btnraw.Location = new System.Drawing.Point(12, 334);
            this.btnraw.Name = "btnraw";
            this.btnraw.Size = new System.Drawing.Size(93, 84);
            this.btnraw.TabIndex = 5;
            this.btnraw.Text = "Raw Materials";
            this.btnraw.UseVisualStyleBackColor = false;
            this.btnraw.Click += new System.EventHandler(this.btnraw_Click);
            // 
            // btnunprinted
            // 
            this.btnunprinted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(138)))), ((int)(((byte)(92)))));
            this.btnunprinted.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnunprinted.ForeColor = System.Drawing.Color.White;
            this.btnunprinted.Location = new System.Drawing.Point(12, 154);
            this.btnunprinted.Name = "btnunprinted";
            this.btnunprinted.Size = new System.Drawing.Size(93, 84);
            this.btnunprinted.TabIndex = 4;
            this.btnunprinted.Text = "Unprinted Shirt";
            this.btnunprinted.UseVisualStyleBackColor = false;
            this.btnunprinted.Click += new System.EventHandler(this.btnunprinted_Click);
            // 
            // btninventory
            // 
            this.btninventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(138)))), ((int)(((byte)(92)))));
            this.btninventory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninventory.ForeColor = System.Drawing.Color.White;
            this.btninventory.Location = new System.Drawing.Point(12, 425);
            this.btninventory.Name = "btninventory";
            this.btninventory.Size = new System.Drawing.Size(93, 84);
            this.btninventory.TabIndex = 5;
            this.btninventory.Text = "Inventory";
            this.btninventory.UseVisualStyleBackColor = false;
            this.btninventory.Click += new System.EventHandler(this.btninventory_Click);
            // 
            // btndash
            // 
            this.btndash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(138)))), ((int)(((byte)(92)))));
            this.btndash.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndash.ForeColor = System.Drawing.Color.White;
            this.btndash.Location = new System.Drawing.Point(12, 64);
            this.btndash.Name = "btndash";
            this.btndash.Size = new System.Drawing.Size(93, 84);
            this.btndash.TabIndex = 4;
            this.btndash.Text = "Dashboard";
            this.btndash.UseVisualStyleBackColor = false;
            this.btndash.Click += new System.EventHandler(this.btndash_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Location = new System.Drawing.Point(110, 49);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(747, 497);
            this.mainpanel.TabIndex = 8;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Location = new System.Drawing.Point(-11, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 41);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(732, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(609, 13);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 23);
            this.btnlogout.TabIndex = 1;
            this.btnlogout.Text = "Log out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(690, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "User Account";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(816, 13);
            this.txtname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(39, 19);
            this.txtname.TabIndex = 0;
            this.txtname.Text = "Name";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.btnready);
            this.Controls.Add(this.btninventory);
            this.Controls.Add(this.btnraw);
            this.Controls.Add(this.btndash);
            this.Controls.Add(this.btnunprinted);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnready;
        private System.Windows.Forms.Button btnraw;
        private System.Windows.Forms.Button btnunprinted;
        private System.Windows.Forms.Button btninventory;
        private System.Windows.Forms.Button btndash;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label txtname;
    }
}