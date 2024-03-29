﻿using System;
using System.Collections.Generic;

namespace EmployeesManagement.Models
{
   
        public class Account
        {
            public int Id { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }
            public string Type { get; set; }
            public int EmployeeId { get; set; }
            public Employee Employee { get; set; }
            public PassApp PassApp { get; set; }
        }
    }
