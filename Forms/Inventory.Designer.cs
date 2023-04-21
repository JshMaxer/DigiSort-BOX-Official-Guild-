
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
            this.btnprint = new System.Windows.Forms.Button();
            this.btndeleteready = new System.Windows.Forms.Button();
            this.btnupdateready = new System.Windows.Forms.Button();
            this.txtsearchready = new System.Windows.Forms.TextBox();
            this.dgready = new System.Windows.Forms.DataGridView();
            this.btndeleteraw = new System.Windows.Forms.Button();
            this.btnupdateraw = new System.Windows.Forms.Button();
            this.txtsearchraw = new System.Windows.Forms.TextBox();
            this.dgrawmaterial = new System.Windows.Forms.DataGridView();
            this.btndeleteunprint = new System.Windows.Forms.Button();
            this.btnupdateunprint = new System.Windows.Forms.Button();
            this.dgunprinted = new System.Windows.Forms.DataGridView();
            this.txtunprinted = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgready)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrawmaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgunprinted)).BeginInit();
            this.SuspendLayout();
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(754, 522);
            this.btnprint.Margin = new System.Windows.Forms.Padding(4);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(181, 61);
            this.btnprint.TabIndex = 28;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // btndeleteready
            // 
            this.btndeleteready.Location = new System.Drawing.Point(870, 336);
            this.btndeleteready.Margin = new System.Windows.Forms.Padding(4);
            this.btndeleteready.Name = "btndeleteready";
            this.btndeleteready.Size = new System.Drawing.Size(100, 28);
            this.btndeleteready.TabIndex = 26;
            this.btndeleteready.Text = "Delete";
            this.btndeleteready.UseVisualStyleBackColor = true;
            this.btndeleteready.Click += new System.EventHandler(this.btndeleteready_Click);
            // 
            // btnupdateready
            // 
            this.btnupdateready.Location = new System.Drawing.Point(870, 300);
            this.btnupdateready.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdateready.Name = "btnupdateready";
            this.btnupdateready.Size = new System.Drawing.Size(100, 28);
            this.btnupdateready.TabIndex = 25;
            this.btnupdateready.Text = "Update";
            this.btnupdateready.UseVisualStyleBackColor = true;
            this.btnupdateready.Click += new System.EventHandler(this.btnupdateready_Click);
            // 
            // txtsearchready
            // 
            this.txtsearchready.Location = new System.Drawing.Point(852, 270);
            this.txtsearchready.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearchready.Name = "txtsearchready";
            this.txtsearchready.Size = new System.Drawing.Size(132, 22);
            this.txtsearchready.TabIndex = 24;
            this.txtsearchready.TextChanged += new System.EventHandler(this.txtsearchready_TextChanged);
            // 
            // dgready
            // 
            this.dgready.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgready.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgready.Location = new System.Drawing.Point(437, 169);
            this.dgready.Margin = new System.Windows.Forms.Padding(4);
            this.dgready.Name = "dgready";
            this.dgready.RowHeadersWidth = 51;
            this.dgready.Size = new System.Drawing.Size(407, 293);
            this.dgready.TabIndex = 23;
            // 
            // btndeleteraw
            // 
            this.btndeleteraw.Location = new System.Drawing.Point(453, 567);
            this.btndeleteraw.Margin = new System.Windows.Forms.Padding(4);
            this.btndeleteraw.Name = "btndeleteraw";
            this.btndeleteraw.Size = new System.Drawing.Size(100, 28);
            this.btndeleteraw.TabIndex = 22;
            this.btndeleteraw.Text = "Delete";
            this.btndeleteraw.UseVisualStyleBackColor = true;
            // 
            // btnupdateraw
            // 
            this.btnupdateraw.Location = new System.Drawing.Point(453, 531);
            this.btnupdateraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdateraw.Name = "btnupdateraw";
            this.btnupdateraw.Size = new System.Drawing.Size(100, 28);
            this.btnupdateraw.TabIndex = 21;
            this.btnupdateraw.Text = "Update";
            this.btnupdateraw.UseVisualStyleBackColor = true;
            // 
            // txtsearchraw
            // 
            this.txtsearchraw.Location = new System.Drawing.Point(437, 501);
            this.txtsearchraw.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearchraw.Name = "txtsearchraw";
            this.txtsearchraw.Size = new System.Drawing.Size(132, 22);
            this.txtsearchraw.TabIndex = 20;
            this.txtsearchraw.TextChanged += new System.EventHandler(this.txtsearchraw_TextChanged);
            // 
            // dgrawmaterial
            // 
            this.dgrawmaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrawmaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrawmaterial.Location = new System.Drawing.Point(19, 314);
            this.dgrawmaterial.Margin = new System.Windows.Forms.Padding(4);
            this.dgrawmaterial.Name = "dgrawmaterial";
            this.dgrawmaterial.RowHeadersWidth = 51;
            this.dgrawmaterial.Size = new System.Drawing.Size(407, 293);
            this.dgrawmaterial.TabIndex = 19;
            // 
            // btndeleteunprint
            // 
            this.btndeleteunprint.Location = new System.Drawing.Point(453, 119);
            this.btndeleteunprint.Margin = new System.Windows.Forms.Padding(4);
            this.btndeleteunprint.Name = "btndeleteunprint";
            this.btndeleteunprint.Size = new System.Drawing.Size(100, 28);
            this.btndeleteunprint.TabIndex = 18;
            this.btndeleteunprint.Text = "Delete";
            this.btndeleteunprint.UseVisualStyleBackColor = true;
            // 
            // btnupdateunprint
            // 
            this.btnupdateunprint.Location = new System.Drawing.Point(453, 83);
            this.btnupdateunprint.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdateunprint.Name = "btnupdateunprint";
            this.btnupdateunprint.Size = new System.Drawing.Size(100, 28);
            this.btnupdateunprint.TabIndex = 17;
            this.btnupdateunprint.Text = "Update";
            this.btnupdateunprint.UseVisualStyleBackColor = true;
            // 
            // dgunprinted
            // 
            this.dgunprinted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgunprinted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgunprinted.Location = new System.Drawing.Point(19, 13);
            this.dgunprinted.Margin = new System.Windows.Forms.Padding(4);
            this.dgunprinted.Name = "dgunprinted";
            this.dgunprinted.RowHeadersWidth = 51;
            this.dgunprinted.Size = new System.Drawing.Size(407, 293);
            this.dgunprinted.TabIndex = 16;
            // 
            // txtunprinted
            // 
            this.txtunprinted.Location = new System.Drawing.Point(437, 53);
            this.txtunprinted.Margin = new System.Windows.Forms.Padding(4);
            this.txtunprinted.Name = "txtunprinted";
            this.txtunprinted.Size = new System.Drawing.Size(132, 22);
            this.txtunprinted.TabIndex = 15;
            this.txtunprinted.TextChanged += new System.EventHandler(this.txtunprinted_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Unprinted Shirts";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(854, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Ready to sell items";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Raw Material";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 621);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btndeleteready);
            this.Controls.Add(this.btnupdateready);
            this.Controls.Add(this.txtsearchready);
            this.Controls.Add(this.dgready);
            this.Controls.Add(this.btndeleteraw);
            this.Controls.Add(this.btnupdateraw);
            this.Controls.Add(this.txtsearchraw);
            this.Controls.Add(this.dgrawmaterial);
            this.Controls.Add(this.btndeleteunprint);
            this.Controls.Add(this.btnupdateunprint);
            this.Controls.Add(this.txtunprinted);
            this.Controls.Add(this.dgunprinted);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgready)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrawmaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgunprinted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btndeleteready;
        private System.Windows.Forms.Button btnupdateready;
        private System.Windows.Forms.TextBox txtsearchready;
        private System.Windows.Forms.DataGridView dgready;
        private System.Windows.Forms.Button btndeleteraw;
        private System.Windows.Forms.Button btnupdateraw;
        private System.Windows.Forms.TextBox txtsearchraw;
        private System.Windows.Forms.DataGridView dgrawmaterial;
        private System.Windows.Forms.Button btndeleteunprint;
        private System.Windows.Forms.Button btnupdateunprint;
        private System.Windows.Forms.DataGridView dgunprinted;
        private System.Windows.Forms.TextBox txtunprinted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}