using EmployeesManagement.Models;
using EmployeesManagement.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagement.Control
{
    public class accountController
    {
        AccountService accountService = new AccountService();

        public Boolean updateEmailEmployee(int id, string email)
        {
            return accountService.updateEmailEmployee(id, email);
        }
        public Boolean updateEmailEmployeeById(int id, string email) { 
            return accountService.updateEmailEmployeeById(id, email);
        }

        public Boolean checkEmailDuplicate(string email, int emid)
        {
            return accountService.checkEmailDuplicate(email, emid);
        }

        public Account getAccountOfEmployee(int emid)
        {
            return accountService.getAccountOfEmployee(emid);
        }
        public Boolean checkUserNameDuplicate(string user_name, int emid) {
            return accountService.checkUserNameDuplicate(user_name, emid);
        }

        public Boolean createAccount(Account a) {
            return accountService.createAccount(a);
        }
        public string hashPassword(string password) {
            return accountService.hashPassword(password);
        }

        public bool verifyPassword(string password, string storedHash) {
            return accountService.verifyPassword(password, storedHash);
        }

        public DataTable GetAccountData() {
            return accountService.GetAccountData();
        }

        public DataTable GetAccountNeedAssignData() {
            return accountService.GetAccountNeedAssignData();
        }
        public Boolean updateEmployeeIdForAccount(int accountId, int emId) {
            return accountService.updateEmployeeIdForAccount(accountId, emId);
        }

        public Boolean removeeEmployeeIdOutAccount(int accountId) {
            return accountService.removeEmployeeIdOutAccount(accountId);
        }

        public DataTable searchAccountDataByConditionId(string condition, int id) {
            return accountService.searchAccountDataByConditionId(condition, id);
        }

        public DataTable searchAccountNeedAssignDataByCondition(string condition, string value) {
            return accountService.searchAccountNeedAssignDataByCondition(condition, value);
        }
        public DataTable searchAccountDataByCondition(string condition, string id) {
            return accountService.searchAccountDataByCondition(condition, id);
        }
        public DataTable searchAccountNeedAssignDataByConditionId(string condition, int id) {
            return accountService.searchAccountNeedAssignDataByConditionId(condition, id);
        }
        public DataTable GetAccountDataOfEmpList(List<int> empList, int maId) {
            return accountService.GetAccountDataOfEmpList(empList, maId);
        }
        public DataTable GetAccountNeedAssignDataInManage() {
            return accountService.GetAccountNeedAssignDataInManage();
        }
        public DataTable searchAccountDataByConditionIdInManage(string condition, int id, int deId) {
            return accountService.searchAccountDataByConditionIdInManage(condition, id, deId);
        }
        public DataTable searchAccountDataByConditionInManage(string condition, string id, int deId) {
            return accountService.searchAccountDataByConditionInManage(condition, id, deId);
        }

        public Account findById(string condition, string value) {
            return accountService.findById(condition, value);
        }

        public Boolean insertPassApp(string value, int accId) {
            return accountService.insertPassApp(value, accId);
        }

        public PassApp getPassApp(int accId) {
            return accountService.getPassApp(accId);
        }
        public Boolean sendEmails(String fromEmail, String[] toEmails, String passApp, String body, String subject) {
            return accountService.sendEmails(fromEmail, toEmails, passApp, body, subject);
        }
        public List<string> getEmailsHaveEmployeeId() {
            return accountService.getEmailsHaveEmployeeId();
        }
        public bool SendEmailWithAttachment(string fromEmail, string[] toEmails, string passApp, string body, string subject, string attachmentFilePath) { 
            return accountService.SendEmailWithAttachment(fromEmail,toEmails, passApp, body,subject,attachmentFilePath);
        }
    }
}
