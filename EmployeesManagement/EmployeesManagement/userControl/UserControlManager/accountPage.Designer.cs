namespace EmployeesManagement.userControl.UserControlManager
{
    partial class accountPage
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
            cbSearchPosition = new ComboBox();
            btnSearch2 = new Button();
            cbSearch = new ComboBox();
            removeBtn = new Button();
            assignBtn = new Button();
            btnFindAll = new Button();
            dgvAccount = new DataGridView();
            tbSearch = new TextBox();
            btnSearch1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            SuspendLayout();
            // 
            // cbSearchPosition
            // 
            cbSearchPosition.FormattingEnabled = true;
            cbSearchPosition.Location = new Point(31, 5);
            cbSearchPosition.Name = "cbSearchPosition";
            cbSearchPosition.Size = new Size(258, 28);
            cbSearchPosition.TabIndex = 47;
            cbSearchPosition.Text = "Select the item";
            cbSearchPosition.Visible = false;
            // 
            // btnSearch2
            // 
            btnSearch2.Location = new Point(307, 6);
            btnSearch2.Name = "btnSearch2";
            btnSearch2.Size = new Size(94, 29);
            btnSearch2.TabIndex = 46;
            btnSearch2.Text = "Search";
            btnSearch2.UseVisualStyleBackColor = true;
            btnSearch2.Visible = false;
            btnSearch2.Click += btnSearch2_Click;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(31, 44);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(258, 28);
            cbSearch.TabIndex = 45;
            cbSearch.Text = "Select the item you want to search";
            cbSearch.SelectedIndexChanged += cbSearch_SelectedIndexChanged;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(270, 110);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(169, 29);
            removeBtn.TabIndex = 44;
            removeBtn.Text = "Remove employee id";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // assignBtn
            // 
            assignBtn.Location = new Point(31, 110);
            assignBtn.Name = "assignBtn";
            assignBtn.Size = new Size(169, 29);
            assignBtn.TabIndex = 43;
            assignBtn.Text = "Assign employee id";
            assignBtn.UseVisualStyleBackColor = true;
            assignBtn.Click += assignBtn_Click;
            // 
            // btnFindAll
            // 
            btnFindAll.Location = new Point(421, 6);
            btnFindAll.Name = "btnFindAll";
            btnFindAll.Size = new Size(94, 29);
            btnFindAll.TabIndex = 42;
            btnFindAll.Text = "Find All";
            btnFindAll.UseVisualStyleBackColor = true;
            btnFindAll.Click += btnFindAll_Click;
            // 
            // dgvAccount
            // 
            dgvAccount.AllowUserToAddRows = false;
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Dock = DockStyle.Bottom;
            dgvAccount.Location = new Point(0, 163);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.ReadOnly = true;
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.RowTemplate.Height = 29;
            dgvAccount.Size = new Size(903, 546);
            dgvAccount.TabIndex = 41;
            dgvAccount.CellContentClick += dgvAccount_CellContentClick;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(31, 7);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(258, 27);
            tbSearch.TabIndex = 48;
            // 
            // btnSearch1
            // 
            btnSearch1.Location = new Point(307, 7);
            btnSearch1.Name = "btnSearch1";
            btnSearch1.Size = new Size(94, 29);
            btnSearch1.TabIndex = 49;
            btnSearch1.Text = "Search";
            btnSearch1.UseVisualStyleBackColor = true;
            btnSearch1.Click += btnSearch1_Click;
            // 
            // accountPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearch1);
            Controls.Add(tbSearch);
            Controls.Add(cbSearchPosition);
            Controls.Add(btnSearch2);
            Controls.Add(cbSearch);
            Controls.Add(removeBtn);
            Controls.Add(assignBtn);
            Controls.Add(btnFindAll);
            Controls.Add(dgvAccount);
            Name = "accountPage";
            Size = new Size(903, 709);
            Load += accountPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSearchPosition;
        private Button btnSearch2;
        private ComboBox cbSearch;
        private Button removeBtn;
        private Button assignBtn;
        private Button btnFindAll;
        private DataGridView dgvAccount;
        private TextBox tbSearch;
        private Button btnSearch1;
    }
}
