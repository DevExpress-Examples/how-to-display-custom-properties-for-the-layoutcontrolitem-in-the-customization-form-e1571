Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraLayout
Imports DXSample
Imports DevExpress.XtraLayout.Customization

Namespace S132265
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			layoutControl1.RegisterCustomPropertyGridWrapper(GetType(LayoutControlItem), GetType(MyLayoutControlItemPropertyWrapper))
		End Sub
	End Class
End Namespace