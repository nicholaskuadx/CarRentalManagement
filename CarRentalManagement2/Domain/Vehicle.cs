namespace CarRentalManagement2.Domain
{
    public class Vehicle :BaseDomainModel
    {
        public int Year { get; set; }
        public string? LicensePlateNumber { get; set; }
        public int MakeID { get; set; }
        public int ModelID { get; set; }
        public int ColourID { get; set; }
    }
}
