
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
            this.txtname = new System.Windows.Forms.Label();
            this.btndeact = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnactivity = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogout = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btuseraccount = new Guna.UI2.WinForms.Guna2ImageButton();
            this.info = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.btndamageitems = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btninvent = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnreadytosell = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnrawmaterials = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnunprintedshirts = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btdashboard = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dragcotrol = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.smoothedge = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Location = new System.Drawing.Point(97, 49);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(760, 497);
            this.mainpanel.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.btndeact);
            this.panel1.Controls.Add(this.btnactivity);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btuseraccount);
            this.panel1.Location = new System.Drawing.Point(-11, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 41);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtname.Location = new System.Drawing.Point(20, 12);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(50, 17);
            this.txtname.TabIndex = 2;
            this.txtname.Text = "Menu";
            this.txtname.Visible = false;
            // 
            // btndeact
            // 
            this.btndeact.BorderRadius = 8;
            this.btndeact.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndeact.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndeact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndeact.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndeact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndeact.FillColor = System.Drawing.Color.Lavender;
            this.btndeact.FillColor2 = System.Drawing.Color.FloralWhite;
            this.btndeact.Font = new System.Drawing.Font("Verdana", 9F);
            this.btndeact.ForeColor = System.Drawing.Color.Black;
            this.btndeact.Location = new System.Drawing.Point(509, 7);
            this.btndeact.Name = "btndeact";
            this.btndeact.Size = new System.Drawing.Size(176, 27);
            this.btndeact.TabIndex = 1;
            this.btndeact.Text = "Account Deactivation";
            // 
            // btnactivity
            // 
            this.btnactivity.BorderRadius = 8;
            this.btnactivity.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnactivity.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnactivity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnactivity.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnactivity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnactivity.FillColor = System.Drawing.Color.Lavender;
            this.btnactivity.FillColor2 = System.Drawing.Color.FloralWhite;
            this.btnactivity.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnactivity.ForeColor = System.Drawing.Color.Black;
            this.btnactivity.Location = new System.Drawing.Point(691, 7);
            this.btnactivity.Name = "btnactivity";
            this.btnactivity.Size = new System.Drawing.Size(106, 27);
            this.btnactivity.TabIndex = 0;
            this.btnactivity.Text = "Activity Logs";
            this.btnactivity.Click += new System.EventHandler(this.btnactivity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(732, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.btnlogout.Location = new System.Drawing.Point(802, 6);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.PressedState.Image = global::DigiSort_Box.Properties.Resources.logout__1_;
            this.btnlogout.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnlogout.Size = new System.Drawing.Size(32, 29);
            this.btnlogout.TabIndex = 0;
            this.info.SetToolTip(this.btnlogout, "Log out");
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
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
            this.btuseraccount.Location = new System.Drawing.Point(839, 6);
            this.btuseraccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btuseraccount.Name = "btuseraccount";
            this.btuseraccount.PressedState.Image = global::DigiSort_Box.Properties.Resources.account;
            this.btuseraccount.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btuseraccount.Size = new System.Drawing.Size(32, 29);
            this.btuseraccount.TabIndex = 0;
            this.info.SetToolTip(this.btuseraccount, "User Account");
            this.btuseraccount.Click += new System.EventHandler(this.btuseraccount_Click);
            // 
            // info
            // 
            this.info.AllowLinksHandling = true;
            this.info.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.MaximumSize = new System.Drawing.Size(0, 0);
            this.info.ToolTipTitle = "Guide";
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
            this.btndamageitems.Location = new System.Drawing.Point(5, 337);
            this.btndamageitems.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.btndamageitems.Name = "btndamageitems";
            this.btndamageitems.PressedState.Image = global::DigiSort_Box.Properties.Resources.package__1_;
            this.btndamageitems.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btndamageitems.Size = new System.Drawing.Size(72, 63);
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
            this.btninvent.Location = new System.Drawing.Point(5, 420);
            this.btninvent.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.btninvent.Name = "btninvent";
            this.btninvent.PressedState.Image = global::DigiSort_Box.Properties.Resources.inventory__1_;
            this.btninvent.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btninvent.Size = new System.Drawing.Size(72, 63);
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
            this.btnreadytosell.Location = new System.Drawing.Point(5, 254);
            this.btnreadytosell.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.btnreadytosell.Name = "btnreadytosell";
            this.btnreadytosell.PressedState.Image = global::DigiSort_Box.Properties.Resources.trade__1_;
            this.btnreadytosell.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnreadytosell.Size = new System.Drawing.Size(72, 63);
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
            this.btnrawmaterials.Location = new System.Drawing.Point(5, 171);
            this.btnrawmaterials.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.btnrawmaterials.Name = "btnrawmaterials";
            this.btnrawmaterials.PressedState.Image = global::DigiSort_Box.Properties.Resources.raw_materials__1_;
            this.btnrawmaterials.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnrawmaterials.Size = new System.Drawing.Size(72, 63);
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
            this.btnunprintedshirts.Location = new System.Drawing.Point(5, 88);
            this.btnunprintedshirts.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.btnunprintedshirts.Name = "btnunprintedshirts";
            this.btnunprintedshirts.PressedState.Image = global::DigiSort_Box.Properties.Resources.cloth__1_;
            this.btnunprintedshirts.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnunprintedshirts.Size = new System.Drawing.Size(72, 63);
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
            this.btdashboard.Location = new System.Drawing.Point(5, 5);
            this.btdashboard.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.btdashboard.Name = "btdashboard";
            this.btdashboard.PressedState.Image = global::DigiSort_Box.Properties.Resources.dashboard__1_;
            this.btdashboard.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btdashboard.Size = new System.Drawing.Size(72, 63);
            this.btdashboard.TabIndex = 0;
            this.info.SetToolTip(this.btdashboard, "Dashboard");
            this.btdashboard.Click += new System.EventHandler(this.btdashboard_Click);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btdashboard);
            this.flowLayoutPanel1.Controls.Add(this.btnunprintedshirts);
            this.flowLayoutPanel1.Controls.Add(this.btnrawmaterials);
            this.flowLayoutPanel1.Controls.Add(this.btnreadytosell);
            this.flowLayoutPanel1.Controls.Add(this.btndamageitems);
            this.flowLayoutPanel1.Controls.Add(this.btninvent);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 49);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(80, 497);
            this.flowLayoutPanel1.TabIndex = 10;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 554);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
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
        private Guna.UI2.WinForms.Guna2GradientButton btndeact;
        private Guna.UI2.WinForms.Guna2GradientButton btnactivity;
        public System.Windows.Forms.Label txtname;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}