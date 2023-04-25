namespace EmployeesManagement.userControl.Admin.Detail.emailDetail
{
    partial class sendMailEmployeeDetail
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
            cbSearchPosition = new ComboBox();
            cbSearchGender = new ComboBox();
            dgvEmployee = new DataGridView();
            btnSearch = new Button();
            tbSearch = new TextBox();
            cbSearch = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // btnFindAll
            // 
            btnFindAll.Location = new Point(411, 12);
            btnFindAll.Name = "btnFindAll";
            btnFindAll.Size = new Size(94, 29);
            btnFindAll.TabIndex = 33;
            btnFindAll.Text = "Find All";
            btnFindAll.UseVisualStyleBackColor = true;
            btnFindAll.Click += btnFindAll_Click;
            // 
            // cbSearchPosition
            // 
            cbSearchPosition.FormattingEnabled = true;
            cbSearchPosition.Location = new Point(22, 10);
            cbSearchPosition.Name = "cbSearchPosition";
            cbSearchPosition.Size = new Size(258, 28);
            cbSearchPosition.TabIndex = 32;
            cbSearchPosition.Text = "Select the position";
            cbSearchPosition.Visible = false;
            // 
            // cbSearchGender
            // 
            cbSearchGender.FormattingEnabled = true;
            cbSearchGender.Location = new Point(22, 10);
            cbSearchGender.Name = "cbSearchGender";
            cbSearchGender.Size = new Size(258, 28);
            cbSearchGender.TabIndex = 31;
            cbSearchGender.Text = "Select the geder";
            cbSearchGender.Visible = false;
            // 
            // dgvEmployee
            // 
            dgvEmployee.AllowUserToAddRows = false;
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Dock = DockStyle.Bottom;
            dgvEmployee.Location = new Point(0, 157);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.ReadOnly = true;
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.RowTemplate.Height = 29;
            dgvEmployee.Size = new Size(885, 505);
            dgvEmployee.TabIndex = 30;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(298, 11);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 29;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(22, 11);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(258, 27);
            tbSearch.TabIndex = 28;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(22, 46);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(258, 28);
            cbSearch.TabIndex = 34;
            cbSearch.Text = "Select the item you want to search";
            cbSearch.SelectedIndexChanged += cbSearch_SelectedIndexChanged;
            // 
            // sendMailEmployeeDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 662);
            Controls.Add(cbSearch);
            Controls.Add(btnFindAll);
            Controls.Add(cbSearchPosition);
            Controls.Add(cbSearchGender);
            Controls.Add(dgvEmployee);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Name = "sendMailEmployeeDetail";
            Text = "sendMailEmployeeDetail";
            Load += sendMailEmployeeDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFindAll;
        private ComboBox cbSearchPosition;
        private ComboBox cbSearchGender;
        private DataGridView dgvEmployee;
        private Button btnSearch;
        private TextBox tbSearch;
        private ComboBox cbSearch;
    }
}