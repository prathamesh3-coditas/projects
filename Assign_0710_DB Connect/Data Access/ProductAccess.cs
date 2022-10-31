using Assign_0710_DB_Connect.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Assign_0710_DB_Connect.Data_Access
{
    public class ProductAccess : IDbAccess<Product, int>
    {
        SqlConnection conn;
        SqlCommand cmd;
        public ProductAccess()
        {
            conn = new SqlConnection("Data Source=PLONDHE-LAP-072\\MSSQLSERVER01;Initial Catalog=eShoppingCodi;Integrated Security=SSPI");
        }
        IEnumerable<Product> IDbAccess<Product, int>.GetAllRecords()
        {
            List<Product> list = new List<Product>();

            try
            {
                conn.Open();
                //cmd = conn.CreateCommand();
                //cmd.CommandType = System.Data.CommandType.Text;
                //cmd.CommandText = "select * from Product";
                cmd = new SqlCommand("select * from Product", conn);

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    list.Add(new Product()
                    {
                        ProductId = Convert.ToInt32(sdr["ProductId"]),
                        ProductName = sdr["ProductName"].ToString(),
                        Description = sdr["Description"].ToString(),
                        Price = Convert.ToInt32(sdr["Price"]),
                        CatagoryId = Convert.ToInt32(sdr["catagoryId"]),
                        ManufacturerId = Convert.ToInt32(sdr["ManufacturerId"])
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return list;
        }

        Product IDbAccess<Product, int>.Create(Product product)
        {
            try
            {
                conn.Open();

                cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Insert into Product values(@ProductName,@Description,@Price,@CatagoryId,@ManufacturerId,@SubCatagoryId)";

                cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@Description", product.Description);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@catagoryId", product.CatagoryId);
                cmd.Parameters.AddWithValue("@ManufacturerId", product.ManufacturerId);
                cmd.Parameters.AddWithValue("@SubCatagoryId",product.SubCatagoryId);



                var res = cmd.ExecuteNonQuery();
                if (res == 0)
                {
                    throw new Exception("Entry not added..!!!");
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
            return product;


        }

       

        Product IDbAccess<Product, int>.Update(Product entity)
        {
            List<Product> list = new List<Product>();
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "update Product set ProductName=@ProductName,Description=@Description,Price=@Price,catagoryId=@catagoryId,ManufacturerId=@ManufacturerId,SubCatagoryId=@SubCatagoryId where ProductName=@ProductName";

                cmd.Parameters.AddWithValue("@ProductId", entity.ProductId);
                cmd.Parameters.AddWithValue("@ProductName", entity.ProductName);

                cmd.Parameters.AddWithValue("@Description", entity.Description);
                cmd.Parameters.AddWithValue("@Price", entity.Price);
                cmd.Parameters.AddWithValue("@catagoryId", entity.CatagoryId);
                cmd.Parameters.AddWithValue("@ManufacturerId", entity.ManufacturerId);
                cmd.Parameters.AddWithValue("@SubCatagoryId", entity.SubCatagoryId);

                int res = cmd.ExecuteNonQuery();

                if (res == 0)
                {
                    throw new Exception("Record updation failed...!!!");
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

            return entity;
        }


        bool IDbAccess<Product, int>.Delete(Product product)
        {
            bool isDeleted = true;

            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Delete from Product where ProductName=@ProductName";

                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);

                int res = cmd.ExecuteNonQuery();

                if (res == 0)
                {
                    throw new Exception("Record deletion failed...!!!");
                    isDeleted = false;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            return isDeleted;
        }

       public  Product SearchProduct(string catagory)
        {
            Product product = new Product();
            int id = 0;
            string name = string.Empty;
            int catagoryId = 0;

            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select Product.ProductName from Product join Catagory on Product.CatagoryId=Catagory.CatagoryId where Catagory.CatagoryName=@catagory";
                //cmd.CommandText = "select Product.ProductName from Product,Catagory where Product.CatagoryId=Catagory.CatagoryId and Catagory.CatagoryName=@catagory";
                //cmd.CommandText = "select Product.ProductName, Catagory.CatagoryName , Manufacturer.ManufacturerName from Product, Catagory, SubCatagory, Manufacturer where Product.SubCatagoryId = SubCatagory.SubCatagoryId and SubCatagory.CatagoryId = Catagory.CatagoryId and  Product.ManufacturerId = Manufacturer.ManufacturerId and (Manufacturer.ManufacturerName=@abc or Catagory.CatagoryName=@abc) group by Product.ProductName, Catagory.CatagoryName ,Manufacturer.ManufacturerName";
                cmd.Parameters.AddWithValue("@catagory", catagory);
                int res = cmd.ExecuteNonQuery();

                SqlDataReader data = cmd.ExecuteReader();

                while (data.Read())
                {
                    //if (data["Catagory.CatagoryName"].ToString().Equals(catagory))
                    //{
                        id = Convert.ToInt32(data["ProductId"]);
                        name = data["ProductName"].ToString();
                        catagoryId = Convert.ToInt32(data["Catagory"]);
                    //}
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            return product;
            
        }
    }
}
