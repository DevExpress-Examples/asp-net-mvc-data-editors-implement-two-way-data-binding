<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128549380/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T328772)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Controllers/HomeController.vb))
* [CustomerInfo.cs](./CS/Models/CustomerInfo.cs) (VB: [CustomerInfo.vb](./VB/Models/CustomerInfo.vb))
* [ListsDataHelper.cs](./CS/Models/ListsDataHelper.cs) (VB: [ListsDataHelper.vb](./VB/Models/ListsDataHelper.vb))
* [Details.cshtml](./CS/Views/Home/Details.cshtml)
* [Editors.cshtml](./CS/Views/Home/Editors.cshtml)
* [FormLayout.cshtml](./CS/Views/Home/FormLayout.cshtml)
* [Index.cshtml](./CS/Views/Home/Index.cshtml)
<!-- default file list end -->
# Two-way model binding with single and multi-select editors or FormLayout
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t328772/)**
<!-- run online end -->


<p>This example illustrates two-way Model Binding for different editor types. Standalone editors are located in the Editors.cshtml view. In addition, we have the <a href="https://documentation.devexpress.com/#AspNet/CustomDocument16028">FormLayout</a> extension in the FormLayout.cshtml view. We use the simplest possible implementation for simplicity sake. For instance, in the case of standalone editors, we use <a href="https://documentation.devexpress.com/#AspNet/CustomDocument14602">Strongly-Typed Editor Types</a>. Since <a href="https://documentation.devexpress.com/#AspNet/CustomDocument14587">ComboBox</a> and <a href="https://documentation.devexpress.com/#AspNet/CustomDocument16298">TokenBox</a> list editors fully support Model Binding, we also use them in this example. Other list editors do not fully support Model Binding and you need to use the approach illustrated in the <a href="https://www.devexpress.com/Support/Center/p/E4125">E4125 - How to use the CheckBoxList and RadioButtonList editors to edit Model fields</a> code example if you wish to work with them.<br><br><strong>See Also:</strong><br><a href="https://www.devexpress.com/Support/Center/p/KA18701">KA18701 - MVC Data Editors - Model Binding and Editing</a> <br><a href="https://www.devexpress.com/Support/Center/p/T185980">T185980 - UploadControl with Model Binding Support - Registration Form</a> </p>

<br/>


