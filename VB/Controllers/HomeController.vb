Imports System.Web.Mvc

Namespace EditorsModelBinding.Controllers
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return View()
		End Function

		Public Function Editors() As ActionResult
			Return View(ListsDataHelper.GetSampleCustomer())
		End Function

		<HttpPost>
		Public Function Editors(ByVal model As CustomerInfo) As ActionResult
			Return View("Details", model)
		End Function

		Public Function FormLayout() As ActionResult
			Return View(ListsDataHelper.GetSampleCustomer())
		End Function

		<HttpPost>
		Public Function FormLayout(ByVal model As CustomerInfo) As ActionResult
			Return View("Details", model)
		End Function
	End Class
End Namespace