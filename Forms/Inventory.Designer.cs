
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
            this.btnprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(138)))), ((int)(((byte)(92)))));
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(566, 424);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(136, 50);
            this.btnprint.TabIndex = 28;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            // 
            // btndeleteready
            // 
            this.btndeleteready.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(138)))), ((int)(((byte)(92)))));
            this.btndeleteready.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeleteready.Location = new System.Drawing.Point(652, 273);
            this.btndeleteready.Name = "btndeleteready";
            this.btndeleteready.Size = new System.Drawing.Size(75, 23);
            this.btndeleteready.TabIndex = 26;
            this.btndeleteready.Text = "Delete";
            this.btndeleteready.UseVisualStyleBackColor = false;
            this.btndeleteready.Click += new System.EventHandler(this.btndeleteready_Click);
            // 
            // btnupdateready
            // 
            this.btnupdateready.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(138)))), ((int)(((byte)(92)))));
            this.btnupdateready.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdateready.Location = new System.Drawing.Point(652, 244);
            this.btnupdateready.Name = "btnupdateready";
            this.btnupdateready.Size = new System.Drawing.Size(75, 23);
            this.btnupdateready.TabIndex = 25;
            this.btnupdateready.Text = "Update";
            this.btnupdateready.UseVisualStyleBackColor = false;
            this.btnupdateready.Click += new System.EventHandler(this.btnupdateready_Click);
            // 
            // txtsearchready
            // 
            this.txtsearchready.Location = new System.Drawing.Point(639, 219);
            this.txtsearchready.Name = "txtsearchready";
            this.txtsearchready.Size = new System.Drawing.Size(100, 20);
            this.txtsearchready.TabIndex = 24;
            this.txtsearchready.TextChanged += new System.EventHandler(this.txtsearchready_TextChanged);
            // 
            // dgready
            // 
            this.dgready.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgready.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgready.Location = new System.Drawing.Point(328, 137);
            this.dgready.Name = "dgready";
            this.dgready.RowHeadersWidth = 51;
            this.dgready.Size = new System.Drawing.Size(304, 238);
            this.dgready.TabIndex = 23;
            // 
            // btndeleteraw
            // 
            this.btndeleteraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(138)))), ((int)(((byte)(92)))));
            this.btndeleteraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeleteraw.Location = new System.Drawing.Point(340, 461);
            this.btndeleteraw.Name = "btndeleteraw";
            this.btndeleteraw.Size = new System.Drawing.Size(75, 23);
            this.btndeleteraw.TabIndex = 22;
            this.btndeleteraw.Text = "Delete";
            this.btndeleteraw.UseVisualStyleBackColor = false;
            // 
            // btnupdateraw
            // 
            this.btnupdateraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(138)))), ((int)(((byte)(92)))));
            this.btnupdateraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdateraw.Location = new System.Drawing.Point(340, 431);
            this.btnupdateraw.Name = "btnupdateraw";
            this.btnupdateraw.Size = new System.Drawing.Size(75, 23);
            this.btnupdateraw.TabIndex = 21;
            this.btnupdateraw.Text = "Update";
            this.btnupdateraw.UseVisualStyleBackColor = false;
            // 
            // txtsearchraw
            // 
            this.txtsearchraw.Location = new System.Drawing.Point(328, 407);
            this.txtsearchraw.Name = "txtsearchraw";
            this.txtsearchraw.Size = new System.Drawing.Size(100, 20);
            this.txtsearchraw.TabIndex = 20;
            this.txtsearchraw.TextChanged += new System.EventHandler(this.txtsearchraw_TextChanged);
            // 
            // dgrawmaterial
            // 
            this.dgrawmaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrawmaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrawmaterial.Location = new System.Drawing.Point(14, 255);
            this.dgrawmaterial.Name = "dgrawmaterial";
            this.dgrawmaterial.RowHeadersWidth = 51;
            this.dgrawmaterial.Size = new System.Drawing.Size(304, 238);
            this.dgrawmaterial.TabIndex = 19;
            // 
            // btndeleteunprint
            // 
            this.btndeleteunprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(138)))), ((int)(((byte)(92)))));
            this.btndeleteunprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeleteunprint.Location = new System.Drawing.Point(340, 97);
            this.btndeleteunprint.Name = "btndeleteunprint";
            this.btndeleteunprint.Size = new System.Drawing.Size(75, 23);
            this.btndeleteunprint.TabIndex = 18;
            this.btndeleteunprint.Text = "Delete";
            this.btndeleteunprint.UseVisualStyleBackColor = false;
            // 
            // btnupdateunprint
            // 
            this.btnupdateunprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(138)))), ((int)(((byte)(92)))));
            this.btnupdateunprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdateunprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateunprint.Location = new System.Drawing.Point(340, 67);
            this.btnupdateunprint.Name = "btnupdateunprint";
            this.btnupdateunprint.Size = new System.Drawing.Size(75, 23);
            this.btnupdateunprint.TabIndex = 17;
            this.btnupdateunprint.Text = "Update";
            this.btnupdateunprint.UseVisualStyleBackColor = false;
            // 
            // dgunprinted
            // 
            this.dgunprinted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgunprinted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgunprinted.Location = new System.Drawing.Point(14, 11);
            this.dgunprinted.Name = "dgunprinted";
            this.dgunprinted.RowHeadersWidth = 51;
            this.dgunprinted.Size = new System.Drawing.Size(304, 238);
            this.dgunprinted.TabIndex = 16;
            // 
            // txtunprinted
            // 
            this.txtunprinted.Location = new System.Drawing.Point(328, 43);
            this.txtunprinted.Name = "txtunprinted";
            this.txtunprinted.Size = new System.Drawing.Size(100, 20);
            this.txtunprinted.TabIndex = 15;
            this.txtunprinted.TextChanged += new System.EventHandler(this.txtunprinted_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Unprinted Shirts";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(640, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Ready to sell items";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 390);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Raw Material";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 505);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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