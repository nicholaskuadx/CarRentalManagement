namespace CarRentalManagement2.Domain
{
    public class Customer :BaseDomainModel
    {
        string? DriverLicenseNumber { get; set; }
        string? Address { get; set; }
        string? ContactNumber { get; set; }
        string? EmailAddress { get; set; }
    }
}
