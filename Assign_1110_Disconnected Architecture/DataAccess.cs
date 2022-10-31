using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1110_Disconnected_Architecture
{
    internal class DataAccess
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet ds;

        public DataAccess()
        {
            conn = new SqlConnection("Data Source=PLONDHE-LAP-072\\MSSQLSERVER01;Initial catalog=EmployeeBase;Integrated Security=SSPI");
            ds=new DataSet();
            GetData();
        }

        private void GetData()
        {
            adapter = new SqlDataAdapter("select * from Department",conn);

            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            adapter.Fill(ds, "Department");


            adapter = new SqlDataAdapter("select * from Employee", conn);

            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            adapter.Fill(ds, "Employee");

        }

        public void AddEntry()
        {
            DataRow dr = ds.Tables["Department"].NewRow();

            dr[0] = 60;
            dr[1] = "New Dept";
            dr[2] = "Delhi";
            dr[3] = 450;


            //dr["DeptNo"] = 60;
            //dr["DeptName"] = "New Dept";
            //dr["Location"] = "Delhi";
            //dr["Capacity"] = 450;

            ds.Tables["Department"].Rows.Add(dr);

            //This command builder object is internally used to generate an insert command inorder to insert
            //updated data in Database.s
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            adapter.Update(ds,"Department");
        }

        DataRow dr;
        public void Search(int deptNumber)
        {
            dr = ds.Tables["Department"].Rows.Find(deptNumber);
            Console.WriteLine($"ID:{dr["DeptNo"]}   Name:{dr["DeptName"]}");
        }

        public void Delete(int deptId)
        {
            dr = ds.Tables["Department"].Rows.Find(deptId);
            dr.Delete();

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(ds, "Department");
        }

        public void Update(int deptId)
        {
            dr = ds.Tables["Department"].Rows.Find(deptId);

            dr[1] = "Updated Department";
            dr[2] = "Chennai";
            dr[3] = 150;


            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(ds, "Department");

        }

        public void DataRelationObj()
        {
            DataRelation relation = new DataRelation("Dept-Employee-Relation", 
                ds.Tables["Department"].Columns["DeptNo"], 
                ds.Tables["Employee"].Columns["DeptNo"]);

            ds.Relations.Add(relation);

            foreach (DataRow dept in ds.Tables["Department"].Rows)
            {
                Console.WriteLine(dept.ItemArray[1]);
                DataRow[] records= dept.GetChildRows(relation);
                foreach (var item in records)
                {
                    Console.WriteLine($"{item.ItemArray[0]}     {item.ItemArray[1]}");
                }
            }
        }

        

    }
}
