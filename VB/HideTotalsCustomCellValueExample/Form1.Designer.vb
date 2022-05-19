Imports DevExpress.XtraPivotGrid
Namespace HideTotalsCustomCellValueExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.pivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldLowLevel = New DevExpress.XtraPivotGrid.PivotGridField()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.pivotGridField1, Me.pivotGridField2, Me.pivotGridField3, Me.pivotGridField4, Me.fieldLowLevel})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(828, 368)
            Me.pivotGridControl1.TabIndex = 0
            '
            'pivotGridField1
            '
            Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.pivotGridField1.AreaIndex = 0
            DataSourceColumnBinding1.ColumnName = "Column"
            Me.pivotGridField1.DataBinding = DataSourceColumnBinding1
            Me.pivotGridField1.Name = "pivotGridField1"
            '
            'pivotGridField2
            '
            Me.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.pivotGridField2.AreaIndex = 1
            DataSourceColumnBinding2.ColumnName = "Row"
            Me.pivotGridField2.DataBinding = DataSourceColumnBinding2
            Me.pivotGridField2.Name = "pivotGridField2"
            '
            'pivotGridField3
            '
            Me.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.pivotGridField3.AreaIndex = 0
            Me.pivotGridField3.Caption = "Summary Value"
            DataSourceColumnBinding3.ColumnName = "Value"
            Me.pivotGridField3.DataBinding = DataSourceColumnBinding3
            Me.pivotGridField3.Name = "pivotGridField3"
            '
            'pivotGridField4
            '
            Me.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.pivotGridField4.AreaIndex = 0
            DataSourceColumnBinding4.ColumnName = "Group"
            Me.pivotGridField4.DataBinding = DataSourceColumnBinding4
            Me.pivotGridField4.Name = "pivotGridField4"
            '
            'fieldLowLevel
            '
            Me.fieldLowLevel.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldLowLevel.AreaIndex = 1
            Me.fieldLowLevel.Caption = "Low Level Value"
            DataSourceColumnBinding5.ColumnName = "Value"
            Me.fieldLowLevel.DataBinding = DataSourceColumnBinding5
            Me.fieldLowLevel.Name = "fieldLowLevel"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(828, 368)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Hide Totals for the CustomCellValue calculated field"
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents pivotGridControl1 As PivotGridControl
		Private pivotGridField1 As PivotGridField
		Private pivotGridField2 As PivotGridField
		Private pivotGridField3 As PivotGridField
		Private pivotGridField4 As PivotGridField
		Private fieldLowLevel As PivotGridField
	End Class
End Namespace
