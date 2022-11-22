using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

Console.WriteLine("COnsume The REST API");
Console.WriteLine("Press a Key when Service Starts");
Console.ReadLine();
HttpClient client = new HttpClient();

var cats = await client.GetFromJsonAsync<List<Catagory>>("https://localhost:7183/api/Catagory");

foreach (var item in cats)
{
    Console.WriteLine($"{item.CatagoryId} {item.CatagoryName} {item.BasePrice}");
}

Console.WriteLine("POSTA");
var catNew = new Catagory()
{
    CatagoryId = 112,
    CatagoryName = "foods",
    BasePrice = 4444
};
var response = await client.PostAsJsonAsync<Catagory>("https://localhost:7183/api/Catagory", catNew);
// resonse.Content, will return HttpContext Object
// response.Content.ReadAsStringAsync(), will provde actual Details in Response Message
Console.WriteLine(await response.Content.ReadAsStringAsync());

var response1 = await client.PutAsJsonAsync<Catagory>($"https://localhost:7183/api/Catagory/{catNew.CatagoryId}", catNew);

var response2 = await client.DeleteAsync($"https://localhost:7183/api/Catagory/{catNew.CatagoryId}");


Console.ReadLine();

public partial class Catagory
{
    //public Catagory()
    //{
    //    Products = new HashSet<Product>();
    //}
    public int CatagoryId { get; set; }
    public string CatagoryName { get; set; } = null!;
    public decimal BasePrice { get; set; }
    //public virtual ICollection<Product> Products { get; set; }
}

public partial class Product
{
    public int ProductUniqueId { get; set; }
    public string ProductId { get; set; } = null!;
    public string ProductName { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
    public int CatagoryId { get; set; }
    public string Manufacturer { get; set; } = null!;

    //public virtual Catagory Catagory { get; set; } = null!;
}