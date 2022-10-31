using EmployeeRecordsParallel;

var collection = new EmployeeCollection();
RecordLogics logics = new RecordLogics();
int tax = 0;


Parallel.For(0, collection.Count, (i) =>
{
    collection[i].Tax = logics.TaxCalculations(collection[i].Salary);
    logics.ReadData(collection[i]);

});
