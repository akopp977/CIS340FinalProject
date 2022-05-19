using finalProject.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace finalProject
{
    //This class is a Form that handles the final phase of checking out
    //It confirms the total price and lets the user decide to checkout or keep shopping
    public partial class Checkout : Form
    {
        //Field holds the row clollectiong from DGV_Shop 
        private DataGridViewRowCollection ItemsToBuy;
        //Field holds the DGV from the shop form to be used here 
        private DataGridView DGV_Shop { get; set; }
        //Public constructor
        public Checkout()
        {
            InitializeComponent();
        }
        //Overloaded constructor that takes the dgv from the shop form and put into appropriate fields
        public Checkout(DataGridView dgv_Shop)
        {
            InitializeComponent();
            DGV_Shop = dgv_Shop;
            ItemsToBuy = dgv_Shop.Rows;
        }
        //Upon loading of the form dgv is populated, subtotal, discounts, taxes are calcualted along with total
        private void Checkout_Load(object sender, EventArgs e)
        {
            //Establish connection to database
            DBContext context = new DBContext();
            //Gets all products in database along with desired data
            var resultProducts = (from selected in context.Products
                                  select new { selected.ProdId, selected.Name, selected.Desc, selected.TypeId, selected.Price });

            //For each adds each items to the checkout items dgv with the desired data excluding unnesscasry things
            foreach (DataGridViewRow row in ItemsToBuy)
            {
                var products = (from results in resultProducts
                                where results.Name == row.Cells[1].Value.ToString().Trim()
                                select results.Price).ToList();
                dgv_CheckoutItems.Rows.Add(row.Cells[1].Value.ToString().Trim(), row.Cells[0].Value.ToString().Trim(), products[0].ToString());
            }

            var rowsToAdd = dgv_CheckoutItems.Rows;
            //Varible to hold each according value
            decimal subtotal = 0;
            decimal discounts = 0;
            decimal taxes = 0;
            decimal total = 0;
            //Gets the logged in users type to be able to apply discounts or calcualte taxes/total correctly
            var customerTypes = (from cusType in context.Customers
                                 join typeDB in context.CustomerTypes on cusType.CusTypeId equals typeDB.CusTypeId
                                 where cusType.CusId == LoginForm.CUS_ID
                                 select cusType.CusType).ToList()[0].CustomerType.ToString().Trim();
            //For everyitem getting bought add the price * quantity to the subtotal
            foreach (DataGridViewRow row in rowsToAdd)
            {
                var productType = (from products in context.Products
                                   where products.Name == row.Cells[0].Value.ToString().Trim()
                                   select products.TypeId).ToList()[0].ToString().Trim();
                //If user is teacher then 10% discount on books add to discount to be subtracted from subtotal before taxes
                if ((int.Parse(productType) == 1) && customerTypes == "Teacher")
                {
                    discounts = discounts + (decimal.Parse(row.Cells[2].Value.ToString().Trim()) * int.Parse(row.Cells[1].Value.ToString().Trim())) * 0.1M;
                }

                subtotal = subtotal + (decimal.Parse(row.Cells[2].Value.ToString().Trim()) * int.Parse(row.Cells[1].Value.ToString().Trim()));
            }
            //Displays the amounts to the user
            lbl_DiscountAmount.Text = "$" + decimal.Round(discounts, 2).ToString();
            lbl_SubtotalAmount.Text = "$" + decimal.Round(subtotal, 2).ToString();
            //Gets the amount to tax after discounts are accounted for
            var amountToTax = subtotal - discounts;
            //Amount to add to amountToTax for total cost
            taxes = amountToTax * 0.05M;
            //If veteran or senior citien then no taxes as per instructions
            if (customerTypes == "Veteran" || customerTypes == "Senior Citizen")
            {
                taxes = 0;
            }
            //Displays amounts to user and gets total by adding amountToTax to taxes
            lbl_TaxAmount.Text = "$" + decimal.Round(taxes, 2).ToString();
            label2.Text = customerTypes;
            total = amountToTax + taxes;
            lbl_TotalAmount.Text = "$" + decimal.Round(total, 2).ToString();
        }
        //When customer does not wish to confirm purchase
        private void btn_KeepShopping_Click(object sender, EventArgs e)
        {
            //Closes the checkout form and lets the user keep shopping
            this.Close();
        }
        //When customer would like to finalie checkout and purchase the items
        //Creates a transaction and transaction items
        private void btn_FinalCheckout_Click(object sender, EventArgs e)
        {

            //Establish connection to database
            DBContext context = new DBContext();
            //Gets datetime to be able to add to transaction
            var datetime = DateTime.Now;
            //Gets customer id for the transaction
            var customerID = (from cusID in context.Customers
                              where cusID.Username == LoginForm.Username
                              select cusID.CusId).ToList()[0];
            //All products used to get prod_id for adding to transactionItems
            var resultProducts = (from selected in context.Products
                                  select new { selected.ProdId, selected.Name, selected.Desc, selected.TypeId, selected.Price });
            //Transaction to be added then adding appropriate data
            Transactions transactionToAdd = new Transactions();
            transactionToAdd.Total = decimal.Parse(lbl_TotalAmount.Text.Trim().Replace("$", ""));
            transactionToAdd.DateTime = datetime;
            transactionToAdd.CusId = customerID;
            //Adds trasaction and saves changes to save to DB
            context.Transactions.Add(transactionToAdd);
            context.SaveChanges();
            var transactionID = (from tranID in context.Transactions
                                 where tranID.DateTime == datetime & tranID.CusId == customerID
                                 select tranID.TranId).ToList()[0];
            //For each item in the transaction make a transactionItem to add to transactionItems
            foreach (DataGridViewRow item in dgv_CheckoutItems.Rows)
            {
                TransactionItems itemToAdd = new TransactionItems();
                itemToAdd.TranId = transactionID;
                itemToAdd.ProdId = (from results in resultProducts
                                    where results.Name == item.Cells[0].Value.ToString().Trim()
                                    select results.ProdId).ToList()[0];
                itemToAdd.Price = decimal.Parse(item.Cells[2].Value.ToString().Trim());
                itemToAdd.Quantity = int.Parse(item.Cells[1].Value.ToString().Trim());
                context.TransactionItems.Add(itemToAdd);
            }
            //saves changes to save to DB
            context.SaveChanges();
            //Clears the rows in the shop page since things where bought
            DGV_Shop.Rows.Clear();
            //hides this form since no more action required
            this.Hide();
        }
    }
}
