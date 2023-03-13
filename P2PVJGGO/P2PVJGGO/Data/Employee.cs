namespace P2PVJGGO.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public string Area { get; set; }
        public int EmployeeId { get; set; }
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public Employee(int id, string role, string area, int employeeId, string jobTitle, decimal salary, int cityId, City city)
        {
            Id = id;
            Role = role;
            Area = area;
            EmployeeId = employeeId;
            JobTitle = jobTitle;
            Salary = salary;
            CityId = cityId;
            City = city;
        }
    }

}
