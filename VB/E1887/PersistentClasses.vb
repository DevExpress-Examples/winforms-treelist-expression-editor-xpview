Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Namespace DXSample.BO
	Public Class Order
		Inherits XPObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Private fName As String
		Public Property Name() As String
			Get
				Return fName
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Name", fName, value)
			End Set
		End Property

		Private fUnitPrice As Decimal
		Public Property UnitPrice() As Decimal
			Get
				Return fUnitPrice
			End Get
			Set(ByVal value As Decimal)
				SetPropertyValue(Of Decimal)("UnitPrice", fUnitPrice, value)
			End Set
		End Property

		Private fQuantity As Integer
		Public Property Quantity() As Integer
			Get
				Return fQuantity
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("Quantity", fQuantity, value)
			End Set
		End Property

		Private fParent As Order
		<Association("Order-SubOrders")> _
		Public Property Parent() As Order
			Get
				Return fParent
			End Get
			Set(ByVal value As Order)
				SetPropertyValue(Of Order)("Parent", fParent, value)
			End Set
		End Property

		<Association("Order-SubOrders", GetType(Order))> _
		Public ReadOnly Property SubOrders() As XPCollection(Of Order)
			Get
				Return GetCollection(Of Order)("SubOrders")
			End Get
		End Property
	End Class
End Namespace