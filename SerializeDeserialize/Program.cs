using System;
using Newtonsoft.Json;

namespace SerializeDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create product Onject
            var ProductObj = new Product{Id=1,Name="Processor",Price=99.9};
            // Serialize the product object to JSON 
            var jsonString = JsonConvert.SerializeObject(ProductObj);
            System.Console.WriteLine(jsonString);

            // Deserialize the JSON string bact to Obj
            var ProductObjDeserialized = JsonConvert.DeserializeObject<Product>(jsonString);
            System.Console.WriteLine($"The product ID is {ProductObjDeserialized.Id}");
        }
    }

    // Create model class
    class Product{
        public int Id{get;set;}
        public string Name{get;set;}
        public double Price {get;set;}

    }
}
