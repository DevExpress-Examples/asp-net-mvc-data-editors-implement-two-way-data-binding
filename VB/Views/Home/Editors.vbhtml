@ModelType CustomerInfo

<style type="text/css">
    label:after {
        content: ": "
    }
</style>

@Using (Html.BeginForm())
    
    @<table>
        <tr>
            <td style="width: 200px;">
                @Html.LabelFor(Function(m) m.FirstName)
            </td>
            <td>
                @Html.DevExpress().TextBoxFor(Function(m) m.FirstName).GetHtml()
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.BirthDate)
            </td>
            <td>
                @Html.DevExpress().DateEditFor(Function(m) m.BirthDate).GetHtml()
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.Notes)
            </td>
            <td>
                @Html.DevExpress().MemoFor(Function(m) m.Notes).GetHtml()
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.Age)
            </td>
            <td>
                @Html.DevExpress().SpinEditFor(Function(m) m.Age).GetHtml()
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.HireDate)
            </td>
            <td>
                @Html.DevExpress().CalendarFor(Function(m) m.HireDate).GetHtml()
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.Salary)
            </td>
            <td>
                @Html.DevExpress().TrackBarFor(Function(m) m.Salary).GetHtml()
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.PreferedColor)
            </td>
            <td>
                @Html.DevExpress().ColorEditFor(Function(m) m.PreferedColor).GetHtml()
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.Photo)
            </td>
            <td>
                @Html.DevExpress().BinaryImageFor(Function(m) m.Photo, _
                    Sub(settings)
                        settings.Properties.EditingSettings.Enabled = True
                    End Sub).GetHtml()
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.Teams)
            </td>
            <td>
                @Html.DevExpress().TokenBoxFor(Function(m) m.Teams).BindList(ListsDataHelper.GetTeams()).GetHtml()
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.Location)
            </td>
            <td>
                @Html.DevExpress().ComboBoxFor(Function(m) m.Location).BindList(ListsDataHelper.GetLocations()).GetHtml()
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.IsActive)
            </td>
            <td>
                @Html.DevExpress().CheckBoxFor(Function(m) m.IsActive).GetHtml()
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.PrimaryEmail)
            </td>
            <td>
                @Html.DevExpress().ButtonEditFor(Function(m) m.PrimaryEmail).GetHtml()
            </td>
        </tr>

    </table>
    
    @Html.DevExpress().Button( _
        Sub(settings)
            settings.Name = "btnSubmit"
            settings.Text = "Submit"
            settings.UseSubmitBehavior = True
        End Sub).GetHtml()

    @Html.DevExpress().Button( _
        Sub(settings)
            settings.Name = "btnClear"
            settings.Text = "Clear"
            settings.ClientSideEvents.Click = "function(s, e) { ASPxClientEdit.ClearEditorsInContainer(null); }"
    End Sub).GetHtml()
End Using