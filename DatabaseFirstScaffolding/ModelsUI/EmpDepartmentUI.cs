﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatabaseFirstScaffolding.Models;

public partial class EmpDepartmentUI
{
    public int? EmployeeId { get; set; }

    public int? DepartmentId { get; set; }

    public virtual DepartmentUI Department { get; set; }

    public virtual EmployeeUI Employee { get; set; }
}