Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			Dim r As New XtraReport1()
			AddHandler r.PrintingSystem.PreviewFormEx.VisibleChanged, AddressOf PreviewFormEx_VisibleChanged
			r.ShowPreviewDialog()

		End Sub

		Private Sub PreviewFormEx_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
			CType(sender, DevExpress.XtraPrinting.Preview.PrintPreviewFormEx).PrintBarManager.AllowQuickCustomization = False
			CType(sender, DevExpress.XtraPrinting.Preview.PrintPreviewFormEx).PrintBarManager.Bars(2).OptionsBar.DrawDragBorder = False
			CType(sender, DevExpress.XtraPrinting.Preview.PrintPreviewFormEx).PrintBarManager.Bars(0).OptionsBar.DrawDragBorder = False
		End Sub
	End Class
End Namespace