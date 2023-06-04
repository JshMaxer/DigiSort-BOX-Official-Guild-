
namespace DigiSort_Box.Forms
{
    partial class Inventory
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
            this.dgready = new System.Windows.Forms.DataGridView();
            this.dgrawmaterial = new System.Windows.Forms.DataGridView();
            this.dgunprinted = new System.Windows.Forms.DataGridView();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnupdate = new Guna.UI2.WinForms.Guna2Button();
            this.btndelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnprint = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtusername = new System.Windows.Forms.Label();
            this.dgrawdamage = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabraw = new System.Windows.Forms.TabPage();
            this.tabready = new System.Windows.Forms.TabPage();
            this.tabunprinted = new System.Windows.Forms.TabPage();
            this.tabrawdamage = new System.Windows.Forms.TabPage();
            this.tabreadydamage = new System.Windows.Forms.TabPage();
            this.dgreadydamage = new System.Windows.Forms.DataGridView();
            this.tabunprinteddamage = new System.Windows.Forms.TabPage();
            this.dgunprinteddamage = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgready)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrawmaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgunprinted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrawdamage)).BeginInit();
            this.guna2TabControl1.SuspendLayout();
            this.tabraw.SuspendLayout();
            this.tabready.SuspendLayout();
            this.tabunprinted.SuspendLayout();
            this.tabrawdamage.SuspendLayout();
            this.tabreadydamage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgreadydamage)).BeginInit();
            this.tabunprinteddamage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgunprinteddamage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgready
            // 
            this.dgready.AllowUserToAddRows = false;
            this.dgready.AllowUserToDeleteRows = false;
            this.dgready.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgready.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgready.Location = new System.Drawing.Point(6, 6);
            this.dgready.Name = "dgready";
            this.dgready.ReadOnly = true;
            this.dgready.RowHeadersWidth = 51;
            this.dgready.Size = new System.Drawing.Size(426, 481);
            this.dgready.TabIndex = 23;
            // 
            // dgrawmaterial
            // 
            this.dgrawmaterial.AllowUserToAddRows = false;
            this.dgrawmaterial.AllowUserToDeleteRows = false;
            this.dgrawmaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrawmaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrawmaterial.Location = new System.Drawing.Point(6, 6);
            this.dgrawmaterial.Name = "dgrawmaterial";
            this.dgrawmaterial.ReadOnly = true;
            this.dgrawmaterial.RowHeadersWidth = 51;
            this.dgrawmaterial.Size = new System.Drawing.Size(426, 481);
            this.dgrawmaterial.TabIndex = 19;
            // 
            // dgunprinted
            // 
            this.dgunprinted.AllowUserToAddRows = false;
            this.dgunprinted.AllowUserToDeleteRows = false;
            this.dgunprinted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgunprinted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgunprinted.Location = new System.Drawing.Point(6, 6);
            this.dgunprinted.Name = "dgunprinted";
            this.dgunprinted.ReadOnly = true;
            this.dgunprinted.RowHeadersWidth = 51;
            this.dgunprinted.Size = new System.Drawing.Size(426, 481);
            this.dgunprinted.TabIndex = 16;
            // 
            // txtsearch
            // 
            this.txtsearch.Animated = true;
            this.txtsearch.BorderRadius = 8;
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.DefaultText = "";
            this.txtsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.Color.Black;
            this.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.Location = new System.Drawing.Point(644, 34);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.MaxLength = 4;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PlaceholderText = "SEARCH";
            this.txtsearch.SelectedText = "";
            this.txtsearch.Size = new System.Drawing.Size(111, 28);
            this.txtsearch.TabIndex = 48;
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtunprinted_TextChanged_1);
            // 
            // btnupdate
            // 
            this.btnupdate.Animated = true;
            this.btnupdate.BorderRadius = 12;
            this.btnupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnupdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(102)))), ((int)(((byte)(194)))));
            this.btnupdate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(92)))), ((int)(((byte)(184)))));
            this.btnupdate.Location = new System.Drawing.Point(647, 87);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(104, 43);
            this.btnupdate.TabIndex = 70;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Animated = true;
            this.btndelete.BorderRadius = 12;
            this.btndelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(102)))), ((int)(((byte)(194)))));
            this.btndelete.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(92)))), ((int)(((byte)(184)))));
            this.btndelete.Location = new System.Drawing.Point(647, 135);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(104, 43);
            this.btndelete.TabIndex = 71;
            this.btndelete.Text = "DELETE";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // btnprint
            // 
            this.btnprint.Animated = true;
            this.btnprint.BorderRadius = 12;
            this.btnprint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnprint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnprint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnprint.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnprint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnprint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnprint.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(99)))));
            this.btnprint.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnprint.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(99)))));
            this.btnprint.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnprint.Location = new System.Drawing.Point(647, 183);
            this.btnprint.Margin = new System.Windows.Forms.Padding(2);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(104, 43);
            this.btnprint.TabIndex = 72;
            this.btnprint.Text = "PRINT";
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // txtusername
            // 
            this.txtusername.AutoSize = true;
            this.txtusername.Location = new System.Drawing.Point(660, 326);
            this.txtusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(0, 13);
            this.txtusername.TabIndex = 73;
            this.txtusername.Visible = false;
            // 
            // dgrawdamage
            // 
            this.dgrawdamage.AllowUserToAddRows = false;
            this.dgrawdamage.AllowUserToDeleteRows = false;
            this.dgrawdamage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrawdamage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrawdamage.Location = new System.Drawing.Point(6, 6);
            this.dgrawdamage.Name = "dgrawdamage";
            this.dgrawdamage.ReadOnly = true;
            this.dgrawdamage.RowHeadersWidth = 51;
            this.dgrawdamage.Size = new System.Drawing.Size(426, 481);
            this.dgrawdamage.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(668, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 74;
            this.label2.Text = "Update";
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.tabraw);
            this.guna2TabControl1.Controls.Add(this.tabready);
            this.guna2TabControl1.Controls.Add(this.tabunprinted);
            this.guna2TabControl1.Controls.Add(this.tabrawdamage);
            this.guna2TabControl1.Controls.Add(this.tabreadydamage);
            this.guna2TabControl1.Controls.Add(this.tabunprinteddamage);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(1, 2);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(626, 502);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 75;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabraw
            // 
            this.tabraw.Controls.Add(this.dgrawmaterial);
            this.tabraw.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabraw.Location = new System.Drawing.Point(184, 4);
            this.tabraw.Name = "tabraw";
            this.tabraw.Padding = new System.Windows.Forms.Padding(3);
            this.tabraw.Size = new System.Drawing.Size(438, 494);
            this.tabraw.TabIndex = 0;
            this.tabraw.Text = "Raw Material";
            this.tabraw.UseVisualStyleBackColor = true;
            // 
            // tabready
            // 
            this.tabready.Controls.Add(this.dgready);
            this.tabready.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabready.Location = new System.Drawing.Point(184, 4);
            this.tabready.Name = "tabready";
            this.tabready.Padding = new System.Windows.Forms.Padding(3);
            this.tabready.Size = new System.Drawing.Size(438, 494);
            this.tabready.TabIndex = 1;
            this.tabready.Text = "Ready to sell Items";
            this.tabready.UseVisualStyleBackColor = true;
            // 
            // tabunprinted
            // 
            this.tabunprinted.Controls.Add(this.dgunprinted);
            this.tabunprinted.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabunprinted.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabunprinted.Location = new System.Drawing.Point(184, 4);
            this.tabunprinted.Name = "tabunprinted";
            this.tabunprinted.Size = new System.Drawing.Size(438, 494);
            this.tabunprinted.TabIndex = 2;
            this.tabunprinted.Text = "Unprinted Shirts";
            this.tabunprinted.UseVisualStyleBackColor = true;
            // 
            // tabrawdamage
            // 
            this.tabrawdamage.Controls.Add(this.dgrawdamage);
            this.tabrawdamage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabrawdamage.Location = new System.Drawing.Point(184, 4);
            this.tabrawdamage.Name = "tabrawdamage";
            this.tabrawdamage.Padding = new System.Windows.Forms.Padding(3);
            this.tabrawdamage.Size = new System.Drawing.Size(438, 494);
            this.tabrawdamage.TabIndex = 3;
            this.tabrawdamage.Text = "Raw Material Damage Items";
            this.tabrawdamage.UseVisualStyleBackColor = true;
            // 
            // tabreadydamage
            // 
            this.tabreadydamage.Controls.Add(this.dgreadydamage);
            this.tabreadydamage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabreadydamage.Location = new System.Drawing.Point(184, 4);
            this.tabreadydamage.Name = "tabreadydamage";
            this.tabreadydamage.Size = new System.Drawing.Size(438, 494);
            this.tabreadydamage.TabIndex = 4;
            this.tabreadydamage.Text = "Ready to sell Items Damage Items";
            this.tabreadydamage.UseVisualStyleBackColor = true;
            // 
            // dgreadydamage
            // 
            this.dgreadydamage.AllowUserToAddRows = false;
            this.dgreadydamage.AllowUserToDeleteRows = false;
            this.dgreadydamage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgreadydamage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgreadydamage.Location = new System.Drawing.Point(6, 7);
            this.dgreadydamage.Name = "dgreadydamage";
            this.dgreadydamage.ReadOnly = true;
            this.dgreadydamage.RowHeadersWidth = 51;
            this.dgreadydamage.Size = new System.Drawing.Size(426, 481);
            this.dgreadydamage.TabIndex = 20;
            // 
            // tabunprinteddamage
            // 
            this.tabunprinteddamage.Controls.Add(this.dgunprinteddamage);
            this.tabunprinteddamage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabunprinteddamage.Location = new System.Drawing.Point(184, 4);
            this.tabunprinteddamage.Name = "tabunprinteddamage";
            this.tabunprinteddamage.Size = new System.Drawing.Size(438, 494);
            this.tabunprinteddamage.TabIndex = 5;
            this.tabunprinteddamage.Text = "Unprinted Shirts Damage Items";
            this.tabunprinteddamage.UseVisualStyleBackColor = true;
            // 
            // dgunprinteddamage
            // 
            this.dgunprinteddamage.AllowUserToAddRows = false;
            this.dgunprinteddamage.AllowUserToDeleteRows = false;
            this.dgunprinteddamage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgunprinteddamage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgunprinteddamage.Location = new System.Drawing.Point(6, 7);
            this.dgunprinteddamage.Name = "dgunprinteddamage";
            this.dgunprinteddamage.ReadOnly = true;
            this.dgunprinteddamage.RowHeadersWidth = 51;
            this.dgunprinteddamage.Size = new System.Drawing.Size(426, 481);
            this.dgunprinteddamage.TabIndex = 21;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 505);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtsearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgready)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrawmaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgunprinted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrawdamage)).EndInit();
            this.guna2TabControl1.ResumeLayout(false);
            this.tabraw.ResumeLayout(false);
            this.tabready.ResumeLayout(false);
            this.tabunprinted.ResumeLayout(false);
            this.tabrawdamage.ResumeLayout(false);
            this.tabreadydamage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgreadydamage)).EndInit();
            this.tabunprinteddamage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgunprinteddamage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgready;
        private System.Windows.Forms.DataGridView dgrawmaterial;
        private System.Windows.Forms.DataGridView dgunprinted;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private Guna.UI2.WinForms.Guna2Button btnupdate;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private Guna.UI2.WinForms.Guna2GradientButton btnprint;
        private System.Windows.Forms.DataGridView dgrawdamage;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label txtusername;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabraw;
        private System.Windows.Forms.TabPage tabready;
        private System.Windows.Forms.TabPage tabunprinted;
        private System.Windows.Forms.TabPage tabrawdamage;
        private System.Windows.Forms.TabPage tabreadydamage;
        private System.Windows.Forms.TabPage tabunprinteddamage;
        private System.Windows.Forms.DataGridView dgreadydamage;
        private System.Windows.Forms.DataGridView dgunprinteddamage;
    }
}