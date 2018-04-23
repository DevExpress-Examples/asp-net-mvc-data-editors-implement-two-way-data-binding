@ModelType CustomerInfo

@Using (Html.BeginForm())
    @Html.DevExpress().FormLayout( _
        Sub(settings)
            settings.Name = "FormLayout"
            settings.Items.Add(Function(m) m.FirstName)
            settings.Items.Add(Function(m) m.BirthDate)
            settings.Items.Add(Function(m) m.Notes, _
                Sub(item)
                    item.NestedExtensionType = FormLayoutNestedExtensionItemType.Memo
                End Sub)
            settings.Items.Add(Function(m) m.Age)
            settings.Items.Add(Function(m) m.HireDate, _
                Sub(item)
                    item.NestedExtensionType = FormLayoutNestedExtensionItemType.Calendar
                End Sub)
            settings.Items.Add(Function(m) m.Salary, _
                Sub(item)
                    item.NestedExtensionType = FormLayoutNestedExtensionItemType.TrackBar
                End Sub)
            settings.Items.Add(Function(m) m.PreferedColor, _
                Sub(item)
                    item.NestedExtensionType = FormLayoutNestedExtensionItemType.ColorEdit
                End Sub)
            settings.Items.Add(Function(m) m.Photo, _
                Sub(item)
                    item.NestedExtensionType = FormLayoutNestedExtensionItemType.BinaryImage
                    CType(item.NestedExtensionSettings, BinaryImageEditSettings).Properties.EditingSettings.Enabled = True
                End Sub)
            settings.Items.Add(Function(m) m.Teams, _
               Sub(item)
                   item.NestedExtensionType = FormLayoutNestedExtensionItemType.TokenBox
                   CType(item.NestedExtensionSettings, TokenBoxSettings).Properties.DataSource = ListsDataHelper.GetTeams()
               End Sub)
            settings.Items.Add(Function(m) m.Location, _
               Sub(item)
                   item.NestedExtensionType = FormLayoutNestedExtensionItemType.ComboBox
                   CType(item.NestedExtensionSettings, ComboBoxSettings).Properties.DataSource = ListsDataHelper.GetLocations()
               End Sub)
            settings.Items.Add(Function(m) m.IsActive)
            
            settings.Items.Add(Function(m) m.PrimaryEmail, _
                Sub(item)
                    item.NestedExtensionType = FormLayoutNestedExtensionItemType.ButtonEdit
                End Sub)

            settings.Items.Add( _
                Sub(item)
                    item.ShowCaption = DefaultBoolean.False
                    item.SetNestedContent( _
                        Sub()
                            ViewContext.Writer.Write("<table><tr><td>")

                            Html.DevExpress().Button( _
                                Sub(button)
                                    button.Name = "btnSubmit"
                                    button.Text = "Submit"
                                    button.UseSubmitBehavior = True
                                End Sub).GetHtml()

                            ViewContext.Writer.Write("</td><td>")

                            Html.DevExpress().Button( _
                                Sub(button)
                                    button.Name = "btnClear"
                                    button.Text = "Clear"
                                    button.ClientSideEvents.Click = "function(s, e) { ASPxClientEdit.ClearEditorsInContainer(null); }"
                                End Sub).GetHtml()

                            ViewContext.Writer.Write("</td></tr></table>")
                        End Sub)
                End Sub)
        End Sub).GetHtml()
End Using