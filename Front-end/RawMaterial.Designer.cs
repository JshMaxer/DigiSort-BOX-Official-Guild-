
namespace DigiSort_Box.Forms
{
    partial class RawMaterial
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
            this.btnback = new System.Windows.Forms.Button();
            this.btnadd = new Guna.UI2.WinForms.Guna2Button();
            this.txtquantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbcolor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbdesign = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbmaterial = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Gray;
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(9, 10);
            this.btnback.Margin = new System.Windows.Forms.Padding(2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(58, 28);
            this.btnback.TabIndex = 67;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Visible = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnadd
            // 
            this.btnadd.Animated = true;
            this.btnadd.BorderRadius = 12;
            this.btnadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnadd.Enabled = false;
            this.btnadd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(102)))), ((int)(((byte)(194)))));
            this.btnadd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(92)))), ((int)(((byte)(184)))));
            this.btnadd.Location = new System.Drawing.Point(580, 439);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(124, 37);
            this.btnadd.TabIndex = 68;
            this.btnadd.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtquantity
            // 
            this.txtquantity.Animated = true;
            this.txtquantity.BorderColor = System.Drawing.Color.Black;
            this.txtquantity.BorderRadius = 8;
            this.txtquantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtquantity.DefaultText = "";
            this.txtquantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtquantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtquantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtquantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtquantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtquantity.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txtquantity.ForeColor = System.Drawing.Color.Black;
            this.txtquantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtquantity.Location = new System.Drawing.Point(244, 359);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtquantity.MaxLength = 3;
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.PasswordChar = '\0';
            this.txtquantity.PlaceholderText = "";
            this.txtquantity.SelectedText = "";
            this.txtquantity.Size = new System.Drawing.Size(269, 29);
            this.txtquantity.TabIndex = 79;
            this.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            this.txtquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantity_KeyPress);
            // 
            // cbcolor
            // 
            this.cbcolor.BackColor = System.Drawing.Color.Transparent;
            this.cbcolor.BorderColor = System.Drawing.Color.Black;
            this.cbcolor.BorderRadius = 8;
            this.cbcolor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbcolor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcolor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbcolor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbcolor.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.cbcolor.ForeColor = System.Drawing.Color.Black;
            this.cbcolor.ItemHeight = 30;
            this.cbcolor.Items.AddRange(new object[] {
            "",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple",
            "White",
            "Brown",
            "Gray",
            "Black"});
            this.cbcolor.Location = new System.Drawing.Point(244, 278);
            this.cbcolor.Margin = new System.Windows.Forms.Padding(2);
            this.cbcolor.Name = "cbcolor";
            this.cbcolor.Size = new System.Drawing.Size(270, 36);
            this.cbcolor.StartIndex = 0;
            this.cbcolor.TabIndex = 76;
            this.cbcolor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbcolor.SelectedIndexChanged += new System.EventHandler(this.cbcolor_SelectedIndexChanged);
            // 
            // cbdesign
            // 
            this.cbdesign.BackColor = System.Drawing.Color.Transparent;
            this.cbdesign.BorderColor = System.Drawing.Color.Black;
            this.cbdesign.BorderRadius = 8;
            this.cbdesign.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbdesign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdesign.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbdesign.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbdesign.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.cbdesign.ForeColor = System.Drawing.Color.Black;
            this.cbdesign.ItemHeight = 30;
            this.cbdesign.Items.AddRange(new object[] {
            "",
            "SpyXFamily",
            "Naruto",
            "OnePiece",
            "Black Clover",
            "Kimetsu no Yaiba",
            "Bleach",
            "Boku no tige"});
            this.cbdesign.Location = new System.Drawing.Point(244, 197);
            this.cbdesign.Margin = new System.Windows.Forms.Padding(2);
            this.cbdesign.Name = "cbdesign";
            this.cbdesign.Size = new System.Drawing.Size(270, 36);
            this.cbdesign.TabIndex = 77;
            this.cbdesign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbdesign.SelectedIndexChanged += new System.EventHandler(this.cbdesign_SelectedIndexChanged);
            // 
            // cbmaterial
            // 
            this.cbmaterial.BackColor = System.Drawing.Color.Transparent;
            this.cbmaterial.BorderColor = System.Drawing.Color.Black;
            this.cbmaterial.BorderRadius = 8;
            this.cbmaterial.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmaterial.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmaterial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmaterial.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.cbmaterial.ForeColor = System.Drawing.Color.Black;
            this.cbmaterial.ItemHeight = 30;
            this.cbmaterial.Items.AddRange(new object[] {
            "",
            "Vinyl",
            "Sticker paper",
            "Laminating film",
            "DTP."});
            this.cbmaterial.Location = new System.Drawing.Point(244, 115);
            this.cbmaterial.Margin = new System.Windows.Forms.Padding(2);
            this.cbmaterial.Name = "cbmaterial";
            this.cbmaterial.Size = new System.Drawing.Size(270, 36);
            this.cbmaterial.StartIndex = 0;
            this.cbmaterial.TabIndex = 78;
            this.cbmaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbmaterial.SelectedIndexChanged += new System.EventHandler(this.cbmaterial_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(346, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 75;
            this.label10.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(357, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 74;
            this.label9.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(351, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 73;
            this.label7.Text = "Design";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(346, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 72;
            this.label5.Text = "Material";
            // 
            // RawMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 505);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.cbcolor);
            this.Controls.Add(this.cbdesign);
            this.Controls.Add(this.cbmaterial);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RawMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RawMaterial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnback;
        public Guna.UI2.WinForms.Guna2Button btnadd;
        private Guna.UI2.WinForms.Guna2TextBox txtquantity;
        private Guna.UI2.WinForms.Guna2ComboBox cbcolor;
        private Guna.UI2.WinForms.Guna2ComboBox cbdesign;
        private Guna.UI2.WinForms.Guna2ComboBox cbmaterial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}