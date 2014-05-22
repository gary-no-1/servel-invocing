
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' AddPro_inv_hdr.aspx page.  The Row or RecordControl classes are the 
' ideal place to add code customizations. For example, you can override the LoadData, 
' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.

#Region "Imports statements"

Option Strict On
Imports Microsoft.VisualBasic
Imports BaseClasses.Web.UI.WebControls
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Globalization

Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Utils
Imports ReportTools.ReportCreator
Imports ReportTools.Shared

  
        
Imports ServelInvocing.Business
Imports ServelInvocing.Data
Imports ServelInvocing.UI
        

#End Region

  
Namespace ServelInvocing.UI.Controls.AddPro_inv_hdr

#Region "Section 1: Place your customizations here."

    
Public Class Pro_inv_itemsTableControlRow
        Inherits BasePro_inv_itemsTableControlRow
        ' The BasePro_inv_itemsTableControlRow implements code for a ROW within the
        ' the Pro_inv_itemsTableControl table.  The BasePro_inv_itemsTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of Pro_inv_itemsTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        


		Protected Overrides Sub id_item_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
            ' If a large list selector or a Quick Add link is used, the dropdown list
            ' will contain an item that was not in the original (smaller) list.  During postbacks,
            ' this new item will not be in the list - since the list is based on the original values
            ' read from the database. This function adds the value back if necessary.
            ' In addition, This dropdown can be used on make/model/year style dropdowns.  Make filters the result of Model.
            ' Mode filters the result of Year.  When users change the value of Make, Model and Year are repopulated.
            ' When this function is fire for Make or Model, we don't want the following code executed.
            ' Therefore, we check this situation using Items.Count > 1			
            If Me.id_item.Items.Count > 1 Then
                Dim selectedValue As String = MiscUtils.GetValueSelectedPageRequest(Me.id_item)
                 
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_item, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_item, selectedValue)Then

                ' construct a whereclause to query a record with items.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(ItemsTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As ItemsRecord = ItemsTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = Pro_inv_itemsTable.id_item.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_item.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
            End If
          									
			Dim selectedText As String = id_item.SelectedItem.Text
	    	If not (BaseClasses.Utils.StringUtils.InvariantUCase(selectedText).Equals(BaseClasses.Utils.StringUtils.InvariantUCase(Page.GetResourceValue("Txt:PleaseSelect", "ServelInvocing"))))
    	    	' if "Please Select" string is selected for first dropdown list,
	        	' then do not continue populating the second dropdown list.
				Dim thisItem_id As String
				thisItem_id = me.id_item.text
				Dim srchStr As String
				srchStr = "id = '" + thisItem_Id + "'"
				Dim ProInvItemRec As itemsRecord = ItemsTable.GetRecord(srchStr, False)
				me.item_code.text = ProInvItemRec.item_code
				me.item_description.text = ProInvItemRec.item_description
				me.uom.text = ProInvItemRec.uom
    	    	Return    
    		End If
                
                
        End Sub
End Class

  

Public Class Pro_inv_itemsTableControl
        Inherits BasePro_inv_itemsTableControl

    ' The BasePro_inv_itemsTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The Pro_inv_itemsTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  
Public Class Pro_inv_taxesTableControlRow
        Inherits BasePro_inv_taxesTableControlRow
        ' The BasePro_inv_taxesTableControlRow implements code for a ROW within the
        ' the Pro_inv_taxesTableControl table.  The BasePro_inv_taxesTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of Pro_inv_taxesTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        


		Protected Overrides Sub id_taxes_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
            ' If a large list selector or a Quick Add link is used, the dropdown list
            ' will contain an item that was not in the original (smaller) list.  During postbacks,
            ' this new item will not be in the list - since the list is based on the original values
            ' read from the database. This function adds the value back if necessary.
            ' In addition, This dropdown can be used on make/model/year style dropdowns.  Make filters the result of Model.
            ' Mode filters the result of Year.  When users change the value of Make, Model and Year are repopulated.
            ' When this function is fire for Make or Model, we don't want the following code executed.
            ' Therefore, we check this situation using Items.Count > 1			
            If Me.id_taxes.Items.Count > 1 Then
                Dim selectedValue As String = MiscUtils.GetValueSelectedPageRequest(Me.id_taxes)
                 
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_taxes, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_taxes, selectedValue)Then

                ' construct a whereclause to query a record with taxes.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(TaxesTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As TaxesRecord = TaxesTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = Pro_inv_taxesTable.id_taxes.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_taxes.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
            End If

			Dim selectedText As String = id_taxes.SelectedItem.Text
	    	If not (BaseClasses.Utils.StringUtils.InvariantUCase(selectedText).Equals(BaseClasses.Utils.StringUtils.InvariantUCase(Page.GetResourceValue("Txt:PleaseSelect", "ServelInvocing"))))
    	    	' if "Please Select" string is selected for first dropdown list,
	        	' then do not continue populating the second dropdown list.
				Dim thisTaxes_id As String
				thisTaxes_id = me.id_taxes.text
				Dim srchHdrStr As String
				srchHdrStr = "id = '" + thisTaxes_Id + "'"
				Dim ProInvTaxesRec As taxesRecord = TaxesTable.GetRecord(srchHdrStr, False)
				me.tax_code.text  = ProInvtaxesRec.tax_code
				me.tax_rate.text  = ProInvtaxesRec.tax_rate.tostring()
				me.tax_name.text  = ProInvtaxesRec.tax_name
				me.tax_print.text = ProInvtaxesRec.tax_print
				me.calc_type.text = ProInvtaxesRec.calc_type
				me.tax_type.text  = ProInvtaxesRec.tax_type
    	    	Return    
    		End If
                
        End Sub
End Class

  

Public Class Pro_inv_taxesTableControl
        Inherits BasePro_inv_taxesTableControl

    ' The BasePro_inv_taxesTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The Pro_inv_taxesTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.


#Region "Code Customization"

''' <summary>
''' This method will add three records on the page.
''' </summary>
    
#End Region
End Class

  
Public Class Pro_inv_termsTableControlRow
        Inherits BasePro_inv_termsTableControlRow
        ' The BasePro_inv_termsTableControlRow implements code for a ROW within the
        ' the Pro_inv_termsTableControl table.  The BasePro_inv_termsTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of Pro_inv_termsTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class Pro_inv_termsTableControl
        Inherits BasePro_inv_termsTableControl

    ' The BasePro_inv_termsTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The Pro_inv_termsTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.


#Region "Code Customization"

''' <summary>
''' This method will add three records on the page.
''' </summary>
		Public Overrides Sub LoadData()

    ' Call MyBase.LoadData()
    MyBase.LoadData()

    If Not Me.Page.IsPostBack() Then
		Dim srchTermsStr As String
		srchTermsStr = "id <> '0'"
		'Dim TermsRec As TermsRecord
		Dim TermsManyRec As TermsRecord()
		TermsManyRec = TermsTable.GetRecords(srchTermsStr)
		Dim j as Integer
		j = TermsManyRec.count()
		
        Dim list As ArrayList
        If (IsNothing(DataSource)) Then
            list = New ArrayList()
        Else
            list = New ArrayList(Me.DataSource)
        End If             
        Dim i As Integer
		
        'This will insert rows at the end of the table control
        For i = 0 To j - 1
            list.Add(New Pro_inv_termsRecord)
        Next i
        
        'Add the code to insert rows at top of the table control
        ' For i = 0 To 2
            ' list.Insert(i, New Pro_inv_termsRecord)
        ' Next i
        Me.DataSource = DirectCast(list.ToArray(GetType(Pro_inv_termsRecord)), Pro_inv_termsRecord())
		
        'Dim recControls As pro_inv_termsTableControlRow() = Me.GetRecordControls()
        'Dim recControls As pro_inv_termsTableRow() = Me.GetRecord()
		'For Each rec As pro_inv_termsTableControlRow In recControls
  		'	rec.narration.text = "this is a test"
		'Next

    End If
End Sub
    
#End Region

		
		Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record for each row in the table.  To do this, it calls the
            ' DataBind for each of the rows.
            ' DataBind also populates any filters above the table, and sets the pagination
            ' control to the correct number of records and the current page number.
            
            MyBase.DataBind()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
                Return
            End If
			'Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", "1")
           
            ' Setup the pagination controls.
            BindPaginationControls()

            ' Call the Set methods for each controls on the panel
        
            SetnarrationLabel1()
            Setsort_orderLabel1()
      
			Dim TermsRec As TermsRecord
			Dim TermsManyRec As TermsRecord()
			TermsManyRec = TermsTable.GetRecords("id <> '0'")
			'Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", "2")


            ' Bind the repeater with the list of records to expand the UI.
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Pro_inv_termsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return
            rep.DataSource = DataSource()
            rep.DataBind()

            Dim index As Integer = 0
			Dim termctr As Integer = 0
            For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
                ' Loop through all rows in the table, set its DataSource and call DataBind().
                Dim recControl As Pro_inv_termsTableControlRow = DirectCast(repItem.FindControl("Pro_inv_termsTableControlRow"), Pro_inv_termsTableControlRow) 
                recControl.DataSource = Me.DataSource(index)
                If Me.UIData.Count > index Then
                    recControl.PreviousUIData = Me.UIData(index)
                End If				
                recControl.DataBind()
                recControl.Visible = Not Me.InDeletedRecordIds(recControl)
				TermsRec = TermsManyRec(termctr)
				recControl.narration.text = TermsRec.narration
				recControl.sort_order.text = TermsRec.sort_order.tostring()
                index += 1
				termctr +=1
            Next

        
            ' setting the state of expand or collapse alternative rows
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                

            ' Initialize other asp controls
            
            SetnarrationLabel1()
            Setsort_orderLabel1()
      End Sub
End Class

  
Public Class Pro_inv_hdrRecordControl
        Inherits BasePro_inv_hdrRecordControl
        ' The BasePro_inv_hdrRecordControl implements the LoadData, DataBind and other
        ' methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        ' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
		Public Overrides Sub DataBind()
			MyBase.DataBind()
			If Not (Me.Page.IsPostBack) Then
				' This code executes when the page is first loaded.
				Dim tempToday , tempTime as string
				tempToday = Today().tostring()
				tempToday = mid(tempToday,9,2)+ mid(tempToday,4,2) + left(tempToday,2)
				tempTime = Now.ToShortTimeString()
				tempTime = left(right(tempTime,8),5)
				Dim strProInvNo as string 
				strProInvNo = tempToday + "/" + tempTime
				Dim random As New Random()
				Dim ch As Char
				ch = Convert.ToChar(Convert.ToInt32((25 * random.NextDouble() + 65)))
				strProInvNo = strProInvNo + "/" + ch
				me.pro_inv_no.text = strProInvNo				
			Else
				' This code executes during a button click or other postback.
			End If		
		End Sub
        


		
		Protected Overrides Sub id_tax_group_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
            ' If a large list selector or a Quick Add link is used, the dropdown list
            ' will contain an item that was not in the original (smaller) list.  During postbacks,
            ' this new item will not be in the list - since the list is based on the original values
            ' read from the database. This function adds the value back if necessary.
            ' In addition, This dropdown can be used on make/model/year style dropdowns.  Make filters the result of Model.
            ' Mode filters the result of Year.  When users change the value of Make, Model and Year are repopulated.
            ' When this function is fire for Make or Model, we don't want the following code executed.
            ' Therefore, we check this situation using Items.Count > 1			
            If Me.id_tax_group.Items.Count > 1 Then
                Dim selectedValue As String = MiscUtils.GetValueSelectedPageRequest(Me.id_tax_group)
                 
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_tax_group, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_tax_group, selectedValue)Then

                ' construct a whereclause to query a record with tax_groups.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(Tax_groupsTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As Tax_groupsRecord = Tax_groupsTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = Pro_inv_hdrTable.id_tax_group.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_tax_group.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
            End If
		
			Dim selectedText As String = id_tax_group.SelectedItem.Text
	    	If not (BaseClasses.Utils.StringUtils.InvariantUCase(selectedText).Equals(BaseClasses.Utils.StringUtils.InvariantUCase(Page.GetResourceValue("Txt:PleaseSelect", "ServelInvocing"))))
    	    	' if "Please Select" string is selected for first dropdown list,
	        	' then do not continue populating the second dropdown list.
				Dim thisTax_group_id As String
				thisTax_group_id = me.id_tax_group.text
				Dim srchStr As String
				srchStr = "id_tax_group = '" + thisTax_group_Id + "'"

				Dim Tax_group_dtlsRec As Tax_group_dtlsRecord
				Dim TaxesManyRec As Tax_group_dtlsRecord()
				TaxesManyRec = Tax_group_dtlsTable.GetRecords(srchStr)
				Dim j as Integer
				j = TaxesManyRec.count()
				
		        Dim list As ArrayList
        		list = New ArrayList()
		        Dim i As Integer
		        For i = 0 To j - 1
		            list.Add(New Pro_inv_taxesRecord)
        		Next i
				Dim pro_inv_taxesObj As pro_inv_taxesTableControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Pro_inv_taxesTableControl"), Pro_inv_taxesTableControl)
				pro_inv_taxesObj.DataSource = DirectCast(list.ToArray(GetType(Pro_inv_taxesRecord)), Pro_inv_taxesRecord())
				pro_inv_taxesObj.databind()

				Dim rep As System.Web.UI.WebControls.Repeater = CType(MiscUtils.FindControlRecursively(Me.Page, "Pro_inv_taxesTableControlRepeater"),System.Web.UI.WebControls.Repeater)
				'If rep Is Nothing Then 
				'Return
				'Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", "8")
				'end if
			
	            'rep.DataSource = DataSource()
    	        'rep.DataBind()

        	    Dim index As Integer = 0
				Dim taxctr As Integer = 0
            	For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
                	' Loop through all rows in the table, set its DataSource and call DataBind().
                	Dim recControl As Pro_inv_taxesTableControlRow = DirectCast(repItem.FindControl("Pro_inv_taxesTableControlRow"), Pro_inv_taxesTableControlRow) 
                	'recControl.DataSource = Me.DataSource(index)
	                'If Me.UIData.Count > index Then
    	            '    recControl.PreviousUIData = Me.UIData(index)
        	        'End If				
            	    'recControl.DataBind()
                	'recControl.Visible = Not Me.InDeletedRecordIds(recControl)
					Tax_group_dtlsRec = TaxesManyRec(taxctr)
					recControl.id_taxes.text = Tax_group_dtlsRec.id_taxes.tostring()
					recControl.tax_code.text = Tax_group_dtlsRec.tax_code
					recControl.tax_name.text = Tax_group_dtlsRec.tax_name
					recControl.tax_print.text = Tax_group_dtlsRec.tax_print
					recControl.tax_rate.text = Tax_group_dtlsRec.tax_rate.tostring()
					recControl.calc_type.text = Tax_group_dtlsRec.calc_type
					recControl.sort_order1.text = Tax_group_dtlsRec.sort_order.tostring()
					recControl.tax_type.text = Tax_group_dtlsRec.tax_type
					
	                index += 1
					taxctr +=1
        	    Next

            End If

    'If Not Me.Page.IsPostBack() Then
        'If (IsNothing(DataSource)) Then
        '    list = New ArrayList()
        'Else
        '    list = New ArrayList(Me.DataSource)
        'End If             
    'End If
                
                
        End Sub

		Public Overrides Sub CalculateButton_Click(ByVal sender As Object, ByVal args As EventArgs)
			' to do
			' id_party should be filled , id_tax_group should be filled
			Dim search_pointer as String = "111"
       	    Dim index As Integer = 0
			
            Try
				Dim irep As System.Web.UI.WebControls.Repeater = CType(MiscUtils.FindControlRecursively(Me.Page, "Pro_inv_itemsTableControlRepeater"),System.Web.UI.WebControls.Repeater)
				Dim item_total As Decimal = 0
        	   	For Each irepItem As System.Web.UI.WebControls.RepeaterItem In irep.Items
            	   	Dim irecControl As Pro_inv_itemsTableControlRow = DirectCast(irepItem.FindControl("Pro_inv_itemsTableControlRow"), Pro_inv_itemsTableControlRow) 
					item_total += CDec(irecControl.amount.text)
					index += 1
    	   	    Next

				Dim net_total  As Decimal = 0
				Dim prv_amount As Decimal = 0
				Dim prv_total  As Decimal = 0
				Dim tax_amount As Decimal = 0
				Dim ex_total   As Decimal = 0
				Dim inv_total  As Decimal = 0
			
				net_total  = item_total
				prv_amount = item_total
				prv_total  = item_total
			
				Dim trep As System.Web.UI.WebControls.Repeater = CType(MiscUtils.FindControlRecursively(Me.Page, "Pro_inv_taxesTableControlRepeater"),System.Web.UI.WebControls.Repeater)
       		    index = 0
           		For Each trepItem As System.Web.UI.WebControls.RepeaterItem In trep.Items
	               	Dim trecControl As Pro_inv_taxesTableControlRow = DirectCast(trepItem.FindControl("Pro_inv_taxesTableControlRow"), Pro_inv_taxesTableControlRow) 
				'if trecControl.calc_type.text = "ON NET TOTAL        " then
					if trecControl.calc_type.text.trim() = "ON NET TOTAL" then
						if trecControl.tax_lock.Checked then
							tax_amount = CDec(trecControl.tax_amount.text)
							trecControl.tax_amount.text = Format(tax_amount, "c")
						else
							trecControl.tax_on.text = FORMAT(net_total, "c")
							tax_amount = Math.round(net_total * CDec(trecControl.tax_rate.text) / 100,0)
							trecControl.tax_amount.text = Format(tax_amount, "c")
						end if 	
						prv_total += tax_amount
						prv_amount = tax_amount
					end if
				'if trecControl.calc_type.text = "PREVIOUS AMOUNT     " then
					if trecControl.calc_type.text.trim() = "PREVIOUS AMOUNT" then
						if trecControl.tax_lock.Checked then
							tax_amount = CDec(trecControl.tax_amount.text)
							trecControl.tax_amount.text = Format(tax_amount, "c")
						else
							trecControl.tax_on.text = FORMAT(prv_amount, "c")
							tax_amount = Math.round(prv_amount * CDec(trecControl.tax_rate.text) / 100,0)
							trecControl.tax_amount.text = Format(tax_amount, "c")
						end if	
						prv_total += tax_amount
						prv_amount = tax_amount
					end if
				'if trecControl.calc_type.text = "PREVIOUS TOTAL      " then
					if trecControl.calc_type.text.trim() = "PREVIOUS TOTAL" then
						if trecControl.tax_lock.Checked then
							tax_amount = CDec(trecControl.tax_amount.text)
							trecControl.tax_amount.text = Format(tax_amount, "c")
						else
							trecControl.tax_on.text = FORMAT(prv_total, "c")
							tax_amount = Math.round(prv_total * CDec(trecControl.tax_rate.text) / 100,0)
							trecControl.tax_amount.text = Format(tax_amount, "c")
						end if	
						prv_total += tax_amount
						prv_amount = tax_amount
					end if
				'if trecControl.calc_type.text = "ACTUAL              " then
					if trecControl.calc_type.text.trim() = "ACTUAL" then
						trecControl.tax_on.text = FORMAT(CDec(trecControl.tax_amount.text),"c")
						tax_amount = CDec(trecControl.tax_amount.text)
						trecControl.tax_amount.text = Format(tax_amount, "c")
						prv_total += tax_amount
						prv_amount = tax_amount
					end if
					if trecControl.calc_type.text.trim() = "SUB TOTAL" then
						trecControl.tax_on.text = FORMAT(prv_total, "c")
						tax_amount = prv_total
						trecControl.tax_amount.text = Format(tax_amount, "c")
					'prv_total += tax_amount
						prv_amount = tax_amount
					end if
			    ' compute total amount of excise duty
					if trecControl.tax_type.text.trim() = "EXCISE" then
						tax_amount = CDec(trecControl.tax_amount.text)
						ex_total += tax_amount					
					end if	
					index += 1
    	   	    Next

				inv_total = prv_total
			
				Dim crep As System.Web.UI.WebControls.Repeater = CType(MiscUtils.FindControlRecursively(Me.Page, "Pro_inv_taxesTableControlRepeater"),System.Web.UI.WebControls.Repeater)
	           	For Each crepItem As System.Web.UI.WebControls.RepeaterItem In crep.Items
    	           	Dim crecControl As Pro_inv_taxesTableControlRow = DirectCast(crepItem.FindControl("Pro_inv_taxesTableControlRow"), Pro_inv_taxesTableControlRow) 
					crecControl.item_total1.text  = FORMAT(item_total, "c")
					crecControl.excise_total.text = FORMAT(ex_total, "c")
					crecControl.grand_total1.text = FORMAT(inv_total, "c")
				
					index += 1
    	   	    Next

				me.item_total.text  = FORMAT(item_total, "c")
            	me.grand_total.text = FORMAT(prv_total, "c")
				me.item_totalLabel.visible = true
				me.item_total.visible = true
				me.grand_totalLabel.visible = true
				me.grand_total.visible = true
				
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                'Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
				
				Dim msg_calc_error as String
				msg_calc_error = "Please check all tax rates | item rate / qty - one of them is blank"
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", msg_calc_error)
            Finally
    
            End Try
    
        End Sub

		Protected Overrides Sub id_party_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
            ' If a large list selector or a Quick Add link is used, the dropdown list
            ' will contain an item that was not in the original (smaller) list.  During postbacks,
            ' this new item will not be in the list - since the list is based on the original values
            ' read from the database. This function adds the value back if necessary.
            ' In addition, This dropdown can be used on make/model/year style dropdowns.  Make filters the result of Model.
            ' Mode filters the result of Year.  When users change the value of Make, Model and Year are repopulated.
            ' When this function is fire for Make or Model, we don't want the following code executed.
            ' Therefore, we check this situation using Items.Count > 1			
            If Me.id_party.Items.Count > 1 Then
                Dim selectedValue As String = MiscUtils.GetValueSelectedPageRequest(Me.id_party)
                 
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_party, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_party, selectedValue)Then

                ' construct a whereclause to query a record with party.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(PartyTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As PartyRecord = PartyTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = Pro_inv_hdrTable.id_party.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_party.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
            End If
          
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()
                ' Because Set methods will be called, it is important to initialize the data source ahead of time
                Me.DataSource = Me.GetRecord()
                Me.Page.CommitTransaction(sender)

            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
            Finally
                DbUtils.EndTransaction()
            End Try			

			Dim selectedText As String = id_party.SelectedItem.Text
	    	If not (BaseClasses.Utils.StringUtils.InvariantUCase(selectedText).Equals(BaseClasses.Utils.StringUtils.InvariantUCase(Page.GetResourceValue("Txt:PleaseSelect", "ServelInvocing"))))
    	    	' if "Please Select" string is selected for first dropdown list,
	        	' then do not continue populating the second dropdown list.
				Dim thisParty_id As String
				thisParty_id = me.id_party.text
				Dim srchHdrStr As String
				srchHdrStr = "id = '" + thisParty_Id + "'"
				Dim ProInvPartyRec As partyRecord = PartyTable.GetRecord(srchHdrStr, False)
				me.tin_no.text = ProInvPartyRec.tin_no
				me.bill_name.text = ProInvPartyRec.name
				me.bill_address.text = ProInvPartyRec.address
				me.ship_name.text = ProInvPartyRec.name
				me.ship_address.text = ProInvPartyRec.address
				' -- added - 22-04-2014
				me.contact.text = ProInvPartyRec.contact
				me.phone.text = ProInvPartyRec.phone
				me.email.text = ProInvPartyRec.email
    	    	' Return    
    		End If
		
                
            ' Reset id_site
            Setid_site()									
                
                
        End Sub

		Protected Overrides Sub id_site_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
            ' If a large list selector or a Quick Add link is used, the dropdown list
            ' will contain an item that was not in the original (smaller) list.  During postbacks,
            ' this new item will not be in the list - since the list is based on the original values
            ' read from the database. This function adds the value back if necessary.
            ' In addition, This dropdown can be used on make/model/year style dropdowns.  Make filters the result of Model.
            ' Mode filters the result of Year.  When users change the value of Make, Model and Year are repopulated.
            ' When this function is fire for Make or Model, we don't want the following code executed.
            ' Therefore, we check this situation using Items.Count > 1			
            If Me.id_site.Items.Count > 1 Then
                Dim selectedValue As String = MiscUtils.GetValueSelectedPageRequest(Me.id_site)
                 
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_site, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_site, selectedValue)Then

                ' construct a whereclause to query a record with sites.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(SitesTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As SitesRecord = SitesTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String= EvaluateFormula("name", rc(0))				
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_site.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
            End If
          									
			Dim selectedText As String = id_site.SelectedItem.Text
	    	If not (BaseClasses.Utils.StringUtils.InvariantUCase(selectedText).Equals(BaseClasses.Utils.StringUtils.InvariantUCase(Page.GetResourceValue("Txt:PleaseSelect", "ServelInvocing"))))
    	    	' if "Please Select" string is selected for first dropdown list,
	        	' then do not continue populating the second dropdown list.
				Dim thisSite_id As String
				thisSite_id = me.id_site.text
				Dim srchHdrStr As String
				srchHdrStr = "id = '" + thisSite_Id + "'"
				Dim ProInvSitesRec As sitesRecord = SitesTable.GetRecord(srchHdrStr, False)
				me.ship_name.text = ProInvSitesRec.name
				me.ship_address.text = ProInvSitesRec.address
    	    	' Return    
    		End If
                
                
        End Sub
End Class

  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the Pro_inv_itemsTableControlRow control on the AddPro_inv_hdr page.
