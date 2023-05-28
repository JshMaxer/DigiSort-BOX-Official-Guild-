
namespace DigiSort_Box.Forms
{
    partial class Unprinted
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnadd = new Guna.UI2.WinForms.Guna2Button();
            this.cbcolor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbshade = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbsize = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtquantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(339, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 49;
            this.label10.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(355, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(348, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Shade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Color";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Gray;
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(9, 10);
            this.btnback.Margin = new System.Windows.Forms.Padding(2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(58, 28);
            this.btnback.TabIndex = 59;
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
            this.btnadd.TabIndex = 69;
            this.btnadd.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
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
            this.cbcolor.Location = new System.Drawing.Point(238, 107);
            this.cbcolor.Margin = new System.Windows.Forms.Padding(2);
            this.cbcolor.Name = "cbcolor";
            this.cbcolor.Size = new System.Drawing.Size(270, 36);
            this.cbcolor.StartIndex = 0;
            this.cbcolor.TabIndex = 70;
            this.cbcolor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbcolor.SelectedIndexChanged += new System.EventHandler(this.cbcolor_SelectedIndexChanged);
            // 
            // cbshade
            // 
            this.cbshade.BackColor = System.Drawing.Color.Transparent;
            this.cbshade.BorderColor = System.Drawing.Color.Black;
            this.cbshade.BorderRadius = 8;
            this.cbshade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbshade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbshade.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbshade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbshade.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.cbshade.ForeColor = System.Drawing.Color.Black;
            this.cbshade.ItemHeight = 30;
            this.cbshade.Location = new System.Drawing.Point(238, 172);
            this.cbshade.Margin = new System.Windows.Forms.Padding(2);
            this.cbshade.Name = "cbshade";
            this.cbshade.Size = new System.Drawing.Size(270, 36);
            this.cbshade.TabIndex = 70;
            this.cbshade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbshade.SelectedIndexChanged += new System.EventHandler(this.cbshade_SelectedIndexChanged);
            // 
            // cbsize
            // 
            this.cbsize.BackColor = System.Drawing.Color.Transparent;
            this.cbsize.BorderColor = System.Drawing.Color.Black;
            this.cbsize.BorderRadius = 8;
            this.cbsize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbsize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsize.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbsize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbsize.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.cbsize.ForeColor = System.Drawing.Color.Black;
            this.cbsize.ItemHeight = 30;
            this.cbsize.Items.AddRange(new object[] {
            "",
            "Small",
            "Medium",
            "Large",
            "Extra Large",
            "2XL",
            "3XL",
            "4XL",
            "5XL"});
            this.cbsize.Location = new System.Drawing.Point(238, 246);
            this.cbsize.Margin = new System.Windows.Forms.Padding(2);
            this.cbsize.Name = "cbsize";
            this.cbsize.Size = new System.Drawing.Size(270, 36);
            this.cbsize.StartIndex = 0;
            this.cbsize.TabIndex = 70;
            this.cbsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbsize.SelectedIndexChanged += new System.EventHandler(this.cbsize_SelectedIndexChanged);
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
            this.txtquantity.Location = new System.Drawing.Point(238, 313);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtquantity.MaxLength = 3;
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.PasswordChar = '\0';
            this.txtquantity.PlaceholderText = "";
            this.txtquantity.SelectedText = "";
            this.txtquantity.Size = new System.Drawing.Size(269, 29);
            this.txtquantity.TabIndex = 71;
            this.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            this.txtquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantity_KeyPress);
            // 
            // Unprinted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 505);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.cbsize);
            this.Controls.Add(this.cbshade);
            this.Controls.Add(this.cbcolor);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Unprinted";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unprinted";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnback;
        public Guna.UI2.WinForms.Guna2Button btnadd;
        private Guna.UI2.WinForms.Guna2ComboBox cbcolor;
        private Guna.UI2.WinForms.Guna2ComboBox cbshade;
        private Guna.UI2.WinForms.Guna2ComboBox cbsize;
        private Guna.UI2.WinForms.Guna2TextBox txtquantity;
    }
}