Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.Xpo
Imports DXSample.BO
Imports DevExpress.Xpo.DB

Namespace E1887
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			XpoDefault.ConnectionString = InMemoryDataStore.GetConnectionString("..\..\data.xml")
			CreateData()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			SkinManager.EnableFormSkins()
			Application.Run(New Form1())
		End Sub

		Private Shared Sub CreateData()
			Using uow As New UnitOfWork()
				If uow.FindObject(Of Order)(Nothing) IsNot Nothing Then
					Return
				End If
				Dim parent As New Order(uow)
				parent.Name = "Queso Cabrales"
				parent.UnitPrice = 14D
				parent.Quantity = 12
				parent.Save()
				Dim child As New Order(uow)
				child.Name = "Singaporean Hokkien Fried Mee"
				child.UnitPrice = 9.8D
				child.Quantity = 10
				child.Parent = parent
				child.Save()
				child = New Order(uow)
				child.Name = "Mozzarella di Giovanni"
				child.UnitPrice = 34.8D
				child.Quantity = 5
				child.Parent = parent
				child.Save()
				parent = New Order(uow)
				parent.Name = "Tofu"
				parent.UnitPrice = 18.6D
				parent.Quantity = 9
				parent.Save()
				child = New Order(uow)
				child.Name = "Manjimup Dried Apples"
				child.UnitPrice = 42.4D
				child.Quantity = 40
				child.Parent = parent
				child.Save()
				uow.CommitChanges()
			End Using
		End Sub
	End Class
End Namespace