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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvProject = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 27);
            this.textBox1.TabIndex = 1;
            // 
            // dgvProject
            // 
            this.dgvProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProject.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProject.Location = new System.Drawing.Point(0, 163);
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.RowHeadersWidth = 51;
            this.dgvProject.RowTemplate.Height = 29;
            this.dgvProject.Size = new System.Drawing.Size(903, 546);
            this.dgvProject.TabIndex = 9;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(673, 21);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(94, 29);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // projectsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dgvProject);
            this.Controls.Add(this.textBox1);
            this.Name = "projectsPage";
            this.Size = new System.Drawing.Size(903, 709);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private DataGridView dgvProject;
        private Button addBtn;
    }
}
