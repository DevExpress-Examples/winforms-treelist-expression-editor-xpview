Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace E1887
	Partial Public Class InputForm
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Public ReadOnly Property ColumnName() As String
			Get
				Return textEdit1.Text
			End Get
		End Property
	End Class
End Namespace