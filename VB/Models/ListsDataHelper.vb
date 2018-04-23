Imports System
Imports System.Drawing

Public NotInheritable Class ListsDataHelper

	Private Sub New()
	End Sub

	Public Shared Function GetTeams() As String()
		Return New String() { "R&D", "Support", "Management" }
	End Function

	Public Shared Function GetLocations() As String()
		Return New String() { "Home", "Office", "Unknown" }
	End Function

	Public Shared Function GetSampleCustomer() As CustomerInfo
		Return New CustomerInfo() With {.Id = 0, .FirstName = "John", .BirthDate = New Date(1980, 1, 1), .Notes = "Some text...", .Age = 30, .HireDate = New Date(2000, 1, 1), .Salary = 20, .PreferedColor = "red", .Photo = CType((New ImageConverter()).ConvertTo(SystemIcons.Application.ToBitmap(), GetType(Byte())), Byte()), .Teams = New String() { "R&D" }, .Location = "Office", .IsActive = True, .PrimaryEmail = "test@test.com"}
	End Function
End Class