
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
            this.components = new System.ComponentModel.Container();
            this.dgready = new System.Windows.Forms.DataGridView();
            this.dgrawmaterial = new System.Windows.Forms.DataGridView();
            this.dgunprinted = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtunprinted = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtready = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtraw = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnupdate = new Guna.UI2.WinForms.Guna2Button();
            this.btndelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnprint = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgready)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrawmaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgunprinted)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgready
            // 
            this.dgready.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgready.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgready.Location = new System.Drawing.Point(437, 169);
            this.dgready.Margin = new System.Windows.Forms.Padding(4);
            this.dgready.Name = "dgready";
            this.dgready.RowHeadersWidth = 51;
            this.dgready.Size = new System.Drawing.Size(405, 293);
            this.dgready.TabIndex = 23;
            // 
            // dgrawmaterial
            // 
            this.dgrawmaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrawmaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrawmaterial.Location = new System.Drawing.Point(19, 314);
            this.dgrawmaterial.Margin = new System.Windows.Forms.Padding(4);
            this.dgrawmaterial.Name = "dgrawmaterial";
            this.dgrawmaterial.RowHeadersWidth = 51;
            this.dgrawmaterial.Size = new System.Drawing.Size(405, 293);
            this.dgrawmaterial.TabIndex = 19;
            // 
            // dgunprinted
            // 
            this.dgunprinted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgunprinted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgunprinted.Location = new System.Drawing.Point(19, 14);
            this.dgunprinted.Margin = new System.Windows.Forms.Padding(4);
            this.dgunprinted.Name = "dgunprinted";
            this.dgunprinted.RowHeadersWidth = 51;
            this.dgunprinted.Size = new System.Drawing.Size(405, 293);
            this.dgunprinted.TabIndex = 16;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 28);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // txtunprinted
            // 
            this.txtunprinted.Animated = true;
            this.txtunprinted.BorderRadius = 8;
            this.txtunprinted.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtunprinted.DefaultText = "";
            this.txtunprinted.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtunprinted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtunprinted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtunprinted.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtunprinted.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtunprinted.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtunprinted.ForeColor = System.Drawing.Color.Black;
            this.txtunprinted.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtunprinted.Location = new System.Drawing.Point(437, 14);
            this.txtunprinted.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtunprinted.MaxLength = 4;
            this.txtunprinted.Name = "txtunprinted";
            this.txtunprinted.PasswordChar = '\0';
            this.txtunprinted.PlaceholderText = "< Unprinted Shirts";
            this.txtunprinted.SelectedText = "";
            this.txtunprinted.Size = new System.Drawing.Size(210, 35);
            this.txtunprinted.TabIndex = 48;
            this.txtunprinted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtunprinted.TextChanged += new System.EventHandler(this.txtunprinted_TextChanged_1);
            // 
            // txtready
            // 
            this.txtready.Animated = true;
            this.txtready.BorderRadius = 8;
            this.txtready.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtready.DefaultText = "";
            this.txtready.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtready.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtready.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtready.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtready.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtready.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtready.ForeColor = System.Drawing.Color.Black;
            this.txtready.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtready.Location = new System.Drawing.Point(437, 126);
            this.txtready.Margin = new System.Windows.Forms.Padding(4);
            this.txtready.MaxLength = 4;
            this.txtready.Name = "txtready";
            this.txtready.PasswordChar = '\0';
            this.txtready.PlaceholderText = "Ready to sell items";
            this.txtready.SelectedText = "";
            this.txtready.Size = new System.Drawing.Size(210, 35);
            this.txtready.TabIndex = 48;
            this.txtready.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtready.TextChanged += new System.EventHandler(this.txtready_TextChanged);
            // 
            // txtraw
            // 
            this.txtraw.Animated = true;
            this.txtraw.BorderRadius = 8;
            this.txtraw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtraw.DefaultText = "";
            this.txtraw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtraw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtraw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtraw.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtraw.ForeColor = System.Drawing.Color.Black;
            this.txtraw.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtraw.Location = new System.Drawing.Point(437, 470);
            this.txtraw.Margin = new System.Windows.Forms.Padding(4);
            this.txtraw.MaxLength = 4;
            this.txtraw.Name = "txtraw";
            this.txtraw.PasswordChar = '\0';
            this.txtraw.PlaceholderText = "Raw Material";
            this.txtraw.SelectedText = "";
            this.txtraw.Size = new System.Drawing.Size(210, 35);
            this.txtraw.TabIndex = 48;
            this.txtraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtraw.TextChanged += new System.EventHandler(this.txtraw_TextChanged);
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
            this.btnupdate.Location = new System.Drawing.Point(844, 493);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(139, 53);
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
            this.btndelete.Location = new System.Drawing.Point(844, 554);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(139, 53);
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
            this.btnprint.Location = new System.Drawing.Point(699, 557);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(139, 53);
            this.btnprint.TabIndex = 72;
            this.btnprint.Text = "PRINT";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 622);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtraw);
            this.Controls.Add(this.txtready);
            this.Controls.Add(this.txtunprinted);
            this.Controls.Add(this.dgready);
            this.Controls.Add(this.dgrawmaterial);
            this.Controls.Add(this.dgunprinted);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgready)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrawmaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgunprinted)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgready;
        private System.Windows.Forms.DataGridView dgrawmaterial;
        private System.Windows.Forms.DataGridView dgunprinted;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2TextBox txtunprinted;
        private Guna.UI2.WinForms.Guna2TextBox txtready;
        private Guna.UI2.WinForms.Guna2TextBox txtraw;
        private Guna.UI2.WinForms.Guna2Button btnupdate;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private Guna.UI2.WinForms.Guna2GradientButton btnprint;
    }
}