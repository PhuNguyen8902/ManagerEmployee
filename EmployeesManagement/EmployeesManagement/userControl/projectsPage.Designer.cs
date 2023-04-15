namespace EmployeesManagement.userControl
{
    partial class projectsPage
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
            deleteBtn = new Button();
            dgvDepartment = new DataGridView();
            addBtn = new Button();
            updateBtn = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).BeginInit();
            SuspendLayout();
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(787, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 21;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // dgvDepartment
            // 
            dgvDepartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartment.Dock = DockStyle.Bottom;
            dgvDepartment.Location = new Point(0, 163);
            dgvDepartment.Name = "dgvDepartment";
            dgvDepartment.RowHeadersWidth = 51;
            dgvDepartment.RowTemplate.Height = 29;
            dgvDepartment.Size = new Size(903, 546);
            dgvDepartment.TabIndex = 20;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(567, 6);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 19;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(677, 6);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 18;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(298, 6);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 17;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 27);
            textBox1.TabIndex = 16;
            // 
            // projectsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(deleteBtn);
            Controls.Add(dgvDepartment);
            Controls.Add(addBtn);
            Controls.Add(updateBtn);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "projectsPage";
            Size = new Size(903, 709);
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteBtn;
        private DataGridView dgvDepartment;
        private Button addBtn;
        private Button updateBtn;
        private Button button1;
        private TextBox textBox1;
    }
}
