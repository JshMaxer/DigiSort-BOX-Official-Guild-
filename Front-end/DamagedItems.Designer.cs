
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvitems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvitems
            // 
            this.dgvitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvitems.Location = new System.Drawing.Point(146, 71);
            this.dgvitems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvitems.Name = "dgvitems";
            this.dgvitems.RowHeadersWidth = 51;
            this.dgvitems.Size = new System.Drawing.Size(695, 386);
            this.dgvitems.TabIndex = 46;
            // 
            // smoothedge
            // 
            this.smoothedge.BorderRadius = 12;
            this.smoothedge.TargetControl = this;
            // 
            // txtissue
            // 
            this.txtissue.Animated = true;
            this.txtissue.BorderRadius = 8;
            this.txtissue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtissue.DefaultText = "";
            this.txtissue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtissue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtissue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtissue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtissue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtissue.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtissue.ForeColor = System.Drawing.Color.Black;
            this.txtissue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtissue.Location = new System.Drawing.Point(256, 465);
            this.txtissue.Margin = new System.Windows.Forms.Padding(4);
            this.txtissue.Name = "txtissue";
            this.txtissue.PasswordChar = '\0';
            this.txtissue.PlaceholderText = "ISSUE";
            this.txtissue.SelectedText = "";
            this.txtissue.Size = new System.Drawing.Size(461, 34);
            this.txtissue.TabIndex = 47;
            this.txtissue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtquantity
            // 
            this.txtquantity.Animated = true;
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
            this.txtquantity.Location = new System.Drawing.Point(428, 505);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtquantity.MaxLength = 4;
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.PasswordChar = '\0';
            this.txtquantity.PlaceholderText = "QUANTITY";
            this.txtquantity.SelectedText = "";
            this.txtquantity.Size = new System.Drawing.Size(117, 31);
            this.txtquantity.TabIndex = 47;
            this.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnadd
            // 
            this.btnadd.Animated = true;
            this.btnadd.BorderRadius = 12;
            this.btnadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnadd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(102)))), ((int)(((byte)(194)))));
            this.btnadd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(92)))), ((int)(((byte)(184)))));
            this.btnadd.Location = new System.Drawing.Point(402, 557);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(168, 52);
            this.btnadd.TabIndex = 69;
            this.btnadd.Text = "Add";
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
            this.cbtable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbtable.ItemHeight = 30;
            this.cbtable.Items.AddRange(new object[] {
            "Raw Materials",
            "Ready to Sell Items",
            "Unprinted Shirts"});
            this.cbtable.Location = new System.Drawing.Point(214, 11);
            this.cbtable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbtable.Name = "cbtable";
            this.cbtable.Size = new System.Drawing.Size(558, 36);
            this.cbtable.StartIndex = 0;
            this.cbtable.TabIndex = 79;
            this.cbtable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Damaged_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 622);
            this.Controls.Add(this.cbtable);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtissue);
            this.Controls.Add(this.dgvitems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Damaged_Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Damaged Items";
            ((System.ComponentModel.ISupportInitialize)(this.dgvitems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvitems;
        private Guna.UI2.WinForms.Guna2Elipse smoothedge;
        private Guna.UI2.WinForms.Guna2TextBox txtquantity;
        private Guna.UI2.WinForms.Guna2TextBox txtissue;
        public Guna.UI2.WinForms.Guna2Button btnadd;
        private Guna.UI2.WinForms.Guna2ComboBox cbtable;
    }
}