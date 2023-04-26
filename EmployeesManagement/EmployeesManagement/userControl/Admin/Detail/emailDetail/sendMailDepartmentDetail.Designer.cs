namespace EmployeesManagement.userControl.Admin.Detail.emailDetail
{
    partial class sendMailDepartmentDetail
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
            btnFindAll = new Button();
            cbSearch = new ComboBox();
            dgvDepartment = new DataGridView();
            btnSearch = new Button();
            tbSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).BeginInit();
            SuspendLayout();
            // 
            // btnFindAll
            // 
            btnFindAll.Cursor = Cursors.Hand;
            btnFindAll.Location = new Point(416, 6);
            btnFindAll.Name = "btnFindAll";
            btnFindAll.Size = new Size(94, 29);
            btnFindAll.TabIndex = 31;
            btnFindAll.Text = "Find All";
            btnFindAll.UseVisualStyleBackColor = true;
            btnFindAll.Click += btnFindAll_Click;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(27, 45);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(253, 28);
            cbSearch.TabIndex = 30;
            cbSearch.Text = "Select the item want to search";
            cbSearch.SelectedIndexChanged += cbSearch_SelectedIndexChanged;
            // 
            // dgvDepartment
            // 
            dgvDepartment.AllowUserToAddRows = false;
            dgvDepartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartment.Dock = DockStyle.Bottom;
            dgvDepartment.Location = new Point(0, 166);
            dgvDepartment.Name = "dgvDepartment";
            dgvDepartment.ReadOnly = true;
            dgvDepartment.RowHeadersWidth = 51;
            dgvDepartment.RowTemplate.Height = 29;
            dgvDepartment.Size = new Size(885, 496);
            dgvDepartment.TabIndex = 29;
            dgvDepartment.CellContentClick += dgvDepartment_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(298, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 28;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(22, 7);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(258, 27);
            tbSearch.TabIndex = 27;
            // 
            // sendMailDepartmentDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 662);
            Controls.Add(btnFindAll);
            Controls.Add(cbSearch);
            Controls.Add(dgvDepartment);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Name = "sendMailDepartmentDetail";
            Text = "sendMailDepartmentDetail";
            Load += sendMailDepartmentDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFindAll;
        private ComboBox cbSearch;
        private DataGridView dgvDepartment;
        private Button btnSearch;
        private TextBox tbSearch;
    }
}