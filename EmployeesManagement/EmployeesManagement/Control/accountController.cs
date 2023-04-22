using EmployeesManagement.Models;
using EmployeesManagement.Service;
using System;
using System.Collections.Generic;
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

        public Boolean checkEmailDuplicate(string email)
        {
            return accountService.checkEmailDuplicate(email);
        }

        public Account getAccountOfEmployee(int emid)
        {
            return accountService.getAccountOfEmployee(emid);
        }
        public Boolean checkUserNameDuplicate(string user_name) {
            return accountService.checkUserNameDuplicate(user_name);
        }

        public Boolean createAccount(Account a) {
            return accountService.createAccount(a);
        }
        public string hashPassword(string password) {
            return accountService.hashPassword(password);
        }

        public bool verifyPassword(string password, string storedHash){
            return accountService.verifyPassword(password, storedHash);
        }
    }
}
