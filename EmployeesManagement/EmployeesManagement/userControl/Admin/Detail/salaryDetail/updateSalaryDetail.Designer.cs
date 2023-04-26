namespace EmployeesManagement.userControl.Detail.salaryDetail
{
    partial class updateSalaryDetail
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
            cbAllowance = new ComboBox();
            cbLevel = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnComfirm = new Button();
            SuspendLayout();
            // 
            // cbAllowance
            // 
            cbAllowance.FormattingEnabled = true;
            cbAllowance.Location = new Point(125, 302);
            cbAllowance.Name = "cbAllowance";
            cbAllowance.Size = new Size(207, 28);
            cbAllowance.TabIndex = 37;
            cbAllowance.Text = "Chọn mức trợ cấp";
            // 
            // cbLevel
            // 
            cbLevel.FormattingEnabled = true;
            cbLevel.Location = new Point(125, 171);
            cbLevel.Name = "cbLevel";
            cbLevel.Size = new Size(207, 28);
            cbLevel.TabIndex = 36;
            cbLevel.Text = "Chọn chức vụ";
            // 
            // label1
            // 
            label1.BackColor = Color.Teal;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(405, 55);
            label1.TabIndex = 32;
            label1.Text = "Update Salary";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 310);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 35;
            label3.Text = "Allowance:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 173);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 34;
            label2.Text = "Level:";
            // 
            // btnComfirm
            // 
            btnComfirm.Cursor = Cursors.Hand;
            btnComfirm.Location = new Point(138, 444);
            btnComfirm.Name = "btnComfirm";
            btnComfirm.Size = new Size(94, 29);
            btnComfirm.TabIndex = 33;
            btnComfirm.Text = "Comfirm";
            btnComfirm.UseVisualStyleBackColor = true;
            btnComfirm.Click += btnComfirm_Click;
            // 
            // updateSalaryDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 486);
            Controls.Add(cbAllowance);
            Controls.Add(cbLevel);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnComfirm);
            Name = "updateSalaryDetail";
            Text = "updateSalaryDetail";
            Load += updateSalaryDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbAllowance;
        private ComboBox cbLevel;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button btnComfirm;
    }
}