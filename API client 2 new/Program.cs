Console.WriteLine("Press a key after service starts...!!!");
Console.ReadLine();

HttpClient client = new HttpClient();

var response1 = await client.GetAsync("https://localhost:7002/api/values/GetCustomerData");
Console.WriteLine(await response1.Content.ReadAsStringAsync());
Console.WriteLine();
Console.WriteLine("=======================================================================================");
Console.WriteLine();

var response2 = await client.GetAsync("https://localhost:7002/api/values/TotalOrders");
Console.WriteLine(await response2.Content.ReadAsStringAsync());

Console.WriteLine();
Console.WriteLine("=======================================================================================");
Console.WriteLine();

var response3 = await client.GetAsync("https://localhost:7002/api/values/CitiesWithMaxOrders");
Console.WriteLine(await response2.Content.ReadAsStringAsync());
