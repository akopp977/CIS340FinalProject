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
    //Form to display invoices of either the signed in user or all invoices if admin
    public partial class Invoices : Form
    {
        //Constructor
        public Invoices()
        {
            //Establish DB connection
            DBContext context = new DBContext();
            InitializeComponent();
            //Add the choices for time to look at transactions
            cmbo_amountOfMonths.Items.Add("All");
            cmbo_amountOfMonths.Items.Add("Month");
            cmbo_amountOfMonths.Items.Add("2 Months");
            cmbo_amountOfMonths.Items.Add("3 Months");
            cmbo_amountOfMonths.Items.Add("4 Months");
            cmbo_amountOfMonths.Items.Add("5 Months");
            cmbo_amountOfMonths.Items.Add("6 Months");
            cmbo_amountOfMonths.Items.Add("7 Months");
            cmbo_amountOfMonths.Items.Add("8 Months");
            cmbo_amountOfMonths.Items.Add("9 Months");
            cmbo_amountOfMonths.Items.Add("10 Months");
            cmbo_amountOfMonths.Items.Add("11 Months");
            cmbo_amountOfMonths.Items.Add("12 Months");
            //If the user is a admin show all transactions
            if (LoginForm.IsAdmin)
            {
                var result = (from transactions in context.Transactions
                              join C in context.Customers on transactions.CusId equals C.CusId
                              select new { transactions.DateTime, transactions.Total, transactions.TranId, C.Username }).ToList();
                //See whoes transaction you are looking at
                Username.Visible = true;
                foreach (var row in result)
                {
                    dgv_Transations.Rows.Add(row.DateTime, decimal.Round(row.Total, 2), null, row.TranId, row.Username);
                }
            }
            //User is not a admin so only show their transactions using CUS_ID from loginForm
            else
            {
                var result = (from transactions in context.Transactions
                              where transactions.CusId == LoginForm.CUS_ID
                              select new { transactions.DateTime, transactions.Total, transactions.TranId }).ToList();
                foreach (var row in result)
                {
                    dgv_Transations.Rows.Add(row.DateTime, decimal.Round(row.Total, 2), null, row.TranId);
                }
            }
        }

        private void dgv_Transations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Esablish db connection
            DBContext context = new DBContext();
            var senderGrid = (DataGridView)sender;
            //Code check to make sure the content click was the view button then grabs the 
            //transaction items from that row and displays them on the right (dgv_TransactionItems)
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                dgv_TransactionItems.Rows.Clear();
                int tranIDFound = int.Parse(dgv_Transations.Rows[e.RowIndex].Cells[3].Value.ToString());
                var transactionItems = (from items in context.TransactionItems
                                        join p in context.Products on items.ProdId equals p.ProdId
                                        where items.TranId == tranIDFound
                                        select new { p.Name, items.Price, items.Quantity }).ToList();
                foreach (var item in transactionItems)
                {
                    dgv_TransactionItems.Rows.Add(item.Name, item.Price, item.Quantity);
                }
            }
        }
        //User can select how many months of transactions they want to view ranging from 1 month ago to 1 year
        private void cmbo_amountOfMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears data so only the selected amount of months transactions show up
            dgv_Transations.Rows.Clear();
            //Sets current date time as first of current month current year so
            //AMount of months back will be for the month not the current date X number of months
            DateTime selectedDateTime = new DateTime(System.DateTime.Today.Year, System.DateTime.Today.Month, 1);

            //Various selections and how many months to eventually filter back to
            switch (cmbo_amountOfMonths.Text)
            {
                case ("All"):
                    //All shows last 5 years worth of transactions not "all"
                    selectedDateTime = System.DateTime.Today.AddYears(-5);
                    break;
                case ("Month"):
                    selectedDateTime = System.DateTime.Today.AddMonths(-1);
                    break;
                case ("2 Months"):
                    selectedDateTime = System.DateTime.Today.AddMonths(-2);
                    break;
                case ("3 Months"):
                    selectedDateTime = System.DateTime.Today.AddMonths(-3);
                    break;
                case ("4 Months"):
                    selectedDateTime = System.DateTime.Today.AddMonths(-4);
                    break;
                case ("5 Months"):
                    selectedDateTime = System.DateTime.Today.AddMonths(-5);
                    break;
                case ("6 Months"):
                    selectedDateTime = System.DateTime.Today.AddMonths(-6);
                    break;
                case ("7 Months"):
                    selectedDateTime = System.DateTime.Today.AddMonths(-7);
                    break;
                case ("8 Months"):
                    selectedDateTime = System.DateTime.Today.AddMonths(-8);
                    break;
                case ("9 Months"):
                    selectedDateTime = System.DateTime.Today.AddMonths(-9);
                    break;
                case ("10 Months"):
                    selectedDateTime = System.DateTime.Today.AddMonths(-10);
                    break;
                case ("11 Months"):
                    selectedDateTime = System.DateTime.Today.AddMonths(-11);
                    break;
                case ("12 Months"):
                    selectedDateTime = System.DateTime.Today.AddMonths(-12);
                    break;
            }
            //Establish db connection
            DBContext context = new DBContext();
            //The if/else for filtering transactions by date for admin and non admin
            if (LoginForm.IsAdmin)
            {
                var result = (from transactions in context.Transactions
                              join C in context.Customers on transactions.CusId equals C.CusId
                              where transactions.DateTime >= selectedDateTime
                              select new { transactions.DateTime, transactions.Total, transactions.TranId, C.Username }).ToList();
                Username.Visible = true;
                foreach (var row in result)
                {
                    dgv_Transations.Rows.Add(row.DateTime, decimal.Round(row.Total, 2), null, row.TranId, row.Username);
                }
            }
            else
            {
                var result = (from transactions in context.Transactions
                              where transactions.CusId == LoginForm.CUS_ID
                              where transactions.DateTime >= selectedDateTime
                              select new { transactions.DateTime, transactions.Total, transactions.TranId }).ToList();
                foreach (var row in result)
                {
                    dgv_Transations.Rows.Add(row.DateTime, decimal.Round(row.Total, 2), null, row.TranId);
                }
            }
        }
    }
}
