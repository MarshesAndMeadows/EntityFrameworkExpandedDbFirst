﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatabaseFirstScaffolding.Models;

public partial class Address
{
    public int AddressId { get; set; }

    public string AddressLine { get; set; }

    public int? PostalCode { get; set; }

    public int? EmployeeId { get; set; }

    public virtual Employee Employee { get; set; }

    public virtual City PostalCodeNavigation { get; set; }
}