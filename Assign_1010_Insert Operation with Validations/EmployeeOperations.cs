using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1010_Insert_Operation_with_Validations
{

    public class EmployeeOperations
    {
        SqlConnection conn = null;
        SqlCommand cmd;
        public EmployeeOperations()
        {
            conn = new SqlConnection("Data Source=PLONDHE-LAP-072\\MSSQLSERVER01;Initial Catalog=eShoppingCodi;Integrated Security=SSPI");
        }

        public void InsertWithValidations(Employee emp)
        {
            conn.Open();

            cmd = conn.CreateCommand();

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select DeptNo from Employee";
            SqlDataReader sdr = cmd.ExecuteReader();

            List<Employee> list = new List<Employee>(); 
            while (sdr.Read())
            {
                if (Convert.ToInt32(sdr["DeptNo"]) ==emp.DeptNo)
                {

                }
            }

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_InsertEmpWithValidations";

            SqlParameter pEmpNo = new SqlParameter();
            pEmpNo.ParameterName = "@empNo";
            pEmpNo.DbType = System.Data.DbType.Int32;
            pEmpNo.Direction = System.Data.ParameterDirection.Input;
            pEmpNo.Value = emp.EmpNo;
            cmd.Parameters.Add(pEmpNo);

            SqlParameter pEmpName = new SqlParameter();
            pEmpName.ParameterName = "@empName";
            pEmpName.DbType = System.Data.DbType.String;
            pEmpName.Direction = System.Data.ParameterDirection.Input;
            pEmpName.Value = emp.EmpName;
            cmd.Parameters.Add(pEmpName);


            SqlParameter pDesignation = new SqlParameter();
            pDesignation.ParameterName = "@Destination";
            pDesignation.DbType = System.Data.DbType.String;
            pDesignation.Direction = System.Data.ParameterDirection.Input;
            pDesignation.Value = emp.Designation;
            cmd.Parameters.Add(pDesignation);

            SqlParameter pSalary = new SqlParameter();
            pSalary.ParameterName = "@Salary";
            pSalary.DbType = System.Data.DbType.Int32;
            pSalary.Direction = System.Data.ParameterDirection.Input;
            pSalary.Value = emp.Salary;
            cmd.Parameters.Add(pSalary);


            SqlParameter pDeptNo = new SqlParameter();
            pDeptNo.ParameterName = "@DeptNo";
            pDeptNo .DbType = System.Data.DbType.Int32;
            pDeptNo .Direction = System.Data.ParameterDirection.Input;
            pDeptNo .Value = emp.DeptNo;
            cmd.Parameters.Add(pDeptNo);
        }
    }
}
