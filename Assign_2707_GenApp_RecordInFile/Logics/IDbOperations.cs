using CS_Gen_App_RecordInFile.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gen_App_RecordInFile.Model
{
    /// <summary>
    /// The 'in' means input parameter 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TPk"></typeparam>
    public interface IDbOperations<TEntity, in TPk> where TEntity : Staff
    {
        List<TEntity> GetAll(); 
        TEntity Get(TPk id);
        TEntity Create(TEntity entity);
        TEntity Update(TPk id, TEntity entity);
        TEntity Delete(TPk id);


        //public abstract int GrossIncome(TEntity staff);

        //public abstract int Tax(TEntity staff);
        //public abstract int calculateNetIncome(TEntity staff);

        //public void getSalary(int id)
        //{
        //    foreach (var item in Doctor.drList)
        //    {
        //        if (item.StaffId == id)
        //        {
        //            Console.WriteLine("=================================================");
        //            Console.WriteLine($"Doctor name:{item.StaffName}");
        //            Console.WriteLine();
        //            Console.WriteLine($"Doctor id:{item.StaffId}");
        //            Console.WriteLine("=================================================");
        //            Console.WriteLine($"Gross income: {}");

        //        }
        //    }
        //}
    }
}