' Do not modify this class. Instead override any method in Pro_inv_itemsTableControlRow.
Public Class BasePro_inv_itemsTableControlRow
        Inherits ServelInvocing.UI.BaseApplicationRecordControl

        '  To customize, override this method in Pro_inv_itemsTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
        End Sub

        '  To customize, override this method in Pro_inv_itemsTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
			'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
			Me.Page.LoadFocusScripts(Me)
		
              ' Show confirmation message on Click
              Me.Pro_inv_itemsRowDeleteButton.Attributes.Add("onClick", "return (confirm('" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteRecordConfirm", "ServelInvocing") & "'));")
              ' Register the event handlers.
          
              AddHandler Me.Pro_inv_itemsRowDeleteButton.Click, AddressOf Pro_inv_itemsRowDeleteButton_Click
              
              AddHandler Me.id_item.SelectedIndexChanged, AddressOf id_item_SelectedIndexChanged
            
              AddHandler Me.item_code.TextChanged, AddressOf item_code_TextChanged
            
              AddHandler Me.item_description.TextChanged, AddressOf item_description_TextChanged
            
              AddHandler Me.qty.TextChanged, AddressOf qty_TextChanged
            
              AddHandler Me.rate.TextChanged, AddressOf rate_TextChanged
            
              AddHandler Me.uom.TextChanged, AddressOf uom_TextChanged
            
              AddHandler Me.amount.TextChanged, AddressOf amount_TextChanged
            
        End Sub

        
        Public Overridable Sub LoadData()        
            ' Load the data from the database into the DataSource pro_inv_items record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = Pro_inv_itemsTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BasePro_inv_itemsTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New Pro_inv_itemsRecord()
          
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Pro_inv_itemsTableControlRow.
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record.  To do this, it calls the Set methods for 
            ' each of the field displayed on the webpage.  It is better to make 
            ' changes in the Set methods, rather than making changes here.
            
            MyBase.DataBind()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
                Return
            End If
        
      
      
            ' Call the Set methods for each controls on the panel
        
            Setid_item()
            Setitem_code()
            Setitem_description()
            Setqty()
            Setrate()
            Setuom()
            Setamount()
      
      
            Me.IsNewRecord = True
            
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
                
                Me.RecordUniqueId = Me.DataSource.GetID.ToXmlString()
            End If
          
            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False
                  
        End Sub
        
        
        Public Overridable Sub Setid_item()
            							
            ' If selection was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.id_item.ID) Then
                If Me.PreviousUIData(Me.id_item.ID) Is Nothing
                    Me.Populateid_itemDropDownList(Nothing, 100)
                Else
                    Me.Populateid_itemDropDownList(Me.PreviousUIData(Me.id_item.ID).ToString(), 100)
                End If
                Return
            End If
            
        
            ' Set the id_item DropDownList on the webpage with value from the
            ' pro_inv_items database record.
            
            ' Me.DataSource is the pro_inv_items record retrieved from the database.
            ' Me.id_item is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_item()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_itemSpecified Then
                            
                ' If the id_item is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.Populateid_itemDropDownList(Me.DataSource.id_item.ToString(), 100)
                
            Else
                
                ' id_item is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.Populateid_itemDropDownList(Nothing, 100)
                Else
                    Me.Populateid_itemDropDownList(Pro_inv_itemsTable.id_item.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub Setitem_code()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.item_code.ID) Then
            
                Me.item_code.Text = Me.PreviousUIData(Me.item_code.ID).ToString()
              
                Return
            End If
            
        
            ' Set the item_code TextBox on the webpage with value from the
            ' pro_inv_items database record.

            ' Me.DataSource is the pro_inv_items record retrieved from the database.
            ' Me.item_code is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setitem_code()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.item_codeSpecified Then
                				
                ' If the item_code is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_itemsTable.item_code)
                            
                Me.item_code.Text = formattedValue
              
            Else 
            
                ' item_code is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.item_code.Text = Pro_inv_itemsTable.item_code.Format(Pro_inv_itemsTable.item_code.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setitem_description()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.item_description.ID) Then
            
                Me.item_description.Text = Me.PreviousUIData(Me.item_description.ID).ToString()
              
                Return
            End If
            
        
            ' Set the item_description TextBox on the webpage with value from the
            ' pro_inv_items database record.

            ' Me.DataSource is the pro_inv_items record retrieved from the database.
            ' Me.item_description is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setitem_description()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.item_descriptionSpecified Then
                				
                ' If the item_description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_itemsTable.item_description)
                            
                Me.item_description.Text = formattedValue
              
            Else 
            
                ' item_description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.item_description.Text = Pro_inv_itemsTable.item_description.Format(Pro_inv_itemsTable.item_description.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setqty()
            
            ' Set AutoPostBack to true so that when the control value is changed, to refresh amount controls
            Me.qty.AutoPostBack = True
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.qty.ID) Then
            
                Me.qty.Text = Me.PreviousUIData(Me.qty.ID).ToString()
              
                Return
            End If
            
        
            ' Set the qty TextBox on the webpage with value from the
            ' pro_inv_items database record.

            ' Me.DataSource is the pro_inv_items record retrieved from the database.
            ' Me.qty is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setqty()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.qtySpecified Then
                				
                ' If the qty is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_itemsTable.qty)
                            
                Me.qty.Text = formattedValue
              
            Else 
            
                ' qty is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.qty.Text = Pro_inv_itemsTable.qty.Format(Pro_inv_itemsTable.qty.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setrate()
            
            ' Set AutoPostBack to true so that when the control value is changed, to refresh amount controls
            Me.rate.AutoPostBack = True
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.rate.ID) Then
            
                Me.rate.Text = Me.PreviousUIData(Me.rate.ID).ToString()
              
                Return
            End If
            
        
            ' Set the rate TextBox on the webpage with value from the
            ' pro_inv_items database record.

            ' Me.DataSource is the pro_inv_items record retrieved from the database.
            ' Me.rate is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setrate()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.rateSpecified Then
                				
                ' If the rate is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_itemsTable.rate)
                            
                Me.rate.Text = formattedValue
              
            Else 
            
                ' rate is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.rate.Text = Pro_inv_itemsTable.rate.Format(Pro_inv_itemsTable.rate.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setuom()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.uom.ID) Then
            
                Me.uom.Text = Me.PreviousUIData(Me.uom.ID).ToString()
              
                Return
            End If
            
        
            ' Set the uom TextBox on the webpage with value from the
            ' pro_inv_items database record.

            ' Me.DataSource is the pro_inv_items record retrieved from the database.
            ' Me.uom is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setuom()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.uomSpecified Then
                				
                ' If the uom is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_itemsTable.uom)
                            
                Me.uom.Text = formattedValue
              
            Else 
            
                ' uom is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.uom.Text = Pro_inv_itemsTable.uom.Format(Pro_inv_itemsTable.uom.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setamount()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.amount.ID) Then
            
                Me.amount.Text = Me.PreviousUIData(Me.amount.ID).ToString()
              
                Return
            End If
            
        
            ' Set the amount TextBox on the webpage with value from the
            ' pro_inv_items database record.

            ' Me.DataSource is the pro_inv_items record retrieved from the database.
            ' Me.amount is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setamount()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the amount is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_itemsTable.amount)
                            
                Me.amount.Text = formattedValue
              
            Else 
            
                ' amount is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.amount.Text = EvaluateFormula("FORMAT(Round(PARSEDECIMAL(Pro_inv_itemsTableControlRow.qty.Text) *PARSEDECIMAL(Pro_inv_itemsTableControlRow.rate.Text) ,0) , ""c"")", Me.DataSource)		
                End If
                 
        End Sub
                
      
        Public Overridable Function EvaluateFormula(ByVal formula As String, Optional ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord = Nothing, Optional ByVal format as String = Nothing) As String
            Dim e As FormulaEvaluator = New FormulaEvaluator()

            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            If dataSourceForEvaluate Is Nothing Then
                
                e.DataSource = Me.DataSource
                
            Else
                e.DataSource = dataSourceForEvaluate
            End If

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing
                Return ""
            End If
            
            If format IsNot Nothing
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function	  
      

        Public Overridable Sub RegisterPostback()
        
        
        End Sub

      
        
        ' To customize, override this method in Pro_inv_itemsTableControlRow.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
        Dim parentCtrl As Pro_inv_hdrRecordControl
          
          
          parentCtrl = DirectCast(Me.Page.FindControlRecursively("Pro_inv_hdrRecordControl"), Pro_inv_hdrRecordControl)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ServelInvocing"))
            End If
            
            Me.DataSource.id_pro_inv_hdr = parentCtrl.DataSource.id0
              
            ' 2. Perform any custom validation.
            Me.Validate()

            
            ' 3. Set the values in the record with data from UI controls.
            ' This calls the Get() method for each of the user interface controls.
            Me.GetUIData()

            ' 4. Save in the database.
            ' We should not save the record if the data did not change. This
            ' will save a database hit and avoid triggering any database triggers.
             
            If Me.DataSource.IsAnyValueChanged Then
                ' Save record to database but do not commit yet.
                ' Auto generated ids are available after saving for use by child (dependent) records.
                Me.DataSource.Save()
              
                DirectCast(GetParentControlObject(Me, "Pro_inv_itemsTableControl"), Pro_inv_itemsTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "Pro_inv_itemsTableControl"), Pro_inv_itemsTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in Pro_inv_itemsTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
            
      
            ' Call the Get methods for each of the user interface controls.
        
            Getid_item()
            Getitem_code()
            Getitem_description()
            Getqty()
            Getrate()
            Getuom()
            Getamount()
        End Sub
        
        
        Public Overridable Sub Getid_item()
         
            ' Retrieve the value entered by the user on the id_item ASP:DropDownList, and
            ' save it into the id_item field in DataSource pro_inv_items record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.id_item), Pro_inv_itemsTable.id_item)				
            
        End Sub
                
        Public Overridable Sub Getitem_code()
            
            ' Retrieve the value entered by the user on the item_code ASP:TextBox, and
            ' save it into the item_code field in DataSource pro_inv_items record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.item_code.Text, Pro_inv_itemsTable.item_code)			

                      
        End Sub
                
        Public Overridable Sub Getitem_description()
            
            ' Retrieve the value entered by the user on the item_description ASP:TextBox, and
            ' save it into the item_description field in DataSource pro_inv_items record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.item_description.Text, Pro_inv_itemsTable.item_description)			

                      
        End Sub
                
        Public Overridable Sub Getqty()
            
            ' Retrieve the value entered by the user on the qty ASP:TextBox, and
            ' save it into the qty field in DataSource pro_inv_items record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.qty.Text, Pro_inv_itemsTable.qty)			

                      
        End Sub
                
        Public Overridable Sub Getrate()
            
            ' Retrieve the value entered by the user on the rate ASP:TextBox, and
            ' save it into the rate field in DataSource pro_inv_items record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.rate.Text, Pro_inv_itemsTable.rate)			

                      
        End Sub
                
        Public Overridable Sub Getuom()
            
            ' Retrieve the value entered by the user on the uom ASP:TextBox, and
            ' save it into the uom field in DataSource pro_inv_items record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.uom.Text, Pro_inv_itemsTable.uom)			

                      
        End Sub
                
        Public Overridable Sub Getamount()
            
            ' Retrieve the value entered by the user on the amount ASP:TextBox, and
            ' save it into the amount field in DataSource pro_inv_items record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.amount.Text, Pro_inv_itemsTable.amount)			

                      
        End Sub
                
      
        ' To customize, override this method in Pro_inv_itemsTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
            Return Nothing
            
        End Function
        

        ' To customize, override this method in Pro_inv_itemsTableControlRow.
        Public Overridable Sub Validate() 
            ' Add custom validation for any control within this panel.
            ' Example.  If you have a State ASP:Textbox control
            ' If Me.State.Text <> "CA" Then
            '    Throw New Exception("State must be CA (California).")
            ' End If

            ' The Validate method is common across all controls within
            ' this panel so you can validate multiple fields, but report
            ' one error message.
            
                
        End Sub

        Public Overridable Sub Delete()
        
            If Me.IsNewRecord() Then
                Return
            End If

            Dim pkValue As KeyValue = KeyValue.XmlToKey(Me.RecordUniqueId)
          Pro_inv_itemsTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "Pro_inv_itemsTableControl"), Pro_inv_itemsTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "Pro_inv_itemsTableControl"), Pro_inv_itemsTableControl).ResetData = True
        End Sub

        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction()
                Me.RegisterPostback()

                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    Me.LoadData()
                    Me.DataBind()			
                End If
                						
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction()
            End Try
        End Sub
        
        

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)
            Dim isNewRecord As String = CType(ViewState("IsNewRecord"), String)
            If Not isNewRecord Is Nothing AndAlso isNewRecord.Trim <> "" Then
                Me.IsNewRecord = Boolean.Parse(isNewRecord)
            End If
            
            Dim myCheckSum As String = CType(ViewState("CheckSum"), String)
            If Not myCheckSum Is Nothing AndAlso myCheckSum.Trim <> "" Then
                Me.CheckSum = myCheckSum
            End If
            
        End Sub

        Protected Overrides Function SaveViewState() As Object
            ViewState("IsNewRecord") = Me.IsNewRecord.ToString()
            ViewState("CheckSum") = Me.CheckSum
            
            Return MyBase.SaveViewState()
        End Function
        
        

        Public Overridable Function CreateWhereClause_id_itemDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the items table.
            ' Examples:
            ' wc.iAND(ItemsTable.item_code, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(ItemsTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
        
                
        ' Fill the id_item list.
        Protected Overridable Sub Populateid_itemDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.id_item.Items.Clear()
            
            ' This is a four step process.
            ' 1. Setup the static list items
            ' 2. Set up the WHERE and the ORDER BY clause
            ' 3. Read a total of maxItems from the database and insert them
            ' 4. Set the selected value (insert if not already present).
                    
            ' 1. Setup the static list items
            														
            Me.id_item.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))							
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_id_itemDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_id_itemDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                
      
      
            Dim orderBy As OrderBy = New OrderBy(false, true)			
        
            orderBy.Add(ItemsTable.item_code, OrderByItem.OrderDir.Asc)				
            
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As ItemsRecord = Nothing
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Do
                    itemValues = ItemsTable.GetRecords(wc, orderBy, pageNum, 500)
                    For each itemValue As ItemsRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.id0Specified Then
                            cvalue = itemValue.id0.ToString()
                            fvalue = itemValue.Format(ItemsTable.item_code)
                                    
                            If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                            Dim newItem As New ListItem(fvalue, cvalue)
                            If counter < maxItems AndAlso Not Me.id_item.Items.Contains(newItem) Then Me.id_item.Items.Add(newItem)
                            counter += 1
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_item, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_item, selectedValue)Then

                ' construct a whereclause to query a record with items.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(ItemsTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As ItemsRecord = ItemsTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = Pro_inv_itemsTable.id_item.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_item.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_itemsRowDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            If(Not Me.Page.IsPageRefresh) Then
        
                Dim tc As Pro_inv_itemsTableControl = DirectCast(GetParentControlObject(Me, "Pro_inv_itemsTableControl"), Pro_inv_itemsTableControl)
                If Not (IsNothing(tc)) Then
                    
                    Me.Visible = False
                End If
              
            End If
      Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
                  
        End Sub
        
        Protected Overridable Sub id_item_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
            ' If a large list selector or a Quick Add link is used, the dropdown list
            ' will contain an item that was not in the original (smaller) list.  During postbacks,
            ' this new item will not be in the list - since the list is based on the original values
            ' read from the database. This function adds the value back if necessary.
            ' In addition, This dropdown can be used on make/model/year style dropdowns.  Make filters the result of Model.
            ' Mode filters the result of Year.  When users change the value of Make, Model and Year are repopulated.
            ' When this function is fire for Make or Model, we don't want the following code executed.
            ' Therefore, we check this situation using Items.Count > 1			
            If Me.id_item.Items.Count > 1 Then
                Dim selectedValue As String = MiscUtils.GetValueSelectedPageRequest(Me.id_item)
                 
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_item, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_item, selectedValue)Then

                ' construct a whereclause to query a record with items.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(ItemsTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As ItemsRecord = ItemsTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = Pro_inv_itemsTable.id_item.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_item.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
            End If
          									
                
                
        End Sub
            
        Protected Overridable Sub item_code_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub item_description_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub qty_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()
                ' Because Set methods will be called, it is important to initialize the data source ahead of time
                Me.DataSource = Me.GetRecord()
                Me.Page.CommitTransaction(sender)

            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
            Finally
                DbUtils.EndTransaction()
            End Try			
                
                
            ' Reset amount
            Setamount()				
        End Sub
            
        Protected Overridable Sub rate_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()
                ' Because Set methods will be called, it is important to initialize the data source ahead of time
                Me.DataSource = Me.GetRecord()
                Me.Page.CommitTransaction(sender)

            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
            Finally
                DbUtils.EndTransaction()
            End Try			
                
                
            ' Reset amount
            Setamount()				
        End Sub
            
        Protected Overridable Sub uom_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub amount_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
   
        Private _PreviousUIData As New Hashtable
        Public Overridable Property PreviousUIData() As Hashtable
            Get
                Return _PreviousUIData
            End Get
            Set(ByVal value As Hashtable)
                _PreviousUIData = value
            End Set
        End Property   
   
        Private _IsNewRecord As Boolean = True
        Public Overridable Property IsNewRecord() As Boolean
            Get
                Return Me._IsNewRecord
            End Get
            Set(ByVal value As Boolean)
                Me._IsNewRecord = value
            End Set
        End Property

        Private _DataChanged As Boolean = False
        Public Overridable Property DataChanged() As Boolean
            Get
                Return Me._DataChanged
            End Get
            Set(ByVal Value As Boolean)
                Me._DataChanged = Value
            End Set
        End Property

        Private _ResetData As Boolean = False
        Public Overridable Property ResetData() As Boolean
            Get
                Return Me._ResetData
            End Get
            Set(ByVal Value As Boolean)
                Me._ResetData = Value
            End Set
        End Property
        
        Public Property RecordUniqueId() As String
            Get
                Return CType(Me.ViewState("BasePro_inv_itemsTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BasePro_inv_itemsTableControlRow_Rec") = value
            End Set
        End Property
        
        Private _DataSource As Pro_inv_itemsRecord
        Public Property DataSource() As Pro_inv_itemsRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As Pro_inv_itemsRecord)
            
                Me._DataSource = value
            End Set
        End Property

        

        Private _checkSum As String
        Public Overridable Property CheckSum() As String
            Get
                Return Me._checkSum
            End Get
            Set(ByVal value As String)
                Me._checkSum = value
            End Set
        End Property
        
        Private _TotalPages As Integer
        Public Property TotalPages() As Integer
            Get
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property
        
        Private _PageIndex As Integer
        Public Property PageIndex() As Integer
            Get
                ' Return the PageIndex
                Return Me._PageIndex
            End Get
            Set(ByVal value As Integer)
                Me._PageIndex = value
            End Set
        End Property
    
        Private _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property
        
        

#Region "Helper Properties"
        
        Public ReadOnly Property id_item() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_item"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property item_code() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "item_code"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property item_description() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "item_description"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property Pro_inv_itemsRecordRowSelection() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_itemsRecordRowSelection"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_itemsRowDeleteButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_itemsRowDeleteButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property qty() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "qty"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property rate() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "rate"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property uom() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "uom"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property amount() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "amount"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As Pro_inv_itemsRecord = Nothing
             
        
            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.
                
            Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ServelInvocing"))
                    
            End If
            Return EvaluateExpressions(url, arg, rec, bEncrypt)
        End Function

         
        Public Overridable Function GetRecord() As Pro_inv_itemsRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return Pro_inv_itemsTable.GetRecord(Me.RecordUniqueId, True)
                
            End If
            
            ' Localization.
            
            Return Nothing
                
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

End Class

  

