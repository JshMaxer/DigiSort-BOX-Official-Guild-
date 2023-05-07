
namespace DigiSort_Box.Forms
{
    partial class Dashboard
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
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.Label();
            this.info = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.dragcotrol = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.smoothedge = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btndamageitems = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btninvent = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnreadytosell = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnrawmaterials = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnunprintedshirts = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btdashboard = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btuseraccount = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnlogout = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Location = new System.Drawing.Point(129, 60);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1014, 612);
            this.mainpanel.TabIndex = 8;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btuseraccount);
            this.panel1.Location = new System.Drawing.Point(-15, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 50);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(976, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 36);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(27, 18);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(50, 20);
            this.txtname.TabIndex = 0;
            this.txtname.Text = "Menu";
            this.txtname.Visible = false;
            // 
            // info
            // 
            this.info.AllowLinksHandling = true;
            this.info.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.MaximumSize = new System.Drawing.Size(0, 0);
            this.info.ToolTipTitle = "Guide";
            // 
            // dragcotrol
            // 
            this.dragcotrol.DockIndicatorTransparencyValue = 0.6D;
            this.dragcotrol.TargetControl = this.panel1;
            this.dragcotrol.UseTransparentDrag = true;
            // 
            // smoothedge
            // 
            this.smoothedge.BorderRadius = 12;
            this.smoothedge.TargetControl = this;
            // 
            // btndamageitems
            // 
            this.btndamageitems.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btndamageitems.HoverState.Image = global::DigiSort_Box.Properties.Resources.package__1_;
            this.btndamageitems.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btndamageitems.Image = global::DigiSort_Box.Properties.Resources.package;
            this.btndamageitems.ImageOffset = new System.Drawing.Point(0, 0);
            this.btndamageitems.ImageRotate = 0F;
            this.btndamageitems.ImageSize = new System.Drawing.Size(45, 45);
            this.btndamageitems.Location = new System.Drawing.Point(16, 473);
            this.btndamageitems.Name = "btndamageitems";
            this.btndamageitems.PressedState.Image = global::DigiSort_Box.Properties.Resources.package__1_;
            this.btndamageitems.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btndamageitems.Size = new System.Drawing.Size(96, 78);
            this.btndamageitems.TabIndex = 0;
            this.info.SetToolTip(this.btndamageitems, "Damage Items");
            this.btndamageitems.Click += new System.EventHandler(this.btndamageitems_Click);
            // 
            // btninvent
            // 
            this.btninvent.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btninvent.HoverState.Image = global::DigiSort_Box.Properties.Resources.inventory__1_;
            this.btninvent.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btninvent.Image = global::DigiSort_Box.Properties.Resources.inventory;
            this.btninvent.ImageOffset = new System.Drawing.Point(0, 0);
            this.btninvent.ImageRotate = 0F;
            this.btninvent.ImageSize = new System.Drawing.Size(45, 45);
            this.btninvent.Location = new System.Drawing.Point(16, 577);
            this.btninvent.Name = "btninvent";
            this.btninvent.PressedState.Image = global::DigiSort_Box.Properties.Resources.inventory__1_;
            this.btninvent.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btninvent.Size = new System.Drawing.Size(96, 78);
            this.btninvent.TabIndex = 0;
            this.info.SetToolTip(this.btninvent, "Inventory");
            this.btninvent.Click += new System.EventHandler(this.btninvent_Click);
            // 
            // btnreadytosell
            // 
            this.btnreadytosell.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnreadytosell.HoverState.Image = global::DigiSort_Box.Properties.Resources.trade__1_;
            this.btnreadytosell.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnreadytosell.Image = global::DigiSort_Box.Properties.Resources.trade;
            this.btnreadytosell.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnreadytosell.ImageRotate = 0F;
            this.btnreadytosell.ImageSize = new System.Drawing.Size(45, 45);
            this.btnreadytosell.Location = new System.Drawing.Point(16, 373);
            this.btnreadytosell.Name = "btnreadytosell";
            this.btnreadytosell.PressedState.Image = global::DigiSort_Box.Properties.Resources.trade__1_;
            this.btnreadytosell.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnreadytosell.Size = new System.Drawing.Size(96, 78);
            this.btnreadytosell.TabIndex = 0;
            this.info.SetToolTip(this.btnreadytosell, "Ready to sell Items");
            this.btnreadytosell.Click += new System.EventHandler(this.btnreadytosell_Click);
            // 
            // btnrawmaterials
            // 
            this.btnrawmaterials.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnrawmaterials.HoverState.Image = global::DigiSort_Box.Properties.Resources.raw_materials__1_;
            this.btnrawmaterials.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnrawmaterials.Image = global::DigiSort_Box.Properties.Resources.raw_materials;
            this.btnrawmaterials.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnrawmaterials.ImageRotate = 0F;
            this.btnrawmaterials.ImageSize = new System.Drawing.Size(45, 45);
            this.btnrawmaterials.Location = new System.Drawing.Point(16, 272);
            this.btnrawmaterials.Name = "btnrawmaterials";
            this.btnrawmaterials.PressedState.Image = global::DigiSort_Box.Properties.Resources.raw_materials__1_;
            this.btnrawmaterials.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnrawmaterials.Size = new System.Drawing.Size(96, 78);
            this.btnrawmaterials.TabIndex = 0;
            this.info.SetToolTip(this.btnrawmaterials, "Raw Meterials");
            this.btnrawmaterials.Click += new System.EventHandler(this.btnrawmaterials_Click);
            // 
            // btnunprintedshirts
            // 
            this.btnunprintedshirts.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnunprintedshirts.HoverState.Image = global::DigiSort_Box.Properties.Resources.cloth__1_;
            this.btnunprintedshirts.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnunprintedshirts.Image = global::DigiSort_Box.Properties.Resources.cloth;
            this.btnunprintedshirts.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnunprintedshirts.ImageRotate = 0F;
            this.btnunprintedshirts.ImageSize = new System.Drawing.Size(45, 45);
            this.btnunprintedshirts.Location = new System.Drawing.Point(16, 172);
            this.btnunprintedshirts.Name = "btnunprintedshirts";
            this.btnunprintedshirts.PressedState.Image = global::DigiSort_Box.Properties.Resources.cloth__1_;
            this.btnunprintedshirts.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnunprintedshirts.Size = new System.Drawing.Size(96, 78);
            this.btnunprintedshirts.TabIndex = 0;
            this.info.SetToolTip(this.btnunprintedshirts, "Unprinted Shirts");
            this.btnunprintedshirts.Click += new System.EventHandler(this.btnunprintedshirts_Click);
            // 
            // btdashboard
            // 
            this.btdashboard.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btdashboard.HoverState.Image = global::DigiSort_Box.Properties.Resources.dashboard__1_;
            this.btdashboard.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.btdashboard.Image = global::DigiSort_Box.Properties.Resources.dashboard;
            this.btdashboard.ImageOffset = new System.Drawing.Point(0, 0);
            this.btdashboard.ImageRotate = 0F;
            this.btdashboard.ImageSize = new System.Drawing.Size(45, 45);
            this.btdashboard.Location = new System.Drawing.Point(35, 75);
            this.btdashboard.Name = "btdashboard";
            this.btdashboard.PressedState.Image = global::DigiSort_Box.Properties.Resources.dashboard__1_;
            this.btdashboard.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btdashboard.Size = new System.Drawing.Size(59, 55);
            this.btdashboard.TabIndex = 0;
            this.info.SetToolTip(this.btdashboard, "Dashboard");
            this.btdashboard.Click += new System.EventHandler(this.btdashboard_Click);
            // 
            // btuseraccount
            // 
            this.btuseraccount.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btuseraccount.HoverState.Image = global::DigiSort_Box.Properties.Resources.account;
            this.btuseraccount.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btuseraccount.Image = global::DigiSort_Box.Properties.Resources.user;
            this.btuseraccount.ImageOffset = new System.Drawing.Point(0, 0);
            this.btuseraccount.ImageRotate = 0F;
            this.btuseraccount.ImageSize = new System.Drawing.Size(20, 20);
            this.btuseraccount.Location = new System.Drawing.Point(1119, 8);
            this.btuseraccount.Name = "btuseraccount";
            this.btuseraccount.PressedState.Image = global::DigiSort_Box.Properties.Resources.account;
            this.btuseraccount.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btuseraccount.Size = new System.Drawing.Size(43, 36);
            this.btuseraccount.TabIndex = 0;
            this.info.SetToolTip(this.btuseraccount, "User Account");
            this.btuseraccount.Click += new System.EventHandler(this.btuseraccount_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnlogout.HoverState.Image = global::DigiSort_Box.Properties.Resources.logout__1_;
            this.btnlogout.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnlogout.Image = global::DigiSort_Box.Properties.Resources.logout;
            this.btnlogout.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnlogout.ImageRotate = 0F;
            this.btnlogout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnlogout.Location = new System.Drawing.Point(1070, 8);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.PressedState.Image = global::DigiSort_Box.Properties.Resources.logout__1_;
            this.btnlogout.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnlogout.Size = new System.Drawing.Size(43, 36);
            this.btnlogout.TabIndex = 0;
            this.info.SetToolTip(this.btnlogout, "Log out");
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 682);
            this.Controls.Add(this.btndamageitems);
            this.Controls.Add(this.btninvent);
            this.Controls.Add(this.btnreadytosell);
            this.Controls.Add(this.btnrawmaterials);
            this.Controls.Add(this.btnunprintedshirts);
            this.Controls.Add(this.btdashboard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label txtname;
        private Guna.UI2.WinForms.Guna2ImageButton btdashboard;
        private Guna.UI2.WinForms.Guna2ImageButton btnunprintedshirts;
        private Guna.UI2.WinForms.Guna2ImageButton btnrawmaterials;
        private Guna.UI2.WinForms.Guna2ImageButton btnreadytosell;
        private Guna.UI2.WinForms.Guna2ImageButton btninvent;
        private Guna.UI2.WinForms.Guna2ImageButton btndamageitems;
        private Guna.UI2.WinForms.Guna2HtmlToolTip info;
        private Guna.UI2.WinForms.Guna2DragControl dragcotrol;
        private Guna.UI2.WinForms.Guna2Elipse smoothedge;
        private Guna.UI2.WinForms.Guna2ImageButton btuseraccount;
        private Guna.UI2.WinForms.Guna2ImageButton btnlogout;
    }
}