Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Design
Imports DevExpress.Data
Imports DevExpress.XtraTreeList.Columns

Namespace E1887

    Public Partial Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub OnShowExpressionEditorClick(ByVal sender As Object, ByVal e As EventArgs)
            Using editor As ExpressionEditorForm = New ConditionExpressionEditorForm(New TreeListDataColumnInfo(treeList1.Columns), Nothing)
                If editor.ShowDialog() = DialogResult.OK Then
                    Using input As InputForm = New InputForm()
                        input.ShowDialog()
                        xpView1.AddProperty(input.ColumnName, editor.Expression)
                        treeList1.PopulateColumns()
                    End Using
                End If
            End Using
        End Sub

        Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs)
            treeList1.DataSource = xpView1
        End Sub
    End Class

    Public Class TreeListDataColumnInfo
        Implements IDataColumnInfo

        Private columnsField As TreeListColumnCollection

        Private column As TreeListColumn

        Public Sub New(ByVal columns As TreeListColumnCollection)
            columnsField = columns
        End Sub

        Private Sub New(ByVal column As TreeListColumn)
            Me.column = column
        End Sub

#Region "IDataColumnInfo Members"
        Public ReadOnly Property Caption As String Implements IDataColumnInfo.Caption
            Get
                If column Is Nothing Then Return String.Empty
                Return If(String.IsNullOrEmpty(column.Caption), column.FieldName, column.Caption)
            End Get
        End Property

        Public ReadOnly Property Columns As List(Of IDataColumnInfo) Implements IDataColumnInfo.Columns
            Get
                Return GetColumns()
            End Get
        End Property

        Private Function GetColumns() As List(Of IDataColumnInfo)
            If column IsNot Nothing Then Return Nothing
            Dim result As List(Of IDataColumnInfo) = New List(Of IDataColumnInfo)()
            For Each col As TreeListColumn In columnsField
                result.Add(New TreeListDataColumnInfo(col))
            Next

            Return result
        End Function

        Public ReadOnly Property Controller As DataControllerBase Implements IDataColumnInfo.Controller
            Get
                Return Nothing
            End Get
        End Property

        Public ReadOnly Property FieldName As String Implements IDataColumnInfo.FieldName
            Get
                Return If(column Is Nothing, String.Empty, column.FieldName)
            End Get
        End Property

        Public ReadOnly Property FieldType As Type Implements IDataColumnInfo.FieldType
            Get
                Return If(column Is Nothing, Nothing, column.ColumnType)
            End Get
        End Property

        Public ReadOnly Property Name As String Implements IDataColumnInfo.Name
            Get
                Return Caption
            End Get
        End Property

        Public ReadOnly Property UnboundExpression As String Implements IDataColumnInfo.UnboundExpression
            Get
                Return FieldName
            End Get
        End Property
#End Region
    End Class
End Namespace
