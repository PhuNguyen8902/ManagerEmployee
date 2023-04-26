﻿namespace EmployeesManagement.userControl.UserControlEmployee
{
    partial class projectEmployeePage
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
            btnFindAll = new Button();
            cbSearchActive = new ComboBox();
            cbSearch = new ComboBox();
            dgvProject = new DataGridView();
            btnSearch = new Button();
            DTPSearch = new DateTimePicker();
            txtSearch = new TextBox();
            btnActive = new Button();
            btnEnd = new Button();
            btnExportExcel = new Button();
            btnDetail = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProject).BeginInit();
            SuspendLayout();
            // 
            // btnFindAll
            // 
            btnFindAll.Cursor = Cursors.Hand;
            btnFindAll.Location = new Point(415, 5);
            btnFindAll.Name = "btnFindAll";
            btnFindAll.Size = new Size(94, 29);
            btnFindAll.TabIndex = 33;
            btnFindAll.Text = "Find All";
            btnFindAll.UseVisualStyleBackColor = true;
            btnFindAll.Click += btnFindAll_Click;
            // 
            // cbSearchActive
            // 
            cbSearchActive.FormattingEnabled = true;
            cbSearchActive.Location = new Point(22, 7);
            cbSearchActive.Name = "cbSearchActive";
            cbSearchActive.Size = new Size(258, 28);
            cbSearchActive.TabIndex = 32;
            cbSearchActive.Visible = false;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(22, 49);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(253, 28);
            cbSearch.TabIndex = 31;
            cbSearch.Text = "Select the item you want to search";
            cbSearch.SelectedIndexChanged += cbSearch_SelectedIndexChanged;
            // 
            // dgvProject
            // 
            dgvProject.AllowUserToAddRows = false;
            dgvProject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProject.Dock = DockStyle.Bottom;
            dgvProject.Location = new Point(0, 163);
            dgvProject.Name = "dgvProject";
            dgvProject.ReadOnly = true;
            dgvProject.RowHeadersWidth = 51;
            dgvProject.RowTemplate.Height = 29;
            dgvProject.Size = new Size(903, 546);
            dgvProject.TabIndex = 29;
            dgvProject.CellContentClick += dgvProject_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(298, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 26;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // DTPSearch
            // 
            DTPSearch.Location = new Point(22, 7);
            DTPSearch.Name = "DTPSearch";
            DTPSearch.Size = new Size(258, 27);
            DTPSearch.TabIndex = 35;
            DTPSearch.Visible = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(22, 7);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(258, 27);
            txtSearch.TabIndex = 34;
            // 
            // btnActive
            // 
            btnActive.Cursor = Cursors.Hand;
            btnActive.Location = new Point(5, 130);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(94, 29);
            btnActive.TabIndex = 26;
            btnActive.Text = "Active";
            btnActive.UseVisualStyleBackColor = true;
            btnActive.Click += btnAcitve_Click;
            // 
            // btnEnd
            // 
            btnEnd.Cursor = Cursors.Hand;
            btnEnd.Location = new Point(100, 130);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(94, 29);
            btnEnd.TabIndex = 26;
            btnEnd.Text = "End";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Cursor = Cursors.Hand;
            btnExportExcel.Location = new Point(680, 130);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(114, 29);
            btnExportExcel.TabIndex = 26;
            btnExportExcel.Text = "Export excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnDetail
            // 
            btnDetail.Cursor = Cursors.Hand;
            btnDetail.Location = new Point(800, 130);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(94, 29);
            btnDetail.TabIndex = 26;
            btnDetail.Text = "Detail";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // projectEmployeePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnActive);
            Controls.Add(btnEnd);
            Controls.Add(btnExportExcel);
            Controls.Add(btnDetail);
            Controls.Add(DTPSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnFindAll);
            Controls.Add(cbSearchActive);
            Controls.Add(cbSearch);
            Controls.Add(dgvProject);
            Controls.Add(btnSearch);
            Name = "projectEmployeePage";
            Size = new Size(903, 709);
            Load += projectEmployeePage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFindAll;
        private ComboBox cbSearchActive;
        private ComboBox cbSearch;
        private DataGridView dgvProject;
        private Button btnSearch;
        private DateTimePicker DTPSearch;
        private TextBox txtSearch;
        private Button btnActive;
        private Button btnEnd;
        private Button btnExportExcel;
        private Button btnDetail;


    }
}
