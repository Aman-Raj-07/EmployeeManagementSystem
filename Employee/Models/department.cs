using System.ComponentModel.DataAnnotations;

namespace Employee.Models
{
    public class department
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
