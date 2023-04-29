﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcepts.Shared
{
    public class Employee
  {
    public int EmployeeId { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "First name is too long.")]
    public string FirstName { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "Last name is too long.")]
    public string LastName { get; set; }

    public DateTime BirthDate { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }
    public int CountryId { get; set; }
    public Country Country { get; set; }
    public string PhoneNumber { get; set; }
    public bool Smoker { get; set; }
    public MaritalStatus MaritalStatus { get; set; }

    [StringLength(100, ErrorMessage = "Comment length can't exceed 1000 characters.")]
    public string Comment { get; set; }
    public DateTime? JoinedDate { get; set; }
    public DateTime? ExitDate { get; set; }

    public double Latitude { get; set; }
    public double Longitude { get; set; }
  }
}
