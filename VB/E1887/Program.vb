Imports System
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.Xpo
Imports DXSample.BO
Imports DevExpress.Xpo.DB

Namespace E1887

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            XpoDefault.ConnectionString = InMemoryDataStore.GetConnectionString("..\..\data.xml")
            Call CreateData()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call SkinManager.EnableFormSkins()
            Call Application.Run(New Form1())
        End Sub

        Private Sub CreateData()
            Using uow As UnitOfWork = New UnitOfWork()
                If uow.FindObject(Of Order)(Nothing) IsNot Nothing Then Return
                Dim parent As Order = New Order(uow)
                parent.Name = "Queso Cabrales"
                parent.UnitPrice = 14D
                parent.Quantity = 12
                parent.Save()
                Dim child As Order = New Order(uow)
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
    End Module
End Namespace
