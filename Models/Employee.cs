﻿using System.ComponentModel.DataAnnotations;
<<<<<<< Updated upstream
=======
using System.ComponentModel.DataAnnotations.Schema;
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
namespace EmployeeManagement
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "İsim 10 karakterden fazla olamaz")]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
        public string PhotoPath { get; set; }
    }
}
