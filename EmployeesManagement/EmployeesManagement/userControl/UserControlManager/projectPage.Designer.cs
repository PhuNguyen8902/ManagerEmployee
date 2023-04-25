﻿namespace EmployeesManagement.userControl.UserControlManager
{
    partial class projectPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbSearchActive = new System.Windows.Forms.ComboBox();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnFindAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnEndProject = new System.Windows.Forms.Button();
            this.btnActiveProject = new System.Windows.Forms.Button();
            this.dgvProject = new System.Windows.Forms.DataGridView();
            this.btnExportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSearchActive
            // 
            this.cbSearchActive.FormattingEnabled = true;
            this.cbSearchActive.Location = new System.Drawing.Point(21, 22);
            this.cbSearchActive.Name = "cbSearchActive";
            this.cbSearchActive.Size = new System.Drawing.Size(258, 28);
            this.cbSearchActive.TabIndex = 26;
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(21, 67);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(253, 28);
            this.cbSearch.TabIndex = 25;
            this.cbSearch.Text = "Chọn mục muốn tìm kiếm";
            // 
            // btnFindAll
            // 
            this.btnFindAll.Location = new System.Drawing.Point(417, 22);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(94, 29);
            this.btnFindAll.TabIndex = 31;
            this.btnFindAll.Text = "Find All";
            this.btnFindAll.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(300, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(797, 157);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(94, 29);
            this.btnDetail.TabIndex = 32;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnEndProject
            // 
            this.btnEndProject.Location = new System.Drawing.Point(107, 157);
            this.btnEndProject.Name = "btnEndProject";
            this.btnEndProject.Size = new System.Drawing.Size(94, 29);
            this.btnEndProject.TabIndex = 33;
            this.btnEndProject.Text = "End";
            this.btnEndProject.UseVisualStyleBackColor = true;
            this.btnEndProject.Click += new System.EventHandler(this.btnEndProject_Click);
            // 
            // btnActiveProject
            // 
            this.btnActiveProject.Location = new System.Drawing.Point(7, 157);
            this.btnActiveProject.Name = "btnActiveProject";
            this.btnActiveProject.Size = new System.Drawing.Size(94, 29);
            this.btnActiveProject.TabIndex = 34;
            this.btnActiveProject.Text = "Active";
            this.btnActiveProject.UseVisualStyleBackColor = true;
            this.btnActiveProject.Click += new System.EventHandler(this.btnActiveProject_Click);
            // 
            // dgvProject
            // 
            this.dgvProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProject.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProject.Location = new System.Drawing.Point(0, 192);
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.ReadOnly = true;
            this.dgvProject.RowHeadersWidth = 51;
            this.dgvProject.RowTemplate.Height = 29;
            this.dgvProject.Size = new System.Drawing.Size(903, 517);
            this.dgvProject.TabIndex = 35;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(673, 157);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(118, 29);
            this.btnExportExcel.TabIndex = 36;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // projectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.dgvProject);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnEndProject);
            this.Controls.Add(this.btnActiveProject);
            this.Controls.Add(this.btnFindAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbSearchActive);
            this.Controls.Add(this.cbSearch);
            this.Name = "projectPage";
            this.Size = new System.Drawing.Size(903, 709);
            this.Load += new System.EventHandler(this.projectPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbSearchActive;
        private ComboBox cbSearch;
        private Button btnFindAll;
        private Button btnSearch;
        private Button btnDetail;
        private Button btnEndProject;
        private Button btnActiveProject;
        private DataGridView dgvProject;
        private Button btnExportExcel;
    }
}
