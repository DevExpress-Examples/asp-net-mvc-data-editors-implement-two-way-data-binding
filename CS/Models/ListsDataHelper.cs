using System;
using System.Drawing;

public static class ListsDataHelper {
    public static string[] GetTeams() {
        return new string[] { "R&D", "Support", "Management" };
    }

    public static string[] GetLocations() {
        return new string[] { "Home", "Office", "Unknown" };
    }

    public static CustomerInfo GetSampleCustomer() {
        return new CustomerInfo() {
            Id = 0,
            FirstName = "John",
            BirthDate = new DateTime(1980, 1, 1),
            Notes = "Some text...",
            Age = 30,
            HireDate = new DateTime(2000, 1, 1),
            Salary = 20,
            PreferedColor = "red",
            Photo = (byte[])new ImageConverter().ConvertTo(SystemIcons.Application.ToBitmap(), typeof(byte[])),
            Teams = new string[] { "R&D" },
            Location = "Office",
            IsActive = true,
            PrimaryEmail = "test@test.com"
        };
    }
}