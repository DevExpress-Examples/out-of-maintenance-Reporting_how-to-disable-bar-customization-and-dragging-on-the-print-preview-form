Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraReports.UI

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			Dim printTool As New ReportPrintTool(New XtraReport1())
			AddHandler printTool.PreviewForm.VisibleChanged, AddressOf PreviewFormEx_VisibleChanged
			printTool.ShowPreviewDialog()
		End Sub

		Private Sub PreviewFormEx_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
			CType(sender, PrintPreviewFormEx).PrintBarManager.AllowQuickCustomization = False
			CType(sender, PrintPreviewFormEx).PrintBarManager.Bars(2).OptionsBar.DrawDragBorder = False
			CType(sender, PrintPreviewFormEx).PrintBarManager.Bars(0).OptionsBar.DrawDragBorder = False
		End Sub
	End Class
End Namespace