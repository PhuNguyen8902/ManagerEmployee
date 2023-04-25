namespace EmployeesManagement.userControl.UserControlManager
{
    partial class employeePage
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
            textBox1 = new TextBox();
            button1 = new Button();
            deleteBtn = new Button();
            addBtn = new Button();
            updateBtn = new Button();
            btnExportExcel = new Button();
            dgvEmployee = new DataGridView();
            btnDetail = new Button();
            btnEmail = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(297, 19);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(793, 17);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(573, 19);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 11;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(683, 19);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 10;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(10, 120);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(120, 29);
            btnExportExcel.TabIndex = 10;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // dgvEmployee
            // 
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Dock = DockStyle.Bottom;
            dgvEmployee.Location = new Point(0, 163);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.ReadOnly = true;
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.RowTemplate.Height = 29;
            dgvEmployee.Size = new Size(903, 546);
            dgvEmployee.TabIndex = 13;
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(793, 128);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(94, 29);
            btnDetail.TabIndex = 14;
            btnDetail.Text = "Detail";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // btnEmail
            // 
            btnEmail.Location = new Point(174, 120);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(120, 29);
            btnEmail.TabIndex = 29;
            btnEmail.Text = "Send Email";
            btnEmail.UseVisualStyleBackColor = true;
            btnEmail.Click += btnEmail_Click;
            // 
            // employeePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnEmail);
            Controls.Add(btnDetail);
            Controls.Add(btnExportExcel);
            Controls.Add(dgvEmployee);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Controls.Add(updateBtn);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "employeePage";
            Size = new Size(903, 709);
            Load += employeePage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button deleteBtn;
        private Button addBtn;
        private Button updateBtn;
        private Button btnExportExcel;
        private DataGridView dgvEmployee;
        private Button btnDetail;
        private Button btnEmail;
    }
}
