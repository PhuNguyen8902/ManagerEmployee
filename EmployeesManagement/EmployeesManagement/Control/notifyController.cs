using EmployeesManagement.Models;
using EmployeesManagement.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagement.Control
{
    internal class notifyController
    {
        private NotifyService notifyService = new NotifyService();
        public void addNotify(int emid, string value) {
             notifyService.addNotify(emid, value);
        }
        public int countNotify(int emid) {
            return notifyService.countNotify(emid);
        }
        public List<Notify> getNotify(int emid) {
            return notifyService.getNotify(emid);
        }
        public bool deleteNotify(int emid){
            return notifyService.deleteNotify(emid);
        }
        public void checkAndDeleteNotify(int emid) { 
            notifyService.checkAndDeleteNotify(emid);
        }
    }
}
