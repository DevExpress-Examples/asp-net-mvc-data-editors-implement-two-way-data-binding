using System;

public class CustomerInfo {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Notes { get; set; }
    public int Age { get; set; }
    public DateTime HireDate { get; set; }
    public decimal Salary { get; set; }
    public string PreferedColor { get; set; }
    public byte[] Photo { get; set; }
    public string[] Teams { get; set; }
    public string Location { get; set; }
    public bool IsActive { get; set; }
    public string PrimaryEmail { get; set; }
}