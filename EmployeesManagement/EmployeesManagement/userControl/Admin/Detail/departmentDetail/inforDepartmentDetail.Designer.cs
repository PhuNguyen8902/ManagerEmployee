namespace EmployeesManagement.userControl.Admin.Detail.departmentDetail
{
    partial class inforDepartmentDetail
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
            cbSearchPosition = new ComboBox();
            cbSearch = new ComboBox();
            btnFindAll = new Button();
            btnSearch = new Button();
            dgvDepartmentDetail = new DataGridView();
            tbSearch = new TextBox();
            cbSearchGender = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDepartmentDetail).BeginInit();
            SuspendLayout();
            // 
            // cbSearchPosition
            // 
            cbSearchPosition.FormattingEnabled = true;
            cbSearchPosition.Location = new Point(18, 8);
            cbSearchPosition.Name = "cbSearchPosition";
            cbSearchPosition.Size = new Size(258, 28);
            cbSearchPosition.TabIndex = 41;
            cbSearchPosition.Text = "Select position";
            cbSearchPosition.Visible = false;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(18, 45);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(258, 28);
            cbSearch.TabIndex = 40;
            cbSearch.Text = "Select the item you want to search";
            cbSearch.SelectedIndexChanged += cbSearch_SelectedIndexChanged;
            // 
            // btnFindAll
            // 
            btnFindAll.Cursor = Cursors.Hand;
            btnFindAll.Location = new Point(412, 7);
            btnFindAll.Name = "btnFindAll";
            btnFindAll.Size = new Size(94, 29);
            btnFindAll.TabIndex = 39;
            btnFindAll.Text = "Find All";
            btnFindAll.UseVisualStyleBackColor = true;
            btnFindAll.Click += btnFindAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(294, 7);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 38;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvDepartmentDetail
            // 
            dgvDepartmentDetail.AllowUserToAddRows = false;
            dgvDepartmentDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartmentDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartmentDetail.Dock = DockStyle.Bottom;
            dgvDepartmentDetail.Location = new Point(0, 164);
            dgvDepartmentDetail.Name = "dgvDepartmentDetail";
            dgvDepartmentDetail.ReadOnly = true;
            dgvDepartmentDetail.RowHeadersWidth = 51;
            dgvDepartmentDetail.RowTemplate.Height = 29;
            dgvDepartmentDetail.Size = new Size(800, 286);
            dgvDepartmentDetail.TabIndex = 37;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(18, 7);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(258, 27);
            tbSearch.TabIndex = 42;
            // 
            // cbSearchGender
            // 
            cbSearchGender.FormattingEnabled = true;
            cbSearchGender.Location = new Point(18, 7);
            cbSearchGender.Name = "cbSearchGender";
            cbSearchGender.Size = new Size(258, 28);
            cbSearchGender.TabIndex = 43;
            cbSearchGender.Text = "Select gender";
            cbSearchGender.Visible = false;
            // 
            // inforDepartmentDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbSearchGender);
            Controls.Add(tbSearch);
            Controls.Add(cbSearchPosition);
            Controls.Add(cbSearch);
            Controls.Add(btnFindAll);
            Controls.Add(btnSearch);
            Controls.Add(dgvDepartmentDetail);
            Name = "inforDepartmentDetail";
            Text = "inforDepartmentDetail";
            Load += inforDepartmentDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepartmentDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSearchPosition;
        private ComboBox cbSearch;
        private Button btnFindAll;
        private Button btnSearch;
        private DataGridView dgvDepartmentDetail;
        private TextBox tbSearch;
        private ComboBox cbSearchGender;
    }
}