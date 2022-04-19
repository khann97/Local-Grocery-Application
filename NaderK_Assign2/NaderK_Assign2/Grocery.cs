using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 003, Nader Khan, 300251089

namespace NaderK_Assign2
{
    class Grocery
    {
        public string ItemName { get; set; }

        public string ItemCode { get; set; }

        public double UnitPrice { get; set; }

        public double StartingQty { get; set; }

        public double QtyMinForRestock { get; set; }

        public double QtySold { get; set; }

        public double QtyRestocked { get; set; }

        public Grocery(string itemCode, string itemName, double unitPrice, double qtyMinForRestock, double startingQty, double qtySold, double qtyRestocked)
        {
            ItemName = itemName;
            ItemCode = itemCode;
            UnitPrice = unitPrice;
            StartingQty = startingQty;
            QtyMinForRestock = qtyMinForRestock;
            QtySold = qtySold;
            QtyRestocked = qtyRestocked;
        }
        public double QuantityOnHand
        {
            get
            {
                return ((StartingQty - QtySold) + QtyRestocked);
            }
        }
        public double TotalSales
        {
            get
            {
                return (QtySold * UnitPrice);
            }
        }
        public override string ToString()
        {
            string outputString = String.Format("{0,-24}{1,-18}{2,-15}{3,-16}{4,-22}{5,-14}{6,-18}{7,-18}{8,0}", ItemCode, ItemName, UnitPrice.ToString("C"), StartingQty, QtyMinForRestock, QtySold, QtyRestocked, QuantityOnHand, TotalSales.ToString("C"));
            return outputString;
        }
    }
}
