@ModelType CustomerInfo

@Code
    Dim base64 As String = If(Model.Photo IsNot Nothing, Convert.ToBase64String(Model.Photo), Nothing)
    Dim photoSrc As String = String.Format("data:image/png;base64,{0}", base64)
End Code

<h2>Details:</h2>

    <table>
        <tr>
            <td style="width: 200px;">
                @Html.LabelFor(Function(m) m.FirstName)
            </td>
            <td>
                @Html.DisplayFor(Function(m) m.FirstName)
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.BirthDate)
            </td>
            <td>
                @Html.DisplayFor(Function(m) m.BirthDate)
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.Notes)
            </td>
            <td>
                @Html.DisplayFor(Function(m) m.Notes)
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.Age)
            </td>
            <td>
                @Html.DisplayFor(Function(m) m.Age)
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.HireDate)
            </td>
            <td>
                @Html.DisplayFor(Function(m) m.HireDate)
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.Salary)
            </td>
            <td>
                @Html.DisplayFor(Function(m) m.Salary)
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.PreferedColor)
            </td>
            <td>
                @Html.DisplayFor(Function(m) m.PreferedColor)
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.Photo)
            </td>
            <td>
                <img src="@photoSrc" />
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.Teams)
            </td>
            <td>
                @For Each team As String In Model.Teams
                    Dim tm As String = team
                    @Html.DisplayFor(Function(m) tm)
                Next
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.Location)
            </td>
            <td>
                @Html.DisplayFor(Function(m) m.Location)
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.IsActive)
            </td>
            <td>
                @Html.DisplayFor(Function(m) m.IsActive)
            </td>
        </tr>

        <tr>
            <td>
                @Html.LabelFor(Function(m) m.PrimaryEmail)
            </td>
            <td>
                @Html.DisplayFor(Function(m) m.PrimaryEmail)
            </td>
        </tr>

    </table>