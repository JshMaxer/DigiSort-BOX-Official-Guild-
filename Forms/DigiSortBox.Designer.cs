
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
            this.btncreate = new System.Windows.Forms.Button();
            this.btnlog = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(576, 501);
            this.btncreate.Margin = new System.Windows.Forms.Padding(4);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(100, 28);
            this.btncreate.TabIndex = 4;
            this.btncreate.Text = "Create Account";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnlog
            // 
            this.btnlog.Location = new System.Drawing.Point(290, 501);
            this.btnlog.Margin = new System.Windows.Forms.Padding(4);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(100, 28);
            this.btnlog.TabIndex = 3;
            this.btnlog.Text = "Log in";
            this.btnlog.UseVisualStyleBackColor = true;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::DigiSort_Box.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(949, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // DigiSortBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 574);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.btnlog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DigiSortBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DigiSortBox";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DigiSortBox_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnlog;
    }
}