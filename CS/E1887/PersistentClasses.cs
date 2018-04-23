using DevExpress.Xpo;
namespace DXSample.BO {
    public class Order : XPObject {
        public Order(Session session) : base(session) { }

        private string fName;
        public string Name {
            get { return fName; }
            set { SetPropertyValue<string>("Name", ref fName, value); }
        }

        private decimal fUnitPrice;
        public decimal UnitPrice {
            get { return fUnitPrice; }
            set { SetPropertyValue<decimal>("UnitPrice", ref fUnitPrice, value); }
        }

        private int fQuantity;
        public int Quantity {
            get { return fQuantity; }
            set { SetPropertyValue<int>("Quantity", ref fQuantity, value); }
        }

        private Order fParent;
        [Association("Order-SubOrders")]
        public Order Parent {
            get { return fParent; }
            set { SetPropertyValue<Order>("Parent", ref fParent, value); }
        }

        [Association("Order-SubOrders", typeof(Order))]
        public XPCollection<Order> SubOrders { get { return GetCollection<Order>("SubOrders"); } }
    }
}