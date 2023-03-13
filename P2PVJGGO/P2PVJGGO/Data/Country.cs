using System.Collections.Generic;

namespace P2PVJGGO.Data
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CapitalCity { get; set; }
        public string Language { get; set; }
        public string Currency { get; set; }
        public int Population { get; set; }

        public ICollection<City> Cities { get; set; }

        public Country(int id, string name, string capitalCity, string language, string currency, int population)
        {
            Id = id;
            Name = name;
            CapitalCity = capitalCity;
            Language = language;
            Currency = currency;
            Population = population;
            Cities = new List<City>();
        }
    }


}
