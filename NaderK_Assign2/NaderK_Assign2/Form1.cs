using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// 003, Nader Khan, 300251089

namespace NaderK_Assign2
{
    public partial class Form1 : Form
    {
        List<Grocery> GroceryList = new List<Grocery>();

        public Form1()
        {
            InitializeComponent();
        }
        //Loads the grocery data in a formatted ToString output into the list box as line items
        private void LoadAllItemsToListBox(List<Grocery> AnyGroceryList)
        {
            outputListBox.Items.Clear();
            string groceryInfo = "{0,-24}{1,-18}{2,-15}{3,-16}{4,-22}{5,-14}{6,-18}{7,-18}{8,0}";
            outputListBox.Items.Add(String.Format(groceryInfo, "ItemName", "ItemCode", "UnitPrice", "StartingQty", "QtyMinForRestock", "QtySold", "QtyRestocked", "QuantityOnHand", "Sales"));         
            foreach (Grocery eachItem in AnyGroceryList)
            {
                //Adds grocery item into list box as each line item
                outputListBox.Items.Add(eachItem.ToString());
            }
        }
        //Load button to load the localgrocery.cvs file
        private void loadGroceryData_Click(object sender, EventArgs e)
        {
            GroceryList.Clear();
            try
            {
                using (StreamReader myIntStreamReader = new StreamReader("localgrocery.csv"))
                {
                    string eachLine;

                    if (!myIntStreamReader.EndOfStream)
                    {
                        eachLine = myIntStreamReader.ReadLine();
                    }
                    while (!myIntStreamReader.EndOfStream)
                    {
                        //Converted double into strings, thus arrays are setup
                        eachLine = myIntStreamReader.ReadLine();
                        string[] userFieldsArray = eachLine.Split(',');
                        string itemName = userFieldsArray[1];
                        string itemCode = userFieldsArray[0];
                        string price = userFieldsArray[2];
                        double.TryParse(price, out double unitPrice);
                        string minRestock = userFieldsArray[3];
                        double.TryParse(minRestock, out double qtyMinRestock);
                        string initial = userFieldsArray[4];
                        double.TryParse(initial, out double startingQty);
                        string sold = userFieldsArray[5];
                        double.TryParse(sold, out double qtySold);
                        string restock = userFieldsArray[6];
                        double.TryParse(restock, out double qtyRestocked);
                        Grocery eachItem = new Grocery(itemCode, itemName, unitPrice, qtyMinRestock, startingQty, qtySold, qtyRestocked);
                        GroceryList.Add(eachItem);
                        double[] availableQty = new double[7];
                        double[] totalSales = new double[8];
                    }
                }
                LoadAllItemsToListBox(GroceryList);
                statusLabel.Text = "Loaded " + GroceryList.Count + " items from the file";
                }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void outputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Upon listbox index change, this event is triggered
            int listBoxIndex = outputListBox.SelectedIndex;
            if (listBoxIndex == 0)
            {
                ClearAllFields(); //When header is selected, clear all the text box fields
                statusLabel.Text = "Selected header in the listbox";
            }
            else if (listBoxIndex > 0 && GroceryList.Count > 0)
            {
                //Formats the textbox input into the List
                quantitySoldTextBox.Text = GroceryList[listBoxIndex].QtySold.ToString(); 
                quantityRestockedTextBox.Text = GroceryList[listBoxIndex].QtyRestocked.ToString();
            }
        }
        private void ClearAllFields()
        {
            quantitySoldTextBox.Text = "";
            quantityRestockedTextBox.Text = "";
        }
        private void updateSoldQuantity_Click(object sender, EventArgs e)
        {
            if (outputListBox.SelectedIndex == -1 || outputListBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a grocery item to increment");
            }
            else if (!double.TryParse(quantitySoldTextBox.Text, out double qtySold) || qtySold <= 0 || qtySold > GroceryList[outputListBox.SelectedIndex - 1].StartingQty)
            {
                //Sold Quantity must be more than 0 than Starting Quantity
                MessageBox.Show("Please enter the valid number of quantity sold");
            }
            else
            {
                int listBoxIndex = outputListBox.SelectedIndex;
                //Updates list
                GroceryList[listBoxIndex - 1].QtySold = qtySold;
                statusLabel.Text = "Incremented Qty Sold for item with Item Code " + GroceryList[outputListBox.SelectedIndex - 1].ItemName;
                outputListBox.Items[listBoxIndex] = GroceryList[listBoxIndex - 1];
            }
        }
        private void updateRestockedQuantity_Click(object sender, EventArgs e)
        {
            if (outputListBox.SelectedIndex == -1 || outputListBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a grocery item to restock");
            }
            else if (!double.TryParse(quantityRestockedTextBox.Text, out double qtyRestock) || qtyRestock <= 0)
            {
                MessageBox.Show("Please enter a valid number for restocked items");
            }
            else
            {
                int listBoxIndex = outputListBox.SelectedIndex;
                GroceryList[listBoxIndex - 1].QtyRestocked = qtyRestock;
                statusLabel.Text = "Incremented Restocked Qty for item with Item Code " + GroceryList[outputListBox.SelectedIndex - 1].ItemName;
                outputListBox.Items[listBoxIndex] = GroceryList[listBoxIndex - 1];

            }
        }
        private void deleteGroceryItem_Click(object sender, EventArgs e)
        {
            if (outputListBox.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a grocery item to delete");
            }
            else
            {
                statusLabel.Text = "Deleted record for item with item code " + GroceryList[outputListBox.SelectedIndex - 1].ItemName;
                GroceryList.RemoveAt(outputListBox.SelectedIndex - 1);
                //Deletes item line from list box when selected
                outputListBox.Items.RemoveAt(outputListBox.SelectedIndex);
                ClearAllFields();
            }
        }
        private void saveGroceryData_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter myOutputStream
                    = new StreamWriter("updatedgrocery.csv"))
                {
                    string groceryHeader = "ItemName, ItemCode, UnitPrice, QtyMinForRestock, InitialQty, QtySold, QtyRestocked";
                    myOutputStream.WriteLine(groceryHeader);//Writes to file
                    foreach (Grocery eachItem in GroceryList)
                    {
                        myOutputStream.WriteLine(eachItem.ItemCode + "," + eachItem.ItemName + "," + eachItem.UnitPrice + "," + eachItem.QtyMinForRestock + "," + eachItem.StartingQty + "," + eachItem.QtySold + "," + eachItem.QtyRestocked);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            statusLabel.Text = "Saved " + GroceryList.Count + " records into the output inventory file";
        }
        private void saveRestockReport_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter myOutputStream
                    = new StreamWriter("groceryrestocks.csv"))
                {
                    string groceryHeader = "ItemName, ItemCode, QtyMinForRestock, AvailableQty";
                    myOutputStream.WriteLine(groceryHeader);//Writes to file
                    foreach (Grocery eachItem in GroceryList)
                    {
                        if (eachItem.StartingQty < eachItem.QtyMinForRestock) 
                            myOutputStream.WriteLine(eachItem.ItemCode + "," + eachItem.ItemName + "," + eachItem.QtyMinForRestock + "," + eachItem.StartingQty);
                        double restockRep = eachItem.QtyMinForRestock;
                        //Output banner/status box for restock repocrt
                        statusLabel.Text = "Saved " + restockRep + " records into the restocks needed output file";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void saveSalesReport_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter myOutputStream
                    = new StreamWriter("grocerysales.csv"))
                {
                    string groceryHeader = "ItemName, ItemCode, QtySold, UnitPrice, Sales";
                    myOutputStream.WriteLine(groceryHeader);//Writes to file
                    foreach (Grocery eachItem in GroceryList)
                    {
                        if (eachItem.TotalSales > 0) //Output Sales if more than 0
                            myOutputStream.WriteLine(eachItem.ItemCode + "," + eachItem.ItemName + "," + eachItem.QtySold + "," + eachItem.UnitPrice.ToString("C") + "," + eachItem.TotalSales.ToString("C"));
                        double salesRep = eachItem.QtySold;
                        statusLabel.Text = "Saved " + salesRep + " records into the output sales file";
                        //Output banner/status box for sales report/sold report
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
