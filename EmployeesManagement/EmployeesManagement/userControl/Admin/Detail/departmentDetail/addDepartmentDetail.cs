﻿using EmployeesManagement.Control;
using EmployeesManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagement.userControl.Detail.departmentDetail
{
    public partial class addDepartmentDetail : Form
    {
        departmentController departmentController = new departmentController();
        public addDepartmentDetail()
        {
            InitializeComponent();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length > 11)
            {
                txtPhone.Text = txtPhone.Text.Substring(0, 11);
                MessageBox.Show("Do not enter more than 11 numbers");
            }
        }
        private Boolean checkPhone(string phone){
            if (!phone.StartsWith("0") || phone.Length != 11 || !phone.All(char.IsDigit))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPhone.Text != "" && txtAddress.Text != "")
            {
                Boolean phone =  checkPhone(txtPhone.Text);
                if (!phone) {
                    MessageBox.Show("Phone numbers that start with 0 and receive 11 numbers");
                    return;
                }
                Department department = new Department(txtName.Text, txtPhone.Text, txtAddress.Text);
                if (departmentController.addDepartment(department))
                {
                    MessageBox.Show("Insert Success");

                    FormCollection allOpenedForm = Application.OpenForms;
                    foreach (Form form in allOpenedForm)
                    {
                        if (form.Name == "primary")
                        {
                            this.Close();
                            form.Close();
                            primary primaryPage = new primary();
                            primaryPage.Show();
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Insert Fail");
                }
            }
            else
            {
                MessageBox.Show("Please enter in full");
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}