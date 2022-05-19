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
    public partial class Shop : Form
    {
        //Construtor class that adds buttons needed to interact with the DGV for purchasing and removing things from cart
        public Shop()
        {
            InitializeComponent();
            //Button for adding things to precheckout dgv
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgv_ShopProducts.Columns.Add(btn);
            btn.HeaderText = "";
            btn.Text = "Add to cart";
            btn.Name = "btn_AddToCart";
            btn.UseColumnTextForButtonValue = true;

            //Button in the precheckout to remove unwanted items
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            dgv_PreCheckout.Columns.Add(btn2);
            btn2.HeaderText = "";
            btn2.Text = "Remove";
            btn2.Name = "btn_Remove";
            btn2.UseColumnTextForButtonValue = true;

        }

        private void Shop_Load(object sender, EventArgs e)
        {
            //Establish connection to database
            DBContext context = new DBContext();
            //Gets all products
            var products = (from P in context.Products
                            select new { Name = P.Name, Desc = P.Desc, Price = P.Price });
            //Displays all products that customer can buy
            dgv_ShopProducts.DataSource = products.ToList();


        }
        //Mthod triggers when cutomers wants to add something to the "cart"
        private void dgv_ShopProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            //Checks to make sure the cell clicked was a add button and also not the header ie >=0
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //Validation and exception handling, making sure quantity is set and is integer>0
                if (dgv_ShopProducts.Rows[e.RowIndex].Cells[0].Value == null ||
                    dgv_ShopProducts.Rows[e.RowIndex].Cells[0].Value.ToString().Trim() == "0" ||
                    !Validation.IsInteger(dgv_ShopProducts.Rows[e.RowIndex].Cells[0].Value.ToString().Trim()))
                {
                    var errorMessage = "";
                    //If statments set error message according to what is causing an issue
                    if (dgv_ShopProducts.Rows[e.RowIndex].Cells[0].Value == null)
                    {
                        errorMessage += Environment.NewLine + "Quantity must be set";
                    }
                    else if (!Validation.IsInteger(dgv_ShopProducts.Rows[e.RowIndex].Cells[0].Value.ToString().Trim()))
                    {
                        errorMessage += Environment.NewLine + "Must enter a postitive integer";
                    }
                    else if (dgv_ShopProducts.Rows[e.RowIndex].Cells[0].Value.ToString().Trim() == "0")
                    {
                        errorMessage += Environment.NewLine + "Quantity must be greater than 0";
                    }
                    //Displays error so user can correct
                    ErrorForm error = new ErrorForm(errorMessage);
                    error.Show();
                }
                //If product is in the cart already add quantity to amount that is alreayd in cart
                else if (InCartAlready(dgv_ShopProducts.Rows[e.RowIndex].Cells[2].Value.ToString().Trim()) != -1)
                {
                    int currentQuantity = int.Parse(dgv_PreCheckout.Rows[InCartAlready(dgv_ShopProducts.Rows[e.RowIndex].Cells[2].Value.ToString().Trim())].Cells[0].Value.ToString().Trim());
                    currentQuantity += int.Parse(dgv_ShopProducts.Rows[e.RowIndex].Cells[0].Value.ToString());
                    dgv_PreCheckout.Rows[InCartAlready(dgv_ShopProducts.Rows[e.RowIndex].Cells[2].Value.ToString().Trim())].Cells[0].Value = currentQuantity;
                }
                //Its not in the cart so add new row with data to precheckout
                else
                {
                    var productToBuyRowData = dgv_ShopProducts.Rows[e.RowIndex].Cells[0];
                    var product = dgv_ShopProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                    var quantity = dgv_ShopProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                    dgv_PreCheckout.Rows.Add(quantity, product);
                }
            }
        }
        //Returns -1 if not in cart anything else means it is already in the cart as per row.Index method
        private int InCartAlready(string product)
        {
            foreach (DataGridViewRow row in dgv_PreCheckout.Rows)
            {
                if (row.Cells[1].Value.ToString().Trim() == product)
                {
                    return row.Index;
                }
            }
            return -1;
        }
        //Removes row from the precheckout if button is pressed
        private void dgv_PreCheckout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                dgv_PreCheckout.Rows.Remove(dgv_PreCheckout.CurrentRow);
            }
        }
        //When textbox changes use filtersearch to update the dgv shop products
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filteredSearch();
        }
        //This method uses whatever text is typed and querys product list for product names that contain the text
        private void filteredSearch()
        {
            //Establish connection to database
            DBContext context = new DBContext();
            //If nothing is typed show all the items
            if (txt_Search.Text.Trim() == "")
            {
                var products = from P in context.Products
                               select new { Name = P.Name, Desc = P.Desc, Price = P.Price };
                dgv_ShopProducts.DataSource = products.ToList();

            }
            //Something is typed show filtered items based off of text
            else
            {
                var products = from P in context.Products
                               where P.Name.Contains(txt_Search.Text)
                               select new { Name = P.Name, Desc = P.Desc, Price = P.Price };
                dgv_ShopProducts.DataSource = products.ToList();
            }
        }
        //When purchase is clicked sent to extra confirmation window that shows total and other information
        private void btn_Purchase_Click(object sender, EventArgs e)
        {
            if (dgv_PreCheckout.Rows.Count > 0)
            {
                //Send the dgv precheckout so it can be used to calculte cost and also cleared is items bought
                Checkout checkout = new Checkout(dgv_PreCheckout);
                checkout.ShowDialog();
            }
            //Only able to purchase if you have items otherwise error
            else
            {
                ErrorForm error = new ErrorForm("Cart must have atleast 1 item");
                error.Show();
            }
        }
    }
}
