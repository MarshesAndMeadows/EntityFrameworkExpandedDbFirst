﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatabaseFirstScaffolding.Models;

public partial class PhoneNumber
{
    public int PhoneNumberId { get; set; }

    public int? EmployeeId { get; set; }

    public int? PhoneNumber1 { get; set; }

    public virtual Employee Employee { get; set; }
}