namespace P2PVJGGO.Data
{
    public class Enterprise
    {
        #region Props

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string EnterpriseType { get; set; }
        public string Website { get; set; }
        public int NumberOfEmployees { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        #endregion

        #region Constructor
        public Enterprise(int id, string name, string description, string enterpriseType, string website, int numberofemployees)
        {
            Id = id;
            Name = name;
            Description = description;
            EnterpriseType = enterpriseType;
            Website = website;
            NumberOfEmployees = numberofemployees;
        }

        #endregion
    }
}
