
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtable = new System.Windows.Forms.ComboBox();
            this.dgtable = new System.Windows.Forms.DataGridView();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lbltxt1 = new System.Windows.Forms.Label();
            this.smoothedge = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.exitform = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnupdate = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.exitform);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbtable
            // 
            this.cbtable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtable.FormattingEnabled = true;
            this.cbtable.Items.AddRange(new object[] {
            resources.GetString("cbtable.Items"),
            resources.GetString("cbtable.Items1"),
            resources.GetString("cbtable.Items2")});
            resources.ApplyResources(this.cbtable, "cbtable");
            this.cbtable.Name = "cbtable";
            this.cbtable.SelectedIndexChanged += new System.EventHandler(this.cbtable_SelectedIndexChanged);
            // 
            // dgtable
            // 
            this.dgtable.AllowUserToAddRows = false;
            this.dgtable.AllowUserToDeleteRows = false;
            this.dgtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgtable, "dgtable");
            this.dgtable.Name = "dgtable";
            this.dgtable.ReadOnly = true;
            this.dgtable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtable_CellClick);
            // 
            // txt2
            // 
            resources.ApplyResources(this.txt2, "txt2");
            this.txt2.Name = "txt2";
            // 
            // txt3
            // 
            resources.ApplyResources(this.txt3, "txt3");
            this.txt3.Name = "txt3";
            // 
            // txt4
            // 
            resources.ApplyResources(this.txt4, "txt4");
            this.txt4.Name = "txt4";
            // 
            // txt1
            // 
            resources.ApplyResources(this.txt1, "txt1");
            this.txt1.Name = "txt1";
            // 
            // txt5
            // 
            resources.ApplyResources(this.txt5, "txt5");
            this.txt5.Name = "txt5";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            // 
            // lbltxt1
            // 
            resources.ApplyResources(this.lbltxt1, "lbltxt1");
            this.lbltxt1.Name = "lbltxt1";
            // 
            // smoothedge
            // 
            this.smoothedge.BorderRadius = 12;
            this.smoothedge.TargetControl = this;
            // 
            // exitform
            // 
            resources.ApplyResources(this.exitform, "exitform");
            this.exitform.Animated = true;
            this.exitform.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.exitform.IconColor = System.Drawing.Color.White;
            this.exitform.Name = "exitform";
            this.exitform.Click += new System.EventHandler(this.exitform_Click);
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
            resources.ApplyResources(this.btnupdate, "btnupdate");
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(92)))), ((int)(((byte)(184)))));
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // update
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.lbltxt1);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.dgtable);
            this.Controls.Add(this.cbtable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "update";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbtable;
        private System.Windows.Forms.DataGridView dgtable;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lbltxt1;
        private Guna.UI2.WinForms.Guna2Elipse smoothedge;
        private Guna.UI2.WinForms.Guna2ControlBox exitform;
        private Guna.UI2.WinForms.Guna2Button btnupdate;
    }
}