' Base class for the Pro_inv_itemsTableControl control on the AddPro_inv_hdr page.
' Do not modify this class. Instead override any method in Pro_inv_itemsTableControl.
Public Class BasePro_inv_itemsTableControl
        Inherits ServelInvocing.UI.BaseApplicationTableControl

        

        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      	  	  
      
           ' Setup the filter and search events.
        
      
      
            ' Control Initializations.
            ' Initialize the table's current sort order.
            
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(True, True)
            
            End If

            ' Setup default pagination settings.
        
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "10"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
            Me.ClearControlsFromSession()
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
              ' Show confirmation message on Click
              Me.Pro_inv_itemsDeleteButton.Attributes.Add("onClick", "return (confirm('" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteConfirm", "ServelInvocing") & "'));")
            ' Setup the pagination events.
            
              AddHandler Me.Pro_inv_itemsPagination.FirstPage.Click, AddressOf Pro_inv_itemsPagination_FirstPage_Click
              
              AddHandler Me.Pro_inv_itemsPagination.LastPage.Click, AddressOf Pro_inv_itemsPagination_LastPage_Click
              
              AddHandler Me.Pro_inv_itemsPagination.NextPage.Click, AddressOf Pro_inv_itemsPagination_NextPage_Click
              
              AddHandler Me.Pro_inv_itemsPagination.PageSizeButton.Click, AddressOf Pro_inv_itemsPagination_PageSizeButton_Click
            
              AddHandler Me.Pro_inv_itemsPagination.PreviousPage.Click, AddressOf Pro_inv_itemsPagination_PreviousPage_Click
              
            ' Setup the sorting events.
          
              AddHandler Me.amountLabel.Click, AddressOf amountLabel_Click
            
              AddHandler Me.id_itemLabel1.Click, AddressOf id_itemLabel1_Click
            
              AddHandler Me.item_descriptionLabel.Click, AddressOf item_descriptionLabel_Click
            
              AddHandler Me.qtyLabel.Click, AddressOf qtyLabel_Click
            
              AddHandler Me.rateLabel.Click, AddressOf rateLabel_Click
            
              AddHandler Me.uomLabel.Click, AddressOf uomLabel_Click
            
            ' Setup the button events.
          
              AddHandler Me.Pro_inv_itemsAddButton.Click, AddressOf Pro_inv_itemsAddButton_Click
              
              AddHandler Me.Pro_inv_itemsDeleteButton.Click, AddressOf Pro_inv_itemsDeleteButton_Click
              
              AddHandler Me.Pro_inv_itemsResetButton.Click, AddressOf Pro_inv_itemsResetButton_Click
              
          ' Setup events for others
            
        End Sub
        
        
        Public Overridable Sub LoadData()
            ' Read data from database. Returns an array of records that can be assigned
            ' to the DataSource table control property.
            Try	
                
                ' The WHERE clause will be empty when displaying all records in table.
                Dim wc As WhereClause = CreateWhereClause()
                If wc IsNot Nothing AndAlso Not wc.RunQuery Then
                    ' Initialize an empty array of records
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Pro_inv_itemsRecord)), Pro_inv_itemsRecord())
                    ' Add records to the list if needed.
                    Me.AddNewRecords()
                    Return
                End If

                ' Call OrderBy to determine the order - either use the order defined
                ' on the Query Wizard, or specified by user (by clicking on column heading)
                Dim orderBy As OrderBy = CreateOrderBy()
                
                ' Get the pagesize from the pagesize control.
                Me.GetPageSize()
                
                ' Get the total number of records to be displayed.
                
                Me.TotalRecords = Pro_inv_itemsTable.GetRecordCount(wc)
                              
                ' Make sure PageIndex (current page) is within bounds.
                If Me.TotalPages <= 0 OrElse Me.PageIndex < 0 Then
                    Me.PageIndex = 0
                ElseIf Me.DisplayLastPage OrElse Me.PageIndex >= Me.TotalPages Then
                    Me.PageIndex = Me.TotalPages - 1
                End If

                ' Retrieve the records and set the table DataSource.
                ' Only PageSize records are fetched starting at PageIndex (zero based).
                If Me.TotalRecords <= 0 Then
                    ' No records matching query. Initialize an empty array of records
                    
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Pro_inv_itemsRecord)), Pro_inv_itemsRecord())
                    
                ElseIf Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                
                    Dim postdata As New ArrayList
                    For Each rc As Pro_inv_itemsTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(Pro_inv_itemsRecord)), Pro_inv_itemsRecord())
                
                Else  ' Get the records from the database	
                    Me.DataSource = Pro_inv_itemsTable.GetRecords(wc, orderBy, Me.PageIndex, Me.PageSize) 
                End If
                
                ' Add any new rows desired by the user.
                Me.AddNewRecords()
            
                ' Turn off the ToggleAll checkbox
                Me.Pro_inv_itemsToggleAll.Checked = False
            

                ' Initialize the page and grand totals. now
            
            Catch ex As Exception
                ' Report the error message to the end user
                Dim msg As String = ex.Message
                If ex.InnerException IsNot Nothing Then
                    msg = msg & " InnerException: " & ex.InnerException.Message
                End If
                Throw New Exception(msg, ex.InnerException)
            End Try
        End Sub
        
        
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record for each row in the table.  To do this, it calls the
            ' DataBind for each of the rows.
            ' DataBind also populates any filters above the table, and sets the pagination
            ' control to the correct number of records and the current page number.
            
            MyBase.DataBind()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
                Return
            End If
      
          ' Improve performance by prefetching display as records.
          Me.PreFetchForeignKeyValues()
             
            ' Setup the pagination controls.
            BindPaginationControls()

            ' Call the Set methods for each controls on the panel
        
            SetamountLabel()
            Setid_itemLabel1()
            Setitem_descriptionLabel()
            SetqtyLabel()
            SetrateLabel()
            SetuomLabel()
      
  

            ' Bind the repeater with the list of records to expand the UI.
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Pro_inv_itemsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return
            rep.DataSource = DataSource()
            rep.DataBind()

            Dim index As Integer = 0
            For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
                ' Loop through all rows in the table, set its DataSource and call DataBind().
                Dim recControl As Pro_inv_itemsTableControlRow = DirectCast(repItem.FindControl("Pro_inv_itemsTableControlRow"), Pro_inv_itemsTableControlRow) 
                recControl.DataSource = Me.DataSource(index)
                If Me.UIData.Count > index Then
                    recControl.PreviousUIData = Me.UIData(index)
                End If				
                recControl.DataBind()
                recControl.Visible = Not Me.InDeletedRecordIds(recControl)
                index += 1
            Next

        
            ' setting the state of expand or collapse alternative rows
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                

            ' Initialize other asp controls
            
            SetamountLabel()
            Setid_itemLabel1()
            Setitem_descriptionLabel()
            SetqtyLabel()
            SetrateLabel()
            SetuomLabel()
      End Sub

      
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(Pro_inv_itemsTable.id_item, Me.DataSource)
          
          End Sub
        
      
        Public Overridable Sub RegisterPostback()
        
        
        End Sub
        
        Public Overridable Function EvaluateFormula(ByVal formula As String, Optional ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord = Nothing, Optional ByVal format as String = Nothing) As String
            Dim e As FormulaEvaluator = New FormulaEvaluator()

            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing Then
                Return ""
            End If
            
            If format IsNot Nothing Then
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function			

        Public Overridable Sub ResetControl()
                    
            Me.CurrentSortOrder.Reset()
            If (Me.InSession(Me, "Order_By")) Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(true, true)
            
            End If
                
            Me.PageIndex = 0
        End Sub

        Protected Overridable Sub BindPaginationControls()
            ' Setup the pagination controls.

            ' Bind the buttons for Pro_inv_itemsTableControl pagination.
        
            Me.Pro_inv_itemsPagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            Me.Pro_inv_itemsPagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.Pro_inv_itemsPagination.LastPage.Enabled = False
            End If
          
            Me.Pro_inv_itemsPagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.Pro_inv_itemsPagination.NextPage.Enabled = False
            End If
          
            Me.Pro_inv_itemsPagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)

            ' Bind the pagination labels.
        
            If Me.TotalPages > 0 Then
                Me.Pro_inv_itemsPagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Pro_inv_itemsPagination.CurrentPage.Text = "0"
            End If
            Me.Pro_inv_itemsPagination.PageSize.Text = Me.PageSize.ToString()
            Me.Pro_inv_itemsPagination.TotalItems.Text = Me.TotalRecords.ToString()
            Me.Pro_inv_itemsPagination.TotalPages.Text = Me.TotalPages.ToString()
        End Sub

        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As Pro_inv_itemsTableControlRow
            For Each recCtl In Me.GetRecordControls()
        
                If Me.InDeletedRecordIds(recCtl) Then
                    ' Delete any pending deletes. 
                    recCtl.Delete()
                Else
                    If recCtl.Visible Then
                        recCtl.SaveData()
                    End If
                End If
          
            Next
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
          
            ' Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            For Each recCtl In Me.GetRecordControls()
                recCtl.IsNewRecord = False
            Next
    
      
            ' Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            Me.DeletedRecordIds = Nothing
      
        End Sub

        
          Public Overridable Function CreateOrderBy() As OrderBy
          ' The CurrentSortOrder is initialized to the sort order on the
          ' Query Wizard.  It may be modified by the Click handler for any of
          ' the column heading to sort or reverse sort by that column.
          ' You can add your own sort order, or modify it on the Query Wizard.
          Return Me.CurrentSortOrder
          End Function
      
        Public Overridable Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            Pro_inv_itemsTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
              
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
              Dim pro_inv_hdrRecordControlObj As Pro_inv_hdrRecordControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Pro_inv_hdrRecordControl"), Pro_inv_hdrRecordControl)
              
                If (Not IsNothing(pro_inv_hdrRecordControlObj) AndAlso Not IsNothing(pro_inv_hdrRecordControlObj.GetRecord()) AndAlso Not IsNothing(pro_inv_hdrRecordControlObj.GetRecord().id0))
                    wc.iAND(Pro_inv_itemsTable.id_pro_inv_hdr, BaseFilter.ComparisonOperator.EqualsTo, pro_inv_hdrRecordControlObj.GetRecord().id0.ToString())
                    selectedRecordKeyValue.AddElement(Pro_inv_itemsTable.id_pro_inv_hdr.InternalName, pro_inv_hdrRecordControlObj.GetRecord().id0.ToString())
                Else
                    wc.RunQuery = False
                    Return wc
                End If
              
      HttpContext.Current.Session("Pro_inv_itemsTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
    
            Return wc
        End Function
        
    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Pro_inv_itemsTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.
            
            Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
            
            Dim selectedRecordInPro_inv_hdrRecordControl as String = DirectCast(HttpContext.Current.Session("Pro_inv_itemsTableControlWhereClause"), String)
            
            If Not selectedRecordInPro_inv_hdrRecordControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInPro_inv_hdrRecordControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInPro_inv_hdrRecordControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(Pro_inv_itemsTable.id_pro_inv_hdr) Then
            wc.iAND(Pro_inv_itemsTable.id_pro_inv_hdr, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(Pro_inv_itemsTable.id_pro_inv_hdr).ToString())
       End If
      
            End If
          
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            Return wc
        End Function
          
          
        Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                                 ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                                 ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                                 ByVal resultList As ArrayList) As Boolean
                                                 
            'Formats the resultItem and adds it to the list of suggestions.
            Dim index As Integer = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))
            Dim itemToAdd As String = ""
            Dim isFound As Boolean = False
            Dim isAdded As Boolean = False
            ' Get the index where prfixt is at the beginning of resultItem. If not found then, index of word which begins with prefixText.
            If InvariantLCase(autoTypeAheadSearch).equals("wordsstartingwithsearchstring") And Not index = 0 Then
                ' Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                Dim regex1 As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                If regex1.IsMatch(resultItem) Then
                    index = regex1.Match(resultItem).Index
                    isFound = True
                End If
                ' If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                If not resultItem(index).ToString() = " " Then
                    ' Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    Dim regex As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    If regex.IsMatch(resultItem) Then
                        index = regex.Match(resultItem).Index
                        isFound = True
                    End If
                 End If
            End If
            
            ' If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            ' beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            If index = 0 Or isFound Or InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") then
                If InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atbeginningofmatchedstring") Then
                    ' Expression to find beginning of the word which contains prefixText
                    Dim regex1 As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    '  Find the beginning of the word which contains prefexText
                    If (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") AndAlso regex1.IsMatch(resultItem)) Then
                        index = regex1.Match(resultItem).Index
                        isFound = True
                    End If
                    ' Display string from the index till end of the string if sub string from index till end is less than columnLength value.
                    If Len(resultItem) - index <= columnLength Then
                        If index = 0 Then 
                            itemToAdd = resultItem 
                        Else
                            itemToAdd = "..." & resultItem.Substring(index, Len(resultItem) - index) 
                        End If
                    Else
                        If index = 0 Then
                            itemToAdd = resultItem.Substring(index, (columnLength - 3)) & "..."
                        Else
                            'Truncate the string to show only columnLength - 6 characters as begining and trailing "..." has to be appended.
                            itemToAdd = "..." & resultItem.Substring(index , columnLength - 6) & "..." 
                        End If
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("inmiddleofmatchedstring") Then
                    Dim subStringBeginIndex As Integer = CType(columnLength/2, Integer)
                    If Len(resultItem) <= columnLength Then
                        itemToAdd = resultItem
                    Else
                        ' Sanity check at end of the string
                        If index + Len(prefixText) = columnLength Then
                            itemToAdd =  "..." & resultItem.Substring(index-columnLength,index)
                        ElseIf Len(resultItem) - index < subStringBeginIndex Then 
                            ' Display string from the end till columnLength value if, index is closer to the end of the string.
                            itemToAdd =  "..." & resultItem.Substring(Len(resultItem)-columnLength,Len(resultItem))
                        ElseIf index <= subStringBeginIndex Then 
                            ' Sanity chet at beginning of the string
                            itemToAdd =  resultItem.Substring(0, columnLength) & "..."
                        Else
                            ' Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd =  "..." & resultItem.Substring(index - subStringBeginIndex, columnLength) & "..." 
                        End If
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atendofmatchedstring") Then
                     ' Expression to find ending of the word which contains prefexText
                    Dim regex1 As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex("\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    ' Find the ending of the word which contains prefexText
                    If regex1.IsMatch(resultItem, index + 1) Then
                        index = regex1.Match(resultItem, index + 1).Index
                    Else
                        ' If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length
                    End If
                    If index > Len(resultItem) Then
                        index = Len(resultItem)
                    End If
                    ' If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    If  index <= columnLength Then
                        if index = Len(resultItem) Then   'Make decision to append "..."
                            itemToAdd = resultItem.Substring(0,index)
                        Else
                            itemToAdd = resultItem.Substring(0,index) & "..."
                        End If
                    Else
                        If index = Len(resultItem) Then
                            itemToAdd = "..." & resultItem.Substring(index - (columnLength - 3), (columnLength - 3))
                        Else
                            'Truncate the string to show only columnLength - 6 characters as begining and trailing "..." has to be appended.
                            itemToAdd = "..." & resultItem.Substring(index - (columnLength - 6), columnLength - 6) & "..." 
                        End If
                    End If
                End If
                
                ' Remove newline character from itemToAdd
                Dim prefixTextIndex As Integer = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase)
                ' If itemToAdd contains any newline after the search text then show text only till newline
                Dim regex2 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                Dim newLineIndexAfterPrefix As Integer = -1
                If regex2.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexAfterPrefix > -1) Then
                    If itemToAdd.EndsWith("...") Then
                        itemToAdd = (itemToAdd.Substring(0, newLineIndexAfterPrefix) + "...")
                    Else
                        itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix)
                    End If
                End If
                ' If itemToAdd contains any newline before search text then show text which comes after newline
                Dim regex3 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", (System.Text.RegularExpressions.RegexOptions.IgnoreCase Or System.Text.RegularExpressions.RegexOptions.RightToLeft))
                Dim newLineIndexBeforePrefix As Integer = -1
                If regex3.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexBeforePrefix > -1) Then
                    If itemToAdd.StartsWith("...") Then
                        itemToAdd = ("..." + itemToAdd.Substring((newLineIndexBeforePrefix + regex3.Match(itemToAdd, prefixTextIndex).Length)))
                    Else
                        itemToAdd = itemToAdd.Substring((newLineIndexBeforePrefix + regex3.Match(itemToAdd, prefixTextIndex).Length))
                    End If
                End If

                If Not itemToAdd is nothing AndAlso Not resultList.Contains(itemToAdd) Then
                    
                    resultList.Add(itemToAdd)
          				
                    isAdded = true
                End If
            End If
            Return isAdded
        End Function
        
    
        Protected Overridable Sub GetPageSize()
        
            If Me.Pro_inv_itemsPagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.Pro_inv_itemsPagination.PageSize.Text)
                Catch ex As Exception
                End Try
            End If
        End Sub

        Protected Overridable Sub AddNewRecords()
            
            Dim newRecordList As ArrayList = New ArrayList()
          
            Dim newUIDataList As System.Collections.Generic.List(Of Hashtable) = New System.Collections.Generic.List(Of Hashtable)()
      
            ' Loop though all the record controls and if the record control
            ' does not have a unique record id set, then create a record
            ' and add to the list.
            If Not Me.ResetData Then
                Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Pro_inv_itemsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
                If rep Is Nothing Then Return

                Dim repItem As System.Web.UI.WebControls.RepeaterItem
                For Each repItem In rep.Items
                    ' Loop through all rows in the table, set its DataSource and call DataBind().
                    Dim recControl As Pro_inv_itemsTableControlRow = DirectCast(repItem.FindControl("Pro_inv_itemsTableControlRow"), Pro_inv_itemsTableControlRow)

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                    
                        Dim rec As Pro_inv_itemsRecord = New Pro_inv_itemsRecord()
        
                        If MiscUtils.IsValueSelected(recControl.id_item) Then
                            rec.Parse(recControl.id_item.SelectedItem.Value, Pro_inv_itemsTable.id_item)
                        End If
                        If recControl.item_code.Text <> "" Then
                            rec.Parse(recControl.item_code.Text, Pro_inv_itemsTable.item_code)
                        End If
                        If recControl.item_description.Text <> "" Then
                            rec.Parse(recControl.item_description.Text, Pro_inv_itemsTable.item_description)
                        End If
                        If recControl.qty.Text <> "" Then
                            rec.Parse(recControl.qty.Text, Pro_inv_itemsTable.qty)
                        End If
                        If recControl.rate.Text <> "" Then
                            rec.Parse(recControl.rate.Text, Pro_inv_itemsTable.rate)
                        End If
                        If recControl.uom.Text <> "" Then
                            rec.Parse(recControl.uom.Text, Pro_inv_itemsTable.uom)
                        End If
                        If recControl.amount.Text <> "" Then
                            rec.Parse(recControl.amount.Text, Pro_inv_itemsTable.amount)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If

            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
            
                newRecordList.Insert(0, New Pro_inv_itemsRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
            
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(Pro_inv_itemsRecord)), Pro_inv_itemsRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As Pro_inv_itemsTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As Pro_inv_itemsTableControlRow) As Boolean
            If Me.DeletedRecordIds Is Nothing OrElse Me.DeletedRecordIds.Trim = "" Then
                Return False
            End If

            Return Me.DeletedRecordIds.IndexOf("[" & rec.RecordUniqueId & "]") >= 0
        End Function

        Private _DeletedRecordIds As String
        Public Property DeletedRecordIds() As String
            Get
                Return Me._DeletedRecordIds
            End Get
            Set(ByVal value As String)
                Me._DeletedRecordIds = value
            End Set
        End Property
        
      
        ' Create Set, WhereClause, and Populate Methods
        
        Public Overridable Sub SetamountLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setid_itemLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setitem_descriptionLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetqtyLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetrateLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetuomLabel()
            
                    
        End Sub
                
        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction
                Me.RegisterPostback()
                
                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    Dim added As Boolean = Me.AddNewRecord > 0
                    Me.LoadData()
                    Me.DataBind()
                    
                    If added Then
                        Me.SetFocusToAddedRow()
                    End If
                    
                End If
                				
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
        End Sub
        
        'this function sets focus to the first editable element in the new added row in the editable table	
        Protected Overridable Sub SetFocusToAddedRow()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Pro_inv_itemsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing OrElse rep.Items.Count = 0 Then Return
            Dim repItem As System.Web.UI.WebControls.RepeaterItem
            For Each repItem In rep.Items  
			    'Load scripts to table rows
                Me.Page.LoadFocusScripts(repItem)
                Dim recControl As Pro_inv_itemsTableControlRow = DirectCast(repItem.FindControl("Pro_inv_itemsTableControlRow"), Pro_inv_itemsTableControlRow)
                If recControl.IsNewRecord Then
                    For Each field As Control In recControl.Controls
                        If field.Visible AndAlso Me.Page.IsControlEditable(field, False) Then
						    'set focus on the first editable field in the new row
						    field.Focus()
                            Dim updPan As UpdatePanel = DirectCast(Me.Page.FindControlRecursively("UpdatePanel1"), UpdatePanel)
                            If Not updPan Is Nothing Then updPan.Update()
                            Return
                        End If
                    Next
                    Return
                End If
            Next
        End Sub
        
        
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()

            ' Save filter controls to values to session.
        
            
            ' Save table control properties to the session.
            If Not Me.CurrentSortOrder Is Nothing Then
            Me.SaveToSession(Me, "Order_By", Me.CurrentSortOrder.ToXmlString())
            End If
            Me.SaveToSession(Me, "Page_Index", Me.PageIndex.ToString())
            Me.SaveToSession(Me, "Page_Size", Me.PageSize.ToString())
        
            Me.SaveToSession(Me, "DeletedRecordIds", Me.DeletedRecordIds)  
        
        End Sub
        
        Protected  Sub SaveControlsToSession_Ajax()
            ' Save filter controls to values to session.
          
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            
            ' Clear table properties from the session.
            Me.RemoveFromSession(Me, "Order_By")
            Me.RemoveFromSession(Me, "Page_Index")
            Me.RemoveFromSession(Me, "Page_Size")
            
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("Pro_inv_itemsTableControl_OrderBy"), String)
            
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            Else
                Me.CurrentSortOrder = New OrderBy(True, True)
            End If
            
            Dim pageIndex As String = CType(ViewState("Page_Index"), String)
            If pageIndex IsNot Nothing Then
                Me.PageIndex = CInt(pageIndex)
            End If

            Dim pageSize As String = CType(ViewState("Page_Size"), String)
            If Not pageSize Is Nothing Then
                Me.PageSize = CInt(pageSize)
            End If
        
            Me.DeletedRecordIds = CType(Me.ViewState("DeletedRecordIds"), String)
        
        End Sub

        Protected Overrides Function SaveViewState() As Object
            
            If Me.CurrentSortOrder IsNot Nothing Then
                Me.ViewState("Pro_inv_itemsTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
        
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
            Return MyBase.SaveViewState()
        End Function

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_itemsPagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            Me.PageIndex = 0
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_itemsPagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            Me.DisplayLastPage = True
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_itemsPagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            Me.PageIndex += 1
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for LinkButton
        Public Overridable Sub Pro_inv_itemsPagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            Try
                
            Me.DataChanged = True
      
            Me.PageSize = Integer.Parse(Me.Pro_inv_itemsPagination.PageSize.Text)
      
            Me.PageIndex = Integer.Parse(Me.Pro_inv_itemsPagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_itemsPagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            If Me.PageIndex > 0 Then
                Me.PageIndex -= 1
                Me.DataChanged = True
            End If
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        

        ' Generate the event handling functions for sorting events.
        
        Public Overridable Sub amountLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by amount when clicked.
              
            ' Get previous sorting state for amount.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_itemsTable.amount)
            If sd Is Nothing Then
                ' First time sort, so add sort order for amount.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_itemsTable.amount, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by amount, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub id_itemLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by id_item when clicked.
              
            ' Get previous sorting state for id_item.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_itemsTable.id_item)
            If sd Is Nothing Then
                ' First time sort, so add sort order for id_item.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_itemsTable.id_item, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by id_item, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub item_descriptionLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by item_description when clicked.
              
            ' Get previous sorting state for item_description.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_itemsTable.item_description)
            If sd Is Nothing Then
                ' First time sort, so add sort order for item_description.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_itemsTable.item_description, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by item_description, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub qtyLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by qty when clicked.
              
            ' Get previous sorting state for qty.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_itemsTable.qty)
            If sd Is Nothing Then
                ' First time sort, so add sort order for qty.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_itemsTable.qty, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by qty, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub rateLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by rate when clicked.
              
            ' Get previous sorting state for rate.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_itemsTable.rate)
            If sd Is Nothing Then
                ' First time sort, so add sort order for rate.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_itemsTable.rate, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by rate, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub uomLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by uom when clicked.
              
            ' Get previous sorting state for uom.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_itemsTable.uom)
            If sd Is Nothing Then
                ' First time sort, so add sort order for uom.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_itemsTable.uom, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by uom, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            

        ' Generate the event handling functions for button events.
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_itemsAddButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            Me.AddNewRecord = 1
            Me.DataChanged = True
      Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_itemsDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            If(Not Me.Page.IsPageRefresh) Then
        
                Me.DeleteSelectedRecords(True)
          
            End If
      Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_itemsResetButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
              Me.CurrentSortOrder.Reset()
              If Me.InSession(Me, "Order_By") Then
                  Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
              Else
                  Me.CurrentSortOrder = New OrderBy(True, True)
              
              End If
              

        ' Setting the DataChanged to True results in the page being refreshed with
        ' the most recent data from the database.  This happens in PreRender event
        ' based on the current sort, search and filter criteria.
        Me.DataChanged = True
            
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
      

        ' Generate the event handling functions for filter and search events.
        
      
        ' Generate the event handling functions for others
        
      
        Private _UIData As New System.Collections.Generic.List(Of Hashtable)
        Public Property UIData() As System.Collections.Generic.List(Of Hashtable)
            Get
                Return Me._UIData
            End Get
            Set(ByVal value As System.Collections.Generic.List(Of Hashtable))
                Me._UIData = value
            End Set
        End Property
        
        ' pagination properties
        Private _PageSize As Integer
        Public Property PageSize() As Integer
            Get
                Return Me._PageSize
            End Get
            Set(ByVal value As Integer)
                Me._PageSize = value
            End Set
        End Property

        Private _PageIndex As Integer
        Public Property PageIndex() As Integer
            Get
                ' Return the PageIndex
                Return Me._PageIndex
            End Get
            Set(ByVal value As Integer)
                Me._PageIndex = value
            End Set
        End Property

        Private _TotalRecords As Integer
        Public Property TotalRecords() As Integer
            Get
                Return Me._TotalRecords
            End Get
            Set(ByVal value As Integer)
                If Me.PageSize > 0 Then
                    Me.TotalPages = CInt(Math.Ceiling(value / Me.PageSize))
                End If
                Me._TotalRecords = value
            End Set
        End Property

        Private _TotalPages As Integer
        Public Property TotalPages() As Integer
            Get
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property

        Private _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property

        Private _DataChanged As Boolean = False
        Public Property DataChanged() As Boolean
            Get
                Return Me._DataChanged
            End Get
            Set(ByVal value As Boolean)
                Me._DataChanged = value
            End Set
        End Property
        
        Private _ResetData As Boolean = False
        Public Property ResetData() As Boolean
            Get
                Return Me._ResetData
            End Get
            Set(ByVal value As Boolean)
                Me._ResetData = value
            End Set
        End Property

        Private _AddNewRecord As Integer = 0
        Public Property AddNewRecord() As Integer
            Get
                Return Me._AddNewRecord
            End Get
            Set(ByVal value As Integer)
                Me._AddNewRecord = value
            End Set
        End Property

        
        Private _CurrentSortOrder As OrderBy = Nothing
        Public Property CurrentSortOrder() As OrderBy
            Get
                Return Me._CurrentSortOrder
            End Get
            Set(ByVal value As BaseClasses.Data.OrderBy)
                Me._CurrentSortOrder = value
            End Set
        End Property
        
        Private _DataSource() As Pro_inv_itemsRecord = Nothing
        Public Property DataSource() As Pro_inv_itemsRecord ()
            Get
                Return Me._DataSource
            End Get
            Set(ByVal value() As Pro_inv_itemsRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property amountLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "amountLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property id_itemLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_itemLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property item_descriptionLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "item_descriptionLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_itemsAddButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_itemsAddButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_itemsDeleteButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_itemsDeleteButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_itemsPagination() As ServelInvocing.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_itemsPagination"), ServelInvocing.UI.IPagination)
          End Get
          End Property
        
        Public ReadOnly Property Pro_inv_itemsResetButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_itemsResetButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_itemsToggleAll() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_itemsToggleAll"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
        
        Public ReadOnly Property qtyLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "qtyLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property rateLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "rateLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property uomLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "uomLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"
        
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
      
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As Pro_inv_itemsTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
                End If
                Dim rec As Pro_inv_itemsRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
          
        Public Overridable Function GetSelectedRecordIndex() As Integer
            Dim counter As Integer = 0
            Dim recControl As Pro_inv_itemsTableControlRow
            For Each recControl In Me.GetRecordControls()
                If recControl.Pro_inv_itemsRecordRowSelection.Checked Then
                    Return counter
                End If
                counter += 1
            Next
            Return -1
        End Function
        
        Public Overridable Function GetSelectedRecordControl() As Pro_inv_itemsTableControlRow
            Dim selectedList() As Pro_inv_itemsTableControlRow = Me.GetSelectedRecordControls()
            If selectedList.Length = 0 Then
                Return Nothing
            End If
            Return selectedList(0)
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As Pro_inv_itemsTableControlRow()
        
            Dim selectedList As ArrayList = New ArrayList(25)
            Dim recControl As Pro_inv_itemsTableControlRow
            For Each recControl In Me.GetRecordControls()
                If recControl.Pro_inv_itemsRecordRowSelection.Checked Then
                    selectedList.Add(recControl)
                End If
            Next
            Return DirectCast(selectedList.ToArray(GetType(Pro_inv_itemsTableControlRow)), Pro_inv_itemsTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As Pro_inv_itemsTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
            End If
            
            Dim recCtl As Pro_inv_itemsTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
                    recCtl.Pro_inv_itemsRecordRowSelection.Checked = False
                
                Else
                
                    recCtl.Delete()
                    
                    ' Setting the DataChanged to True results in the page being refreshed with
                    ' the most recent data from the database.  This happens in PreRender event
                    ' based on the current sort, search and filter criteria.
                    Me.DataChanged = True
                    Me.ResetData = True
                  
                End If
            Next
        End Sub

        Public Function GetRecordControls() As Pro_inv_itemsTableControlRow()
            Dim recList As ArrayList = New ArrayList()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Pro_inv_itemsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return Nothing
            Dim repItem As System.Web.UI.WebControls.RepeaterItem

            For Each repItem In rep.Items
                Dim recControl As Pro_inv_itemsTableControlRow = DirectCast(repItem.FindControl("Pro_inv_itemsTableControlRow"), Pro_inv_itemsTableControlRow)
                recList.Add(recControl)
            Next

            Return DirectCast(recList.ToArray(GetType(Pro_inv_itemsTableControlRow)), Pro_inv_itemsTableControlRow())
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

    

End Class

  
' Base class for the Pro_inv_taxesTableControlRow control on the AddPro_inv_hdr page.
' Do not modify this class. Instead override any method in Pro_inv_taxesTableControlRow.
Public Class BasePro_inv_taxesTableControlRow
        Inherits ServelInvocing.UI.BaseApplicationRecordControl

        '  To customize, override this method in Pro_inv_taxesTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
        End Sub

        '  To customize, override this method in Pro_inv_taxesTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
			'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
			Me.Page.LoadFocusScripts(Me)
		
              ' Show confirmation message on Click
              Me.Pro_inv_taxesRowDeleteButton.Attributes.Add("onClick", "return (confirm('" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteRecordConfirm", "ServelInvocing") & "'));")
              ' Register the event handlers.
          
              AddHandler Me.Pro_inv_taxesRowDeleteButton.Click, AddressOf Pro_inv_taxesRowDeleteButton_Click
              
              AddHandler Me.id_taxes.SelectedIndexChanged, AddressOf id_taxes_SelectedIndexChanged
            
              AddHandler Me.tax_lock.CheckedChanged, AddressOf tax_lock_CheckedChanged
            
              AddHandler Me.calc_type.TextChanged, AddressOf calc_type_TextChanged
            
              AddHandler Me.excise_total.TextChanged, AddressOf excise_total_TextChanged
            
              AddHandler Me.grand_total1.TextChanged, AddressOf grand_total1_TextChanged
            
              AddHandler Me.item_total1.TextChanged, AddressOf item_total1_TextChanged
            
              AddHandler Me.sort_order1.TextChanged, AddressOf sort_order1_TextChanged
            
              AddHandler Me.tax_amount.TextChanged, AddressOf tax_amount_TextChanged
            
              AddHandler Me.tax_code.TextChanged, AddressOf tax_code_TextChanged
            
              AddHandler Me.tax_name.TextChanged, AddressOf tax_name_TextChanged
            
              AddHandler Me.tax_on.TextChanged, AddressOf tax_on_TextChanged
            
              AddHandler Me.tax_print.TextChanged, AddressOf tax_print_TextChanged
            
              AddHandler Me.tax_rate.TextChanged, AddressOf tax_rate_TextChanged
            
              AddHandler Me.tax_type.TextChanged, AddressOf tax_type_TextChanged
            
        End Sub

        
        Public Overridable Sub LoadData()        
            ' Load the data from the database into the DataSource pro_inv_taxes record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = Pro_inv_taxesTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BasePro_inv_taxesTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New Pro_inv_taxesRecord()
          
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Pro_inv_taxesTableControlRow.
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record.  To do this, it calls the Set methods for 
            ' each of the field displayed on the webpage.  It is better to make 
            ' changes in the Set methods, rather than making changes here.
            
            MyBase.DataBind()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
                Return
            End If
        
      
      
            ' Call the Set methods for each controls on the panel
        
            Setcalc_type()
            Setexcise_total()
            Setgrand_total1()
            Setid_taxes()
            Setitem_total1()
            Setsort_order1()
            Settax_amount()
            Settax_code()
                        Settax_lock()
                    
            Settax_name()
            Settax_on()
            Settax_print()
            Settax_rate()
            Settax_type()
      
      
            Me.IsNewRecord = True
            
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
                
                Me.RecordUniqueId = Me.DataSource.GetID.ToXmlString()
            End If
          
            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False
                  
        End Sub
        
        
        Public Overridable Sub Setcalc_type()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.calc_type.ID) Then
            
                Me.calc_type.Text = Me.PreviousUIData(Me.calc_type.ID).ToString()
              
                Return
            End If
            
        
            ' Set the calc_type TextBox on the webpage with value from the
            ' pro_inv_taxes database record.

            ' Me.DataSource is the pro_inv_taxes record retrieved from the database.
            ' Me.calc_type is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcalc_type()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.calc_typeSpecified Then
                				
                ' If the calc_type is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_taxesTable.calc_type)
                            
                Me.calc_type.Text = formattedValue
              
            Else 
            
                ' calc_type is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.calc_type.Text = Pro_inv_taxesTable.calc_type.Format(Pro_inv_taxesTable.calc_type.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setexcise_total()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.excise_total.ID) Then
            
                Me.excise_total.Text = Me.PreviousUIData(Me.excise_total.ID).ToString()
              
                Return
            End If
            
        
            ' Set the excise_total TextBox on the webpage with value from the
            ' pro_inv_taxes database record.

            ' Me.DataSource is the pro_inv_taxes record retrieved from the database.
            ' Me.excise_total is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setexcise_total()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.excise_totalSpecified Then
                				
                ' If the excise_total is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_taxesTable.excise_total)
                            
                Me.excise_total.Text = formattedValue
              
            Else 
            
                ' excise_total is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.excise_total.Text = Pro_inv_taxesTable.excise_total.Format(Pro_inv_taxesTable.excise_total.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setgrand_total1()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.grand_total1.ID) Then
            
                Me.grand_total1.Text = Me.PreviousUIData(Me.grand_total1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the grand_total TextBox on the webpage with value from the
            ' pro_inv_taxes database record.

            ' Me.DataSource is the pro_inv_taxes record retrieved from the database.
            ' Me.grand_total1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setgrand_total1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.grand_totalSpecified Then
                				
                ' If the grand_total is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_taxesTable.grand_total)
                            
                Me.grand_total1.Text = formattedValue
              
            Else 
            
                ' grand_total is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.grand_total1.Text = Pro_inv_taxesTable.grand_total.Format(Pro_inv_taxesTable.grand_total.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setid_taxes()
            							
            ' If selection was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.id_taxes.ID) Then
                If Me.PreviousUIData(Me.id_taxes.ID) Is Nothing
                    Me.Populateid_taxesDropDownList(Nothing, 100)
                Else
                    Me.Populateid_taxesDropDownList(Me.PreviousUIData(Me.id_taxes.ID).ToString(), 100)
                End If
                Return
            End If
            
        
            ' Set the id_taxes DropDownList on the webpage with value from the
            ' pro_inv_taxes database record.
            
            ' Me.DataSource is the pro_inv_taxes record retrieved from the database.
            ' Me.id_taxes is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_taxes()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_taxesSpecified Then
                            
                ' If the id_taxes is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.Populateid_taxesDropDownList(Me.DataSource.id_taxes.ToString(), 100)
                
            Else
                
                ' id_taxes is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.Populateid_taxesDropDownList(Nothing, 100)
                Else
                    Me.Populateid_taxesDropDownList(Pro_inv_taxesTable.id_taxes.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub Setitem_total1()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.item_total1.ID) Then
            
                Me.item_total1.Text = Me.PreviousUIData(Me.item_total1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the item_total TextBox on the webpage with value from the
            ' pro_inv_taxes database record.

            ' Me.DataSource is the pro_inv_taxes record retrieved from the database.
            ' Me.item_total1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setitem_total1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.item_totalSpecified Then
                				
                ' If the item_total is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_taxesTable.item_total)
                            
                Me.item_total1.Text = formattedValue
              
            Else 
            
                ' item_total is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.item_total1.Text = Pro_inv_taxesTable.item_total.Format(Pro_inv_taxesTable.item_total.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setsort_order1()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.sort_order1.ID) Then
            
                Me.sort_order1.Text = Me.PreviousUIData(Me.sort_order1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the sort_order TextBox on the webpage with value from the
            ' pro_inv_taxes database record.

            ' Me.DataSource is the pro_inv_taxes record retrieved from the database.
            ' Me.sort_order1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setsort_order1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.sort_orderSpecified Then
                				
                ' If the sort_order is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_taxesTable.sort_order)
                            
                Me.sort_order1.Text = formattedValue
              
            Else 
            
                ' sort_order is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.sort_order1.Text = Pro_inv_taxesTable.sort_order.Format(Pro_inv_taxesTable.sort_order.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Settax_amount()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.tax_amount.ID) Then
            
                Me.tax_amount.Text = Me.PreviousUIData(Me.tax_amount.ID).ToString()
              
                Return
            End If
            
        
            ' Set the tax_amount TextBox on the webpage with value from the
            ' pro_inv_taxes database record.

            ' Me.DataSource is the pro_inv_taxes record retrieved from the database.
            ' Me.tax_amount is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settax_amount()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tax_amountSpecified Then
                				
                ' If the tax_amount is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_taxesTable.tax_amount)
                            
                Me.tax_amount.Text = formattedValue
              
            Else 
            
                ' tax_amount is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tax_amount.Text = Pro_inv_taxesTable.tax_amount.Format(Pro_inv_taxesTable.tax_amount.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Settax_code()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.tax_code.ID) Then
            
                Me.tax_code.Text = Me.PreviousUIData(Me.tax_code.ID).ToString()
              
                Return
            End If
            
        
            ' Set the tax_code TextBox on the webpage with value from the
            ' pro_inv_taxes database record.

            ' Me.DataSource is the pro_inv_taxes record retrieved from the database.
            ' Me.tax_code is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settax_code()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tax_codeSpecified Then
                				
                ' If the tax_code is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_taxesTable.tax_code)
                            
                Me.tax_code.Text = formattedValue
              
            Else 
            
                ' tax_code is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tax_code.Text = Pro_inv_taxesTable.tax_code.Format(Pro_inv_taxesTable.tax_code.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Settax_lock()
            							
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.tax_lock.ID) Then
                Me.tax_lock.Checked = Convert.ToBoolean(Me.PreviousUIData(Me.tax_lock.ID))
                Return
            End If		
            
        
            ' Set the tax_lock CheckBox on the webpage with value from the
            ' pro_inv_taxes database record.

            ' Me.DataSource is the pro_inv_taxes record retrieved from the database.
            ' Me.tax_lock is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.Settax_lock()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tax_lockSpecified Then
                									
                ' If the tax_lock is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.tax_lock.Checked = Me.DataSource.tax_lock
            Else
            
                ' tax_lock is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.tax_lock.Checked = Pro_inv_taxesTable.tax_lock.ParseValue(Pro_inv_taxesTable.tax_lock.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub Settax_name()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.tax_name.ID) Then
            
                Me.tax_name.Text = Me.PreviousUIData(Me.tax_name.ID).ToString()
              
                Return
            End If
            
        
            ' Set the tax_name TextBox on the webpage with value from the
            ' pro_inv_taxes database record.

            ' Me.DataSource is the pro_inv_taxes record retrieved from the database.
            ' Me.tax_name is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settax_name()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tax_nameSpecified Then
                				
                ' If the tax_name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_taxesTable.tax_name)
                            
                Me.tax_name.Text = formattedValue
              
            Else 
            
                ' tax_name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tax_name.Text = Pro_inv_taxesTable.tax_name.Format(Pro_inv_taxesTable.tax_name.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Settax_on()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.tax_on.ID) Then
            
                Me.tax_on.Text = Me.PreviousUIData(Me.tax_on.ID).ToString()
              
                Return
            End If
            
        
            ' Set the tax_on TextBox on the webpage with value from the
            ' pro_inv_taxes database record.

            ' Me.DataSource is the pro_inv_taxes record retrieved from the database.
            ' Me.tax_on is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settax_on()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tax_onSpecified Then
                				
                ' If the tax_on is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_taxesTable.tax_on)
                            
                Me.tax_on.Text = formattedValue
              
            Else 
            
                ' tax_on is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tax_on.Text = Pro_inv_taxesTable.tax_on.Format(Pro_inv_taxesTable.tax_on.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Settax_print()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.tax_print.ID) Then
            
                Me.tax_print.Text = Me.PreviousUIData(Me.tax_print.ID).ToString()
              
                Return
            End If
            
        
            ' Set the tax_print TextBox on the webpage with value from the
            ' pro_inv_taxes database record.

            ' Me.DataSource is the pro_inv_taxes record retrieved from the database.
            ' Me.tax_print is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settax_print()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tax_printSpecified Then
                				
                ' If the tax_print is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_taxesTable.tax_print)
                            
                Me.tax_print.Text = formattedValue
              
            Else 
            
                ' tax_print is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tax_print.Text = Pro_inv_taxesTable.tax_print.Format(Pro_inv_taxesTable.tax_print.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Settax_rate()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.tax_rate.ID) Then
            
                Me.tax_rate.Text = Me.PreviousUIData(Me.tax_rate.ID).ToString()
              
                Return
            End If
            
        
            ' Set the tax_rate TextBox on the webpage with value from the
            ' pro_inv_taxes database record.

            ' Me.DataSource is the pro_inv_taxes record retrieved from the database.
            ' Me.tax_rate is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settax_rate()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tax_rateSpecified Then
                				
                ' If the tax_rate is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_taxesTable.tax_rate)
                            
                Me.tax_rate.Text = formattedValue
              
            Else 
            
                ' tax_rate is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tax_rate.Text = Pro_inv_taxesTable.tax_rate.Format(Pro_inv_taxesTable.tax_rate.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Settax_type()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.tax_type.ID) Then
            
                Me.tax_type.Text = Me.PreviousUIData(Me.tax_type.ID).ToString()
              
                Return
            End If
            
        
            ' Set the tax_type TextBox on the webpage with value from the
            ' pro_inv_taxes database record.

            ' Me.DataSource is the pro_inv_taxes record retrieved from the database.
            ' Me.tax_type is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settax_type()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tax_typeSpecified Then
                				
                ' If the tax_type is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_taxesTable.tax_type)
                            
                Me.tax_type.Text = formattedValue
              
            Else 
            
                ' tax_type is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tax_type.Text = Pro_inv_taxesTable.tax_type.Format(Pro_inv_taxesTable.tax_type.DefaultValue)
                        		
                End If
                 
        End Sub
                
      
        Public Overridable Function EvaluateFormula(ByVal formula As String, Optional ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord = Nothing, Optional ByVal format as String = Nothing) As String
            Dim e As FormulaEvaluator = New FormulaEvaluator()

            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            If dataSourceForEvaluate Is Nothing Then
                
                e.DataSource = Me.DataSource
                
            Else
                e.DataSource = dataSourceForEvaluate
            End If

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing
                Return ""
            End If
            
            If format IsNot Nothing
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function	  
      

        Public Overridable Sub RegisterPostback()
        
        
        End Sub

      
        
        ' To customize, override this method in Pro_inv_taxesTableControlRow.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
        Dim parentCtrl As Pro_inv_hdrRecordControl
          
          
          parentCtrl = DirectCast(Me.Page.FindControlRecursively("Pro_inv_hdrRecordControl"), Pro_inv_hdrRecordControl)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ServelInvocing"))
            End If
            
            Me.DataSource.id_pro_inv_hdr = parentCtrl.DataSource.id0
              
            ' 2. Perform any custom validation.
            Me.Validate()

            
            ' 3. Set the values in the record with data from UI controls.
            ' This calls the Get() method for each of the user interface controls.
            Me.GetUIData()

            ' 4. Save in the database.
            ' We should not save the record if the data did not change. This
            ' will save a database hit and avoid triggering any database triggers.
             
            If Me.DataSource.IsAnyValueChanged Then
                ' Save record to database but do not commit yet.
                ' Auto generated ids are available after saving for use by child (dependent) records.
                Me.DataSource.Save()
              
                DirectCast(GetParentControlObject(Me, "Pro_inv_taxesTableControl"), Pro_inv_taxesTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "Pro_inv_taxesTableControl"), Pro_inv_taxesTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in Pro_inv_taxesTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
            
      
            ' Call the Get methods for each of the user interface controls.
        
            Getcalc_type()
            Getexcise_total()
            Getgrand_total1()
            Getid_taxes()
            Getitem_total1()
            Getsort_order1()
            Gettax_amount()
            Gettax_code()
            Gettax_lock()
            Gettax_name()
            Gettax_on()
            Gettax_print()
            Gettax_rate()
            Gettax_type()
        End Sub
        
        
        Public Overridable Sub Getcalc_type()
            
            ' Retrieve the value entered by the user on the calc_type ASP:TextBox, and
            ' save it into the calc_type field in DataSource pro_inv_taxes record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.calc_type.Text, Pro_inv_taxesTable.calc_type)			

                      
        End Sub
                
        Public Overridable Sub Getexcise_total()
            
            ' Retrieve the value entered by the user on the excise_total ASP:TextBox, and
            ' save it into the excise_total field in DataSource pro_inv_taxes record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.excise_total.Text, Pro_inv_taxesTable.excise_total)			

                      
        End Sub
                
        Public Overridable Sub Getgrand_total1()
            
            ' Retrieve the value entered by the user on the grand_total ASP:TextBox, and
            ' save it into the grand_total field in DataSource pro_inv_taxes record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.grand_total1.Text, Pro_inv_taxesTable.grand_total)			

                      
        End Sub
                
        Public Overridable Sub Getid_taxes()
         
            ' Retrieve the value entered by the user on the id_taxes ASP:DropDownList, and
            ' save it into the id_taxes field in DataSource pro_inv_taxes record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.id_taxes), Pro_inv_taxesTable.id_taxes)				
            
        End Sub
                
        Public Overridable Sub Getitem_total1()
            
            ' Retrieve the value entered by the user on the item_total ASP:TextBox, and
            ' save it into the item_total field in DataSource pro_inv_taxes record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.item_total1.Text, Pro_inv_taxesTable.item_total)			

                      
        End Sub
                
        Public Overridable Sub Getsort_order1()
            
            ' Retrieve the value entered by the user on the sort_order ASP:TextBox, and
            ' save it into the sort_order field in DataSource pro_inv_taxes record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.sort_order1.Text, Pro_inv_taxesTable.sort_order)			

                      
        End Sub
                
        Public Overridable Sub Gettax_amount()
            
            ' Retrieve the value entered by the user on the tax_amount ASP:TextBox, and
            ' save it into the tax_amount field in DataSource pro_inv_taxes record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.tax_amount.Text, Pro_inv_taxesTable.tax_amount)			

                      
        End Sub
                
        Public Overridable Sub Gettax_code()
            
            ' Retrieve the value entered by the user on the tax_code ASP:TextBox, and
            ' save it into the tax_code field in DataSource pro_inv_taxes record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.tax_code.Text, Pro_inv_taxesTable.tax_code)			

                      
        End Sub
                
        Public Overridable Sub Gettax_lock()
        
        
            ' Retrieve the value entered by the user on the tax_lock ASP:CheckBox, and
            ' save it into the tax_lock field in DataSource pro_inv_taxes record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.tax_lock = Me.tax_lock.Checked
                    
        End Sub
                
        Public Overridable Sub Gettax_name()
            
            ' Retrieve the value entered by the user on the tax_name ASP:TextBox, and
            ' save it into the tax_name field in DataSource pro_inv_taxes record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.tax_name.Text, Pro_inv_taxesTable.tax_name)			

                      
        End Sub
                
        Public Overridable Sub Gettax_on()
            
            ' Retrieve the value entered by the user on the tax_on ASP:TextBox, and
            ' save it into the tax_on field in DataSource pro_inv_taxes record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.tax_on.Text, Pro_inv_taxesTable.tax_on)			

                      
        End Sub
                
        Public Overridable Sub Gettax_print()
            
            ' Retrieve the value entered by the user on the tax_print ASP:TextBox, and
            ' save it into the tax_print field in DataSource pro_inv_taxes record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.tax_print.Text, Pro_inv_taxesTable.tax_print)			

                      
        End Sub
                
        Public Overridable Sub Gettax_rate()
            
            ' Retrieve the value entered by the user on the tax_rate ASP:TextBox, and
            ' save it into the tax_rate field in DataSource pro_inv_taxes record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.tax_rate.Text, Pro_inv_taxesTable.tax_rate)			

                      
        End Sub
                
        Public Overridable Sub Gettax_type()
            
            ' Retrieve the value entered by the user on the tax_type ASP:TextBox, and
            ' save it into the tax_type field in DataSource pro_inv_taxes record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.tax_type.Text, Pro_inv_taxesTable.tax_type)			

                      
        End Sub
                
      
        ' To customize, override this method in Pro_inv_taxesTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
            Return Nothing
            
        End Function
        

        ' To customize, override this method in Pro_inv_taxesTableControlRow.
        Public Overridable Sub Validate() 
            ' Add custom validation for any control within this panel.
            ' Example.  If you have a State ASP:Textbox control
            ' If Me.State.Text <> "CA" Then
            '    Throw New Exception("State must be CA (California).")
            ' End If

            ' The Validate method is common across all controls within
            ' this panel so you can validate multiple fields, but report
            ' one error message.
            
                
        End Sub

        Public Overridable Sub Delete()
        
            If Me.IsNewRecord() Then
                Return
            End If

            Dim pkValue As KeyValue = KeyValue.XmlToKey(Me.RecordUniqueId)
          Pro_inv_taxesTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "Pro_inv_taxesTableControl"), Pro_inv_taxesTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "Pro_inv_taxesTableControl"), Pro_inv_taxesTableControl).ResetData = True
        End Sub

        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction()
                Me.RegisterPostback()

                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    Me.LoadData()
                    Me.DataBind()			
                End If
                						
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction()
            End Try
        End Sub
        
        

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)
            Dim isNewRecord As String = CType(ViewState("IsNewRecord"), String)
            If Not isNewRecord Is Nothing AndAlso isNewRecord.Trim <> "" Then
                Me.IsNewRecord = Boolean.Parse(isNewRecord)
            End If
            
            Dim myCheckSum As String = CType(ViewState("CheckSum"), String)
            If Not myCheckSum Is Nothing AndAlso myCheckSum.Trim <> "" Then
                Me.CheckSum = myCheckSum
            End If
            
        End Sub

        Protected Overrides Function SaveViewState() As Object
            ViewState("IsNewRecord") = Me.IsNewRecord.ToString()
            ViewState("CheckSum") = Me.CheckSum
            
            Return MyBase.SaveViewState()
        End Function
        
        

        Public Overridable Function CreateWhereClause_id_taxesDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the taxes table.
            ' Examples:
            ' wc.iAND(TaxesTable.tax_name, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(TaxesTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
        
                
        ' Fill the id_taxes list.
        Protected Overridable Sub Populateid_taxesDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.id_taxes.Items.Clear()
            
            ' This is a four step process.
            ' 1. Setup the static list items
            ' 2. Set up the WHERE and the ORDER BY clause
            ' 3. Read a total of maxItems from the database and insert them
            ' 4. Set the selected value (insert if not already present).
                    
            ' 1. Setup the static list items
            														
            Me.id_taxes.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))							
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_id_taxesDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_id_taxesDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                
      
      
            Dim orderBy As OrderBy = New OrderBy(false, true)			
        
            orderBy.Add(TaxesTable.tax_name, OrderByItem.OrderDir.Asc)				
            
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As TaxesRecord = Nothing
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Do
                    itemValues = TaxesTable.GetRecords(wc, orderBy, pageNum, 500)
                    For each itemValue As TaxesRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.id0Specified Then
                            cvalue = itemValue.id0.ToString()
                            fvalue = itemValue.Format(TaxesTable.tax_name)
                                    
                            If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                            Dim newItem As New ListItem(fvalue, cvalue)
                            If counter < maxItems AndAlso Not Me.id_taxes.Items.Contains(newItem) Then Me.id_taxes.Items.Add(newItem)
                            counter += 1
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_taxes, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_taxes, selectedValue)Then

                ' construct a whereclause to query a record with taxes.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(TaxesTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As TaxesRecord = TaxesTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = Pro_inv_taxesTable.id_taxes.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_taxes.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_taxesRowDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            If(Not Me.Page.IsPageRefresh) Then
        
                Dim tc As Pro_inv_taxesTableControl = DirectCast(GetParentControlObject(Me, "Pro_inv_taxesTableControl"), Pro_inv_taxesTableControl)
                If Not (IsNothing(tc)) Then
                    
                    Me.Visible = False
                End If
              
            End If
      Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
                  
        End Sub
        
        Protected Overridable Sub id_taxes_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
            ' If a large list selector or a Quick Add link is used, the dropdown list
            ' will contain an item that was not in the original (smaller) list.  During postbacks,
            ' this new item will not be in the list - since the list is based on the original values
            ' read from the database. This function adds the value back if necessary.
            ' In addition, This dropdown can be used on make/model/year style dropdowns.  Make filters the result of Model.
            ' Mode filters the result of Year.  When users change the value of Make, Model and Year are repopulated.
            ' When this function is fire for Make or Model, we don't want the following code executed.
            ' Therefore, we check this situation using Items.Count > 1			
            If Me.id_taxes.Items.Count > 1 Then
                Dim selectedValue As String = MiscUtils.GetValueSelectedPageRequest(Me.id_taxes)
                 
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_taxes, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_taxes, selectedValue)Then

                ' construct a whereclause to query a record with taxes.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(TaxesTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As TaxesRecord = TaxesTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = Pro_inv_taxesTable.id_taxes.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_taxes.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
            End If
          									
                
                
        End Sub
            
        Protected Overridable Sub tax_lock_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub calc_type_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub excise_total_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub grand_total1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub item_total1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub sort_order1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub tax_amount_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub tax_code_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub tax_name_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub tax_on_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub tax_print_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub tax_rate_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub tax_type_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
   
        Private _PreviousUIData As New Hashtable
        Public Overridable Property PreviousUIData() As Hashtable
            Get
                Return _PreviousUIData
            End Get
            Set(ByVal value As Hashtable)
                _PreviousUIData = value
            End Set
        End Property   
   
        Private _IsNewRecord As Boolean = True
        Public Overridable Property IsNewRecord() As Boolean
            Get
                Return Me._IsNewRecord
            End Get
            Set(ByVal value As Boolean)
                Me._IsNewRecord = value
            End Set
        End Property

        Private _DataChanged As Boolean = False
        Public Overridable Property DataChanged() As Boolean
            Get
                Return Me._DataChanged
            End Get
            Set(ByVal Value As Boolean)
                Me._DataChanged = Value
            End Set
        End Property

        Private _ResetData As Boolean = False
        Public Overridable Property ResetData() As Boolean
            Get
                Return Me._ResetData
            End Get
            Set(ByVal Value As Boolean)
                Me._ResetData = Value
            End Set
        End Property
        
        Public Property RecordUniqueId() As String
            Get
                Return CType(Me.ViewState("BasePro_inv_taxesTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BasePro_inv_taxesTableControlRow_Rec") = value
            End Set
        End Property
        
        Private _DataSource As Pro_inv_taxesRecord
        Public Property DataSource() As Pro_inv_taxesRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As Pro_inv_taxesRecord)
            
                Me._DataSource = value
            End Set
        End Property

        

        Private _checkSum As String
        Public Overridable Property CheckSum() As String
            Get
                Return Me._checkSum
            End Get
            Set(ByVal value As String)
                Me._checkSum = value
            End Set
        End Property
        
        Private _TotalPages As Integer
        Public Property TotalPages() As Integer
            Get
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property
        
        Private _PageIndex As Integer
        Public Property PageIndex() As Integer
            Get
                ' Return the PageIndex
                Return Me._PageIndex
            End Get
            Set(ByVal value As Integer)
                Me._PageIndex = value
            End Set
        End Property
    
        Private _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property
        
        

