
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnraw
            // 
            this.btnraw.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnraw.Location = new System.Drawing.Point(22, 58);
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
            this.btnunprint.Location = new System.Drawing.Point(22, 119);
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
            this.btnready.Location = new System.Drawing.Point(22, 181);
            this.btnready.Name = "btnready";
            this.btnready.Size = new System.Drawing.Size(200, 55);
            this.btnready.TabIndex = 0;
            this.btnready.Text = "Ready to sell Items";
            this.btnready.UseVisualStyleBackColor = true;
            this.btnready.Click += new System.EventHandler(this.btnready_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 45);
            this.panel1.TabIndex = 11;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.Gray;
            this.btnback.Location = new System.Drawing.Point(203, 10);
            this.btnback.Margin = new System.Windows.Forms.Padding(4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(36, 29);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "X";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Preview Account";
            // 
            // preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(243, 258);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnready);
            this.Controls.Add(this.btnunprint);
            this.Controls.Add(this.btnraw);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview Account";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.preview_FormClosed);
            this.Load += new System.EventHandler(this.preview_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnraw;
        private System.Windows.Forms.Button btnunprint;
        private System.Windows.Forms.Button btnready;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label label1;
    }
}