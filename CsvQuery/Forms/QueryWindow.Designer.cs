﻿namespace CsvQuery.Forms
{
    using System.Windows.Forms;

    partial class QueryWindow
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
            this.txbQuery = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyWithHeadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmenuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.createNewCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmenuShowRowNumbers = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnExec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbQuery
            // 
            this.txbQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbQuery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbQuery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuery.Location = new System.Drawing.Point(2, 1);
            this.txbQuery.Name = "txbQuery";
            this.txbQuery.Size = new System.Drawing.Size(110, 21);
            this.txbQuery.TabIndex = 0;
            this.txbQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnQueryTextboxKeyDown);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.ContextMenuStrip = this.contextMenuStrip;
            this.dataGrid.Location = new System.Drawing.Point(13, 27);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = Main.Settings.ShowRowNumbers;
            this.dataGrid.Size = new System.Drawing.Size(259, 223);
            this.dataGrid.TabIndex = 1;
            System.Drawing.Font oldFont = this.dataGrid.DefaultCellStyle.Font;
            this.dataGrid.DefaultCellStyle.Font = new System.Drawing.Font(oldFont.Name, Main.Settings.DatagridCellFontSize);
            this.dataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.OnDataBindingComplete);

            using (var gfx = this.dataGrid.CreateGraphics())
            {
                var points = this.dataGrid.DefaultCellStyle.Font.SizeInPoints;
                this.dataGrid.RowTemplate.Height = (int)(points * gfx.DpiX / 72 + 6);                
            }

            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.copyWithHeadersToolStripMenuItem,
            this.contextmenuSelectAll,
            this.toolStripMenuItem1,
            this.createNewCSVToolStripMenuItem,
            this.contextmenuShowRowNumbers});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(173, 76);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.OnContextmenuCopy);
            // 
            // copyWithHeadersToolStripMenuItem
            // 
            this.copyWithHeadersToolStripMenuItem.Name = "copyWithHeadersToolStripMenuItem";
            this.copyWithHeadersToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.copyWithHeadersToolStripMenuItem.Text = "Copy with &headers";
            this.copyWithHeadersToolStripMenuItem.Click += new System.EventHandler(this.OnContextmenuCopyWithHeaders);
            // 
            // contextmenuSelectAll
            // 
            this.contextmenuSelectAll.Name = "contextmenuSelectAll";
            this.contextmenuSelectAll.Size = new System.Drawing.Size(172, 22);
            this.contextmenuSelectAll.Text = "Select &All";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 6);
            // 
            // createNewCSVToolStripMenuItem
            // 
            this.createNewCSVToolStripMenuItem.Name = "createNewCSVToolStripMenuItem";
            this.createNewCSVToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.createNewCSVToolStripMenuItem.Text = "Create &new CSV...";
            this.createNewCSVToolStripMenuItem.Click += new System.EventHandler(this.OnMenuClickCreateNewCSV);
            // 
            // contextmenuShowRowNumbers
            // 
            this.contextmenuShowRowNumbers.CheckOnClick = true;
            this.contextmenuShowRowNumbers.Name = "contextmenuShowRowNumbers";
            this.contextmenuShowRowNumbers.Size = new System.Drawing.Size(295, 36);
            this.contextmenuShowRowNumbers.Text = "Show row numbers";
            this.contextmenuShowRowNumbers.Click += new System.EventHandler(this.OnContextmenuShowRowNumbers);
            this.contextmenuShowRowNumbers.Checked = this.dataGrid.RowHeadersVisible;
            this.FormatDataGrid();

            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyze.Location = new System.Drawing.Point(197, 0);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyze.TabIndex = 2;
            this.btnAnalyze.Text = "&Read File";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.OnClickAnalyzeButton);
            // 
            // btnExec
            // 
            this.btnExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExec.Location = new System.Drawing.Point(116, 0);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(75, 23);
            this.btnExec.TabIndex = 3;
            this.btnExec.Text = "&Execute";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.OnClickExecButton);
            // 
            // QueryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.txbQuery);
            this.Name = "QueryWindow";
            this.Text = "QueryWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbQuery;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyWithHeadersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createNewCSVToolStripMenuItem;
        private ToolStripMenuItem contextmenuSelectAll;
        private ToolStripMenuItem contextmenuShowRowNumbers;
    }
}