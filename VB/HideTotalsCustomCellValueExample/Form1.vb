Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports System.ComponentModel
Imports System.Linq

Namespace HideTotalsCustomCellValueExample
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
			AddHandler pivotGridControl1.CustomCellValue, AddressOf pivotGridControl1_CustomCellValue
			Dim data As New BindingList(Of PivotData)()
			For i As Integer = 0 To 99
				data.Add(New PivotData() With {.Group = "Group " & i Mod 4, .Row = "Row " & i Mod 5, .Column = "Column" & i Mod 3, .Value = i})
			Next i
			pivotGridControl1.DataSource = data
			pivotGridControl1.BestFitDataHeaders(True)
		End Sub

		Private Sub pivotGridControl1_CustomCellValue(ByVal sender As Object, ByVal e As PivotCellValueEventArgs) Handles pivotGridControl1.CustomCellValue
			If e.DataField Is fieldLowLevel Then
				Dim lastLevelField As PivotGridField = pivotGridControl1.GetFieldsByArea(PivotArea.RowArea).Last()
				If e.RowValueType = PivotGridValueType.Total OrElse e.RowValueType = PivotGridValueType.GrandTotal OrElse e.RowField IsNot lastLevelField Then
					e.Value = Nothing
				End If
			End If
		End Sub

	End Class
	Friend Class PivotData
		Public Property Group() As String
		Public Property Row() As String
		Public Property Column() As String
		Public Property Value() As Decimal
	End Class
End Namespace
