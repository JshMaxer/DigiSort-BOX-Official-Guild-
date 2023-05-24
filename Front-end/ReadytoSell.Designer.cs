
namespace DigiSort_Box.Forms
{
    partial class ReadytoSell
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
            this.cbshade = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbcolor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbproduct = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbsize = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Gray;
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(12, 12);
            this.btnback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(77, 34);
            this.btnback.TabIndex = 66;
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
            this.btnadd.Location = new System.Drawing.Point(774, 540);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(165, 45);
            this.btnadd.TabIndex = 69;
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
            this.txtquantity.Location = new System.Drawing.Point(318, 428);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(5);
            this.txtquantity.MaxLength = 3;
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.PasswordChar = '\0';
            this.txtquantity.PlaceholderText = "";
            this.txtquantity.SelectedText = "";
            this.txtquantity.Size = new System.Drawing.Size(359, 36);
            this.txtquantity.TabIndex = 79;
            this.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            this.txtquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantity_KeyPress);
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
            this.cbshade.Location = new System.Drawing.Point(318, 273);
            this.cbshade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbshade.Name = "cbshade";
            this.cbshade.Size = new System.Drawing.Size(359, 36);
            this.cbshade.TabIndex = 76;
            this.cbshade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbshade.SelectedIndexChanged += new System.EventHandler(this.cbshade_SelectedIndexChanged);
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
            this.cbcolor.Location = new System.Drawing.Point(318, 202);
            this.cbcolor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbcolor.Name = "cbcolor";
            this.cbcolor.Size = new System.Drawing.Size(359, 36);
            this.cbcolor.TabIndex = 77;
            this.cbcolor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbcolor.SelectedIndexChanged += new System.EventHandler(this.cbcolor_SelectedIndexChanged);
            // 
            // cbproduct
            // 
            this.cbproduct.BackColor = System.Drawing.Color.Transparent;
            this.cbproduct.BorderColor = System.Drawing.Color.Black;
            this.cbproduct.BorderRadius = 8;
            this.cbproduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbproduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbproduct.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbproduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbproduct.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.cbproduct.ForeColor = System.Drawing.Color.Black;
            this.cbproduct.ItemHeight = 30;
            this.cbproduct.Items.AddRange(new object[] {
            "",
            "SpyXFamily",
            "Naruto",
            "OnePiece",
            "Black Clover",
            "Kimetsu no Yaiba",
            "Bleach",
            "Boku no tige"});
            this.cbproduct.Location = new System.Drawing.Point(318, 132);
            this.cbproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbproduct.Name = "cbproduct";
            this.cbproduct.Size = new System.Drawing.Size(359, 36);
            this.cbproduct.StartIndex = 0;
            this.cbproduct.TabIndex = 78;
            this.cbproduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbproduct.SelectedIndexChanged += new System.EventHandler(this.cbproduct_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(452, 403);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 75;
            this.label10.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(464, 251);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 74;
            this.label9.Text = "Shade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(464, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 73;
            this.label7.Text = "Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(475, 328);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 74;
            this.label8.Text = "Size";
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
            this.cbsize.Location = new System.Drawing.Point(318, 350);
            this.cbsize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbsize.Name = "cbsize";
            this.cbsize.Size = new System.Drawing.Size(359, 36);
            this.cbsize.StartIndex = 0;
            this.cbsize.TabIndex = 76;
            this.cbsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbsize.SelectedIndexChanged += new System.EventHandler(this.cbsize_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 72;
            this.label6.Text = "Product Name";
            // 
            // ReadytoSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 622);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.cbsize);
            this.Controls.Add(this.cbshade);
            this.Controls.Add(this.cbcolor);
            this.Controls.Add(this.cbproduct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReadytoSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReadytoSell";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnback;
        public Guna.UI2.WinForms.Guna2Button btnadd;
        private Guna.UI2.WinForms.Guna2TextBox txtquantity;
        private Guna.UI2.WinForms.Guna2ComboBox cbshade;
        private Guna.UI2.WinForms.Guna2ComboBox cbcolor;
        private Guna.UI2.WinForms.Guna2ComboBox cbproduct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox cbsize;
        private System.Windows.Forms.Label label6;
    }
}