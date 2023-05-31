
namespace DigiSort_Box.Forms
{
    partial class update
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitform = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.smoothedge = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbltxt1 = new System.Windows.Forms.Label();
            this.btnupdate = new Guna.UI2.WinForms.Guna2Button();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.cbtable = new System.Windows.Forms.ComboBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.cb4 = new System.Windows.Forms.ComboBox();
            this.txtusername = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dgtable = new System.Windows.Forms.DataGridView();
            this.cb5 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(102)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.exitform);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-11, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 45);
            this.panel1.TabIndex = 0;
            // 
            // exitform
            // 
            this.exitform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitform.Animated = true;
            this.exitform.FillColor = System.Drawing.Color.Transparent;
            this.exitform.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitform.IconColor = System.Drawing.Color.White;
            this.exitform.Location = new System.Drawing.Point(298, 8);
            this.exitform.Margin = new System.Windows.Forms.Padding(2);
            this.exitform.Name = "exitform";
            this.exitform.Size = new System.Drawing.Size(33, 31);
            this.exitform.TabIndex = 12;
            this.exitform.Click += new System.EventHandler(this.exitform_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update";
            // 
            // smoothedge
            // 
            this.smoothedge.BorderRadius = 12;
            this.smoothedge.TargetControl = this;
            // 
            // lbltxt1
            // 
            this.lbltxt1.AutoSize = true;
            this.lbltxt1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbltxt1.Location = new System.Drawing.Point(9, 56);
            this.lbltxt1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltxt1.Name = "lbltxt1";
            this.lbltxt1.Size = new System.Drawing.Size(0, 13);
            this.lbltxt1.TabIndex = 9;
            this.lbltxt1.Visible = false;
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnupdate.Animated = true;
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.BorderRadius = 12;
            this.btnupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnupdate.Enabled = false;
            this.btnupdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(102)))), ((int)(((byte)(194)))));
            this.btnupdate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(92)))), ((int)(((byte)(184)))));
            this.btnupdate.Location = new System.Drawing.Point(100, 445);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(132, 46);
            this.btnupdate.TabIndex = 69;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // txt5
            // 
            this.txt5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt5.Location = new System.Drawing.Point(19, 411);
            this.txt5.Multiline = true;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(298, 24);
            this.txt5.TabIndex = 80;
            this.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbtable
            // 
            this.cbtable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbtable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtable.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.cbtable.FormattingEnabled = true;
            this.cbtable.Items.AddRange(new object[] {
            "Raw Materials",
            "Ready to Sell Items",
            "Unprinted Shirts"});
            this.cbtable.Location = new System.Drawing.Point(19, 48);
            this.cbtable.Name = "cbtable";
            this.cbtable.Size = new System.Drawing.Size(299, 25);
            this.cbtable.TabIndex = 75;
            this.cbtable.SelectedIndexChanged += new System.EventHandler(this.cbtable_SelectedIndexChanged);
            // 
            // cb1
            // 
            this.cb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(19, 276);
            this.cb1.Margin = new System.Windows.Forms.Padding(2);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(298, 24);
            this.cb1.TabIndex = 84;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // cb2
            // 
            this.cb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb2.FormattingEnabled = true;
            this.cb2.Location = new System.Drawing.Point(19, 303);
            this.cb2.Margin = new System.Windows.Forms.Padding(2);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(298, 24);
            this.cb2.TabIndex = 84;
            this.cb2.SelectedIndexChanged += new System.EventHandler(this.cb2_SelectedIndexChanged);
            // 
            // cb3
            // 
            this.cb3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb3.FormattingEnabled = true;
            this.cb3.Location = new System.Drawing.Point(19, 330);
            this.cb3.Margin = new System.Windows.Forms.Padding(2);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(298, 24);
            this.cb3.TabIndex = 84;
            this.cb3.SelectedIndexChanged += new System.EventHandler(this.cb3_SelectedIndexChanged);
            // 
            // cb4
            // 
            this.cb4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb4.FormattingEnabled = true;
            this.cb4.Location = new System.Drawing.Point(19, 357);
            this.cb4.Margin = new System.Windows.Forms.Padding(2);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(298, 24);
            this.cb4.TabIndex = 84;
            // 
            // txtusername
            // 
            this.txtusername.AutoSize = true;
            this.txtusername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtusername.Location = new System.Drawing.Point(32, 451);
            this.txtusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(0, 13);
            this.txtusername.TabIndex = 74;
            this.txtusername.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtid.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(20, 250);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(121, 23);
            this.txtid.TabIndex = 85;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgtable
            // 
            this.dgtable.AllowUserToAddRows = false;
            this.dgtable.AllowUserToDeleteRows = false;
            this.dgtable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgtable.Location = new System.Drawing.Point(19, 78);
            this.dgtable.Name = "dgtable";
            this.dgtable.ReadOnly = true;
            this.dgtable.RowHeadersWidth = 51;
            this.dgtable.Size = new System.Drawing.Size(298, 167);
            this.dgtable.TabIndex = 76;
            this.dgtable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtable_CellClick);
            // 
            // cb5
            // 
            this.cb5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb5.FormattingEnabled = true;
            this.cb5.Location = new System.Drawing.Point(19, 384);
            this.cb5.Margin = new System.Windows.Forms.Padding(2);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(298, 24);
            this.cb5.TabIndex = 84;
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(334, 500);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.cb5);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.cbtable);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.dgtable);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.lbltxt1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "update";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update and Delete";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox exitform;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse smoothedge;
        private System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.Label txtusername;
        private System.Windows.Forms.ComboBox cb4;
        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.ComboBox cbtable;
        private System.Windows.Forms.TextBox txt5;
        private Guna.UI2.WinForms.Guna2Button btnupdate;
        private System.Windows.Forms.Label lbltxt1;
        private System.Windows.Forms.DataGridView dgtable;
        private System.Windows.Forms.ComboBox cb5;
    }
}