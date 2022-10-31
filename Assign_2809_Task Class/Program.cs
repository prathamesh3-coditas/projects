using EmployeeRecordsTask;

EmployeeCollection employees = new EmployeeCollection();
RecordLogics logic = new RecordLogics();


//Parallel.For(0, employees.Count, (i) =>
//{
//    //for (int i = 0; i < employees.Count; i++)
//    //{
//    employees[i].Tax = logic.TaxCalculations(employees[i].Salary);
//    Task t1 = Task.Factory.StartNew(() =>
//    {
//        logic.WriteMaster(employees[i]);
//    });
//    t1.Wait();
//    Task t2 = Task.Factory.StartNew(() =>
//    {
//        logic.createSlip(employees[i]);
//    });
//    t2.Wait();
//    //}
//});





for (int i = 0; i < employees.Count; i++)
{
    employees[i].Tax = logic.TaxCalculations(employees[i].Salary);

    await logic.WriteMaster(employees[i]);

    await logic.createSlip(employees[i]);
}



//Task t1 = Task.Factory.StartNew(() =>
//{
//	for (int i = 0; i < employees.Count; i++)
//	{
//		logic.WriteMaster(employees[i]);
//	}
//});
