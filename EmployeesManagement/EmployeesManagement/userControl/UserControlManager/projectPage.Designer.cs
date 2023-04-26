namespace EmployeesManagement.userControl.UserControlManager
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
            cbSearch = new ComboBox();
            btnFindAll = new Button();
            btnSearch = new Button();
            btnDetail = new Button();
            btnEndProject = new Button();
            btnActiveProject = new Button();
            dgvProject = new DataGridView();
            btnExportExcel = new Button();
            DTPSearch = new DateTimePicker();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProject).BeginInit();
            SuspendLayout();
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(21, 67);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(253, 28);
            cbSearch.TabIndex = 25;
            cbSearch.Text = "Chọn mục muốn tìm kiếm";
            cbSearch.SelectedIndexChanged += cbSearch_SelectedIndexChanged_1;
            // 
            // btnFindAll
            // 
            btnFindAll.Cursor = Cursors.Hand;
            btnFindAll.Location = new Point(417, 22);
            btnFindAll.Name = "btnFindAll";
            btnFindAll.Size = new Size(94, 29);
            btnFindAll.TabIndex = 31;
            btnFindAll.Text = "Find All";
            btnFindAll.UseVisualStyleBackColor = true;
            btnFindAll.Click += btnFindAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(300, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 27;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDetail
            // 
            btnDetail.Cursor = Cursors.Hand;
            btnDetail.Location = new Point(797, 157);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(94, 29);
            btnDetail.TabIndex = 32;
            btnDetail.Text = "Detail";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // btnEndProject
            // 
            btnEndProject.Cursor = Cursors.Hand;
            btnEndProject.Location = new Point(107, 157);
            btnEndProject.Name = "btnEndProject";
            btnEndProject.Size = new Size(94, 29);
            btnEndProject.TabIndex = 33;
            btnEndProject.Text = "End";
            btnEndProject.UseVisualStyleBackColor = true;
            btnEndProject.Click += btnEndProject_Click;
            // 
            // btnActiveProject
            // 
            btnActiveProject.Cursor = Cursors.Hand;
            btnActiveProject.Location = new Point(7, 157);
            btnActiveProject.Name = "btnActiveProject";
            btnActiveProject.Size = new Size(94, 29);
            btnActiveProject.TabIndex = 34;
            btnActiveProject.Text = "Active";
            btnActiveProject.UseVisualStyleBackColor = true;
            btnActiveProject.Click += btnActiveProject_Click;
            // 
            // dgvProject
            // 
            dgvProject.AllowUserToAddRows = false;
            dgvProject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProject.Dock = DockStyle.Bottom;
            dgvProject.Location = new Point(0, 192);
            dgvProject.Name = "dgvProject";
            dgvProject.ReadOnly = true;
            dgvProject.RowHeadersWidth = 51;
            dgvProject.RowTemplate.Height = 29;
            dgvProject.Size = new Size(903, 517);
            dgvProject.TabIndex = 35;
            dgvProject.CellContentClick += dgvProject_CellContentClick;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Cursor = Cursors.Hand;
            btnExportExcel.Location = new Point(673, 157);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(118, 29);
            btnExportExcel.TabIndex = 36;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // DTPSearch
            // 
            DTPSearch.Location = new Point(21, 24);
            DTPSearch.Name = "DTPSearch";
            DTPSearch.Size = new Size(258, 27);
            DTPSearch.TabIndex = 37;
            DTPSearch.Visible = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(21, 23);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(258, 27);
            txtSearch.TabIndex = 38;
            // 
            // projectPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtSearch);
            Controls.Add(DTPSearch);
            Controls.Add(btnExportExcel);
            Controls.Add(dgvProject);
            Controls.Add(btnDetail);
            Controls.Add(btnEndProject);
            Controls.Add(btnActiveProject);
            Controls.Add(btnFindAll);
            Controls.Add(btnSearch);
            Controls.Add(cbSearch);
            Name = "projectPage";
            Size = new Size(903, 709);
            Load += projectPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbSearch;
        private Button btnFindAll;
        private Button btnSearch;
        private Button btnDetail;
        private Button btnEndProject;
        private Button btnActiveProject;
        private DataGridView dgvProject;
        private Button btnExportExcel;
        private DateTimePicker DTPSearch;
        private TextBox txtSearch;
    }
}
