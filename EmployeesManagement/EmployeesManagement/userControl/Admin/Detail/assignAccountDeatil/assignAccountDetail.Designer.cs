namespace EmployeesManagement.userControl.Admin.Detail.assignAccountDeatil
{
    partial class assignAccountDetail

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
            dgvAssignAccount = new DataGridView();
            btnFindAll = new Button();
            btnSearch = new Button();
            tbSearch = new TextBox();
            cbSearch = new ComboBox();
            cbSearchPosition = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvAssignAccount).BeginInit();
            SuspendLayout();
            // 
            // dgvAssignAccount
            // 
            dgvAssignAccount.AllowUserToAddRows = false;
            dgvAssignAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssignAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssignAccount.Dock = DockStyle.Bottom;
            dgvAssignAccount.Location = new Point(0, 164);
            dgvAssignAccount.Name = "dgvAssignAccount";
            dgvAssignAccount.ReadOnly = true;
            dgvAssignAccount.RowHeadersWidth = 51;
            dgvAssignAccount.RowTemplate.Height = 29;
            dgvAssignAccount.Size = new Size(800, 286);
            dgvAssignAccount.TabIndex = 30;
            dgvAssignAccount.CellContentClick += dgvAssignAccount_CellContentClick;
            // 
            // btnFindAll
            // 
            btnFindAll.Cursor = Cursors.Hand;
            btnFindAll.Location = new Point(412, 12);
            btnFindAll.Name = "btnFindAll";
            btnFindAll.Size = new Size(94, 29);
            btnFindAll.TabIndex = 34;
            btnFindAll.Text = "Find All";
            btnFindAll.UseVisualStyleBackColor = true;
            btnFindAll.Click += btnFindAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(294, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 33;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(18, 12);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(258, 27);
            tbSearch.TabIndex = 32;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(18, 50);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(258, 28);
            cbSearch.TabIndex = 35;
            cbSearch.Text = "Select the item you want to search";
            cbSearch.SelectedIndexChanged += cbSearch_SelectedIndexChanged;
            // 
            // cbSearchPosition
            // 
            cbSearchPosition.FormattingEnabled = true;
            cbSearchPosition.Location = new Point(18, 11);
            cbSearchPosition.Name = "cbSearchPosition";
            cbSearchPosition.Size = new Size(258, 28);
            cbSearchPosition.TabIndex = 36;
            cbSearchPosition.Text = "Select position";
            cbSearchPosition.Visible = false;
            // 
            // assignAccountDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbSearchPosition);
            Controls.Add(cbSearch);
            Controls.Add(btnFindAll);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(dgvAssignAccount);
            Name = "assignAccountDetail";
            Text = "assignAccount";
            Load += assignAccountDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAssignAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAssignAccount;
        private Button btnFindAll;
        private Button btnSearch;
        private TextBox tbSearch;
        private ComboBox cbSearch;
        private ComboBox cbSearchPosition;
    }
}