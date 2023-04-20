
namespace DigiSort_Box.Forms
{
    partial class preview
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
            this.btnraw = new System.Windows.Forms.Button();
            this.btnunprint = new System.Windows.Forms.Button();
            this.btnready = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnraw
            // 
            this.btnraw.Location = new System.Drawing.Point(12, 44);
            this.btnraw.Name = "btnraw";
            this.btnraw.Size = new System.Drawing.Size(178, 52);
            this.btnraw.TabIndex = 0;
            this.btnraw.Text = "Raw Material";
            this.btnraw.UseVisualStyleBackColor = true;
            this.btnraw.Click += new System.EventHandler(this.btnraw_Click);
            // 
            // btnunprint
            // 
            this.btnunprint.Location = new System.Drawing.Point(12, 102);
            this.btnunprint.Name = "btnunprint";
            this.btnunprint.Size = new System.Drawing.Size(178, 52);
            this.btnunprint.TabIndex = 0;
            this.btnunprint.Text = "Unprited Shirts";
            this.btnunprint.UseVisualStyleBackColor = true;
            this.btnunprint.Click += new System.EventHandler(this.btnunprint_Click);
            // 
            // btnready
            // 
            this.btnready.Location = new System.Drawing.Point(12, 160);
            this.btnready.Name = "btnready";
            this.btnready.Size = new System.Drawing.Size(178, 52);
            this.btnready.TabIndex = 0;
            this.btnready.Text = "Ready to sell Items";
            this.btnready.UseVisualStyleBackColor = true;
            this.btnready.Click += new System.EventHandler(this.btnready_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Gray;
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(66, 4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(78, 34);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.button1_Click);
            // 
            // preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(204, 217);
            this.Controls.Add(this.btnready);
            this.Controls.Add(this.btnunprint);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview Account";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnraw;
        private System.Windows.Forms.Button btnunprint;
        private System.Windows.Forms.Button btnready;
        private System.Windows.Forms.Button btnback;
    }
}