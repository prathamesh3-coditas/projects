using Assign_1010_Insert_Operation_with_Validations;

EmployeeOperations operations = new EmployeeOperations();
Employee employee = new Employee()
{
    EmpNo = 2000,
    EmpName = "xyz",
    Designation = "lead",
    Salary = 590000,
    DeptNo = 30
};
operations.InsertWithValidations(employee);