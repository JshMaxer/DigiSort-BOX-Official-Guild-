﻿
namespace DigiSort_Box.Front_end
{
    partial class Damaged_Items
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
            this.components = new System.ComponentModel.Container();
            this.dgvitems = new System.Windows.Forms.DataGridView();
            this.smoothedge = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtissue = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtquantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnadd = new Guna.UI2.WinForms.Guna2Button();
            this.cbtable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvitems
            // 
            this.dgvitems.AllowUserToAddRows = false;
            this.dgvitems.AllowUserToDeleteRows = false;
            this.dgvitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvitems.Location = new System.Drawing.Point(110, 58);
            this.dgvitems.Name = "dgvitems";
            this.dgvitems.ReadOnly = true;
            this.dgvitems.RowHeadersWidth = 51;
            this.dgvitems.Size = new System.Drawing.Size(521, 314);
            this.dgvitems.TabIndex = 46;
            this.dgvitems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvitems_CellClick);
            // 
            // smoothedge
            // 
            this.smoothedge.BorderRadius = 12;
            this.smoothedge.TargetControl = this;
            // 
            // txtissue
            // 
            this.txtissue.Animated = true;
            this.txtissue.AutoScroll = true;
            this.txtissue.BorderColor = System.Drawing.Color.Black;
            this.txtissue.BorderRadius = 8;
            this.txtissue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtissue.DefaultText = "";
            this.txtissue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtissue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtissue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtissue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtissue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtissue.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.txtissue.ForeColor = System.Drawing.Color.Black;
            this.txtissue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtissue.Location = new System.Drawing.Point(118, 378);
            this.txtissue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtissue.MaxLength = 255;
            this.txtissue.Multiline = true;
            this.txtissue.Name = "txtissue";
            this.txtissue.PasswordChar = '\0';
            this.txtissue.PlaceholderText = "(ISSUE) This item is damage...";
            this.txtissue.SelectedText = "";
            this.txtissue.Size = new System.Drawing.Size(503, 80);
            this.txtissue.TabIndex = 47;
            this.txtissue.TextChanged += new System.EventHandler(this.txtissue_TextChanged);
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
            this.txtquantity.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.ForeColor = System.Drawing.Color.Black;
            this.txtquantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtquantity.Location = new System.Drawing.Point(326, 465);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtquantity.MaxLength = 3;
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.PasswordChar = '\0';
            this.txtquantity.PlaceholderText = "QUANTITY";
            this.txtquantity.SelectedText = "";
            this.txtquantity.Size = new System.Drawing.Size(88, 25);
            this.txtquantity.TabIndex = 47;
            this.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            this.txtquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantity_KeyPress);
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
            this.btnadd.Location = new System.Drawing.Point(633, 465);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(103, 31);
            this.btnadd.TabIndex = 69;
            this.btnadd.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cbtable
            // 
            this.cbtable.BackColor = System.Drawing.Color.Transparent;
            this.cbtable.BorderColor = System.Drawing.Color.Black;
            this.cbtable.BorderRadius = 8;
            this.cbtable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbtable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbtable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbtable.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.cbtable.ForeColor = System.Drawing.Color.Black;
            this.cbtable.ItemHeight = 30;
            this.cbtable.Items.AddRange(new object[] {
            "Raw Materials",
            "Ready to Sell Items",
            "Unprinted Shirts"});
            this.cbtable.Location = new System.Drawing.Point(160, 9);
            this.cbtable.Margin = new System.Windows.Forms.Padding(2);
            this.cbtable.Name = "cbtable";
            this.cbtable.Size = new System.Drawing.Size(420, 36);
            this.cbtable.StartIndex = 0;
            this.cbtable.TabIndex = 79;
            this.cbtable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbtable.SelectedIndexChanged += new System.EventHandler(this.cbtable_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 80;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 80;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(667, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 80;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 80;
            this.label4.Visible = false;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(667, 75);
            this.lblid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 81;
            this.lblid.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 82;
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(722, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 82;
            this.label6.Visible = false;
            // 
            // txtusername
            // 
            this.txtusername.AutoSize = true;
            this.txtusername.Location = new System.Drawing.Point(21, 32);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(0, 13);
            this.txtusername.TabIndex = 83;
            this.txtusername.Visible = false;
            // 
            // Damaged_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 505);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbtable);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtissue);
            this.Controls.Add(this.dgvitems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Damaged_Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Damaged Items";
            this.Load += new System.EventHandler(this.Damaged_Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvitems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvitems;
        private Guna.UI2.WinForms.Guna2Elipse smoothedge;
        private Guna.UI2.WinForms.Guna2TextBox txtquantity;
        private Guna.UI2.WinForms.Guna2TextBox txtissue;
        public Guna.UI2.WinForms.Guna2Button btnadd;
        private Guna.UI2.WinForms.Guna2ComboBox cbtable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label txtusername;
    }
}