
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
            this.btnuseraccount = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.Label();
            this.btdashboard = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnunprintedshirts = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnrawmaterials = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnreadytosell = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btninvent = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btndamageitems = new Guna.UI2.WinForms.Guna2ImageButton();
            this.info = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.dragcotrol = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.smoothedge = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
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
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Controls.Add(this.btnuseraccount);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Location = new System.Drawing.Point(-15, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 50);
            this.panel1.TabIndex = 9;
            // 
            // btnuseraccount
            // 
            this.btnuseraccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnuseraccount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuseraccount.ForeColor = System.Drawing.Color.Transparent;
            this.btnuseraccount.Location = new System.Drawing.Point(948, 10);
            this.btnuseraccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnuseraccount.Name = "btnuseraccount";
            this.btnuseraccount.Size = new System.Drawing.Size(161, 28);
            this.btnuseraccount.TabIndex = 2;
            this.btnuseraccount.Text = "User Account";
            this.btnuseraccount.UseVisualStyleBackColor = false;
            this.btnuseraccount.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnlogout.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(840, 10);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(100, 28);
            this.btnlogout.TabIndex = 1;
            this.btnlogout.Text = "Log out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.button1_Click);
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
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::DigiSort_Box.Properties.Resources._1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1126, 7);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(39, 36);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnuseraccount;
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
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}