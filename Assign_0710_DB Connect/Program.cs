using Assign_0710_DB_Connect.Data_Access;
using Assign_0710_DB_Connect.Models;
using System.Reflection.PortableExecutable;

class Caller
{

    static void PrintDataCatagory(IEnumerable<Catagory> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(@$"Catagory ID:{item.CatagoryId}   
Catagory Name:{item.CatagoryName}           
Base Price:{item.BasePrice}");
            Console.WriteLine("---------------------------------------");

        }
    }

    static void PrintDataProducts(IEnumerable<Product> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(@$"Product ID:{item.ProductId}   
Product Name:{item.ProductName}           
Description:{item.Description}
Price:{item.Price}
Manufacturer Id:{item.ManufacturerId}");
            Console.WriteLine("---------------------------------------");

        }
    }


    static void PrintSearchedProduct(Product product)
    {
        Console.WriteLine($"Product Id: {product.ProductId}");
        Console.WriteLine($"Product Name: {product.ProductName}");
        Console.WriteLine($"Catagory Id: {product.CatagoryId}");

    }
    static void Main(string[] args)
    {
        IDbAccess<Catagory, int> catAccess = new CatagoryAccess();
        IDbAccess<Product, int> proAccess = new ProductAccess();


        //Catagory obj = new Catagory()
        //{
        //    CatagoryId = 111,
        //    CatagoryName = "Finance",
        //    BasePrice = 9999
        //};
        //catAccess.Create(obj);


        //var res = catAccess.GetAllRecords();

        //catAccess.Delete(obj);
        //catAccess.Update(obj);
        //PrintDataCatagory(res);
        var res1 = proAccess.GetAllRecords();
        PrintDataProducts(res1);

        Product obj2 = new Product()
        {
            //ProductId = 68,
            ProductName = "Extra large bag",
            Description = "new Quality",
            Price = 9999,
            CatagoryId = 110,
            ManufacturerId = 210,
            SubCatagoryId = 1030
        };
        ////proAccess.Create(obj2);

        //proAccess.Delete(obj2);

        //ProductAccess productAccess = new ProductAccess();

        //Product prod = productAccess.SearchProduct("Food");
        //PrintSearchedProduct(prod);
    }
}