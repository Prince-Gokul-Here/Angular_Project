using Microsoft.EntityFrameworkCore;
using First_Angular_API_Project.Models;
namespace First_Angular_API_Project.Models
{
    public class Product
    {
        public int id {  get; set; }
        public string? Name { get; set; }
        public decimal price { get; set; }
    }
}
