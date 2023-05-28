
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
            this.label1 = new System.Windows.Forms.Label();
            this.exitform = new Guna.UI2.WinForms.Guna2ControlBox();
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(102)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.exitform);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 45);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Preview Account";
            // 
            // exitform
            // 
            this.exitform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitform.Animated = true;
            this.exitform.FillColor = System.Drawing.Color.Transparent;
            this.exitform.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitform.IconColor = System.Drawing.Color.White;
            this.exitform.Location = new System.Drawing.Point(201, 6);
            this.exitform.Margin = new System.Windows.Forms.Padding(2);
            this.exitform.Name = "exitform";
            this.exitform.Size = new System.Drawing.Size(33, 31);
            this.exitform.TabIndex = 14;
            // 
            // preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
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
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox exitform;
    }
}