#Region "Helper Properties"
        
        Public ReadOnly Property calc_type() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "calc_type"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property excise_total() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "excise_total"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property grand_total1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "grand_total1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property id_taxes() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxes"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property item_total1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "item_total1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property Pro_inv_taxesRecordRowSelection() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_taxesRecordRowSelection"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_taxesRowDeleteButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_taxesRowDeleteButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property sort_order1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "sort_order1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property tax_amount() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_amount"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property tax_code() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_code"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property tax_lock() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_lock"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property tax_name() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_name"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property tax_on() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_on"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property tax_print() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_print"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property tax_rate() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_rate"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property tax_type() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_type"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As Pro_inv_taxesRecord = Nothing
             
        
            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.
                
            Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ServelInvocing"))
                    
            End If
            Return EvaluateExpressions(url, arg, rec, bEncrypt)
        End Function

         
        Public Overridable Function GetRecord() As Pro_inv_taxesRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return Pro_inv_taxesTable.GetRecord(Me.RecordUniqueId, True)
                
            End If
            
            ' Localization.
            
            Return Nothing
                
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

End Class

  

' Base class for the Pro_inv_taxesTableControl control on the AddPro_inv_hdr page.
' Do not modify this class. Instead override any method in Pro_inv_taxesTableControl.
Public Class BasePro_inv_taxesTableControl
        Inherits ServelInvocing.UI.BaseApplicationTableControl

        

        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      	  	  
      
           ' Setup the filter and search events.
        
      
      
            ' Control Initializations.
            ' Initialize the table's current sort order.
            
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(True, True)
            
                Me.CurrentSortOrder.Add(Pro_inv_taxesTable.sort_order, OrderByItem.OrderDir.Asc)
              
            End If

            ' Setup default pagination settings.
        
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "10"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
            Me.ClearControlsFromSession()
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
              ' Show confirmation message on Click
              Me.Pro_inv_taxesDeleteButton.Attributes.Add("onClick", "return (confirm('" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteConfirm", "ServelInvocing") & "'));")
            ' Setup the pagination events.
            
              AddHandler Me.Pro_inv_taxesPagination.FirstPage.Click, AddressOf Pro_inv_taxesPagination_FirstPage_Click
              
              AddHandler Me.Pro_inv_taxesPagination.LastPage.Click, AddressOf Pro_inv_taxesPagination_LastPage_Click
              
              AddHandler Me.Pro_inv_taxesPagination.NextPage.Click, AddressOf Pro_inv_taxesPagination_NextPage_Click
              
              AddHandler Me.Pro_inv_taxesPagination.PageSizeButton.Click, AddressOf Pro_inv_taxesPagination_PageSizeButton_Click
            
              AddHandler Me.Pro_inv_taxesPagination.PreviousPage.Click, AddressOf Pro_inv_taxesPagination_PreviousPage_Click
              
            ' Setup the sorting events.
          
              AddHandler Me.calc_typeLabel.Click, AddressOf calc_typeLabel_Click
            
              AddHandler Me.id_taxesLabel1.Click, AddressOf id_taxesLabel1_Click
            
              AddHandler Me.sort_orderLabel.Click, AddressOf sort_orderLabel_Click
            
              AddHandler Me.tax_amountLabel.Click, AddressOf tax_amountLabel_Click
            
              AddHandler Me.tax_lockLabel.Click, AddressOf tax_lockLabel_Click
            
              AddHandler Me.tax_onLabel.Click, AddressOf tax_onLabel_Click
            
              AddHandler Me.tax_rateLabel.Click, AddressOf tax_rateLabel_Click
            
            ' Setup the button events.
          
              AddHandler Me.Pro_inv_taxesAddButton.Click, AddressOf Pro_inv_taxesAddButton_Click
              
              AddHandler Me.Pro_inv_taxesDeleteButton.Click, AddressOf Pro_inv_taxesDeleteButton_Click
              
              AddHandler Me.Pro_inv_taxesResetButton.Click, AddressOf Pro_inv_taxesResetButton_Click
              
          ' Setup events for others
            
        End Sub
        
        
        Public Overridable Sub LoadData()
            ' Read data from database. Returns an array of records that can be assigned
            ' to the DataSource table control property.
            Try	
                
                ' The WHERE clause will be empty when displaying all records in table.
                Dim wc As WhereClause = CreateWhereClause()
                If wc IsNot Nothing AndAlso Not wc.RunQuery Then
                    ' Initialize an empty array of records
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Pro_inv_taxesRecord)), Pro_inv_taxesRecord())
                    ' Add records to the list if needed.
                    Me.AddNewRecords()
                    Return
                End If

                ' Call OrderBy to determine the order - either use the order defined
                ' on the Query Wizard, or specified by user (by clicking on column heading)
                Dim orderBy As OrderBy = CreateOrderBy()
                
                ' Get the pagesize from the pagesize control.
                Me.GetPageSize()
                
                ' Get the total number of records to be displayed.
                
                Me.TotalRecords = Pro_inv_taxesTable.GetRecordCount(wc)
                              
                ' Make sure PageIndex (current page) is within bounds.
                If Me.TotalPages <= 0 OrElse Me.PageIndex < 0 Then
                    Me.PageIndex = 0
                ElseIf Me.DisplayLastPage OrElse Me.PageIndex >= Me.TotalPages Then
                    Me.PageIndex = Me.TotalPages - 1
                End If

                ' Retrieve the records and set the table DataSource.
                ' Only PageSize records are fetched starting at PageIndex (zero based).
                If Me.TotalRecords <= 0 Then
                    ' No records matching query. Initialize an empty array of records
                    
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Pro_inv_taxesRecord)), Pro_inv_taxesRecord())
                    
                ElseIf Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                
                    Dim postdata As New ArrayList
                    For Each rc As Pro_inv_taxesTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(Pro_inv_taxesRecord)), Pro_inv_taxesRecord())
                
                Else  ' Get the records from the database	
                    Me.DataSource = Pro_inv_taxesTable.GetRecords(wc, orderBy, Me.PageIndex, Me.PageSize) 
                End If
                
                ' Add any new rows desired by the user.
                Me.AddNewRecords()
            
                ' Turn off the ToggleAll checkbox
                Me.Pro_inv_taxesToggleAll.Checked = False
            

                ' Initialize the page and grand totals. now
            
            Catch ex As Exception
                ' Report the error message to the end user
                Dim msg As String = ex.Message
                If ex.InnerException IsNot Nothing Then
                    msg = msg & " InnerException: " & ex.InnerException.Message
                End If
                Throw New Exception(msg, ex.InnerException)
            End Try
        End Sub
        
        
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record for each row in the table.  To do this, it calls the
            ' DataBind for each of the rows.
            ' DataBind also populates any filters above the table, and sets the pagination
            ' control to the correct number of records and the current page number.
            
            MyBase.DataBind()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
                Return
            End If
      
          ' Improve performance by prefetching display as records.
          Me.PreFetchForeignKeyValues()
             
            ' Setup the pagination controls.
            BindPaginationControls()

            ' Call the Set methods for each controls on the panel
        
            Setcalc_typeLabel()
            Setid_taxesLabel1()
            Setsort_orderLabel()
            Settax_amountLabel()
            Settax_lockLabel()
            Settax_onLabel()
            Settax_rateLabel()
      
  

            ' Bind the repeater with the list of records to expand the UI.
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Pro_inv_taxesTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return
            rep.DataSource = DataSource()
            rep.DataBind()

            Dim index As Integer = 0
            For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
                ' Loop through all rows in the table, set its DataSource and call DataBind().
                Dim recControl As Pro_inv_taxesTableControlRow = DirectCast(repItem.FindControl("Pro_inv_taxesTableControlRow"), Pro_inv_taxesTableControlRow) 
                recControl.DataSource = Me.DataSource(index)
                If Me.UIData.Count > index Then
                    recControl.PreviousUIData = Me.UIData(index)
                End If				
                recControl.DataBind()
                recControl.Visible = Not Me.InDeletedRecordIds(recControl)
                index += 1
            Next

        
            ' setting the state of expand or collapse alternative rows
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                

            ' Initialize other asp controls
            
            Setcalc_typeLabel()
            Setid_taxesLabel1()
            Setsort_orderLabel()
            Settax_amountLabel()
            Settax_lockLabel()
            Settax_onLabel()
            Settax_rateLabel()
      End Sub

      
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(Pro_inv_taxesTable.id_taxes, Me.DataSource)
          
          End Sub
        
      
        Public Overridable Sub RegisterPostback()
        
        
        End Sub
        
        Public Overridable Function EvaluateFormula(ByVal formula As String, Optional ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord = Nothing, Optional ByVal format as String = Nothing) As String
            Dim e As FormulaEvaluator = New FormulaEvaluator()

            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing Then
                Return ""
            End If
            
            If format IsNot Nothing Then
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function			

        Public Overridable Sub ResetControl()
                    
            Me.CurrentSortOrder.Reset()
            If (Me.InSession(Me, "Order_By")) Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(true, true)
            
                Me.CurrentSortOrder.Add(Pro_inv_taxesTable.sort_order, OrderByItem.OrderDir.Asc)
              
            End If
                
            Me.PageIndex = 0
        End Sub

        Protected Overridable Sub BindPaginationControls()
            ' Setup the pagination controls.

            ' Bind the buttons for Pro_inv_taxesTableControl pagination.
        
            Me.Pro_inv_taxesPagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            Me.Pro_inv_taxesPagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.Pro_inv_taxesPagination.LastPage.Enabled = False
            End If
          
            Me.Pro_inv_taxesPagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.Pro_inv_taxesPagination.NextPage.Enabled = False
            End If
          
            Me.Pro_inv_taxesPagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)

            ' Bind the pagination labels.
        
            If Me.TotalPages > 0 Then
                Me.Pro_inv_taxesPagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Pro_inv_taxesPagination.CurrentPage.Text = "0"
            End If
            Me.Pro_inv_taxesPagination.PageSize.Text = Me.PageSize.ToString()
            Me.Pro_inv_taxesPagination.TotalItems.Text = Me.TotalRecords.ToString()
            Me.Pro_inv_taxesPagination.TotalPages.Text = Me.TotalPages.ToString()
        End Sub

        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As Pro_inv_taxesTableControlRow
            For Each recCtl In Me.GetRecordControls()
        
                If Me.InDeletedRecordIds(recCtl) Then
                    ' Delete any pending deletes. 
                    recCtl.Delete()
                Else
                    If recCtl.Visible Then
                        recCtl.SaveData()
                    End If
                End If
          
            Next
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
          
            ' Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            For Each recCtl In Me.GetRecordControls()
                recCtl.IsNewRecord = False
            Next
    
      
            ' Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            Me.DeletedRecordIds = Nothing
      
        End Sub

        
          Public Overridable Function CreateOrderBy() As OrderBy
          ' The CurrentSortOrder is initialized to the sort order on the
          ' Query Wizard.  It may be modified by the Click handler for any of
          ' the column heading to sort or reverse sort by that column.
          ' You can add your own sort order, or modify it on the Query Wizard.
          Return Me.CurrentSortOrder
          End Function
      
        Public Overridable Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            Pro_inv_taxesTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
              
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
              Dim pro_inv_hdrRecordControlObj As Pro_inv_hdrRecordControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Pro_inv_hdrRecordControl"), Pro_inv_hdrRecordControl)
              
                If (Not IsNothing(pro_inv_hdrRecordControlObj) AndAlso Not IsNothing(pro_inv_hdrRecordControlObj.GetRecord()) AndAlso Not IsNothing(pro_inv_hdrRecordControlObj.GetRecord().id0))
                    wc.iAND(Pro_inv_taxesTable.id_pro_inv_hdr, BaseFilter.ComparisonOperator.EqualsTo, pro_inv_hdrRecordControlObj.GetRecord().id0.ToString())
                    selectedRecordKeyValue.AddElement(Pro_inv_taxesTable.id_pro_inv_hdr.InternalName, pro_inv_hdrRecordControlObj.GetRecord().id0.ToString())
                Else
                    wc.RunQuery = False
                    Return wc
                End If
              
      HttpContext.Current.Session("Pro_inv_taxesTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
    
            Return wc
        End Function
        
    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Pro_inv_taxesTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.
            
            Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
            
            Dim selectedRecordInPro_inv_hdrRecordControl as String = DirectCast(HttpContext.Current.Session("Pro_inv_taxesTableControlWhereClause"), String)
            
            If Not selectedRecordInPro_inv_hdrRecordControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInPro_inv_hdrRecordControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInPro_inv_hdrRecordControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(Pro_inv_taxesTable.id_pro_inv_hdr) Then
            wc.iAND(Pro_inv_taxesTable.id_pro_inv_hdr, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(Pro_inv_taxesTable.id_pro_inv_hdr).ToString())
       End If
      
            End If
          
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            Return wc
        End Function
          
          
        Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                                 ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                                 ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                                 ByVal resultList As ArrayList) As Boolean
                                                 
            'Formats the resultItem and adds it to the list of suggestions.
            Dim index As Integer = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))
            Dim itemToAdd As String = ""
            Dim isFound As Boolean = False
            Dim isAdded As Boolean = False
            ' Get the index where prfixt is at the beginning of resultItem. If not found then, index of word which begins with prefixText.
            If InvariantLCase(autoTypeAheadSearch).equals("wordsstartingwithsearchstring") And Not index = 0 Then
                ' Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                Dim regex1 As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                If regex1.IsMatch(resultItem) Then
                    index = regex1.Match(resultItem).Index
                    isFound = True
                End If
                ' If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                If not resultItem(index).ToString() = " " Then
                    ' Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    Dim regex As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    If regex.IsMatch(resultItem) Then
                        index = regex.Match(resultItem).Index
                        isFound = True
                    End If
                 End If
            End If
            
            ' If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            ' beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            If index = 0 Or isFound Or InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") then
                If InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atbeginningofmatchedstring") Then
                    ' Expression to find beginning of the word which contains prefixText
                    Dim regex1 As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    '  Find the beginning of the word which contains prefexText
                    If (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") AndAlso regex1.IsMatch(resultItem)) Then
                        index = regex1.Match(resultItem).Index
                        isFound = True
                    End If
                    ' Display string from the index till end of the string if sub string from index till end is less than columnLength value.
                    If Len(resultItem) - index <= columnLength Then
                        If index = 0 Then 
                            itemToAdd = resultItem 
                        Else
                            itemToAdd = "..." & resultItem.Substring(index, Len(resultItem) - index) 
                        End If
                    Else
                        If index = 0 Then
                            itemToAdd = resultItem.Substring(index, (columnLength - 3)) & "..."
                        Else
                            'Truncate the string to show only columnLength - 6 characters as begining and trailing "..." has to be appended.
                            itemToAdd = "..." & resultItem.Substring(index , columnLength - 6) & "..." 
                        End If
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("inmiddleofmatchedstring") Then
                    Dim subStringBeginIndex As Integer = CType(columnLength/2, Integer)
                    If Len(resultItem) <= columnLength Then
                        itemToAdd = resultItem
                    Else
                        ' Sanity check at end of the string
                        If index + Len(prefixText) = columnLength Then
                            itemToAdd =  "..." & resultItem.Substring(index-columnLength,index)
                        ElseIf Len(resultItem) - index < subStringBeginIndex Then 
                            ' Display string from the end till columnLength value if, index is closer to the end of the string.
                            itemToAdd =  "..." & resultItem.Substring(Len(resultItem)-columnLength,Len(resultItem))
                        ElseIf index <= subStringBeginIndex Then 
                            ' Sanity chet at beginning of the string
                            itemToAdd =  resultItem.Substring(0, columnLength) & "..."
                        Else
                            ' Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd =  "..." & resultItem.Substring(index - subStringBeginIndex, columnLength) & "..." 
                        End If
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atendofmatchedstring") Then
                     ' Expression to find ending of the word which contains prefexText
                    Dim regex1 As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex("\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    ' Find the ending of the word which contains prefexText
                    If regex1.IsMatch(resultItem, index + 1) Then
                        index = regex1.Match(resultItem, index + 1).Index
                    Else
                        ' If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length
                    End If
                    If index > Len(resultItem) Then
                        index = Len(resultItem)
                    End If
                    ' If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    If  index <= columnLength Then
                        if index = Len(resultItem) Then   'Make decision to append "..."
                            itemToAdd = resultItem.Substring(0,index)
                        Else
                            itemToAdd = resultItem.Substring(0,index) & "..."
                        End If
                    Else
                        If index = Len(resultItem) Then
                            itemToAdd = "..." & resultItem.Substring(index - (columnLength - 3), (columnLength - 3))
                        Else
                            'Truncate the string to show only columnLength - 6 characters as begining and trailing "..." has to be appended.
                            itemToAdd = "..." & resultItem.Substring(index - (columnLength - 6), columnLength - 6) & "..." 
                        End If
                    End If
                End If
                
                ' Remove newline character from itemToAdd
                Dim prefixTextIndex As Integer = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase)
                ' If itemToAdd contains any newline after the search text then show text only till newline
                Dim regex2 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                Dim newLineIndexAfterPrefix As Integer = -1
                If regex2.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexAfterPrefix > -1) Then
                    If itemToAdd.EndsWith("...") Then
                        itemToAdd = (itemToAdd.Substring(0, newLineIndexAfterPrefix) + "...")
                    Else
                        itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix)
                    End If
                End If
                ' If itemToAdd contains any newline before search text then show text which comes after newline
                Dim regex3 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", (System.Text.RegularExpressions.RegexOptions.IgnoreCase Or System.Text.RegularExpressions.RegexOptions.RightToLeft))
                Dim newLineIndexBeforePrefix As Integer = -1
                If regex3.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexBeforePrefix > -1) Then
                    If itemToAdd.StartsWith("...") Then
                        itemToAdd = ("..." + itemToAdd.Substring((newLineIndexBeforePrefix + regex3.Match(itemToAdd, prefixTextIndex).Length)))
                    Else
                        itemToAdd = itemToAdd.Substring((newLineIndexBeforePrefix + regex3.Match(itemToAdd, prefixTextIndex).Length))
                    End If
                End If

                If Not itemToAdd is nothing AndAlso Not resultList.Contains(itemToAdd) Then
                    
                    resultList.Add(itemToAdd)
          				
                    isAdded = true
                End If
            End If
            Return isAdded
        End Function
        
    
        Protected Overridable Sub GetPageSize()
        
            If Me.Pro_inv_taxesPagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.Pro_inv_taxesPagination.PageSize.Text)
                Catch ex As Exception
                End Try
            End If
        End Sub

        Protected Overridable Sub AddNewRecords()
            
            Dim newRecordList As ArrayList = New ArrayList()
          
            Dim newUIDataList As System.Collections.Generic.List(Of Hashtable) = New System.Collections.Generic.List(Of Hashtable)()
      
            ' Loop though all the record controls and if the record control
            ' does not have a unique record id set, then create a record
            ' and add to the list.
            If Not Me.ResetData Then
                Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Pro_inv_taxesTableControlRepeater"), System.Web.UI.WebControls.Repeater)
                If rep Is Nothing Then Return

                Dim repItem As System.Web.UI.WebControls.RepeaterItem
                For Each repItem In rep.Items
                    ' Loop through all rows in the table, set its DataSource and call DataBind().
                    Dim recControl As Pro_inv_taxesTableControlRow = DirectCast(repItem.FindControl("Pro_inv_taxesTableControlRow"), Pro_inv_taxesTableControlRow)

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                    
                        Dim rec As Pro_inv_taxesRecord = New Pro_inv_taxesRecord()
        
                        If recControl.calc_type.Text <> "" Then
                            rec.Parse(recControl.calc_type.Text, Pro_inv_taxesTable.calc_type)
                        End If
                        If recControl.excise_total.Text <> "" Then
                            rec.Parse(recControl.excise_total.Text, Pro_inv_taxesTable.excise_total)
                        End If
                        If recControl.grand_total1.Text <> "" Then
                            rec.Parse(recControl.grand_total1.Text, Pro_inv_taxesTable.grand_total)
                        End If
                        If MiscUtils.IsValueSelected(recControl.id_taxes) Then
                            rec.Parse(recControl.id_taxes.SelectedItem.Value, Pro_inv_taxesTable.id_taxes)
                        End If
                        If recControl.item_total1.Text <> "" Then
                            rec.Parse(recControl.item_total1.Text, Pro_inv_taxesTable.item_total)
                        End If
                        If recControl.sort_order1.Text <> "" Then
                            rec.Parse(recControl.sort_order1.Text, Pro_inv_taxesTable.sort_order)
                        End If
                        If recControl.tax_amount.Text <> "" Then
                            rec.Parse(recControl.tax_amount.Text, Pro_inv_taxesTable.tax_amount)
                        End If
                        If recControl.tax_code.Text <> "" Then
                            rec.Parse(recControl.tax_code.Text, Pro_inv_taxesTable.tax_code)
                        End If
                        rec.tax_lock = recControl.tax_lock.Checked
                
                        If recControl.tax_name.Text <> "" Then
                            rec.Parse(recControl.tax_name.Text, Pro_inv_taxesTable.tax_name)
                        End If
                        If recControl.tax_on.Text <> "" Then
                            rec.Parse(recControl.tax_on.Text, Pro_inv_taxesTable.tax_on)
                        End If
                        If recControl.tax_print.Text <> "" Then
                            rec.Parse(recControl.tax_print.Text, Pro_inv_taxesTable.tax_print)
                        End If
                        If recControl.tax_rate.Text <> "" Then
                            rec.Parse(recControl.tax_rate.Text, Pro_inv_taxesTable.tax_rate)
                        End If
                        If recControl.tax_type.Text <> "" Then
                            rec.Parse(recControl.tax_type.Text, Pro_inv_taxesTable.tax_type)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If

            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
            
                newRecordList.Insert(0, New Pro_inv_taxesRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
            
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(Pro_inv_taxesRecord)), Pro_inv_taxesRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As Pro_inv_taxesTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As Pro_inv_taxesTableControlRow) As Boolean
            If Me.DeletedRecordIds Is Nothing OrElse Me.DeletedRecordIds.Trim = "" Then
                Return False
            End If

            Return Me.DeletedRecordIds.IndexOf("[" & rec.RecordUniqueId & "]") >= 0
        End Function

        Private _DeletedRecordIds As String
        Public Property DeletedRecordIds() As String
            Get
                Return Me._DeletedRecordIds
            End Get
            Set(ByVal value As String)
                Me._DeletedRecordIds = value
            End Set
        End Property
        
      
        ' Create Set, WhereClause, and Populate Methods
        
        Public Overridable Sub Setcalc_typeLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setid_taxesLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setsort_orderLabel()
            
                    
        End Sub
                
        Public Overridable Sub Settax_amountLabel()
            
                    
        End Sub
                
        Public Overridable Sub Settax_lockLabel()
            
                    
        End Sub
                
        Public Overridable Sub Settax_onLabel()
            
                    
        End Sub
                
        Public Overridable Sub Settax_rateLabel()
            
                    
        End Sub
                
        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction
                Me.RegisterPostback()
                
                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    Dim added As Boolean = Me.AddNewRecord > 0
                    Me.LoadData()
                    Me.DataBind()
                    
                    If added Then
                        Me.SetFocusToAddedRow()
                    End If
                    
                End If
                				
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
        End Sub
        
        'this function sets focus to the first editable element in the new added row in the editable table	
        Protected Overridable Sub SetFocusToAddedRow()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Pro_inv_taxesTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing OrElse rep.Items.Count = 0 Then Return
            Dim repItem As System.Web.UI.WebControls.RepeaterItem
            For Each repItem In rep.Items  
			    'Load scripts to table rows
                Me.Page.LoadFocusScripts(repItem)
                Dim recControl As Pro_inv_taxesTableControlRow = DirectCast(repItem.FindControl("Pro_inv_taxesTableControlRow"), Pro_inv_taxesTableControlRow)
                If recControl.IsNewRecord Then
                    For Each field As Control In recControl.Controls
                        If field.Visible AndAlso Me.Page.IsControlEditable(field, False) Then
						    'set focus on the first editable field in the new row
						    field.Focus()
                            Dim updPan As UpdatePanel = DirectCast(Me.Page.FindControlRecursively("UpdatePanel1"), UpdatePanel)
                            If Not updPan Is Nothing Then updPan.Update()
                            Return
                        End If
                    Next
                    Return
                End If
            Next
        End Sub
        
        
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()

            ' Save filter controls to values to session.
        
            
            ' Save table control properties to the session.
            If Not Me.CurrentSortOrder Is Nothing Then
            Me.SaveToSession(Me, "Order_By", Me.CurrentSortOrder.ToXmlString())
            End If
            Me.SaveToSession(Me, "Page_Index", Me.PageIndex.ToString())
            Me.SaveToSession(Me, "Page_Size", Me.PageSize.ToString())
        
            Me.SaveToSession(Me, "DeletedRecordIds", Me.DeletedRecordIds)  
        
        End Sub
        
        Protected  Sub SaveControlsToSession_Ajax()
            ' Save filter controls to values to session.
          
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            
            ' Clear table properties from the session.
            Me.RemoveFromSession(Me, "Order_By")
            Me.RemoveFromSession(Me, "Page_Index")
            Me.RemoveFromSession(Me, "Page_Size")
            
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("Pro_inv_taxesTableControl_OrderBy"), String)
            
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            Else
                Me.CurrentSortOrder = New OrderBy(True, True)
            End If
            
            Dim pageIndex As String = CType(ViewState("Page_Index"), String)
            If pageIndex IsNot Nothing Then
                Me.PageIndex = CInt(pageIndex)
            End If

            Dim pageSize As String = CType(ViewState("Page_Size"), String)
            If Not pageSize Is Nothing Then
                Me.PageSize = CInt(pageSize)
            End If
        
            Me.DeletedRecordIds = CType(Me.ViewState("DeletedRecordIds"), String)
        
        End Sub

        Protected Overrides Function SaveViewState() As Object
            
            If Me.CurrentSortOrder IsNot Nothing Then
                Me.ViewState("Pro_inv_taxesTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
        
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
            Return MyBase.SaveViewState()
        End Function

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_taxesPagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            Me.PageIndex = 0
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_taxesPagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            Me.DisplayLastPage = True
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_taxesPagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            Me.PageIndex += 1
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for LinkButton
        Public Overridable Sub Pro_inv_taxesPagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            Try
                
            Me.DataChanged = True
      
            Me.PageSize = Integer.Parse(Me.Pro_inv_taxesPagination.PageSize.Text)
      
            Me.PageIndex = Integer.Parse(Me.Pro_inv_taxesPagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_taxesPagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            If Me.PageIndex > 0 Then
                Me.PageIndex -= 1
                Me.DataChanged = True
            End If
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        

        ' Generate the event handling functions for sorting events.
        
        Public Overridable Sub calc_typeLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by calc_type when clicked.
              
            ' Get previous sorting state for calc_type.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_taxesTable.calc_type)
            If sd Is Nothing Then
                ' First time sort, so add sort order for calc_type.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_taxesTable.calc_type, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by calc_type, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub id_taxesLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by id_taxes when clicked.
              
            ' Get previous sorting state for id_taxes.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_taxesTable.id_taxes)
            If sd Is Nothing Then
                ' First time sort, so add sort order for id_taxes.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_taxesTable.id_taxes, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by id_taxes, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub sort_orderLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by sort_order when clicked.
              
            ' Get previous sorting state for sort_order.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_taxesTable.sort_order)
            If sd Is Nothing Then
                ' First time sort, so add sort order for sort_order.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_taxesTable.sort_order, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by sort_order, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub tax_amountLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by tax_amount when clicked.
              
            ' Get previous sorting state for tax_amount.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_taxesTable.tax_amount)
            If sd Is Nothing Then
                ' First time sort, so add sort order for tax_amount.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_taxesTable.tax_amount, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by tax_amount, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub tax_lockLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by tax_lock when clicked.
              
            ' Get previous sorting state for tax_lock.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_taxesTable.tax_lock)
            If sd Is Nothing Then
                ' First time sort, so add sort order for tax_lock.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_taxesTable.tax_lock, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by tax_lock, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub tax_onLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by tax_on when clicked.
              
            ' Get previous sorting state for tax_on.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_taxesTable.tax_on)
            If sd Is Nothing Then
                ' First time sort, so add sort order for tax_on.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_taxesTable.tax_on, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by tax_on, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub tax_rateLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by tax_rate when clicked.
              
            ' Get previous sorting state for tax_rate.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_taxesTable.tax_rate)
            If sd Is Nothing Then
                ' First time sort, so add sort order for tax_rate.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_taxesTable.tax_rate, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by tax_rate, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            

        ' Generate the event handling functions for button events.
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_taxesAddButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            Me.AddNewRecord = 1
            Me.DataChanged = True
      Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_taxesDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            If(Not Me.Page.IsPageRefresh) Then
        
                Me.DeleteSelectedRecords(True)
          
            End If
      Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_taxesResetButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
              Me.CurrentSortOrder.Reset()
              If Me.InSession(Me, "Order_By") Then
                  Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
              Else
                  Me.CurrentSortOrder = New OrderBy(True, True)
              
                Me.CurrentSortOrder.Add(Pro_inv_taxesTable.sort_order, OrderByItem.OrderDir.Asc)
                
              End If
              

        ' Setting the DataChanged to True results in the page being refreshed with
        ' the most recent data from the database.  This happens in PreRender event
        ' based on the current sort, search and filter criteria.
        Me.DataChanged = True
            
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
      

        ' Generate the event handling functions for filter and search events.
        
      
        ' Generate the event handling functions for others
        
      
        Private _UIData As New System.Collections.Generic.List(Of Hashtable)
        Public Property UIData() As System.Collections.Generic.List(Of Hashtable)
            Get
                Return Me._UIData
            End Get
            Set(ByVal value As System.Collections.Generic.List(Of Hashtable))
                Me._UIData = value
            End Set
        End Property
        
        ' pagination properties
        Private _PageSize As Integer
        Public Property PageSize() As Integer
            Get
                Return Me._PageSize
            End Get
            Set(ByVal value As Integer)
                Me._PageSize = value
            End Set
        End Property

        Private _PageIndex As Integer
        Public Property PageIndex() As Integer
            Get
                ' Return the PageIndex
                Return Me._PageIndex
            End Get
            Set(ByVal value As Integer)
                Me._PageIndex = value
            End Set
        End Property

        Private _TotalRecords As Integer
        Public Property TotalRecords() As Integer
            Get
                Return Me._TotalRecords
            End Get
            Set(ByVal value As Integer)
                If Me.PageSize > 0 Then
                    Me.TotalPages = CInt(Math.Ceiling(value / Me.PageSize))
                End If
                Me._TotalRecords = value
            End Set
        End Property

        Private _TotalPages As Integer
        Public Property TotalPages() As Integer
            Get
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property

        Private _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property

        Private _DataChanged As Boolean = False
        Public Property DataChanged() As Boolean
            Get
                Return Me._DataChanged
            End Get
            Set(ByVal value As Boolean)
                Me._DataChanged = value
            End Set
        End Property
        
        Private _ResetData As Boolean = False
        Public Property ResetData() As Boolean
            Get
                Return Me._ResetData
            End Get
            Set(ByVal value As Boolean)
                Me._ResetData = value
            End Set
        End Property

        Private _AddNewRecord As Integer = 0
        Public Property AddNewRecord() As Integer
            Get
                Return Me._AddNewRecord
            End Get
            Set(ByVal value As Integer)
                Me._AddNewRecord = value
            End Set
        End Property

        
        Private _CurrentSortOrder As OrderBy = Nothing
        Public Property CurrentSortOrder() As OrderBy
            Get
                Return Me._CurrentSortOrder
            End Get
            Set(ByVal value As BaseClasses.Data.OrderBy)
                Me._CurrentSortOrder = value
            End Set
        End Property
        
        Private _DataSource() As Pro_inv_taxesRecord = Nothing
        Public Property DataSource() As Pro_inv_taxesRecord ()
            Get
                Return Me._DataSource
            End Get
            Set(ByVal value() As Pro_inv_taxesRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property calc_typeLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "calc_typeLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property id_taxesLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxesLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_taxesAddButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_taxesAddButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_taxesDeleteButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_taxesDeleteButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_taxesPagination() As ServelInvocing.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_taxesPagination"), ServelInvocing.UI.IPagination)
          End Get
          End Property
        
        Public ReadOnly Property Pro_inv_taxesResetButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_taxesResetButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_taxesToggleAll() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_taxesToggleAll"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
        
        Public ReadOnly Property sort_orderLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "sort_orderLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property tax_amountLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_amountLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property tax_lockLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_lockLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property tax_onLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_onLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property tax_rateLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_rateLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"
        
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
      
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As Pro_inv_taxesTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
                End If
                Dim rec As Pro_inv_taxesRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
          
        Public Overridable Function GetSelectedRecordIndex() As Integer
            Dim counter As Integer = 0
            Dim recControl As Pro_inv_taxesTableControlRow
            For Each recControl In Me.GetRecordControls()
                If recControl.Pro_inv_taxesRecordRowSelection.Checked Then
                    Return counter
                End If
                counter += 1
            Next
            Return -1
        End Function
        
        Public Overridable Function GetSelectedRecordControl() As Pro_inv_taxesTableControlRow
            Dim selectedList() As Pro_inv_taxesTableControlRow = Me.GetSelectedRecordControls()
            If selectedList.Length = 0 Then
                Return Nothing
            End If
            Return selectedList(0)
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As Pro_inv_taxesTableControlRow()
        
            Dim selectedList As ArrayList = New ArrayList(25)
            Dim recControl As Pro_inv_taxesTableControlRow
            For Each recControl In Me.GetRecordControls()
                If recControl.Pro_inv_taxesRecordRowSelection.Checked Then
                    selectedList.Add(recControl)
                End If
            Next
            Return DirectCast(selectedList.ToArray(GetType(Pro_inv_taxesTableControlRow)), Pro_inv_taxesTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As Pro_inv_taxesTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
            End If
            
            Dim recCtl As Pro_inv_taxesTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
                    recCtl.Pro_inv_taxesRecordRowSelection.Checked = False
                
                Else
                
                    recCtl.Delete()
                    
                    ' Setting the DataChanged to True results in the page being refreshed with
                    ' the most recent data from the database.  This happens in PreRender event
                    ' based on the current sort, search and filter criteria.
                    Me.DataChanged = True
                    Me.ResetData = True
                  
                End If
            Next
        End Sub

        Public Function GetRecordControls() As Pro_inv_taxesTableControlRow()
            Dim recList As ArrayList = New ArrayList()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Pro_inv_taxesTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return Nothing
            Dim repItem As System.Web.UI.WebControls.RepeaterItem

            For Each repItem In rep.Items
                Dim recControl As Pro_inv_taxesTableControlRow = DirectCast(repItem.FindControl("Pro_inv_taxesTableControlRow"), Pro_inv_taxesTableControlRow)
                recList.Add(recControl)
            Next

            Return DirectCast(recList.ToArray(GetType(Pro_inv_taxesTableControlRow)), Pro_inv_taxesTableControlRow())
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

    

End Class

  
' Base class for the Pro_inv_termsTableControlRow control on the AddPro_inv_hdr page.
' Do not modify this class. Instead override any method in Pro_inv_termsTableControlRow.
Public Class BasePro_inv_termsTableControlRow
        Inherits ServelInvocing.UI.BaseApplicationRecordControl

        '  To customize, override this method in Pro_inv_termsTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
        End Sub

        '  To customize, override this method in Pro_inv_termsTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
			'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
			Me.Page.LoadFocusScripts(Me)
		
              ' Show confirmation message on Click
              Me.Pro_inv_termsRowDeleteButton.Attributes.Add("onClick", "return (confirm('" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteRecordConfirm", "ServelInvocing") & "'));")
              ' Register the event handlers.
          
              AddHandler Me.Pro_inv_termsRowDeleteButton.Click, AddressOf Pro_inv_termsRowDeleteButton_Click
              
              AddHandler Me.narration.TextChanged, AddressOf narration_TextChanged
            
              AddHandler Me.sort_order.TextChanged, AddressOf sort_order_TextChanged
            
        End Sub

        
        Public Overridable Sub LoadData()        
            ' Load the data from the database into the DataSource pro_inv_terms record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = Pro_inv_termsTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BasePro_inv_termsTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New Pro_inv_termsRecord()
          
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Pro_inv_termsTableControlRow.
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record.  To do this, it calls the Set methods for 
            ' each of the field displayed on the webpage.  It is better to make 
            ' changes in the Set methods, rather than making changes here.
            
            MyBase.DataBind()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
                Return
            End If
        
      
      
            ' Call the Set methods for each controls on the panel
        
            Setnarration()
            Setsort_order()
      
      
            Me.IsNewRecord = True
            
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
                
                Me.RecordUniqueId = Me.DataSource.GetID.ToXmlString()
            End If
          
            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False
                  
        End Sub
        
        
        Public Overridable Sub Setnarration()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.narration.ID) Then
            
                Me.narration.Text = Me.PreviousUIData(Me.narration.ID).ToString()
              
                Return
            End If
            
        
            ' Set the narration TextBox on the webpage with value from the
            ' pro_inv_terms database record.

            ' Me.DataSource is the pro_inv_terms record retrieved from the database.
            ' Me.narration is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setnarration()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.narrationSpecified Then
                				
                ' If the narration is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_termsTable.narration)
                            
                Me.narration.Text = formattedValue
              
            Else 
            
                ' narration is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.narration.Text = Pro_inv_termsTable.narration.Format(Pro_inv_termsTable.narration.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setsort_order()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.sort_order.ID) Then
            
                Me.sort_order.Text = Me.PreviousUIData(Me.sort_order.ID).ToString()
              
                Return
            End If
            
        
            ' Set the sort_order TextBox on the webpage with value from the
            ' pro_inv_terms database record.

            ' Me.DataSource is the pro_inv_terms record retrieved from the database.
            ' Me.sort_order is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setsort_order()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.sort_orderSpecified Then
                				
                ' If the sort_order is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_termsTable.sort_order)
                            
                Me.sort_order.Text = formattedValue
              
            Else 
            
                ' sort_order is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.sort_order.Text = Pro_inv_termsTable.sort_order.Format(Pro_inv_termsTable.sort_order.DefaultValue)
                        		
                End If
                 
        End Sub
                
      
        Public Overridable Function EvaluateFormula(ByVal formula As String, Optional ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord = Nothing, Optional ByVal format as String = Nothing) As String
            Dim e As FormulaEvaluator = New FormulaEvaluator()

            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            If dataSourceForEvaluate Is Nothing Then
                
                e.DataSource = Me.DataSource
                
            Else
                e.DataSource = dataSourceForEvaluate
            End If

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing
                Return ""
            End If
            
            If format IsNot Nothing
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function	  
      

        Public Overridable Sub RegisterPostback()
        
        
        End Sub

      
        
        ' To customize, override this method in Pro_inv_termsTableControlRow.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
        Dim parentCtrl As Pro_inv_hdrRecordControl
          
          
          parentCtrl = DirectCast(Me.Page.FindControlRecursively("Pro_inv_hdrRecordControl"), Pro_inv_hdrRecordControl)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ServelInvocing"))
            End If
            
            Me.DataSource.id_pro_inv_hdr = parentCtrl.DataSource.id0
              
            ' 2. Perform any custom validation.
            Me.Validate()

            
            ' 3. Set the values in the record with data from UI controls.
            ' This calls the Get() method for each of the user interface controls.
            Me.GetUIData()

            ' 4. Save in the database.
            ' We should not save the record if the data did not change. This
            ' will save a database hit and avoid triggering any database triggers.
             
            If Me.DataSource.IsAnyValueChanged Then
                ' Save record to database but do not commit yet.
                ' Auto generated ids are available after saving for use by child (dependent) records.
                Me.DataSource.Save()
              
                DirectCast(GetParentControlObject(Me, "Pro_inv_termsTableControl"), Pro_inv_termsTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "Pro_inv_termsTableControl"), Pro_inv_termsTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in Pro_inv_termsTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
            
      
            ' Call the Get methods for each of the user interface controls.
        
            Getnarration()
            Getsort_order()
        End Sub
        
        
        Public Overridable Sub Getnarration()
            
            ' Retrieve the value entered by the user on the narration ASP:TextBox, and
            ' save it into the narration field in DataSource pro_inv_terms record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.narration.Text, Pro_inv_termsTable.narration)			

                      
        End Sub
                
        Public Overridable Sub Getsort_order()
            
            ' Retrieve the value entered by the user on the sort_order ASP:TextBox, and
            ' save it into the sort_order field in DataSource pro_inv_terms record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.sort_order.Text, Pro_inv_termsTable.sort_order)			

                      
        End Sub
                
      
        ' To customize, override this method in Pro_inv_termsTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
            Return Nothing
            
        End Function
        

        ' To customize, override this method in Pro_inv_termsTableControlRow.
        Public Overridable Sub Validate() 
            ' Add custom validation for any control within this panel.
            ' Example.  If you have a State ASP:Textbox control
            ' If Me.State.Text <> "CA" Then
            '    Throw New Exception("State must be CA (California).")
            ' End If

            ' The Validate method is common across all controls within
            ' this panel so you can validate multiple fields, but report
            ' one error message.
            
                
        End Sub

        Public Overridable Sub Delete()
        
            If Me.IsNewRecord() Then
                Return
            End If

            Dim pkValue As KeyValue = KeyValue.XmlToKey(Me.RecordUniqueId)
          Pro_inv_termsTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "Pro_inv_termsTableControl"), Pro_inv_termsTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "Pro_inv_termsTableControl"), Pro_inv_termsTableControl).ResetData = True
        End Sub

        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction()
                Me.RegisterPostback()

                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    Me.LoadData()
                    Me.DataBind()			
                End If
                						
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction()
            End Try
        End Sub
        
        

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)
            Dim isNewRecord As String = CType(ViewState("IsNewRecord"), String)
            If Not isNewRecord Is Nothing AndAlso isNewRecord.Trim <> "" Then
                Me.IsNewRecord = Boolean.Parse(isNewRecord)
            End If
            
            Dim myCheckSum As String = CType(ViewState("CheckSum"), String)
            If Not myCheckSum Is Nothing AndAlso myCheckSum.Trim <> "" Then
                Me.CheckSum = myCheckSum
            End If
            
        End Sub

        Protected Overrides Function SaveViewState() As Object
            ViewState("IsNewRecord") = Me.IsNewRecord.ToString()
            ViewState("CheckSum") = Me.CheckSum
            
            Return MyBase.SaveViewState()
        End Function
        
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_termsRowDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            If(Not Me.Page.IsPageRefresh) Then
        
                Dim tc As Pro_inv_termsTableControl = DirectCast(GetParentControlObject(Me, "Pro_inv_termsTableControl"), Pro_inv_termsTableControl)
                If Not (IsNothing(tc)) Then
                    
                    Me.Visible = False
                End If
              
            End If
      Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
                  
        End Sub
        
        Protected Overridable Sub narration_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub sort_order_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
   
        Private _PreviousUIData As New Hashtable
        Public Overridable Property PreviousUIData() As Hashtable
            Get
                Return _PreviousUIData
            End Get
            Set(ByVal value As Hashtable)
                _PreviousUIData = value
            End Set
        End Property   
   
        Private _IsNewRecord As Boolean = True
        Public Overridable Property IsNewRecord() As Boolean
            Get
                Return Me._IsNewRecord
            End Get
            Set(ByVal value As Boolean)
                Me._IsNewRecord = value
            End Set
        End Property

        Private _DataChanged As Boolean = False
        Public Overridable Property DataChanged() As Boolean
            Get
                Return Me._DataChanged
            End Get
            Set(ByVal Value As Boolean)
                Me._DataChanged = Value
            End Set
        End Property

        Private _ResetData As Boolean = False
        Public Overridable Property ResetData() As Boolean
            Get
                Return Me._ResetData
            End Get
            Set(ByVal Value As Boolean)
                Me._ResetData = Value
            End Set
        End Property
        
        Public Property RecordUniqueId() As String
            Get
                Return CType(Me.ViewState("BasePro_inv_termsTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BasePro_inv_termsTableControlRow_Rec") = value
            End Set
        End Property
        
        Private _DataSource As Pro_inv_termsRecord
        Public Property DataSource() As Pro_inv_termsRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As Pro_inv_termsRecord)
            
                Me._DataSource = value
            End Set
        End Property

        

        Private _checkSum As String
        Public Overridable Property CheckSum() As String
            Get
                Return Me._checkSum
            End Get
            Set(ByVal value As String)
                Me._checkSum = value
            End Set
        End Property
        
        Private _TotalPages As Integer
        Public Property TotalPages() As Integer
            Get
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property
        
        Private _PageIndex As Integer
        Public Property PageIndex() As Integer
            Get
                ' Return the PageIndex
                Return Me._PageIndex
            End Get
            Set(ByVal value As Integer)
                Me._PageIndex = value
            End Set
        End Property
    
        Private _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property
        
        

