using System.ComponentModel.DataAnnotations;

namespace Employee.Models
{
    public class Emp
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string city { get; set; }
        public string mobile { get; set; }
        public int salary { get; set; }
        public int departmentId { get; set; }
       
    }
}
