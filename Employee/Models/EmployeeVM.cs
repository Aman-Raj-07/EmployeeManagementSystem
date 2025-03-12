namespace Employee.Models
{
    public class EmployeeVM
    {
        public List<Emp> EmpVM { get; set; }
        public List<department> departmentVM { get; set; }

    }
    public class EmplVM
    {
        public Emp EmpVm { get; set; }  
        public List<department> deptVM { get; set; }  
    }
}