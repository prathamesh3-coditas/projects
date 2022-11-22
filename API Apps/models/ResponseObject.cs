namespace API_Apps.models
{
    public class ResponseObject
    {
        public List<Catagory>? Categories { get; set; }
        public List<Product>? Products { get; set; }
        public Catagory? Catagory { get; set; }
        public Product? Product { get; set; }
        public int? StatusCode { get; set; }
        public string? Message { get; set; }
    }
}
