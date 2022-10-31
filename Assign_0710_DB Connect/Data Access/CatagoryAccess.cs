using Assign_0710_DB_Connect.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_0710_DB_Connect.Data_Access
{
    public class CatagoryAccess : IDbAccess<Catagory, int>
    {
        SqlConnection conn;
        SqlCommand cmd;

        public CatagoryAccess()
        {
            conn = new SqlConnection("Data Source=PLONDHE-LAP-072\\MSSQLSERVER01;Initial Catalog=eShoppingCodi;Integrated Security=SSPI");
        }

        IEnumerable<Catagory> IDbAccess<Catagory, int>.GetAllRecords()
        {
            List<Catagory> list = new List<Catagory>();

            try
            {
                conn.Open();
                cmd = conn.CreateCommand();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from catagory";

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    list.Add(new Catagory()
                    {
                        CatagoryId = Convert.ToInt32(sdr["CatagoryId"]),
                        CatagoryName = sdr["CatagoryName"].ToString(),
                        BasePrice = Convert.ToInt32(sdr["BasePrice"])
                    }); ;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
            finally
            {
                conn.Close();
            }


            return list;
        }

        Catagory IDbAccess<Catagory, int>.Create(Catagory cat)
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Insert into catagory values(@CatagoryId,@CatagoryName,@BasePrice)";

                cmd.Parameters.AddWithValue("@CatagoryId", cat.CatagoryId);
                cmd.Parameters.AddWithValue("@CatagoryName", cat.CatagoryName);
                cmd.Parameters.AddWithValue("@BasePrice", cat.BasePrice);

                int res = cmd.ExecuteNonQuery();

                if (res == 0)
                    throw new Exception("No record inserted");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
            finally
            {
                conn.Close();
            }


            return cat;
        }

        Catagory IDbAccess<Catagory, int>.Update(Catagory cat)
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "update Catagory set CatagoryName=@CatagoryName,BasePrice=@BasePrice where CatagoryId=@CatagoryId";

                cmd.Parameters.AddWithValue("@CatagoryId", cat.CatagoryId);
                cmd.Parameters.AddWithValue("@CatagoryName", cat.CatagoryName);
                cmd.Parameters.AddWithValue("@BasePrice", cat.BasePrice);

                int res = cmd.ExecuteNonQuery();

                if (res == 0)
                {
                    throw new Exception("Record not updated");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return cat;
        }


        bool IDbAccess<Catagory, int>.Delete(Catagory cat)
        {
            bool isSuccess = false;
            try
            {

                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Delete Catagory where CatagoryId=@CatagoryId";

                cmd.Parameters.AddWithValue("@CatagoryId", cat.CatagoryId);

                int res = cmd.ExecuteNonQuery();

                if (res == 0)
                {
                    throw new Exception("Record deletion failed....!!!");
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }


}