#Region "Helper Properties"
        
        Public ReadOnly Property narration() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "narration"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property Pro_inv_termsRecordRowSelection() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_termsRecordRowSelection"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_termsRowDeleteButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_termsRowDeleteButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property sort_order() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "sort_order"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As Pro_inv_termsRecord = Nothing
             
        
            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.
                
            Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ServelInvocing"))
                    
            End If
            Return EvaluateExpressions(url, arg, rec, bEncrypt)
        End Function

         
        Public Overridable Function GetRecord() As Pro_inv_termsRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return Pro_inv_termsTable.GetRecord(Me.RecordUniqueId, True)
                
            End If
            
            ' Localization.
            
            Return Nothing
                
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

End Class

  

' Base class for the Pro_inv_termsTableControl control on the AddPro_inv_hdr page.
' Do not modify this class. Instead override any method in Pro_inv_termsTableControl.
Public Class BasePro_inv_termsTableControl
        Inherits ServelInvocing.UI.BaseApplicationTableControl

        

        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      	  	  
      
           ' Setup the filter and search events.
        
      
      
            ' Control Initializations.
            ' Initialize the table's current sort order.
            
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(True, True)
            
            End If

            ' Setup default pagination settings.
        
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "10"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
            Me.ClearControlsFromSession()
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
              ' Show confirmation message on Click
              Me.Pro_inv_termsDeleteButton.Attributes.Add("onClick", "return (confirm('" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteConfirm", "ServelInvocing") & "'));")
            ' Setup the pagination events.
            
              AddHandler Me.Pro_inv_termsPagination.FirstPage.Click, AddressOf Pro_inv_termsPagination_FirstPage_Click
              
              AddHandler Me.Pro_inv_termsPagination.LastPage.Click, AddressOf Pro_inv_termsPagination_LastPage_Click
              
              AddHandler Me.Pro_inv_termsPagination.NextPage.Click, AddressOf Pro_inv_termsPagination_NextPage_Click
              
              AddHandler Me.Pro_inv_termsPagination.PageSizeButton.Click, AddressOf Pro_inv_termsPagination_PageSizeButton_Click
            
              AddHandler Me.Pro_inv_termsPagination.PreviousPage.Click, AddressOf Pro_inv_termsPagination_PreviousPage_Click
              
            ' Setup the sorting events.
          
              AddHandler Me.narrationLabel1.Click, AddressOf narrationLabel1_Click
            
              AddHandler Me.sort_orderLabel1.Click, AddressOf sort_orderLabel1_Click
            
            ' Setup the button events.
          
              AddHandler Me.Pro_inv_termsAddButton.Click, AddressOf Pro_inv_termsAddButton_Click
              
              AddHandler Me.Pro_inv_termsDeleteButton.Click, AddressOf Pro_inv_termsDeleteButton_Click
              
              AddHandler Me.Pro_inv_termsResetButton.Click, AddressOf Pro_inv_termsResetButton_Click
              
          ' Setup events for others
            
        End Sub
        
        
        Public Overridable Sub LoadData()
            ' Read data from database. Returns an array of records that can be assigned
            ' to the DataSource table control property.
            Try	
                
                ' The WHERE clause will be empty when displaying all records in table.
                Dim wc As WhereClause = CreateWhereClause()
                If wc IsNot Nothing AndAlso Not wc.RunQuery Then
                    ' Initialize an empty array of records
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Pro_inv_termsRecord)), Pro_inv_termsRecord())
                    ' Add records to the list if needed.
                    Me.AddNewRecords()
                    Return
                End If

                ' Call OrderBy to determine the order - either use the order defined
                ' on the Query Wizard, or specified by user (by clicking on column heading)
                Dim orderBy As OrderBy = CreateOrderBy()
                
                ' Get the pagesize from the pagesize control.
                Me.GetPageSize()
                
                ' Get the total number of records to be displayed.
                
                Me.TotalRecords = Pro_inv_termsTable.GetRecordCount(wc)
                              
                ' Make sure PageIndex (current page) is within bounds.
                If Me.TotalPages <= 0 OrElse Me.PageIndex < 0 Then
                    Me.PageIndex = 0
                ElseIf Me.DisplayLastPage OrElse Me.PageIndex >= Me.TotalPages Then
                    Me.PageIndex = Me.TotalPages - 1
                End If

                ' Retrieve the records and set the table DataSource.
                ' Only PageSize records are fetched starting at PageIndex (zero based).
                If Me.TotalRecords <= 0 Then
                    ' No records matching query. Initialize an empty array of records
                    
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Pro_inv_termsRecord)), Pro_inv_termsRecord())
                    
                ElseIf Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                
                    Dim postdata As New ArrayList
                    For Each rc As Pro_inv_termsTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(Pro_inv_termsRecord)), Pro_inv_termsRecord())
                
                Else  ' Get the records from the database	
                    Me.DataSource = Pro_inv_termsTable.GetRecords(wc, orderBy, Me.PageIndex, Me.PageSize) 
                End If
                
                ' Add any new rows desired by the user.
                Me.AddNewRecords()
            
                ' Turn off the ToggleAll checkbox
                Me.Pro_inv_termsToggleAll.Checked = False
            

                ' Initialize the page and grand totals. now
            
            Catch ex As Exception
                ' Report the error message to the end user
                Dim msg As String = ex.Message
                If ex.InnerException IsNot Nothing Then
                    msg = msg & " InnerException: " & ex.InnerException.Message
                End If
                Throw New Exception(msg, ex.InnerException)
            End Try
        End Sub
        
        
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record for each row in the table.  To do this, it calls the
            ' DataBind for each of the rows.
            ' DataBind also populates any filters above the table, and sets the pagination
            ' control to the correct number of records and the current page number.
            
            MyBase.DataBind()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
                Return
            End If
           
            ' Setup the pagination controls.
            BindPaginationControls()

            ' Call the Set methods for each controls on the panel
        
            SetnarrationLabel1()
            Setsort_orderLabel1()
      
  

            ' Bind the repeater with the list of records to expand the UI.
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Pro_inv_termsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return
            rep.DataSource = DataSource()
            rep.DataBind()

            Dim index As Integer = 0
            For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
                ' Loop through all rows in the table, set its DataSource and call DataBind().
                Dim recControl As Pro_inv_termsTableControlRow = DirectCast(repItem.FindControl("Pro_inv_termsTableControlRow"), Pro_inv_termsTableControlRow) 
                recControl.DataSource = Me.DataSource(index)
                If Me.UIData.Count > index Then
                    recControl.PreviousUIData = Me.UIData(index)
                End If				
                recControl.DataBind()
                recControl.Visible = Not Me.InDeletedRecordIds(recControl)
                index += 1
            Next

        
            ' setting the state of expand or collapse alternative rows
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                

            ' Initialize other asp controls
            
            SetnarrationLabel1()
            Setsort_orderLabel1()
      End Sub

      
      
        Public Overridable Sub RegisterPostback()
        
        
        End Sub
        
        Public Overridable Function EvaluateFormula(ByVal formula As String, Optional ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord = Nothing, Optional ByVal format as String = Nothing) As String
            Dim e As FormulaEvaluator = New FormulaEvaluator()

            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing Then
                Return ""
            End If
            
            If format IsNot Nothing Then
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function			

        Public Overridable Sub ResetControl()
                    
            Me.CurrentSortOrder.Reset()
            If (Me.InSession(Me, "Order_By")) Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(true, true)
            
            End If
                
            Me.PageIndex = 0
        End Sub

        Protected Overridable Sub BindPaginationControls()
            ' Setup the pagination controls.

            ' Bind the buttons for Pro_inv_termsTableControl pagination.
        
            Me.Pro_inv_termsPagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            Me.Pro_inv_termsPagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.Pro_inv_termsPagination.LastPage.Enabled = False
            End If
          
            Me.Pro_inv_termsPagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.Pro_inv_termsPagination.NextPage.Enabled = False
            End If
          
            Me.Pro_inv_termsPagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)

            ' Bind the pagination labels.
        
            If Me.TotalPages > 0 Then
                Me.Pro_inv_termsPagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Pro_inv_termsPagination.CurrentPage.Text = "0"
            End If
            Me.Pro_inv_termsPagination.PageSize.Text = Me.PageSize.ToString()
            Me.Pro_inv_termsPagination.TotalItems.Text = Me.TotalRecords.ToString()
            Me.Pro_inv_termsPagination.TotalPages.Text = Me.TotalPages.ToString()
        End Sub

        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As Pro_inv_termsTableControlRow
            For Each recCtl In Me.GetRecordControls()
        
                If Me.InDeletedRecordIds(recCtl) Then
                    ' Delete any pending deletes. 
                    recCtl.Delete()
                Else
                    If recCtl.Visible Then
                        recCtl.SaveData()
                    End If
                End If
          
            Next
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
          
            ' Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            For Each recCtl In Me.GetRecordControls()
                recCtl.IsNewRecord = False
            Next
    
      
            ' Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            Me.DeletedRecordIds = Nothing
      
        End Sub

        
          Public Overridable Function CreateOrderBy() As OrderBy
          ' The CurrentSortOrder is initialized to the sort order on the
          ' Query Wizard.  It may be modified by the Click handler for any of
          ' the column heading to sort or reverse sort by that column.
          ' You can add your own sort order, or modify it on the Query Wizard.
          Return Me.CurrentSortOrder
          End Function
      
        Public Overridable Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            Pro_inv_termsTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
              
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
              Dim pro_inv_hdrRecordControlObj As Pro_inv_hdrRecordControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Pro_inv_hdrRecordControl"), Pro_inv_hdrRecordControl)
              
                If (Not IsNothing(pro_inv_hdrRecordControlObj) AndAlso Not IsNothing(pro_inv_hdrRecordControlObj.GetRecord()) AndAlso Not IsNothing(pro_inv_hdrRecordControlObj.GetRecord().id0))
                    wc.iAND(Pro_inv_termsTable.id_pro_inv_hdr, BaseFilter.ComparisonOperator.EqualsTo, pro_inv_hdrRecordControlObj.GetRecord().id0.ToString())
                    selectedRecordKeyValue.AddElement(Pro_inv_termsTable.id_pro_inv_hdr.InternalName, pro_inv_hdrRecordControlObj.GetRecord().id0.ToString())
                Else
                    wc.RunQuery = False
                    Return wc
                End If
              
      HttpContext.Current.Session("Pro_inv_termsTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
    
            Return wc
        End Function
        
    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Pro_inv_termsTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.
            
            Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
            
            Dim selectedRecordInPro_inv_hdrRecordControl as String = DirectCast(HttpContext.Current.Session("Pro_inv_termsTableControlWhereClause"), String)
            
            If Not selectedRecordInPro_inv_hdrRecordControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInPro_inv_hdrRecordControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInPro_inv_hdrRecordControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(Pro_inv_termsTable.id_pro_inv_hdr) Then
            wc.iAND(Pro_inv_termsTable.id_pro_inv_hdr, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(Pro_inv_termsTable.id_pro_inv_hdr).ToString())
       End If
      
            End If
          
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            Return wc
        End Function
          
          
        Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                                 ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                                 ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                                 ByVal resultList As ArrayList) As Boolean
                                                 
            'Formats the resultItem and adds it to the list of suggestions.
            Dim index As Integer = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))
            Dim itemToAdd As String = ""
            Dim isFound As Boolean = False
            Dim isAdded As Boolean = False
            ' Get the index where prfixt is at the beginning of resultItem. If not found then, index of word which begins with prefixText.
            If InvariantLCase(autoTypeAheadSearch).equals("wordsstartingwithsearchstring") And Not index = 0 Then
                ' Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                Dim regex1 As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                If regex1.IsMatch(resultItem) Then
                    index = regex1.Match(resultItem).Index
                    isFound = True
                End If
                ' If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                If not resultItem(index).ToString() = " " Then
                    ' Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    Dim regex As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    If regex.IsMatch(resultItem) Then
                        index = regex.Match(resultItem).Index
                        isFound = True
                    End If
                 End If
            End If
            
            ' If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            ' beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            If index = 0 Or isFound Or InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") then
                If InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atbeginningofmatchedstring") Then
                    ' Expression to find beginning of the word which contains prefixText
                    Dim regex1 As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    '  Find the beginning of the word which contains prefexText
                    If (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") AndAlso regex1.IsMatch(resultItem)) Then
                        index = regex1.Match(resultItem).Index
                        isFound = True
                    End If
                    ' Display string from the index till end of the string if sub string from index till end is less than columnLength value.
                    If Len(resultItem) - index <= columnLength Then
                        If index = 0 Then 
                            itemToAdd = resultItem 
                        Else
                            itemToAdd = "..." & resultItem.Substring(index, Len(resultItem) - index) 
                        End If
                    Else
                        If index = 0 Then
                            itemToAdd = resultItem.Substring(index, (columnLength - 3)) & "..."
                        Else
                            'Truncate the string to show only columnLength - 6 characters as begining and trailing "..." has to be appended.
                            itemToAdd = "..." & resultItem.Substring(index , columnLength - 6) & "..." 
                        End If
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("inmiddleofmatchedstring") Then
                    Dim subStringBeginIndex As Integer = CType(columnLength/2, Integer)
                    If Len(resultItem) <= columnLength Then
                        itemToAdd = resultItem
                    Else
                        ' Sanity check at end of the string
                        If index + Len(prefixText) = columnLength Then
                            itemToAdd =  "..." & resultItem.Substring(index-columnLength,index)
                        ElseIf Len(resultItem) - index < subStringBeginIndex Then 
                            ' Display string from the end till columnLength value if, index is closer to the end of the string.
                            itemToAdd =  "..." & resultItem.Substring(Len(resultItem)-columnLength,Len(resultItem))
                        ElseIf index <= subStringBeginIndex Then 
                            ' Sanity chet at beginning of the string
                            itemToAdd =  resultItem.Substring(0, columnLength) & "..."
                        Else
                            ' Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd =  "..." & resultItem.Substring(index - subStringBeginIndex, columnLength) & "..." 
                        End If
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atendofmatchedstring") Then
                     ' Expression to find ending of the word which contains prefexText
                    Dim regex1 As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex("\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    ' Find the ending of the word which contains prefexText
                    If regex1.IsMatch(resultItem, index + 1) Then
                        index = regex1.Match(resultItem, index + 1).Index
                    Else
                        ' If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length
                    End If
                    If index > Len(resultItem) Then
                        index = Len(resultItem)
                    End If
                    ' If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    If  index <= columnLength Then
                        if index = Len(resultItem) Then   'Make decision to append "..."
                            itemToAdd = resultItem.Substring(0,index)
                        Else
                            itemToAdd = resultItem.Substring(0,index) & "..."
                        End If
                    Else
                        If index = Len(resultItem) Then
                            itemToAdd = "..." & resultItem.Substring(index - (columnLength - 3), (columnLength - 3))
                        Else
                            'Truncate the string to show only columnLength - 6 characters as begining and trailing "..." has to be appended.
                            itemToAdd = "..." & resultItem.Substring(index - (columnLength - 6), columnLength - 6) & "..." 
                        End If
                    End If
                End If
                
                ' Remove newline character from itemToAdd
                Dim prefixTextIndex As Integer = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase)
                ' If itemToAdd contains any newline after the search text then show text only till newline
                Dim regex2 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                Dim newLineIndexAfterPrefix As Integer = -1
                If regex2.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexAfterPrefix > -1) Then
                    If itemToAdd.EndsWith("...") Then
                        itemToAdd = (itemToAdd.Substring(0, newLineIndexAfterPrefix) + "...")
                    Else
                        itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix)
                    End If
                End If
                ' If itemToAdd contains any newline before search text then show text which comes after newline
                Dim regex3 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", (System.Text.RegularExpressions.RegexOptions.IgnoreCase Or System.Text.RegularExpressions.RegexOptions.RightToLeft))
                Dim newLineIndexBeforePrefix As Integer = -1
                If regex3.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexBeforePrefix > -1) Then
                    If itemToAdd.StartsWith("...") Then
                        itemToAdd = ("..." + itemToAdd.Substring((newLineIndexBeforePrefix + regex3.Match(itemToAdd, prefixTextIndex).Length)))
                    Else
                        itemToAdd = itemToAdd.Substring((newLineIndexBeforePrefix + regex3.Match(itemToAdd, prefixTextIndex).Length))
                    End If
                End If

                If Not itemToAdd is nothing AndAlso Not resultList.Contains(itemToAdd) Then
                    
                    resultList.Add(itemToAdd)
          				
                    isAdded = true
                End If
            End If
            Return isAdded
        End Function
        
    
        Protected Overridable Sub GetPageSize()
        
            If Me.Pro_inv_termsPagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.Pro_inv_termsPagination.PageSize.Text)
                Catch ex As Exception
                End Try
            End If
        End Sub

        Protected Overridable Sub AddNewRecords()
            
            Dim newRecordList As ArrayList = New ArrayList()
          
            Dim newUIDataList As System.Collections.Generic.List(Of Hashtable) = New System.Collections.Generic.List(Of Hashtable)()
      
            ' Loop though all the record controls and if the record control
            ' does not have a unique record id set, then create a record
            ' and add to the list.
            If Not Me.ResetData Then
                Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Pro_inv_termsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
                If rep Is Nothing Then Return

                Dim repItem As System.Web.UI.WebControls.RepeaterItem
                For Each repItem In rep.Items
                    ' Loop through all rows in the table, set its DataSource and call DataBind().
                    Dim recControl As Pro_inv_termsTableControlRow = DirectCast(repItem.FindControl("Pro_inv_termsTableControlRow"), Pro_inv_termsTableControlRow)

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                    
                        Dim rec As Pro_inv_termsRecord = New Pro_inv_termsRecord()
        
                        If recControl.narration.Text <> "" Then
                            rec.Parse(recControl.narration.Text, Pro_inv_termsTable.narration)
                        End If
                        If recControl.sort_order.Text <> "" Then
                            rec.Parse(recControl.sort_order.Text, Pro_inv_termsTable.sort_order)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If

            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
            
                newRecordList.Insert(0, New Pro_inv_termsRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
            
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(Pro_inv_termsRecord)), Pro_inv_termsRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As Pro_inv_termsTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As Pro_inv_termsTableControlRow) As Boolean
            If Me.DeletedRecordIds Is Nothing OrElse Me.DeletedRecordIds.Trim = "" Then
                Return False
            End If

            Return Me.DeletedRecordIds.IndexOf("[" & rec.RecordUniqueId & "]") >= 0
        End Function

        Private _DeletedRecordIds As String
        Public Property DeletedRecordIds() As String
            Get
                Return Me._DeletedRecordIds
            End Get
            Set(ByVal value As String)
                Me._DeletedRecordIds = value
            End Set
        End Property
        
      
        ' Create Set, WhereClause, and Populate Methods
        
        Public Overridable Sub SetnarrationLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setsort_orderLabel1()
            
                    
        End Sub
                
        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction
                Me.RegisterPostback()
                
                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    Dim added As Boolean = Me.AddNewRecord > 0
                    Me.LoadData()
                    Me.DataBind()
                    
                    If added Then
                        Me.SetFocusToAddedRow()
                    End If
                    
                End If
                				
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
        End Sub
        
        'this function sets focus to the first editable element in the new added row in the editable table	
        Protected Overridable Sub SetFocusToAddedRow()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Pro_inv_termsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing OrElse rep.Items.Count = 0 Then Return
            Dim repItem As System.Web.UI.WebControls.RepeaterItem
            For Each repItem In rep.Items  
			    'Load scripts to table rows
                Me.Page.LoadFocusScripts(repItem)
                Dim recControl As Pro_inv_termsTableControlRow = DirectCast(repItem.FindControl("Pro_inv_termsTableControlRow"), Pro_inv_termsTableControlRow)
                If recControl.IsNewRecord Then
                    For Each field As Control In recControl.Controls
                        If field.Visible AndAlso Me.Page.IsControlEditable(field, False) Then
						    'set focus on the first editable field in the new row
						    field.Focus()
                            Dim updPan As UpdatePanel = DirectCast(Me.Page.FindControlRecursively("UpdatePanel1"), UpdatePanel)
                            If Not updPan Is Nothing Then updPan.Update()
                            Return
                        End If
                    Next
                    Return
                End If
            Next
        End Sub
        
        
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()

            ' Save filter controls to values to session.
        
            
            ' Save table control properties to the session.
            If Not Me.CurrentSortOrder Is Nothing Then
            Me.SaveToSession(Me, "Order_By", Me.CurrentSortOrder.ToXmlString())
            End If
            Me.SaveToSession(Me, "Page_Index", Me.PageIndex.ToString())
            Me.SaveToSession(Me, "Page_Size", Me.PageSize.ToString())
        
            Me.SaveToSession(Me, "DeletedRecordIds", Me.DeletedRecordIds)  
        
        End Sub
        
        Protected  Sub SaveControlsToSession_Ajax()
            ' Save filter controls to values to session.
          
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            
            ' Clear table properties from the session.
            Me.RemoveFromSession(Me, "Order_By")
            Me.RemoveFromSession(Me, "Page_Index")
            Me.RemoveFromSession(Me, "Page_Size")
            
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("Pro_inv_termsTableControl_OrderBy"), String)
            
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            Else
                Me.CurrentSortOrder = New OrderBy(True, True)
            End If
            
            Dim pageIndex As String = CType(ViewState("Page_Index"), String)
            If pageIndex IsNot Nothing Then
                Me.PageIndex = CInt(pageIndex)
            End If

            Dim pageSize As String = CType(ViewState("Page_Size"), String)
            If Not pageSize Is Nothing Then
                Me.PageSize = CInt(pageSize)
            End If
        
            Me.DeletedRecordIds = CType(Me.ViewState("DeletedRecordIds"), String)
        
        End Sub

        Protected Overrides Function SaveViewState() As Object
            
            If Me.CurrentSortOrder IsNot Nothing Then
                Me.ViewState("Pro_inv_termsTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
        
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
            Return MyBase.SaveViewState()
        End Function

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_termsPagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            Me.PageIndex = 0
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_termsPagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            Me.DisplayLastPage = True
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_termsPagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            Me.PageIndex += 1
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for LinkButton
        Public Overridable Sub Pro_inv_termsPagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            Try
                
            Me.DataChanged = True
      
            Me.PageSize = Integer.Parse(Me.Pro_inv_termsPagination.PageSize.Text)
      
            Me.PageIndex = Integer.Parse(Me.Pro_inv_termsPagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_termsPagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            If Me.PageIndex > 0 Then
                Me.PageIndex -= 1
                Me.DataChanged = True
            End If
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        

        ' Generate the event handling functions for sorting events.
        
        Public Overridable Sub narrationLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by narration when clicked.
              
            ' Get previous sorting state for narration.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_termsTable.narration)
            If sd Is Nothing Then
                ' First time sort, so add sort order for narration.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_termsTable.narration, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by narration, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub sort_orderLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by sort_order when clicked.
              
            ' Get previous sorting state for sort_order.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_termsTable.sort_order)
            If sd Is Nothing Then
                ' First time sort, so add sort order for sort_order.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_termsTable.sort_order, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by sort_order, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            

        ' Generate the event handling functions for button events.
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_termsAddButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            Me.AddNewRecord = 1
            Me.DataChanged = True
      Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_termsDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            If(Not Me.Page.IsPageRefresh) Then
        
                Me.DeleteSelectedRecords(True)
          
            End If
      Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_termsResetButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
              Me.CurrentSortOrder.Reset()
              If Me.InSession(Me, "Order_By") Then
                  Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
              Else
                  Me.CurrentSortOrder = New OrderBy(True, True)
              
              End If
              

        ' Setting the DataChanged to True results in the page being refreshed with
        ' the most recent data from the database.  This happens in PreRender event
        ' based on the current sort, search and filter criteria.
        Me.DataChanged = True
            
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
      

        ' Generate the event handling functions for filter and search events.
        
      
        ' Generate the event handling functions for others
        
      
        Private _UIData As New System.Collections.Generic.List(Of Hashtable)
        Public Property UIData() As System.Collections.Generic.List(Of Hashtable)
            Get
                Return Me._UIData
            End Get
            Set(ByVal value As System.Collections.Generic.List(Of Hashtable))
                Me._UIData = value
            End Set
        End Property
        
        ' pagination properties
        Private _PageSize As Integer
        Public Property PageSize() As Integer
            Get
                Return Me._PageSize
            End Get
            Set(ByVal value As Integer)
                Me._PageSize = value
            End Set
        End Property

        Private _PageIndex As Integer
        Public Property PageIndex() As Integer
            Get
                ' Return the PageIndex
                Return Me._PageIndex
            End Get
            Set(ByVal value As Integer)
                Me._PageIndex = value
            End Set
        End Property

        Private _TotalRecords As Integer
        Public Property TotalRecords() As Integer
            Get
                Return Me._TotalRecords
            End Get
            Set(ByVal value As Integer)
                If Me.PageSize > 0 Then
                    Me.TotalPages = CInt(Math.Ceiling(value / Me.PageSize))
                End If
                Me._TotalRecords = value
            End Set
        End Property

        Private _TotalPages As Integer
        Public Property TotalPages() As Integer
            Get
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property

        Private _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property

        Private _DataChanged As Boolean = False
        Public Property DataChanged() As Boolean
            Get
                Return Me._DataChanged
            End Get
            Set(ByVal value As Boolean)
                Me._DataChanged = value
            End Set
        End Property
        
        Private _ResetData As Boolean = False
        Public Property ResetData() As Boolean
            Get
                Return Me._ResetData
            End Get
            Set(ByVal value As Boolean)
                Me._ResetData = value
            End Set
        End Property

        Private _AddNewRecord As Integer = 0
        Public Property AddNewRecord() As Integer
            Get
                Return Me._AddNewRecord
            End Get
            Set(ByVal value As Integer)
                Me._AddNewRecord = value
            End Set
        End Property

        
        Private _CurrentSortOrder As OrderBy = Nothing
        Public Property CurrentSortOrder() As OrderBy
            Get
                Return Me._CurrentSortOrder
            End Get
            Set(ByVal value As BaseClasses.Data.OrderBy)
                Me._CurrentSortOrder = value
            End Set
        End Property
        
        Private _DataSource() As Pro_inv_termsRecord = Nothing
        Public Property DataSource() As Pro_inv_termsRecord ()
            Get
                Return Me._DataSource
            End Get
            Set(ByVal value() As Pro_inv_termsRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property narrationLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "narrationLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_termsAddButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_termsAddButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_termsDeleteButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_termsDeleteButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_termsPagination() As ServelInvocing.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_termsPagination"), ServelInvocing.UI.IPagination)
          End Get
          End Property
        
        Public ReadOnly Property Pro_inv_termsResetButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_termsResetButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_termsToggleAll() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_termsToggleAll"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
        
        Public ReadOnly Property sort_orderLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "sort_orderLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"
        
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
      
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As Pro_inv_termsTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
                End If
                Dim rec As Pro_inv_termsRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
          
        Public Overridable Function GetSelectedRecordIndex() As Integer
            Dim counter As Integer = 0
            Dim recControl As Pro_inv_termsTableControlRow
            For Each recControl In Me.GetRecordControls()
                If recControl.Pro_inv_termsRecordRowSelection.Checked Then
                    Return counter
                End If
                counter += 1
            Next
            Return -1
        End Function
        
        Public Overridable Function GetSelectedRecordControl() As Pro_inv_termsTableControlRow
            Dim selectedList() As Pro_inv_termsTableControlRow = Me.GetSelectedRecordControls()
            If selectedList.Length = 0 Then
                Return Nothing
            End If
            Return selectedList(0)
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As Pro_inv_termsTableControlRow()
        
            Dim selectedList As ArrayList = New ArrayList(25)
            Dim recControl As Pro_inv_termsTableControlRow
            For Each recControl In Me.GetRecordControls()
                If recControl.Pro_inv_termsRecordRowSelection.Checked Then
                    selectedList.Add(recControl)
                End If
            Next
            Return DirectCast(selectedList.ToArray(GetType(Pro_inv_termsTableControlRow)), Pro_inv_termsTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As Pro_inv_termsTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
            End If
            
            Dim recCtl As Pro_inv_termsTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
                    recCtl.Pro_inv_termsRecordRowSelection.Checked = False
                
                Else
                
                    recCtl.Delete()
                    
                    ' Setting the DataChanged to True results in the page being refreshed with
                    ' the most recent data from the database.  This happens in PreRender event
                    ' based on the current sort, search and filter criteria.
                    Me.DataChanged = True
                    Me.ResetData = True
                  
                End If
            Next
        End Sub

        Public Function GetRecordControls() As Pro_inv_termsTableControlRow()
            Dim recList As ArrayList = New ArrayList()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Pro_inv_termsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return Nothing
            Dim repItem As System.Web.UI.WebControls.RepeaterItem

            For Each repItem In rep.Items
                Dim recControl As Pro_inv_termsTableControlRow = DirectCast(repItem.FindControl("Pro_inv_termsTableControlRow"), Pro_inv_termsTableControlRow)
                recList.Add(recControl)
            Next

            Return DirectCast(recList.ToArray(GetType(Pro_inv_termsTableControlRow)), Pro_inv_termsTableControlRow())
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

    

End Class

  
' Base class for the Pro_inv_hdrRecordControl control on the AddPro_inv_hdr page.
' Do not modify this class. Instead override any method in Pro_inv_hdrRecordControl.
Public Class BasePro_inv_hdrRecordControl
        Inherits ServelInvocing.UI.BaseApplicationRecordControl

        '  To customize, override this method in Pro_inv_hdrRecordControl.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
            ' Setup the filter and search events.
        
        End Sub

        '  To customize, override this method in Pro_inv_hdrRecordControl.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
              ' Setup the pagination events.	  
         
              ' Register the event handlers.
          
            AddHandler Me.CalculateButton.Button.Click, AddressOf CalculateButton_Click
        
              AddHandler Me.id_commodity.SelectedIndexChanged, AddressOf id_commodity_SelectedIndexChanged
            
              AddHandler Me.id_party.SelectedIndexChanged, AddressOf id_party_SelectedIndexChanged
            
              AddHandler Me.id_site.SelectedIndexChanged, AddressOf id_site_SelectedIndexChanged
            
              AddHandler Me.id_tax_group.SelectedIndexChanged, AddressOf id_tax_group_SelectedIndexChanged
            
              AddHandler Me.id_transporter.SelectedIndexChanged, AddressOf id_transporter_SelectedIndexChanged
            
              AddHandler Me.bill_address.TextChanged, AddressOf bill_address_TextChanged
            
              AddHandler Me.bill_name.TextChanged, AddressOf bill_name_TextChanged
            
              AddHandler Me.contact.TextChanged, AddressOf contact_TextChanged
            
              AddHandler Me.email.TextChanged, AddressOf email_TextChanged
            
              AddHandler Me.freight_to_pay.TextChanged, AddressOf freight_to_pay_TextChanged
            
              AddHandler Me.gr_rr_dt.TextChanged, AddressOf gr_rr_dt_TextChanged
            
              AddHandler Me.gr_rr_no.TextChanged, AddressOf gr_rr_no_TextChanged
            
              AddHandler Me.grand_total.TextChanged, AddressOf grand_total_TextChanged
            
              AddHandler Me.item_total.TextChanged, AddressOf item_total_TextChanged
            
              AddHandler Me.no_of_packages.TextChanged, AddressOf no_of_packages_TextChanged
            
              AddHandler Me.packing_details.TextChanged, AddressOf packing_details_TextChanged
            
              AddHandler Me.phone.TextChanged, AddressOf phone_TextChanged
            
              AddHandler Me.po_dt.TextChanged, AddressOf po_dt_TextChanged
            
              AddHandler Me.po_no.TextChanged, AddressOf po_no_TextChanged
            
              AddHandler Me.pro_inv_dt.TextChanged, AddressOf pro_inv_dt_TextChanged
            
              AddHandler Me.pro_inv_no.TextChanged, AddressOf pro_inv_no_TextChanged
            
              AddHandler Me.road_permit_no.TextChanged, AddressOf road_permit_no_TextChanged
            
              AddHandler Me.sale_ord_dt.TextChanged, AddressOf sale_ord_dt_TextChanged
            
              AddHandler Me.sale_ord_no.TextChanged, AddressOf sale_ord_no_TextChanged
            
              AddHandler Me.ship_address.TextChanged, AddressOf ship_address_TextChanged
            
              AddHandler Me.ship_name.TextChanged, AddressOf ship_name_TextChanged
            
              AddHandler Me.tin_no.TextChanged, AddressOf tin_no_TextChanged
            
              AddHandler Me.weight.TextChanged, AddressOf weight_TextChanged
            
        End Sub

        
        Public Overridable Sub LoadData()        
            ' Load the data from the database into the DataSource pro_inv_hdr record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = Pro_inv_hdrTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' This is the first time a record is being retrieved from the database.
            ' So create a Where Clause based on the staic Where clause specified
            ' on the Query wizard and the dynamic part specified by the end user
            ' on the search and filter controls (if any).
            
            Dim wc As WhereClause = Me.CreateWhereClause()
          
            ' If there is no Where clause, then simply create a new, blank record.
             
            If wc Is Nothing OrElse Not wc.RunQuery Then
                Me.DataSource = New Pro_inv_hdrRecord()
            
                Return
            End If
          
            ' Retrieve the record from the database.  It is possible
            
            Dim recList() As Pro_inv_hdrRecord = Pro_inv_hdrTable.GetRecords(wc, Nothing, 0, 2)
            If recList.Length = 0 Then
                ' There is no data for this Where clause.
                wc.RunQuery = False
                
                Return
            End If
            
            ' Set DataSource based on record retrieved from the database.
            Me.DataSource = CType(Pro_inv_hdrRecord.Copy(recList(0), False), Pro_inv_hdrRecord)
                  
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Pro_inv_hdrRecordControl.
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record.  To do this, it calls the Set methods for 
            ' each of the field displayed on the webpage.  It is better to make 
            ' changes in the Set methods, rather than making changes here.
            
            MyBase.DataBind()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
                Return
            End If
        
      
      
            ' Call the Set methods for each controls on the panel
        
            Setbill_address()
            Setbill_addressLabel()
            Setbill_name()
            Setbill_nameLabel()
            Setcontact()
            SetcontactLabel()
            Setemail()
            SetemailLabel()
            Setfreight_to_pay()
            Setfreight_to_payLabel()
            Setgr_rr_dt()
            Setgr_rr_dtLabel()
            Setgr_rr_no()
            Setgr_rr_noLabel()
            Setgrand_total()
            Setgrand_totalLabel()
            Setid_commodity()
            Setid_commodityLabel()
            Setid_party()
            Setid_partyLabel()
            Setid_site()
            Setid_siteLabel()
            Setid_tax_group()
            Setid_tax_groupLabel()
            Setid_transporter()
            Setid_transporterLabel()
            Setitem_total()
            Setitem_totalLabel()
            Setno_of_packages()
            Setno_of_packagesLabel()
            Setpacking_details()
            Setpacking_detailsLabel()
            Setphone()
            SetphoneLabel()
            Setpo_dt()
            Setpo_dtLabel()
            Setpo_no()
            Setpo_noLabel()
            Setpro_inv_dt()
            Setpro_inv_dtLabel()
            Setpro_inv_no()
            Setpro_inv_noLabel()
            Setroad_permit_no()
            Setroad_permit_noLabel()
            Setsale_ord_dt()
            Setsale_ord_dtLabel()
            Setsale_ord_no()
            Setsale_ord_noLabel()
            Setship_address()
            Setship_addressLabel()
            Setship_name()
            Setship_nameLabel()
            Settin_no()
            Settin_noLabel()
            Setweight()
            SetweightLabel()
      
      
            Me.IsNewRecord = True
            
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
                
                Me.RecordUniqueId = Me.DataSource.GetID.ToXmlString()
            End If
          
            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False
            
        Dim recPro_inv_itemsTableControl as Pro_inv_itemsTableControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Pro_inv_itemsTableControl"), Pro_inv_itemsTableControl)
        
            If (shouldResetControl OrElse Me.Page.IsPageRefresh)
              recPro_inv_itemsTableControl.ResetControl()
            End IF
        
        recPro_inv_itemsTableControl.LoadData()
        recPro_inv_itemsTableControl.DataBind()
        
        Dim recPro_inv_taxesTableControl as Pro_inv_taxesTableControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Pro_inv_taxesTableControl"), Pro_inv_taxesTableControl)
        
            If (shouldResetControl OrElse Me.Page.IsPageRefresh)
              recPro_inv_taxesTableControl.ResetControl()
            End IF
        
        recPro_inv_taxesTableControl.LoadData()
        recPro_inv_taxesTableControl.DataBind()
        
        Dim recPro_inv_termsTableControl as Pro_inv_termsTableControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Pro_inv_termsTableControl"), Pro_inv_termsTableControl)
        
            If (shouldResetControl OrElse Me.Page.IsPageRefresh)
              recPro_inv_termsTableControl.ResetControl()
            End IF
        
        recPro_inv_termsTableControl.LoadData()
        recPro_inv_termsTableControl.DataBind()
              
        End Sub
        
        
        Public Overridable Sub Setbill_address()
            
        
            ' Set the bill_address TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.bill_address is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setbill_address()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.bill_addressSpecified Then
                				
                ' If the bill_address is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.bill_address)
                            
                Me.bill_address.Text = formattedValue
              
            Else 
            
                ' bill_address is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.bill_address.Text = Pro_inv_hdrTable.bill_address.Format(Pro_inv_hdrTable.bill_address.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setbill_name()
            
        
            ' Set the bill_name TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.bill_name is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setbill_name()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.bill_nameSpecified Then
                				
                ' If the bill_name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.bill_name)
                            
                Me.bill_name.Text = formattedValue
              
            Else 
            
                ' bill_name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.bill_name.Text = Pro_inv_hdrTable.bill_name.Format(Pro_inv_hdrTable.bill_name.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setcontact()
            
        
            ' Set the contact TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.contact is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcontact()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.contactSpecified Then
                				
                ' If the contact is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.contact)
                            
                Me.contact.Text = formattedValue
              
            Else 
            
                ' contact is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.contact.Text = Pro_inv_hdrTable.contact.Format(Pro_inv_hdrTable.contact.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setemail()
            
        
            ' Set the email TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.email is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setemail()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.emailSpecified Then
                				
                ' If the email is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.email)
                            
                Me.email.Text = formattedValue
              
            Else 
            
                ' email is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.email.Text = Pro_inv_hdrTable.email.Format(Pro_inv_hdrTable.email.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setfreight_to_pay()
            
        
            ' Set the freight_to_pay TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.freight_to_pay is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setfreight_to_pay()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.freight_to_paySpecified Then
                				
                ' If the freight_to_pay is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.freight_to_pay)
                            
                Me.freight_to_pay.Text = formattedValue
              
            Else 
            
                ' freight_to_pay is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.freight_to_pay.Text = Pro_inv_hdrTable.freight_to_pay.Format(Pro_inv_hdrTable.freight_to_pay.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setgr_rr_dt()
            
        
            ' Set the gr_rr_dt TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.gr_rr_dt is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setgr_rr_dt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.gr_rr_dtSpecified Then
                				
                ' If the gr_rr_dt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.gr_rr_dt, "d")
                            
                Me.gr_rr_dt.Text = formattedValue
              
            Else 
            
                ' gr_rr_dt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.gr_rr_dt.Text = Pro_inv_hdrTable.gr_rr_dt.Format(Pro_inv_hdrTable.gr_rr_dt.DefaultValue, "d")
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setgr_rr_no()
            
        
            ' Set the gr_rr_no TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.gr_rr_no is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setgr_rr_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.gr_rr_noSpecified Then
                				
                ' If the gr_rr_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.gr_rr_no)
                            
                Me.gr_rr_no.Text = formattedValue
              
            Else 
            
                ' gr_rr_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.gr_rr_no.Text = Pro_inv_hdrTable.gr_rr_no.Format(Pro_inv_hdrTable.gr_rr_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setgrand_total()
            
        
            ' Set the grand_total TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.grand_total is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setgrand_total()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.grand_totalSpecified Then
                				
                ' If the grand_total is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.grand_total)
                            
                Me.grand_total.Text = formattedValue
              
            Else 
            
                ' grand_total is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.grand_total.Text = Pro_inv_hdrTable.grand_total.Format(Pro_inv_hdrTable.grand_total.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setid_commodity()
            
        
            ' Set the id_commodity DropDownList on the webpage with value from the
            ' pro_inv_hdr database record.
            
            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.id_commodity is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_commodity()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_commoditySpecified Then
                            
                ' If the id_commodity is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.Populateid_commodityDropDownList(Me.DataSource.id_commodity.ToString(), 100)
                
            Else
                
                ' id_commodity is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.Populateid_commodityDropDownList(Nothing, 100)
                Else
                    Me.Populateid_commodityDropDownList(Pro_inv_hdrTable.id_commodity.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub Setid_party()
            
            ' Set AutoPostBack to true so that when the control value is changed, to refresh id_site controls
            Me.id_party.AutoPostBack = True
            
        
            ' Set the id_party DropDownList on the webpage with value from the
            ' pro_inv_hdr database record.
            
            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.id_party is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_party()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_partySpecified Then
                            
                ' If the id_party is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.Populateid_partyDropDownList(Me.DataSource.id_party.ToString(), 100)
                
            Else
                
                ' id_party is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.Populateid_partyDropDownList(Nothing, 100)
                Else
                    Me.Populateid_partyDropDownList(Pro_inv_hdrTable.id_party.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub Setid_site()
            
        
            ' Set the id_site DropDownList on the webpage with value from the
            ' pro_inv_hdr database record.
            
            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.id_site is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_site()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_siteSpecified Then
                            
                ' If the id_site is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.Populateid_siteDropDownList(Me.DataSource.id_site.ToString(), 100)
                
            Else
                
                ' id_site is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.Populateid_siteDropDownList(Nothing, 100)
                Else
                    Me.Populateid_siteDropDownList(Pro_inv_hdrTable.id_site.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub Setid_tax_group()
            
        
            ' Set the id_tax_group DropDownList on the webpage with value from the
            ' pro_inv_hdr database record.
            
            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.id_tax_group is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_tax_group()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_tax_groupSpecified Then
                            
                ' If the id_tax_group is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.Populateid_tax_groupDropDownList(Me.DataSource.id_tax_group.ToString(), 100)
                
            Else
                
                ' id_tax_group is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.Populateid_tax_groupDropDownList(Nothing, 100)
                Else
                    Me.Populateid_tax_groupDropDownList(Pro_inv_hdrTable.id_tax_group.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub Setid_transporter()
            
        
            ' Set the id_transporter DropDownList on the webpage with value from the
            ' pro_inv_hdr database record.
            
            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.id_transporter is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_transporter()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_transporterSpecified Then
                            
                ' If the id_transporter is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.Populateid_transporterDropDownList(Me.DataSource.id_transporter.ToString(), 100)
                
            Else
                
                ' id_transporter is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.Populateid_transporterDropDownList(Nothing, 100)
                Else
                    Me.Populateid_transporterDropDownList(Pro_inv_hdrTable.id_transporter.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub Setitem_total()
            
        
            ' Set the item_total TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.item_total is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setitem_total()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.item_totalSpecified Then
                				
                ' If the item_total is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.item_total)
                            
                Me.item_total.Text = formattedValue
              
            Else 
            
                ' item_total is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.item_total.Text = Pro_inv_hdrTable.item_total.Format(Pro_inv_hdrTable.item_total.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setno_of_packages()
            
        
            ' Set the no_of_packages TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.no_of_packages is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setno_of_packages()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.no_of_packagesSpecified Then
                				
                ' If the no_of_packages is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.no_of_packages)
                            
                Me.no_of_packages.Text = formattedValue
              
            Else 
            
                ' no_of_packages is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.no_of_packages.Text = Pro_inv_hdrTable.no_of_packages.Format(Pro_inv_hdrTable.no_of_packages.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setpacking_details()
            
        
            ' Set the packing_details TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.packing_details is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpacking_details()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.packing_detailsSpecified Then
                				
                ' If the packing_details is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.packing_details)
                            
                Me.packing_details.Text = formattedValue
              
            Else 
            
                ' packing_details is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.packing_details.Text = Pro_inv_hdrTable.packing_details.Format(Pro_inv_hdrTable.packing_details.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setphone()
            
        
            ' Set the phone TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.phone is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setphone()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.phoneSpecified Then
                				
                ' If the phone is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.phone)
                            
                Me.phone.Text = formattedValue
              
            Else 
            
                ' phone is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.phone.Text = Pro_inv_hdrTable.phone.Format(Pro_inv_hdrTable.phone.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setpo_dt()
            
        
            ' Set the po_dt TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.po_dt is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpo_dt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the po_dt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.po_dt, "d")
                            
                Me.po_dt.Text = formattedValue
              
            Else 
            
                ' po_dt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.po_dt.Text = EvaluateFormula("Today()", Me.DataSource, "d")		
                End If
                 
        End Sub
                
        Public Overridable Sub Setpo_no()
            
        
            ' Set the po_no TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.po_no is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpo_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.po_noSpecified Then
                				
                ' If the po_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.po_no)
                            
                Me.po_no.Text = formattedValue
              
            Else 
            
                ' po_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.po_no.Text = Pro_inv_hdrTable.po_no.Format(Pro_inv_hdrTable.po_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setpro_inv_dt()
            
        
            ' Set the pro_inv_dt TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.pro_inv_dt is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpro_inv_dt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the pro_inv_dt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.pro_inv_dt, "d")
                            
                Me.pro_inv_dt.Text = formattedValue
              
            Else 
            
                ' pro_inv_dt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.pro_inv_dt.Text = EvaluateFormula("Today()", Me.DataSource, "d")		
                End If
                 
        End Sub
                
        Public Overridable Sub Setpro_inv_no()
            
        
            ' Set the pro_inv_no TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.pro_inv_no is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpro_inv_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.pro_inv_noSpecified Then
                				
                ' If the pro_inv_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.pro_inv_no)
                            
                Me.pro_inv_no.Text = formattedValue
              
            Else 
            
                ' pro_inv_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.pro_inv_no.Text = Pro_inv_hdrTable.pro_inv_no.Format(Pro_inv_hdrTable.pro_inv_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setroad_permit_no()
            
        
            ' Set the road_permit_no TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.road_permit_no is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setroad_permit_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.road_permit_noSpecified Then
                				
                ' If the road_permit_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.road_permit_no)
                            
                Me.road_permit_no.Text = formattedValue
              
            Else 
            
                ' road_permit_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.road_permit_no.Text = Pro_inv_hdrTable.road_permit_no.Format(Pro_inv_hdrTable.road_permit_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setsale_ord_dt()
            
        
            ' Set the sale_ord_dt TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.sale_ord_dt is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setsale_ord_dt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the sale_ord_dt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.sale_ord_dt, "d")
                            
                Me.sale_ord_dt.Text = formattedValue
              
            Else 
            
                ' sale_ord_dt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.sale_ord_dt.Text = EvaluateFormula("Today()", Me.DataSource, "d")		
                End If
                 
        End Sub
                
        Public Overridable Sub Setsale_ord_no()
            
        
            ' Set the sale_ord_no TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.sale_ord_no is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setsale_ord_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.sale_ord_noSpecified Then
                				
                ' If the sale_ord_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.sale_ord_no)
                            
                Me.sale_ord_no.Text = formattedValue
              
            Else 
            
                ' sale_ord_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.sale_ord_no.Text = Pro_inv_hdrTable.sale_ord_no.Format(Pro_inv_hdrTable.sale_ord_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setship_address()
            
        
            ' Set the ship_address TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.ship_address is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setship_address()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ship_addressSpecified Then
                				
                ' If the ship_address is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.ship_address)
                            
                Me.ship_address.Text = formattedValue
              
            Else 
            
                ' ship_address is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ship_address.Text = Pro_inv_hdrTable.ship_address.Format(Pro_inv_hdrTable.ship_address.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setship_name()
            
        
            ' Set the ship_name TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.ship_name is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setship_name()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ship_nameSpecified Then
                				
                ' If the ship_name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.ship_name)
                            
                Me.ship_name.Text = formattedValue
              
            Else 
            
                ' ship_name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ship_name.Text = Pro_inv_hdrTable.ship_name.Format(Pro_inv_hdrTable.ship_name.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Settin_no()
            
        
            ' Set the tin_no TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.tin_no is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settin_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tin_noSpecified Then
                				
                ' If the tin_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.tin_no)
                            
                Me.tin_no.Text = formattedValue
              
            Else 
            
                ' tin_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tin_no.Text = Pro_inv_hdrTable.tin_no.Format(Pro_inv_hdrTable.tin_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setweight()
            
        
            ' Set the weight TextBox on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.weight is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setweight()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.weightSpecified Then
                				
                ' If the weight is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.weight)
                            
                Me.weight.Text = formattedValue
              
            Else 
            
                ' weight is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.weight.Text = Pro_inv_hdrTable.weight.Format(Pro_inv_hdrTable.weight.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setbill_addressLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setbill_nameLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetcontactLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetemailLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setfreight_to_payLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setgr_rr_dtLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setgr_rr_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setgrand_totalLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setid_commodityLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setid_partyLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setid_siteLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setid_tax_groupLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setid_transporterLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setitem_totalLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setno_of_packagesLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setpacking_detailsLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetphoneLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setpo_dtLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setpo_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setpro_inv_dtLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setpro_inv_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setroad_permit_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setsale_ord_dtLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setsale_ord_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setship_addressLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setship_nameLabel()
            
                    
        End Sub
                
        Public Overridable Sub Settin_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetweightLabel()
            
                    
        End Sub
                
        Public Overridable Sub ResetControl()
          
        End Sub
        
      
        Public Overridable Function EvaluateFormula(ByVal formula As String, Optional ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord = Nothing, Optional ByVal format as String = Nothing) As String
            Dim e As FormulaEvaluator = New FormulaEvaluator()

            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            If dataSourceForEvaluate Is Nothing Then
                
                e.DataSource = Me.DataSource
                
            Else
                e.DataSource = dataSourceForEvaluate
            End If

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing
                Return ""
            End If
            
            If format IsNot Nothing
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function	  
      

        Public Overridable Sub RegisterPostback()
        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"CalculateButton"))
                        
        
        End Sub

      
        
        ' To customize, override this method in Pro_inv_hdrRecordControl.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
              
            ' 2. Perform any custom validation.
            Me.Validate()

            
            ' 3. Set the values in the record with data from UI controls.
            ' This calls the Get() method for each of the user interface controls.
            Me.GetUIData()

            ' 4. Save in the database.
            ' We should not save the record if the data did not change. This
            ' will save a database hit and avoid triggering any database triggers.
             
            If Me.DataSource.IsAnyValueChanged Then
                ' Save record to database but do not commit yet.
                ' Auto generated ids are available after saving for use by child (dependent) records.
                Me.DataSource.Save()
              
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        Dim recPro_inv_itemsTableControl as Pro_inv_itemsTableControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Pro_inv_itemsTableControl"), Pro_inv_itemsTableControl)
        recPro_inv_itemsTableControl.SaveData()
        
        Dim recPro_inv_taxesTableControl as Pro_inv_taxesTableControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Pro_inv_taxesTableControl"), Pro_inv_taxesTableControl)
        recPro_inv_taxesTableControl.SaveData()
        
        Dim recPro_inv_termsTableControl as Pro_inv_termsTableControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Pro_inv_termsTableControl"), Pro_inv_termsTableControl)
        recPro_inv_termsTableControl.SaveData()
        
        End Sub

        ' To customize, override this method in Pro_inv_hdrRecordControl.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
            
            Dim clearDataSource As Boolean = False
            Dim col As BaseColumn
            
            For Each col In Pro_inv_hdrRecord.TableUtils.TableDefinition.Columns()
                If col.ColumnType.Equals(BaseColumn.ColumnTypes.Unique_Identifier) Then
                    clearDataSource = True
                End If
            Next
            

            If clearDataSource Then
                
                Me.DataSource = New Pro_inv_hdrRecord()
            
            End If
            
      
            ' Call the Get methods for each of the user interface controls.
        
            Getbill_address()
            Getbill_name()
            Getcontact()
            Getemail()
            Getfreight_to_pay()
            Getgr_rr_dt()
            Getgr_rr_no()
            Getgrand_total()
            Getid_commodity()
            Getid_party()
            Getid_site()
            Getid_tax_group()
            Getid_transporter()
            Getitem_total()
            Getno_of_packages()
            Getpacking_details()
            Getphone()
            Getpo_dt()
            Getpo_no()
            Getpro_inv_dt()
            Getpro_inv_no()
            Getroad_permit_no()
            Getsale_ord_dt()
            Getsale_ord_no()
            Getship_address()
            Getship_name()
            Gettin_no()
            Getweight()
        End Sub
        
        
        Public Overridable Sub Getbill_address()
            
            ' Retrieve the value entered by the user on the bill_address ASP:TextBox, and
            ' save it into the bill_address field in DataSource pro_inv_hdr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.bill_address.Text, Pro_inv_hdrTable.bill_address)			

                      
        End Sub
                
        Public Overridable Sub Getbill_name()
            
            ' Retrieve the value entered by the user on the bill_name ASP:TextBox, and
            ' save it into the bill_name field in DataSource pro_inv_hdr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.bill_name.Text, Pro_inv_hdrTable.bill_name)			

                      
        End Sub
                
        Public Overridable Sub Getcontact()
            
            ' Retrieve the value entered by the user on the contact ASP:TextBox, and
            ' save it into the contact field in DataSource pro_inv_hdr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.contact.Text, Pro_inv_hdrTable.contact)			

                      
        End Sub
                
        Public Overridable Sub Getemail()
            
            ' Retrieve the value entered by the user on the email ASP:TextBox, and
            ' save it into the email field in DataSource pro_inv_hdr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.email.Text, Pro_inv_hdrTable.email)			

                      
        End Sub
                
        Public Overridable Sub Getfreight_to_pay()
            
            ' Retrieve the value entered by the user on the freight_to_pay ASP:TextBox, and
            ' save it into the freight_to_pay field in DataSource pro_inv_hdr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.freight_to_pay.Text, Pro_inv_hdrTable.freight_to_pay)			

                      
        End Sub
                
        Public Overridable Sub Getgr_rr_dt()
            
            ' Retrieve the value entered by the user on the gr_rr_dt ASP:TextBox, and
            ' save it into the gr_rr_dt field in DataSource pro_inv_hdr record.
            ' Parse will also validate the date to ensure it is of the proper format
            ' and a valid date.  The format is verified based on the current culture 
            ' settings including the order of month, day and year and the separator character.
            ' Parse throws an exception if the date is invalid.
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.gr_rr_dt.Text, Pro_inv_hdrTable.gr_rr_dt)			

                      
        End Sub
                
        Public Overridable Sub Getgr_rr_no()
            
            ' Retrieve the value entered by the user on the gr_rr_no ASP:TextBox, and
            ' save it into the gr_rr_no field in DataSource pro_inv_hdr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.gr_rr_no.Text, Pro_inv_hdrTable.gr_rr_no)			

                      
        End Sub
                
        Public Overridable Sub Getgrand_total()
            
            ' Retrieve the value entered by the user on the grand_total ASP:TextBox, and
            ' save it into the grand_total field in DataSource pro_inv_hdr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.grand_total.Text, Pro_inv_hdrTable.grand_total)			

                      
        End Sub
                
        Public Overridable Sub Getid_commodity()
         
            ' Retrieve the value entered by the user on the id_commodity ASP:DropDownList, and
            ' save it into the id_commodity field in DataSource pro_inv_hdr record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.id_commodity), Pro_inv_hdrTable.id_commodity)				
            
        End Sub
                
        Public Overridable Sub Getid_party()
         
            ' Retrieve the value entered by the user on the id_party ASP:DropDownList, and
            ' save it into the id_party field in DataSource pro_inv_hdr record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.id_party), Pro_inv_hdrTable.id_party)				
            
        End Sub
                
        Public Overridable Sub Getid_site()
         
            ' Retrieve the value entered by the user on the id_site ASP:DropDownList, and
            ' save it into the id_site field in DataSource pro_inv_hdr record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.id_site), Pro_inv_hdrTable.id_site)				
            
        End Sub
                
        Public Overridable Sub Getid_tax_group()
         
            ' Retrieve the value entered by the user on the id_tax_group ASP:DropDownList, and
            ' save it into the id_tax_group field in DataSource pro_inv_hdr record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.id_tax_group), Pro_inv_hdrTable.id_tax_group)				
            
        End Sub
                
        Public Overridable Sub Getid_transporter()
         
            ' Retrieve the value entered by the user on the id_transporter ASP:DropDownList, and
            ' save it into the id_transporter field in DataSource pro_inv_hdr record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.id_transporter), Pro_inv_hdrTable.id_transporter)				
            
        End Sub
                
        Public Overridable Sub Getitem_total()
            
            ' Retrieve the value entered by the user on the item_total ASP:TextBox, and
            ' save it into the item_total field in DataSource pro_inv_hdr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.item_total.Text, Pro_inv_hdrTable.item_total)			

                      
        End Sub
                
        Public Overridable Sub Getno_of_packages()
            
            ' Retrieve the value entered by the user on the no_of_packages ASP:TextBox, and
            ' save it into the no_of_packages field in DataSource pro_inv_hdr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.no_of_packages.Text, Pro_inv_hdrTable.no_of_packages)			

                      
        End Sub
                
        Public Overridable Sub Getpacking_details()
            
            ' Retrieve the value entered by the user on the packing_details ASP:TextBox, and
            ' save it into the packing_details field in DataSource pro_inv_hdr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.packing_details.Text, Pro_inv_hdrTable.packing_details)			

                      
        End Sub
                
        Public Overridable Sub Getphone()
            
            ' Retrieve the value entered by the user on the phone ASP:TextBox, and
            ' save it into the phone field in DataSource pro_inv_hdr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.phone.Text, Pro_inv_hdrTable.phone)			

                      
        End Sub
                
        Public Overridable Sub Getpo_dt()
            
            ' Retrieve the value entered by the user on the po_dt ASP:TextBox, and
            ' save it into the po_dt field in DataSource pro_inv_hdr record.
            ' Parse will also validate the date to ensure it is of the proper format
            ' and a valid date.  The format is verified based on the current culture 
            ' settings including the order of month, day and year and the separator character.
            ' Parse throws an exception if the date is invalid.
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.po_dt.Text, Pro_inv_hdrTable.po_dt)			

                      
        End Sub
                
        Public Overridable Sub Getpo_no()
            
            ' Retrieve the value entered by the user on the po_no ASP:TextBox, and
            ' save it into the po_no field in DataSource pro_inv_hdr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.po_no.Text, Pro_inv_hdrTable.po_no)			

                      
        End Sub
                
        Public Overridable Sub Getpro_inv_dt()
            
            ' Retrieve the value entered by the user on the pro_inv_dt ASP:TextBox, and
            ' save it into the pro_inv_dt field in DataSource pro_inv_hdr record.
            ' Parse will also validate the date to ensure it is of the proper format
            ' and a valid date.  The format is verified based on the current culture 
            ' settings including the order of month, day and year and the separator character.
            ' Parse throws an exception if the date is invalid.
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.pro_inv_dt.Text, Pro_inv_hdrTable.pro_inv_dt)			

                      
        End Sub
                
        Public Overridable Sub Getpro_inv_no()
            
            ' Retrieve the value entered by the user on the pro_inv_no ASP:TextBox, and
            ' save it into the pro_inv_no field in DataSource pro_inv_hdr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.pro_inv_no.Text, Pro_inv_hdrTable.pro_inv_no)			

                      
        End Sub
                
        Public Overridable Sub Getroad_permit_no()
            
            ' Retrieve the value entered by the user on the road_permit_no ASP:TextBox, and
            ' save it into the road_permit_no field in DataSource pro_inv_hdr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.road_permit_no.Text, Pro_inv_hdrTable.road_permit_no)			

                      
        End Sub
                
        Public Overridable Sub Getsale_ord_dt()
            
            ' Retrieve the value entered by the user on the sale_ord_dt ASP:TextBox, and
            ' save it into the sale_ord_dt field in DataSource pro_inv_hdr record.
            ' Parse will also validate the date to ensure it is of the proper format
            ' and a valid date.  The format is verified based on the current culture 
            ' settings including the order of month, day and year and the separator character.
            ' Parse throws an exception if the date is invalid.
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.sale_ord_dt.Text, Pro_inv_hdrTable.sale_ord_dt)			

                      
        End Sub
                
        Public Overridable Sub Getsale_ord_no()
            
            ' Retrieve the value entered by the user on the sale_ord_no ASP:TextBox, and
            ' save it into the sale_ord_no field in DataSource pro_inv_hdr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.sale_ord_no.Text, Pro_inv_hdrTable.sale_ord_no)			

                      
        End Sub
                
        Public Overridable Sub Getship_address()
            
            ' Retrieve the value entered by the user on the ship_address ASP:TextBox, and
            ' save it into the ship_address field in DataSource pro_inv_hdr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.ship_address.Text, Pro_inv_hdrTable.ship_address)			

                      
        End Sub
                
        Public Overridable Sub Getship_name()
            
            ' Retrieve the value entered by the user on the ship_name ASP:TextBox, and
            ' save it into the ship_name field in DataSource pro_inv_hdr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.ship_name.Text, Pro_inv_hdrTable.ship_name)			

                      
        End Sub
                
        Public Overridable Sub Gettin_no()
            
            ' Retrieve the value entered by the user on the tin_no ASP:TextBox, and
            ' save it into the tin_no field in DataSource pro_inv_hdr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.tin_no.Text, Pro_inv_hdrTable.tin_no)			

                      
        End Sub
                
        Public Overridable Sub Getweight()
            
            ' Retrieve the value entered by the user on the weight ASP:TextBox, and
            ' save it into the weight field in DataSource pro_inv_hdr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.weight.Text, Pro_inv_hdrTable.weight)			

                      
        End Sub
                
      
        ' To customize, override this method in Pro_inv_hdrRecordControl.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
            Dim wc As WhereClause
            Pro_inv_hdrTable.Instance.InnerFilter = Nothing
            wc = New WhereClause()
            
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.
            
            ' Retrieve the record id from the URL parameter.
            Dim recId As String = Me.Page.Request.QueryString.Item("Pro_inv_hdr")
            If recId Is Nothing OrElse recId.Trim = "" Then
                
                Return Nothing
                
            End If
              
            HttpContext.Current.Session("QueryString in AddPro_inv_hdr") = recId
                
            If KeyValue.IsXmlKey(recId) Then
                ' Keys are typically passed as XML structures to handle composite keys.
                ' If XML, then add a Where clause based on the Primary Key in the XML.
                Dim pkValue As KeyValue = KeyValue.XmlToKey(recId)
                 
                wc.iAND(Pro_inv_hdrTable.id0, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValue(Pro_inv_hdrTable.id0).ToString())
        
                    Else
                    ' The URL parameter contains the actual value, not an XML structure.
                    
                wc.iAND(Pro_inv_hdrTable.id0, BaseFilter.ComparisonOperator.EqualsTo, recId)
        
            End If
                
            Return wc
            
        End Function
        
        ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        
        Public Overridable Function CreateWhereClause(ByVal searchText As String, ByVal fromSearchControl As String, ByVal AutoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String) As WhereClause
            Pro_inv_hdrTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.
            Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
            
            
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
       
          
            Return wc
        End Function
          
          
        'Formats the resultItem and adds it to the list of suggestions.
        Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                                 ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                                 ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                                 ByVal resultList As ArrayList) As Boolean
            Dim index As Integer = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))
            Dim itemToAdd As String = ""
            Dim isFound As Boolean = False
            Dim isAdded As Boolean = False
            ' Get the index where prfixt is at the beginning of resultItem. If not found then, index of word which begins with prefixText.
            If InvariantLCase(autoTypeAheadSearch).equals("wordsstartingwithsearchstring") and not index = 0 Then
                ' Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                Dim regex1 As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                If regex1.IsMatch(resultItem) Then
                    index = regex1.Match(resultItem).Index
                    isFound = True
                End If
                ' If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                If not resultItem(index).ToString() = " " Then
                    ' Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    Dim regex As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    If regex.IsMatch(resultItem) Then
                        index = regex.Match(resultItem).Index
                        isFound = True
                    End If
                 End If
            End If
            ' If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            ' beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            If index = 0 Or isFound Or InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") then
                If InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atbeginningofmatchedstring") Then
                    ' Expression to find beginning of the word which contains prefixText
                    Dim regex1 As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    '  Find the beginning of the word which contains prefexText
                    If (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") AndAlso regex1.IsMatch(resultItem)) Then
                        index = regex1.Match(resultItem).Index
                        isFound = True
                    End If
                    ' Display string from the index till end of the string if sub string from index till end is less than columnLength value.
                    If Len(resultItem) - index <= columnLength Then
                        If index = 0 Then 
                            itemToAdd = resultItem 
                        Else
                            itemToAdd = "..." & resultItem.Substring(index, Len(resultItem) - index) 
                        End If
                    Else
                        If index = 0 Then
                            itemToAdd = resultItem.Substring(index, (columnLength - 3)) & "..."
                        Else
                            'Truncate the string to show only columnLength - 6 characters as begining and trailing "..." has to be appended.
                            itemToAdd = "..." & resultItem.Substring(index , columnLength - 6) & "..." 
                        End If
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("inmiddleofmatchedstring") Then
                    Dim subStringBeginIndex As Integer = CType(columnLength/2, Integer)
                    If Len(resultItem) <= columnLength Then
                        itemToAdd = resultItem
                    Else
                        ' Sanity check at end of the string
                        If index + Len(prefixText) = columnLength Then
                            itemToAdd =  "..." & resultItem.Substring(index-columnLength,index)
                        ElseIf Len(resultItem) - index < subStringBeginIndex Then 
                            ' Display string from the end till columnLength value if, index is closer to the end of the string.
                            itemToAdd =  "..." & resultItem.Substring(Len(resultItem)-columnLength,Len(resultItem))
                        ElseIf index <= subStringBeginIndex Then 
                            ' Sanity chet at beginning of the string
                            itemToAdd =  resultItem.Substring(0, columnLength) & "..."
                        Else
                            ' Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd =  "..." & resultItem.Substring(index - subStringBeginIndex, columnLength) & "..." 
                        End If
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atendofmatchedstring") Then
                     ' Expression to find ending of the word which contains prefexText
                    Dim regex1 As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex("\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    ' Find the ending of the word which contains prefexText
                    If regex1.IsMatch(resultItem, index + 1) Then
                        index = regex1.Match(resultItem, index + 1).Index
                    Else
                        ' If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length
                    End If
                    If index > Len(resultItem) Then
                        index = Len(resultItem)
                    End If
                    ' If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    If  index <= columnLength Then
                        if index = Len(resultItem) then   'Make decision to append "..."
                            itemToAdd = resultItem.Substring(0,index)
                        Else
                            itemToAdd = resultItem.Substring(0,index) & "..."
                        End If
                    Else
                        If index = Len(resultItem) Then
                            itemToAdd = "..." & resultItem.Substring(index - (columnLength - 3), (columnLength - 3))
                        Else
                            'Truncate the string to show only columnLength - 6 characters as begining and trailing "..." has to be appended.
                            itemToAdd = "..." & resultItem.Substring(index - (columnLength - 6), columnLength - 6) & "..." 
                        End If
                    End If
                End If
                
                ' Remove newline character from itemToAdd
                Dim prefixTextIndex As Integer = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase)
                ' If itemToAdd contains any newline after the search text then show text only till newline
                Dim regex2 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                Dim newLineIndexAfterPrefix As Integer = -1
                If regex2.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexAfterPrefix > -1) Then
                    If itemToAdd.EndsWith("...") Then
                        itemToAdd = (itemToAdd.Substring(0, newLineIndexAfterPrefix) + "...")
                    Else
                        itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix)
                    End If
                End If
                ' If itemToAdd contains any newline before search text then show text which comes after newline
                Dim regex3 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", (System.Text.RegularExpressions.RegexOptions.IgnoreCase Or System.Text.RegularExpressions.RegexOptions.RightToLeft))
                Dim newLineIndexBeforePrefix As Integer = -1
                If regex3.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexBeforePrefix > -1) Then
                    If itemToAdd.StartsWith("...") Then
                        itemToAdd = ("..." + itemToAdd.Substring((newLineIndexBeforePrefix + regex3.Match(itemToAdd, prefixTextIndex).Length)))
                    Else
                        itemToAdd = itemToAdd.Substring((newLineIndexBeforePrefix + regex3.Match(itemToAdd, prefixTextIndex).Length))
                    End If
                End If

                If Not itemToAdd is nothing AndAlso Not resultList.Contains(itemToAdd) Then
                    resultList.Add(itemToAdd)
                    isAdded = true
                End If
            End If
            Return isAdded
        End Function
        

        ' To customize, override this method in Pro_inv_hdrRecordControl.
        Public Overridable Sub Validate() 
            ' Add custom validation for any control within this panel.
            ' Example.  If you have a State ASP:Textbox control
            ' If Me.State.Text <> "CA" Then
            '    Throw New Exception("State must be CA (California).")
            ' End If

            ' The Validate method is common across all controls within
            ' this panel so you can validate multiple fields, but report
            ' one error message.
            
                
        End Sub

        Public Overridable Sub Delete()
        
            If Me.IsNewRecord() Then
                Return
            End If

            Dim pkValue As KeyValue = KeyValue.XmlToKey(Me.RecordUniqueId)
          Pro_inv_hdrTable.DeleteRecord(pkValue)
          
        End Sub

        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction()
                Me.RegisterPostback()

                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    Me.LoadData()
                    Me.DataBind()			
                End If
                						
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction()
            End Try
        End Sub
        
        

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)
            Dim isNewRecord As String = CType(ViewState("IsNewRecord"), String)
            If Not isNewRecord Is Nothing AndAlso isNewRecord.Trim <> "" Then
                Me.IsNewRecord = Boolean.Parse(isNewRecord)
            End If
            
            Dim myCheckSum As String = CType(ViewState("CheckSum"), String)
            If Not myCheckSum Is Nothing AndAlso myCheckSum.Trim <> "" Then
                Me.CheckSum = myCheckSum
            End If
            
        End Sub

        Protected Overrides Function SaveViewState() As Object
            ViewState("IsNewRecord") = Me.IsNewRecord.ToString()
            ViewState("CheckSum") = Me.CheckSum
            
            Return MyBase.SaveViewState()
        End Function
        
        
        ' Generate the event handling functions for pagination events.
            
      
        ' Generate the event handling functions for filter and search events.
            

        Public Overridable Function CreateWhereClause_id_commodityDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the commodity table.
            ' Examples:
            ' wc.iAND(CommodityTable.commodity, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(CommodityTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
        
                

        Public Overridable Function CreateWhereClause_id_partyDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the party table.
            ' Examples:
            ' wc.iAND(PartyTable.name, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(PartyTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
        
                

        Public Overridable Function CreateWhereClause_id_siteDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the sites table.
            ' Examples:
            ' wc.iAND(SitesTable.name, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(SitesTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            Dim filter As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
        Dim whereClause As WhereClause = New WhereClause()

            If EvaluateFormula("Pro_inv_hdrRecordControl.id_party.SelectedValue") <> "" Then filter.AddFilter(New BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance("ServelInvocing.Business.SitesTable, ServelInvocing.Business").TableDefinition.ColumnList.GetByUniqueName("Sites_.id_party"), EvaluateFormula("Pro_inv_hdrRecordControl.id_party.SelectedValue"), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
         If (EvaluateFormula("Pro_inv_hdrRecordControl.id_party.SelectedValue") = "--PLEASE_SELECT--" OrElse EvaluateFormula("Pro_inv_hdrRecordControl.id_party.SelectedValue") = "--ANY--") Then whereClause.RunQuery = False

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator)

            Return whereClause
				
        End Function
        
                

        Public Overridable Function CreateWhereClause_id_tax_groupDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the tax_groups table.
            ' Examples:
            ' wc.iAND(Tax_groupsTable.tax_group_code, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(Tax_groupsTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
        
                

        Public Overridable Function CreateWhereClause_id_transporterDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the transporters table.
            ' Examples:
            ' wc.iAND(TransportersTable.name, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(TransportersTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
        
                
        ' Fill the id_commodity list.
        Protected Overridable Sub Populateid_commodityDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.id_commodity.Items.Clear()
            
            ' This is a four step process.
            ' 1. Setup the static list items
            ' 2. Set up the WHERE and the ORDER BY clause
            ' 3. Read a total of maxItems from the database and insert them
            ' 4. Set the selected value (insert if not already present).
                    
            ' 1. Setup the static list items
            														
            Me.id_commodity.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))							
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_id_commodityDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_id_commodityDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                
      
      
            Dim orderBy As OrderBy = New OrderBy(false, true)			
        
            orderBy.Add(CommodityTable.commodity, OrderByItem.OrderDir.Asc)				
            
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As CommodityRecord = Nothing
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Do
                    itemValues = CommodityTable.GetRecords(wc, orderBy, pageNum, 500)
                    For each itemValue As CommodityRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.id0Specified Then
                            cvalue = itemValue.id0.ToString()
                            fvalue = itemValue.Format(CommodityTable.commodity)
                                    
                            If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                            Dim newItem As New ListItem(fvalue, cvalue)
                            If counter < maxItems AndAlso Not Me.id_commodity.Items.Contains(newItem) Then Me.id_commodity.Items.Add(newItem)
                            counter += 1
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_commodity, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_commodity, selectedValue)Then

                ' construct a whereclause to query a record with commodity.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(CommodityTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As CommodityRecord = CommodityTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = Pro_inv_hdrTable.id_commodity.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_commodity.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' Fill the id_party list.
        Protected Overridable Sub Populateid_partyDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.id_party.Items.Clear()
            
            ' This is a four step process.
            ' 1. Setup the static list items
            ' 2. Set up the WHERE and the ORDER BY clause
            ' 3. Read a total of maxItems from the database and insert them
            ' 4. Set the selected value (insert if not already present).
                    
            ' 1. Setup the static list items
            														
            Me.id_party.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))							
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_id_partyDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_id_partyDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                
      
      
            Dim orderBy As OrderBy = New OrderBy(false, true)			
        
            orderBy.Add(PartyTable.name, OrderByItem.OrderDir.Asc)				
            
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As PartyRecord = Nothing
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Do
                    itemValues = PartyTable.GetRecords(wc, orderBy, pageNum, 500)
                    For each itemValue As PartyRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.id0Specified Then
                            cvalue = itemValue.id0.ToString()
                            fvalue = itemValue.Format(PartyTable.name)
                                    
                            If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                            Dim newItem As New ListItem(fvalue, cvalue)
                            If counter < maxItems AndAlso Not Me.id_party.Items.Contains(newItem) Then Me.id_party.Items.Add(newItem)
                            counter += 1
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_party, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_party, selectedValue)Then

                ' construct a whereclause to query a record with party.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(PartyTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As PartyRecord = PartyTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = Pro_inv_hdrTable.id_party.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_party.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' Fill the id_site list.
        Protected Overridable Sub Populateid_siteDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.id_site.Items.Clear()
            
            ' This is a four step process.
            ' 1. Setup the static list items
            ' 2. Set up the WHERE and the ORDER BY clause
            ' 3. Read a total of maxItems from the database and insert them
            ' 4. Set the selected value (insert if not already present).
                    
            ' 1. Setup the static list items
            														
            Me.id_site.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))							
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_id_siteDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_id_siteDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                
      
      
            Dim orderBy As OrderBy = New OrderBy(false, true)			
        orderBy.Add(SitesTable.name, OrderByItem.OrderDir.Asc)
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As SitesRecord = Nothing
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Do
                    itemValues = SitesTable.GetRecords(wc, orderBy, pageNum, 500)
                    For each itemValue As SitesRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.id0Specified Then
                            cvalue = itemValue.id0.ToString()
                            fvalue = EvaluateFormula("name", itemValue)
                                    
                            If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                            Dim newItem As New ListItem(fvalue, cvalue)
                            If counter < maxItems AndAlso Not Me.id_site.Items.Contains(newItem) Then Me.id_site.Items.Add(newItem)
                            counter += 1
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_site, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_site, selectedValue)Then

                ' construct a whereclause to query a record with sites.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(SitesTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As SitesRecord = SitesTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String= EvaluateFormula("name", rc(0))				
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_site.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' Fill the id_tax_group list.
        Protected Overridable Sub Populateid_tax_groupDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.id_tax_group.Items.Clear()
            
            ' This is a four step process.
            ' 1. Setup the static list items
            ' 2. Set up the WHERE and the ORDER BY clause
            ' 3. Read a total of maxItems from the database and insert them
            ' 4. Set the selected value (insert if not already present).
                    
            ' 1. Setup the static list items
            														
            Me.id_tax_group.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))							
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_id_tax_groupDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_id_tax_groupDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                
      
      
            Dim orderBy As OrderBy = New OrderBy(false, true)			
        
            orderBy.Add(Tax_groupsTable.tax_group_code, OrderByItem.OrderDir.Asc)				
            
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As Tax_groupsRecord = Nothing
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Do
                    itemValues = Tax_groupsTable.GetRecords(wc, orderBy, pageNum, 500)
                    For each itemValue As Tax_groupsRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.id0Specified Then
                            cvalue = itemValue.id0.ToString()
                            fvalue = itemValue.Format(Tax_groupsTable.tax_group_code)
                                    
                            If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                            Dim newItem As New ListItem(fvalue, cvalue)
                            If counter < maxItems AndAlso Not Me.id_tax_group.Items.Contains(newItem) Then Me.id_tax_group.Items.Add(newItem)
                            counter += 1
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_tax_group, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_tax_group, selectedValue)Then

                ' construct a whereclause to query a record with tax_groups.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(Tax_groupsTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As Tax_groupsRecord = Tax_groupsTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = Pro_inv_hdrTable.id_tax_group.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_tax_group.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' Fill the id_transporter list.
        Protected Overridable Sub Populateid_transporterDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.id_transporter.Items.Clear()
            
            ' This is a four step process.
            ' 1. Setup the static list items
            ' 2. Set up the WHERE and the ORDER BY clause
            ' 3. Read a total of maxItems from the database and insert them
            ' 4. Set the selected value (insert if not already present).
                    
            ' 1. Setup the static list items
            														
            Me.id_transporter.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))							
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_id_transporterDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_id_transporterDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                
      
      
            Dim orderBy As OrderBy = New OrderBy(false, true)			
        
            orderBy.Add(TransportersTable.name, OrderByItem.OrderDir.Asc)				
            
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As TransportersRecord = Nothing
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Do
                    itemValues = TransportersTable.GetRecords(wc, orderBy, pageNum, 500)
                    For each itemValue As TransportersRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.id0Specified Then
                            cvalue = itemValue.id0.ToString()
                            fvalue = itemValue.Format(TransportersTable.name)
                                    
                            If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                            Dim newItem As New ListItem(fvalue, cvalue)
                            If counter < maxItems AndAlso Not Me.id_transporter.Items.Contains(newItem) Then Me.id_transporter.Items.Add(newItem)
                            counter += 1
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_transporter, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_transporter, selectedValue)Then

                ' construct a whereclause to query a record with transporters.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(TransportersTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As TransportersRecord = TransportersTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = Pro_inv_hdrTable.id_transporter.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_transporter.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' event handler for Button with Layout
        Public Overridable Sub CalculateButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            Try
                
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
    
        End Sub
            
        Protected Overridable Sub id_commodity_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
            ' If a large list selector or a Quick Add link is used, the dropdown list
            ' will contain an item that was not in the original (smaller) list.  During postbacks,
            ' this new item will not be in the list - since the list is based on the original values
            ' read from the database. This function adds the value back if necessary.
            ' In addition, This dropdown can be used on make/model/year style dropdowns.  Make filters the result of Model.
            ' Mode filters the result of Year.  When users change the value of Make, Model and Year are repopulated.
            ' When this function is fire for Make or Model, we don't want the following code executed.
            ' Therefore, we check this situation using Items.Count > 1			
            If Me.id_commodity.Items.Count > 1 Then
                Dim selectedValue As String = MiscUtils.GetValueSelectedPageRequest(Me.id_commodity)
                 
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_commodity, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_commodity, selectedValue)Then

                ' construct a whereclause to query a record with commodity.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(CommodityTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As CommodityRecord = CommodityTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = Pro_inv_hdrTable.id_commodity.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_commodity.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
            End If
          									
                
                
        End Sub
            
        Protected Overridable Sub id_party_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
            ' If a large list selector or a Quick Add link is used, the dropdown list
            ' will contain an item that was not in the original (smaller) list.  During postbacks,
            ' this new item will not be in the list - since the list is based on the original values
            ' read from the database. This function adds the value back if necessary.
            ' In addition, This dropdown can be used on make/model/year style dropdowns.  Make filters the result of Model.
            ' Mode filters the result of Year.  When users change the value of Make, Model and Year are repopulated.
            ' When this function is fire for Make or Model, we don't want the following code executed.
            ' Therefore, we check this situation using Items.Count > 1			
            If Me.id_party.Items.Count > 1 Then
                Dim selectedValue As String = MiscUtils.GetValueSelectedPageRequest(Me.id_party)
                 
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_party, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_party, selectedValue)Then

                ' construct a whereclause to query a record with party.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(PartyTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As PartyRecord = PartyTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = Pro_inv_hdrTable.id_party.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_party.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
            End If
          
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()
                ' Because Set methods will be called, it is important to initialize the data source ahead of time
                Me.DataSource = Me.GetRecord()
                Me.Page.CommitTransaction(sender)

            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
            Finally
                DbUtils.EndTransaction()
            End Try			
                
                
            ' Reset id_site
            Setid_site()									
                
                
        End Sub
            
        Protected Overridable Sub id_site_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
            ' If a large list selector or a Quick Add link is used, the dropdown list
            ' will contain an item that was not in the original (smaller) list.  During postbacks,
            ' this new item will not be in the list - since the list is based on the original values
            ' read from the database. This function adds the value back if necessary.
            ' In addition, This dropdown can be used on make/model/year style dropdowns.  Make filters the result of Model.
            ' Mode filters the result of Year.  When users change the value of Make, Model and Year are repopulated.
            ' When this function is fire for Make or Model, we don't want the following code executed.
            ' Therefore, we check this situation using Items.Count > 1			
            If Me.id_site.Items.Count > 1 Then
                Dim selectedValue As String = MiscUtils.GetValueSelectedPageRequest(Me.id_site)
                 
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_site, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_site, selectedValue)Then

                ' construct a whereclause to query a record with sites.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(SitesTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As SitesRecord = SitesTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String= EvaluateFormula("name", rc(0))				
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_site.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
            End If
          									
                
                
        End Sub
            
        Protected Overridable Sub id_tax_group_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
            ' If a large list selector or a Quick Add link is used, the dropdown list
            ' will contain an item that was not in the original (smaller) list.  During postbacks,
            ' this new item will not be in the list - since the list is based on the original values
            ' read from the database. This function adds the value back if necessary.
            ' In addition, This dropdown can be used on make/model/year style dropdowns.  Make filters the result of Model.
            ' Mode filters the result of Year.  When users change the value of Make, Model and Year are repopulated.
            ' When this function is fire for Make or Model, we don't want the following code executed.
            ' Therefore, we check this situation using Items.Count > 1			
            If Me.id_tax_group.Items.Count > 1 Then
                Dim selectedValue As String = MiscUtils.GetValueSelectedPageRequest(Me.id_tax_group)
                 
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_tax_group, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_tax_group, selectedValue)Then

                ' construct a whereclause to query a record with tax_groups.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(Tax_groupsTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As Tax_groupsRecord = Tax_groupsTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = Pro_inv_hdrTable.id_tax_group.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_tax_group.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
            End If
          									
                
                
        End Sub
            
        Protected Overridable Sub id_transporter_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
            ' If a large list selector or a Quick Add link is used, the dropdown list
            ' will contain an item that was not in the original (smaller) list.  During postbacks,
            ' this new item will not be in the list - since the list is based on the original values
            ' read from the database. This function adds the value back if necessary.
            ' In addition, This dropdown can be used on make/model/year style dropdowns.  Make filters the result of Model.
            ' Mode filters the result of Year.  When users change the value of Make, Model and Year are repopulated.
            ' When this function is fire for Make or Model, we don't want the following code executed.
            ' Therefore, we check this situation using Items.Count > 1			
            If Me.id_transporter.Items.Count > 1 Then
                Dim selectedValue As String = MiscUtils.GetValueSelectedPageRequest(Me.id_transporter)
                 
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_transporter, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_transporter, selectedValue)Then

                ' construct a whereclause to query a record with transporters.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(TransportersTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As TransportersRecord = TransportersTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = Pro_inv_hdrTable.id_transporter.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_transporter.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
            End If
          									
                
                
        End Sub
            
        Protected Overridable Sub bill_address_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub bill_name_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub contact_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub email_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub freight_to_pay_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub gr_rr_dt_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub gr_rr_no_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub grand_total_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub item_total_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub no_of_packages_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub packing_details_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub phone_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub po_dt_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub po_no_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub pro_inv_dt_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub pro_inv_no_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub road_permit_no_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub sale_ord_dt_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub sale_ord_no_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub ship_address_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub ship_name_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub tin_no_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub weight_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
   
        Private _PreviousUIData As New Hashtable
        Public Overridable Property PreviousUIData() As Hashtable
            Get
                Return _PreviousUIData
            End Get
            Set(ByVal value As Hashtable)
                _PreviousUIData = value
            End Set
        End Property   
   
        Private _IsNewRecord As Boolean = True
        Public Overridable Property IsNewRecord() As Boolean
            Get
                Return Me._IsNewRecord
            End Get
            Set(ByVal value As Boolean)
                Me._IsNewRecord = value
            End Set
        End Property

        Private _DataChanged As Boolean = False
        Public Overridable Property DataChanged() As Boolean
            Get
                Return Me._DataChanged
            End Get
            Set(ByVal Value As Boolean)
                Me._DataChanged = Value
            End Set
        End Property

        Private _ResetData As Boolean = False
        Public Overridable Property ResetData() As Boolean
            Get
                Return Me._ResetData
            End Get
            Set(ByVal Value As Boolean)
                Me._ResetData = Value
            End Set
        End Property
        
        Public Property RecordUniqueId() As String
            Get
                Return CType(Me.ViewState("BasePro_inv_hdrRecordControl_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BasePro_inv_hdrRecordControl_Rec") = value
            End Set
        End Property
        
        Private _DataSource As Pro_inv_hdrRecord
        Public Property DataSource() As Pro_inv_hdrRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As Pro_inv_hdrRecord)
            
                Me._DataSource = value
            End Set
        End Property

        

        Private _checkSum As String
        Public Overridable Property CheckSum() As String
            Get
                Return Me._checkSum
            End Get
            Set(ByVal value As String)
                Me._checkSum = value
            End Set
        End Property
        
        Private _TotalPages As Integer
        Public Property TotalPages() As Integer
            Get
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property
        
        Private _PageIndex As Integer
        Public Property PageIndex() As Integer
            Get
                ' Return the PageIndex
                Return Me._PageIndex
            End Get
            Set(ByVal value As Integer)
                Me._PageIndex = value
            End Set
        End Property
    
        Private _PageSize As Integer
        Public Property PageSize() As Integer
            Get
                Return Me._PageSize
            End Get
            Set(ByVal value As Integer)
                Me._PageSize = value
            End Set
        End Property
    
        Private _TotalRecords As Integer
        Public Property TotalRecords() As Integer
            Get
                Return Me._TotalRecords
            End Get
            Set(ByVal value As Integer)
                If Me.PageSize > 0 Then
                    Me.TotalPages = CInt(Math.Ceiling(value / Me.PageSize))
                End If

                Me._TotalRecords = value
            End Set
        End Property
        
        Private _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property
        
        

