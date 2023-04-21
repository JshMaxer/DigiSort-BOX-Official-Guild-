
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
            this.SuspendLayout();
            // 
            // btnraw
            // 
            this.btnraw.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnraw.Location = new System.Drawing.Point(9, 10);
            this.btnraw.Name = "btnraw";
            this.btnraw.Size = new System.Drawing.Size(200, 55);
            this.btnraw.TabIndex = 0;
            this.btnraw.Text = "Raw Material";
            this.btnraw.UseVisualStyleBackColor = true;
            this.btnraw.Click += new System.EventHandler(this.btnraw_Click);
            // 
            // btnunprint
            // 
            this.btnunprint.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnunprint.Location = new System.Drawing.Point(9, 71);
            this.btnunprint.Name = "btnunprint";
            this.btnunprint.Size = new System.Drawing.Size(200, 55);
            this.btnunprint.TabIndex = 0;
            this.btnunprint.Text = "Unprited Shirts";
            this.btnunprint.UseVisualStyleBackColor = true;
            this.btnunprint.Click += new System.EventHandler(this.btnunprint_Click);
            // 
            // btnready
            // 
            this.btnready.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnready.Location = new System.Drawing.Point(9, 133);
            this.btnready.Name = "btnready";
            this.btnready.Size = new System.Drawing.Size(200, 55);
            this.btnready.TabIndex = 0;
            this.btnready.Text = "Ready to sell Items";
            this.btnready.UseVisualStyleBackColor = true;
            this.btnready.Click += new System.EventHandler(this.btnready_Click);
            // 
            // preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(220, 199);
            this.Controls.Add(this.btnready);
            this.Controls.Add(this.btnunprint);
            this.Controls.Add(this.btnraw);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview Account";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.preview_FormClosed);
            this.Load += new System.EventHandler(this.preview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnraw;
        private System.Windows.Forms.Button btnunprint;
        private System.Windows.Forms.Button btnready;
    }
}