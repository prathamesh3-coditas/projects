// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Assign_0108_LINQ;

EmployeeCollection employee = new EmployeeCollection();
DepartmentsCollection departments = new DepartmentsCollection();

Console.WriteLine("=======================2nd Question=================================");

var maxSalary = (from emp in employee
                 join dept in departments on emp.DepartmentsNo equals dept.DepartmentsNo
                 group emp by dept.Departmentsname into groups
                 select new
                 {
                     deptName = groups.Key,
                     maxSal = groups.MaxBy(e => e.Salary),
                 });


foreach (var item in maxSalary)
{
    Console.WriteLine($"{item.maxSal.EmpName} has maximum salary from {item.deptName} " +
        $"which is {item.maxSal.Salary}");
}



Console.WriteLine("=======================3rd Question=================================");
//var salSum = from emp in employee
//             orderby emp.DepartmentsNo
//             group emp by emp.DepartmentsNo into groups
//             select new
//             {
//                 deptNo = groups.Key,
//                 sal = groups.Sum(v => v.Salary),

//             };


var salSum = from emp in employee
             join dept in departments on emp.DepartmentsNo equals dept.DepartmentsNo
             group emp by dept.Departmentsname into groups
             select new
             {
                 deptNo = groups.Key,
                 sal = groups.Sum(v => v.Salary)
             };

foreach (var item in salSum)
{
    Console.WriteLine($"Dept Name: {item.deptNo}\nSum of salary: {item.sal}");
    Console.WriteLine();
}




Console.WriteLine("=======================4th Question=================================");

var empDetails = from emp in employee
                 join dept in departments on emp.DepartmentsNo equals dept.DepartmentsNo
                 group emp by dept.Departmentsname;

foreach (var grpKey in empDetails)
{
    Console.WriteLine($"Employees of {grpKey.Key} are");
    foreach (var item in grpKey)
    {
        Console.WriteLine(item.EmpName);
    }
    Console.WriteLine();
}



Console.WriteLine("=======================5th Question=================================");
var empLocation = from emp in employee
                  join dept in departments on emp.DepartmentsNo equals dept.DepartmentsNo
                  group emp by dept.Location into grpLocation
                  select new
                  {
                      location = grpLocation.Key,
                      count = grpLocation.Count()
                  };

foreach (var item in empLocation)
{
    Console.WriteLine($"Location:{item.location}\nCount:{item.count}");
    Console.WriteLine("--------------------------------------------------------------");
}

var s = from p in employee where p.Salary > 20000 group p by p.DepartmentsNo;
Console.WriteLine(  );





Console.WriteLine("=======================6th Question=================================");
var empDetailsDept = from emp in employee
                     join dept in departments
                     on emp.DepartmentsNo equals dept.DepartmentsNo
                     group emp by dept.Location;


foreach (var emplocation in empDetailsDept)
{
    Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
    Console.WriteLine(emplocation.Key);
    Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");


    foreach (var detail in emplocation)
    {
        Console.WriteLine($"Employee name: {detail.EmpName}");
        Console.WriteLine($"Employee number: {detail.EmpNo}");
        Console.WriteLine($"Employee salary: {detail.Salary}");
        Console.WriteLine($"Employee designation: {detail.Designation}");
        Console.WriteLine("--------------------------------------------------------------");

    }
}