#Region "Helper Properties"
        
        Public ReadOnly Property bill_address() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "bill_address"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property bill_addressLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "bill_addressLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property bill_name() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "bill_name"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property bill_nameLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "bill_nameLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property CalculateButton() As ServelInvocing.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CalculateButton"), ServelInvocing.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property contact() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "contact"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property contactLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "contactLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property email() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "email"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property emailLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "emailLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property freight_to_pay() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "freight_to_pay"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property freight_to_payLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "freight_to_payLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property gr_rr_dt() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gr_rr_dt"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property gr_rr_dtLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gr_rr_dtLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property gr_rr_no() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gr_rr_no"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property gr_rr_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gr_rr_noLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property grand_total() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "grand_total"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property grand_totalLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "grand_totalLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property id_commodity() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_commodity"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property id_commodityLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_commodityLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property id_party() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_party"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property id_partyLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_partyLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property id_site() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_site"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property id_siteLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_siteLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property id_tax_group() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_tax_group"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property id_tax_groupLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_tax_groupLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property id_transporter() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_transporter"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property id_transporterLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_transporterLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property item_total() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "item_total"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property item_totalLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "item_totalLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property no_of_packages() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "no_of_packages"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property no_of_packagesLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "no_of_packagesLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property packing_details() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "packing_details"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property packing_detailsLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "packing_detailsLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property phone() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "phone"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property phoneLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "phoneLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property po_dt() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "po_dt"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property po_dtLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "po_dtLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property po_no() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "po_no"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property po_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "po_noLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property pro_inv_dt() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pro_inv_dt"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property pro_inv_dtLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pro_inv_dtLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_hdrTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property pro_inv_no() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pro_inv_no"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property pro_inv_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pro_inv_noLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property road_permit_no() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "road_permit_no"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property road_permit_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "road_permit_noLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property sale_ord_dt() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "sale_ord_dt"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property sale_ord_dtLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "sale_ord_dtLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property sale_ord_no() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "sale_ord_no"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property sale_ord_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "sale_ord_noLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ship_address() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ship_address"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property ship_addressLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ship_addressLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ship_name() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ship_name"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property ship_nameLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ship_nameLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property tin_no() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tin_no"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property tin_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tin_noLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property weight() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "weight"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property weightLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "weightLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As Pro_inv_hdrRecord = Nothing
             
        
            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.
                
            Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ServelInvocing"))
                    
            End If
            Return EvaluateExpressions(url, arg, rec, bEncrypt)
        End Function

         
        Public Overridable Function GetRecord() As Pro_inv_hdrRecord
            If Not Me.DataSource Is Nothing Then
              Return Me.DataSource
            End If
            
            
            Return New Pro_inv_hdrRecord()
            
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

End Class

  

#End Region
    
  
End Namespace

  