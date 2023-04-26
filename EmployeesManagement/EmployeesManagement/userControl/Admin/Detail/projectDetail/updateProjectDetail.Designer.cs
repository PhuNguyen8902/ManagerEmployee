namespace EmployeesManagement.userControl.Detail.projectDetail
{
    partial class updateProjectDetail
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
            DTPEnd = new DateTimePicker();
            label5 = new Label();
            DTPStart = new DateTimePicker();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnComfirm = new Button();
            txtDescription = new TextBox();
            txtName = new TextBox();
            label6 = new Label();
            cbActive = new ComboBox();
            SuspendLayout();
            // 
            // DTPEnd
            // 
            DTPEnd.Format = DateTimePickerFormat.Custom;
            DTPEnd.Location = new Point(138, 293);
            DTPEnd.Name = "DTPEnd";
            DTPEnd.Size = new Size(205, 27);
            DTPEnd.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 300);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 42;
            label5.Text = "End_date:";
            // 
            // DTPStart
            // 
            DTPStart.Format = DateTimePickerFormat.Custom;
            DTPStart.Location = new Point(138, 221);
            DTPStart.Name = "DTPStart";
            DTPStart.Size = new Size(205, 27);
            DTPStart.TabIndex = 41;
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
            label1.TabIndex = 34;
            label1.Text = "Update Project";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 228);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 40;
            label4.Text = "Start_date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 162);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 39;
            label3.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 85);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 38;
            label2.Text = "Name:";
            // 
            // btnComfirm
            // 
            btnComfirm.Cursor = Cursors.Hand;
            btnComfirm.Location = new Point(138, 428);
            btnComfirm.Name = "btnComfirm";
            btnComfirm.Size = new Size(94, 29);
            btnComfirm.TabIndex = 37;
            btnComfirm.Text = "Comfirm";
            btnComfirm.UseVisualStyleBackColor = true;
            btnComfirm.Click += btnComfirm_Click;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.ForeColor = SystemColors.InfoText;
            txtDescription.Location = new Point(138, 148);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(205, 34);
            txtDescription.TabIndex = 36;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = SystemColors.InfoText;
            txtName.Location = new Point(138, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(205, 34);
            txtName.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 358);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 44;
            label6.Text = "Active:";
            // 
            // cbActive
            // 
            cbActive.FormattingEnabled = true;
            cbActive.Location = new Point(138, 359);
            cbActive.Name = "cbActive";
            cbActive.Size = new Size(205, 28);
            cbActive.TabIndex = 45;
            // 
            // updateProjectDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 486);
            Controls.Add(cbActive);
            Controls.Add(label6);
            Controls.Add(DTPEnd);
            Controls.Add(label5);
            Controls.Add(DTPStart);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnComfirm);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Name = "updateProjectDetail";
            Text = "updateProjectDetail";
            Load += updateProjectDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DTPEnd;
        private Label label5;
        private DateTimePicker DTPStart;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnComfirm;
        private TextBox txtDescription;
        private TextBox txtName;
        private Label label6;
        private ComboBox cbActive;
    }
}