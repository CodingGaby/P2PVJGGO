using System.Collections.Generic;

namespace P2PVJGGO.Data
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int Population { get; set; }
        public string Landmark { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public ICollection<Enterprise> Enterprises { get; set; }

        public City(int id, string name, string state, string zipCode, int population, string landmark, int countryId, Country country)
        {
            Id = id;
            Name = name;
            State = state;
            ZipCode = zipCode;
            Population = population;
            Landmark = landmark;
            CountryId = countryId;
            Country = country;
            Employees = new List<Employee>();
            Enterprises = new List<Enterprise>();
        }
    }
}