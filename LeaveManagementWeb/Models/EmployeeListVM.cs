﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagementWeb.Models
{
    public class EmployeeListVM
    {
        public string Id { get; set; }
        [Display(Name ="First Name")]
        public string Firstname { get; set; }
        [Display(Name ="Last Name")]
        public string Lastname { get; set; }
        [Display(Name ="Date Joined")]
        public DateTime DateJoined { get; set; }
        [Display(Name ="Email Adress")]
        public string Email { get; set; }
    }
}
