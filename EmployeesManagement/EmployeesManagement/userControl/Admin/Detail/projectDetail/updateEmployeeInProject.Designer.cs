namespace EmployeesManagement.userControl.Admin.Detail.projectDetail
{
    partial class updateEmployeeInProject
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
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnComfirm = new Button();
            DTPStart = new DateTimePicker();
            DTPEnd = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Teal;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(373, 55);
            label1.TabIndex = 35;
            label1.Text = "Update Employee";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 94);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 41;
            label4.Text = "Start_date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 153);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 43;
            label5.Text = "End_date:";
            // 
            // btnComfirm
            // 
            btnComfirm.Cursor = Cursors.Hand;
            btnComfirm.Location = new Point(127, 224);
            btnComfirm.Name = "btnComfirm";
            btnComfirm.Size = new Size(94, 29);
            btnComfirm.TabIndex = 44;
            btnComfirm.Text = "Comfirm";
            btnComfirm.UseVisualStyleBackColor = true;
            btnComfirm.Click += btnComfirm_Click;
            // 
            // DTPStart
            // 
            DTPStart.Format = DateTimePickerFormat.Custom;
            DTPStart.Location = new Point(118, 94);
            DTPStart.Name = "DTPStart";
            DTPStart.Size = new Size(205, 27);
            DTPStart.TabIndex = 45;
            // 
            // DTPEnd
            // 
            DTPEnd.Format = DateTimePickerFormat.Custom;
            DTPEnd.Location = new Point(118, 153);
            DTPEnd.Name = "DTPEnd";
            DTPEnd.Size = new Size(205, 27);
            DTPEnd.TabIndex = 46;
            // 
            // updateEmployeeInProject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 279);
            Controls.Add(DTPEnd);
            Controls.Add(DTPStart);
            Controls.Add(btnComfirm);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "updateEmployeeInProject";
            Text = "updateEmployeeInProject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label5;
        private Button btnComfirm;
        private DateTimePicker DTPStart;
        private DateTimePicker DTPEnd;
    }
}