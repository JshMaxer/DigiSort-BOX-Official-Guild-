﻿
namespace DigiSort_Box.Forms
{
    partial class maindashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgunprinted = new System.Windows.Forms.DataGridView();
            this.dgrawmaterial = new System.Windows.Forms.DataGridView();
            this.dgready = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgunprinted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrawmaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgready)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgunprinted
            // 
            this.dgunprinted.AllowUserToAddRows = false;
            this.dgunprinted.AllowUserToDeleteRows = false;
            this.dgunprinted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgunprinted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgunprinted.Location = new System.Drawing.Point(13, 13);
            this.dgunprinted.Margin = new System.Windows.Forms.Padding(4);
            this.dgunprinted.Name = "dgunprinted";
            this.dgunprinted.ReadOnly = true;
            this.dgunprinted.RowHeadersWidth = 51;
            this.dgunprinted.Size = new System.Drawing.Size(312, 125);
            this.dgunprinted.TabIndex = 0;
            // 
            // dgrawmaterial
            // 
            this.dgrawmaterial.AllowUserToAddRows = false;
            this.dgrawmaterial.AllowUserToDeleteRows = false;
            this.dgrawmaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrawmaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrawmaterial.Location = new System.Drawing.Point(333, 13);
            this.dgrawmaterial.Margin = new System.Windows.Forms.Padding(4);
            this.dgrawmaterial.Name = "dgrawmaterial";
            this.dgrawmaterial.ReadOnly = true;
            this.dgrawmaterial.RowHeadersWidth = 51;
            this.dgrawmaterial.Size = new System.Drawing.Size(312, 125);
            this.dgrawmaterial.TabIndex = 2;
            this.dgrawmaterial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // dgready
            // 
            this.dgready.AllowUserToAddRows = false;
            this.dgready.AllowUserToDeleteRows = false;
            this.dgready.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgready.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgready.Location = new System.Drawing.Point(653, 13);
            this.dgready.Margin = new System.Windows.Forms.Padding(4);
            this.dgready.Name = "dgready";
            this.dgready.ReadOnly = true;
            this.dgready.RowHeadersWidth = 51;
            this.dgready.Size = new System.Drawing.Size(312, 125);
            this.dgready.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(13, 146);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(554, 258);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(13, 416);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(943, 145);
            this.panel3.TabIndex = 7;
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(570, 146);
            this.chart2.Margin = new System.Windows.Forms.Padding(4);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(377, 265);
            this.chart2.TabIndex = 4;
            this.chart2.Text = "chart1";
            this.chart2.Click += new System.EventHandler(this.chart1_Click);
            // 
            // maindashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 574);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgready);
            this.Controls.Add(this.dgrawmaterial);
            this.Controls.Add(this.dgunprinted);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "maindashboard";
            this.Text = "Main View";
            this.Load += new System.EventHandler(this.maindashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgunprinted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrawmaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgready)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgunprinted;
        private System.Windows.Forms.DataGridView dgready;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataGridView dgrawmaterial;
    }
}