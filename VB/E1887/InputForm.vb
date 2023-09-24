Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors

Namespace E1887

    Public Partial Class InputForm
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Public ReadOnly Property ColumnName As String
            Get
                Return textEdit1.Text
            End Get
        End Property
    End Class
End Namespace
