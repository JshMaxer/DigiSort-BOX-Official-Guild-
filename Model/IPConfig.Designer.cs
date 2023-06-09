namespace DigiSort_Box.Model
{
    partial class IPConfig
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
            this.txtip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbip = new System.Windows.Forms.ComboBox();
            this.btntxt = new System.Windows.Forms.Button();
            this.btncb = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtip
            // 
            this.txtip.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtip.Location = new System.Drawing.Point(56, 40);
            this.txtip.MaxLength = 16;
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(256, 27);
            this.txtip.TabIndex = 0;
            this.txtip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtip.TextChanged += new System.EventHandler(this.txtip_TextChanged);
            this.txtip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtip_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP/HOST Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "CHOOSE IP";
            // 
            // cbip
            // 
            this.cbip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbip.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbip.FormattingEnabled = true;
            this.cbip.Items.AddRange(new object[] {
            "LOCALHOST (Default)",
            "LAN (22.21)",
            "PUBLIC IP (152)"});
            this.cbip.Location = new System.Drawing.Point(56, 183);
            this.cbip.Name = "cbip";
            this.cbip.Size = new System.Drawing.Size(256, 26);
            this.cbip.TabIndex = 2;
            this.cbip.SelectedIndexChanged += new System.EventHandler(this.cbip_SelectedIndexChanged);
            // 
            // btntxt
            // 
            this.btntxt.Enabled = false;
            this.btntxt.Location = new System.Drawing.Point(318, 74);
            this.btntxt.Name = "btntxt";
            this.btntxt.Size = new System.Drawing.Size(46, 26);
            this.btntxt.TabIndex = 3;
            this.btntxt.Text = "✓";
            this.btntxt.UseVisualStyleBackColor = true;
            this.btntxt.Click += new System.EventHandler(this.btntxt_Click);
            // 
            // btncb
            // 
            this.btncb.Enabled = false;
            this.btncb.Location = new System.Drawing.Point(318, 183);
            this.btncb.Name = "btncb";
            this.btncb.Size = new System.Drawing.Size(46, 26);
            this.btncb.TabIndex = 3;
            this.btncb.Text = "✓";
            this.btncb.UseVisualStyleBackColor = true;
            this.btncb.Click += new System.EventHandler(this.btncb_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-5, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "✓";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btntxt_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 26);
            this.button2.TabIndex = 3;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(56, 105);
            this.txtusername.MaxLength = 50;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(256, 27);
            this.txtusername.TabIndex = 0;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "User Name";
            // 
            // IPConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 221);
            this.Controls.Add(this.btncb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btntxt);
            this.Controls.Add(this.cbip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IPConfig";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbip;
        private System.Windows.Forms.Button btntxt;
        private System.Windows.Forms.Button btncb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label3;
    }
}