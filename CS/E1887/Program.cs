using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.Xpo;
using DXSample.BO;
using DevExpress.Xpo.DB;

namespace E1887 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            XpoDefault.ConnectionString = InMemoryDataStore.GetConnectionString(@"..\..\data.xml");
            CreateData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SkinManager.EnableFormSkins();
            Application.Run(new Form1());
        }

        private static void CreateData() {
            using (UnitOfWork uow = new UnitOfWork()) {
                if (uow.FindObject<Order>(null) != null) return;
                Order parent = new Order(uow);
                parent.Name = "Queso Cabrales";
                parent.UnitPrice = 14m;
                parent.Quantity = 12;
                parent.Save();
                Order child = new Order(uow);
                child.Name = "Singaporean Hokkien Fried Mee";
                child.UnitPrice = 9.8m;
                child.Quantity = 10;
                child.Parent = parent;
                child.Save();
                child = new Order(uow);
                child.Name = "Mozzarella di Giovanni";
                child.UnitPrice = 34.8m;
                child.Quantity = 5;
                child.Parent = parent;
                child.Save();
                parent = new Order(uow);
                parent.Name = "Tofu";
                parent.UnitPrice = 18.6m;
                parent.Quantity = 9;
                parent.Save();
                child = new Order(uow);
                child.Name = "Manjimup Dried Apples";
                child.UnitPrice = 42.4m;
                child.Quantity = 40;
                child.Parent = parent;
                child.Save();
                uow.CommitChanges();
            }
        }
    }
}