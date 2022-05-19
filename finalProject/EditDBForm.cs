using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using finalProject.Models.DataLayer;

namespace finalProject
{
    public partial class EditDBForm : Form
    {
        /*****************************************************
         * ColumnX like Column1 referes to the column on the dgv 
         * that it would pertain toIn the UI side it is never used
         * in this way only for back end, on the ui side the name 
         * of the column is on the label, columns are in order as 
         * they appear in the table. For each lbl_ColumnX
         * there is a corresponding txt_ColumnX
         *****************************************************/


        //Field to know if cmboCRUD selected
        private bool chooseCRUDSelected = false;
        //Field to know if table selected
        private bool tableToEditSelected = false;
        //Field to know if entry was found in DB (Used in delete and edit existing
        private bool findNotice = false;
        //Constructor
        public EditDBForm()
        {
            InitializeComponent();
        }
        //Visual studio made this.
        private void EditDBForm_Load(object sender, EventArgs e)
        {

        }

        //When table changes run method to set and show lable/txtboxes and refresh data
        private void cmbo_TableToEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableToEditSelected = true;
            if (tableToEditSelected & chooseCRUDSelected)
            {
                setAndShowLablesAndTextBoxes();
                whatToDisplayBasedOnChooseCRUD();
            }

        }


        //When CRUD option changes, run method to set and show lable/txtboxes and refresh data
        private void cmbo_ChooseCRUD_SelectedIndexChanged(object sender, EventArgs e)
        {
            chooseCRUDSelected = true;
            if (tableToEditSelected & chooseCRUDSelected)
            {
                setAndShowLablesAndTextBoxes();
                whatToDisplayBasedOnChooseCRUD();
            }
        }
        //Function to trim all textboxes (gets rid of extra spaces)
        private void trimTxtBoxes()
        {
            txt_column1.Text = txt_column1.Text.Trim();
            txt_column2.Text = txt_column2.Text.Trim();
            txt_column3.Text = txt_column3.Text.Trim();
            txt_column4.Text = txt_column4.Text.Trim();
            txt_column5.Text = txt_column5.Text.Trim();
            txt_column6.Text = txt_column6.Text.Trim();
            txt_column7.Text = txt_column7.Text.Trim();
        }

        //Function only called when find button is clicked
        private void find()
        {
            DBContext context = new DBContext();
            switch (cmbo_TableToEdit.Text)
            {
                case "Logins":
                    //Gets current data from logins table
                    var resultLogins = (from selected in context.Logins
                                        select new { selected.Username, selected.Password, selected.Admin, selected.CusId });
                    //Looks for result based on username
                    var searchResult = (from results in resultLogins
                                        where results.Username == txt_column1.Text
                                        select results).ToList();
                    //Handles if none found also displays whether found or not
                    if (searchResult.Count! > 0)
                    {
                        lbl_FindNotice.Text = "Found " + searchResult[0].Username;
                        //Since it was found fill in current information in the txt boxes for ease of modification
                        txt_column1.Text = searchResult[0].Username;
                        txt_column2.Text = searchResult[0].Password;
                        txt_column3.Text = searchResult[0].Admin.ToString();
                        txt_column4.Text = searchResult[0].CusId.ToString();
                        findNotice = true;
                    }
                    else
                    {
                        lbl_FindNotice.Text = "Not Found";
                        findNotice = false;
                    }

                    break;

                case "Customers":

                    var resultCustomers = (from selected in context.Customers
                                           select new { selected.FirstName, selected.LastName, selected.PhoneNumber, selected.Email, selected.Username, selected.CusId, selected.CusTypeId });
                    //Looks for result based on First and last name
                    var searchResult2 = (from results in resultCustomers
                                         where results.FirstName == txt_column1.Text & results.LastName == txt_column2.Text
                                         select results).ToList();
                    //Handles if none found also displays whether found or not
                    if (searchResult2.Count! > 0)
                    {
                        lbl_FindNotice.Text = "Found " + searchResult2[0].FirstName.Trim() + ' ' + searchResult2[0].LastName.Trim();
                        //Since it was found fill in current information in the txt boxes for ease of modification
                        txt_column1.Text = searchResult2[0].FirstName;
                        txt_column2.Text = searchResult2[0].LastName;
                        txt_column3.Text = searchResult2[0].PhoneNumber;
                        txt_column4.Text = searchResult2[0].Email;
                        txt_column5.Text = searchResult2[0].Username;
                        txt_column6.Text = searchResult2[0].CusId.ToString();
                        txt_column7.Text = searchResult2[0].CusTypeId.ToString();
                        findNotice = true;
                    }
                    else
                    {
                        lbl_FindNotice.Text = "Not Found";
                        findNotice = false;
                    }
                    break;


                case "Products":

                    var resultProducts = (from selected in context.Products
                                          select new { selected.ProdId, selected.Name, selected.Desc, selected.TypeId, selected.Price });
                    //Looks for result based on username
                    var searchResult4 = (from results in resultProducts
                                         where results.Name == txt_column2.Text
                                         select results).ToList();
                    //Handles if none found also displays whether found or not
                    if (searchResult4.Count! > 0)
                    {
                        lbl_FindNotice.Text = "Found " + searchResult4[0].Name;
                        //Since it was found fill in current information in the txt boxes for ease of modification
                        txt_column1.Text = searchResult4[0].ProdId.ToString();
                        txt_column2.Text = searchResult4[0].Name;
                        txt_column3.Text = searchResult4[0].Desc;
                        txt_column4.Text = searchResult4[0].TypeId.ToString();
                        txt_column5.Text = searchResult4[0].Price.ToString();
                        findNotice = true;
                    }
                    else
                    {
                        lbl_FindNotice.Text = "Not Found";
                        findNotice = false;
                    }
                    break;

                case "Product Types":

                    var resultProductsTypes = (from selected in context.ProductTypes
                                               select new { selected.TypeId, selected.Type });
                    //Looks for result based on Customer Type
                    var searchResult5 = (from results in resultProductsTypes
                                         where results.Type == txt_column2.Text
                                         select results).ToList();

                    //Handles if none found also displays whether found or not
                    if (searchResult5.Count! > 0)
                    {
                        lbl_FindNotice.Text = "Found " + searchResult5[0].Type;
                        //Since it was found fill in current information in the txt boxes for ease of modification
                        txt_column1.Text = searchResult5[0].TypeId.ToString();
                        txt_column2.Text = searchResult5[0].Type;
                        findNotice = true;
                    }
                    else
                    {
                        lbl_FindNotice.Text = "Not Found";
                        findNotice = false;
                    }
                    break;

            }
            trimTxtBoxes();
            whatToDisplayBasedOnChooseCRUD();
        }

        //This method changes visablity of elements and whether an elements is enabled or not based on CRUD operation
        private void whatToDisplayBasedOnChooseCRUD()
        {
            //Defaults all txt boxes to enabled false
            txt_column1.Enabled = false;
            txt_column2.Enabled = false;
            txt_column3.Enabled = false;
            txt_column4.Enabled = false;
            txt_column5.Enabled = false;
            txt_column6.Enabled = false;
            txt_column7.Enabled = false;

            switch (cmbo_ChooseCRUD.Text)
            {
                //Read, dont need to see anything just the dgv
                case "View":
                    lbl_Column1.Visible = false;
                    lbl_Column2.Visible = false;
                    lbl_Column3.Visible = false;
                    lbl_Column4.Visible = false;
                    lbl_Column5.Visible = false;
                    lbl_Column6.Visible = false;
                    lbl_Column7.Visible = false;

                    txt_column1.Visible = false;
                    txt_column2.Visible = false;
                    txt_column3.Visible = false;
                    txt_column4.Visible = false;
                    txt_column5.Visible = false;
                    txt_column6.Visible = false;
                    txt_column7.Visible = false;

                    btn_EditTable.Visible = false;
                    btn_Find.Visible = false;
                    lbl_FindNotice.Visible = false;
                    break;
                //Create only want to edit the boxes that you need to fill in i.e. not the 
                //identity conating field like Customer ID or Product ID or similar
                //Also no need to see find notice or find button as you are creating new
                case "Create new":
                    btn_EditTable.Text = "Create";
                    btn_EditTable.Visible = true;
                    btn_Find.Visible = false;
                    lbl_FindNotice.Visible = false;
                    //Enabling and disabling txt boxes for each case (since you can edit the auto increments)
                    switch (cmbo_TableToEdit.Text)
                    {
                        case "Logins":
                            txt_column1.Enabled = true;
                            txt_column2.Enabled = true;
                            txt_column3.Enabled = true;
                            break;
                        case "Customers":
                            txt_column1.Enabled = true;
                            txt_column2.Enabled = true;
                            txt_column3.Enabled = true;
                            txt_column4.Enabled = true;
                            txt_column5.Enabled = true;
                            txt_column7.Enabled = true;
                            break;
                        case "Products":
                            txt_column2.Enabled = true;
                            txt_column3.Enabled = true;
                            txt_column4.Enabled = true;
                            txt_column5.Enabled = true;
                            break;
                        case "Product Types":
                            txt_column2.Enabled = true;
                            break;
                    }
                    break;
                //Update Only be able to edit what ones you can use to search (find) with like product name or customer first
                //and last name, find button visable because it is used. If findNotice is true though you need to edit
                //the ones that are fields that can be changed i.e. the ones from creating
                case "Edit existing":
                    btn_EditTable.Text = "Submit Edit";
                    btn_EditTable.Visible = true;
                    btn_Find.Visible = true;
                    lbl_FindNotice.Visible = true;

                    switch (cmbo_TableToEdit.Text)
                    {
                        case "Logins":
                            if (findNotice)
                            {
                                txt_column1.Enabled = true;
                                txt_column2.Enabled = true;
                                txt_column3.Enabled = true;
                            }
                            else
                            {
                                txt_column1.Enabled = true;
                            }
                            break;
                        case "Customers":
                            if (findNotice)
                            {
                                txt_column1.Enabled = true;
                                txt_column2.Enabled = true;
                                txt_column3.Enabled = true;
                                txt_column4.Enabled = true;
                                txt_column5.Enabled = true;
                                txt_column7.Enabled = true;
                            }
                            else
                            {
                                txt_column1.Enabled = true;
                                txt_column2.Enabled = true;
                            }
                            break;
                        case "Products":
                            if (findNotice)
                            {
                                txt_column2.Enabled = true;
                                txt_column3.Enabled = true;
                                txt_column4.Enabled = true;
                                txt_column5.Enabled = true;
                            }
                            else
                            {
                                txt_column2.Enabled = true;
                            }
                            break;
                        case "Product Types":
                            txt_column2.Enabled = true;
                            break;
                    }
                    break;
                //Delete only need to edit the ones that you can search with others are not needed
                case "Delete existing":
                    btn_EditTable.Text = "Delete";
                    btn_EditTable.Visible = true;
                    btn_Find.Visible = true;
                    lbl_FindNotice.Visible = true;
                    //Enabling and disabling txt boxes for each case as I only want what you can search with to be editable
                    switch (cmbo_TableToEdit.Text)
                    {
                        case "Logins":
                            txt_column1.Enabled = true;
                            break;
                        case "Customers":
                            txt_column1.Enabled = true;
                            txt_column2.Enabled = true;
                            break;
                        case "Products":
                            txt_column2.Enabled = true;
                            break;
                        case "Product Types":
                            txt_column2.Enabled = true;
                            break;
                    }
                    break;
            }
            //Customer type is non editable by admin therfore only view only as a refernece when creating/editing
            if (cmbo_TableToEdit.Text == "Customer Types")
            {
                cmbo_ChooseCRUD.SelectedIndex = 0;
            }
        }
        //sets what the lables are according to what table is being displayed and then if they are visable or not also 
        //Gets/set whats will be in the DGV for data
        private void setAndShowLablesAndTextBoxes()
        {
            //Establish DB connection
            DBContext context = new DBContext();


            switch (cmbo_TableToEdit.Text)
            {
                //Login table needs to have these fields and only enough txt boxes and lbls for those fields
                case "Logins":
                    lbl_Column1.Text = "Username";
                    lbl_Column2.Text = "Password";
                    lbl_Column3.Text = "Admin";
                    lbl_Column4.Text = "Customer ID";
                    lbl_Column5.Text = "";
                    lbl_Column6.Text = "";
                    lbl_Column7.Text = "";

                    lbl_Column1.Visible = true;
                    lbl_Column2.Visible = true;
                    lbl_Column3.Visible = true;
                    lbl_Column4.Visible = true;
                    lbl_Column5.Visible = false;
                    lbl_Column6.Visible = false;
                    lbl_Column7.Visible = false;

                    txt_column1.Visible = true;
                    txt_column2.Visible = true;
                    txt_column3.Visible = true;
                    txt_column4.Visible = true;
                    txt_column5.Visible = false;
                    txt_column6.Visible = false;
                    txt_column7.Visible = false;
                    //Gets and displays the tables data
                    var resultLogins = (from selected in context.Logins
                                        select new { Username = selected.Username.Trim(), Password = selected.Password.Trim(), Admin = selected.Admin, CusId = selected.CusId }).ToList();
                    dgv_Data.DataSource = resultLogins;
                    break;

                //Customers table needs to have these fields and only enough txt boxes and lbls for those fields
                case "Customers":
                    lbl_Column1.Text = "First Name";
                    lbl_Column2.Text = "Last Name";
                    lbl_Column3.Text = "Phone Number";
                    lbl_Column4.Text = "Email";
                    lbl_Column5.Text = "Username";
                    lbl_Column6.Text = "Customer ID";
                    lbl_Column7.Text = "Customer Type ID";

                    lbl_Column1.Visible = true;
                    lbl_Column2.Visible = true;
                    lbl_Column3.Visible = true;
                    lbl_Column4.Visible = true;
                    lbl_Column5.Visible = true;
                    lbl_Column6.Visible = true;
                    lbl_Column7.Visible = true;

                    txt_column1.Visible = true;
                    txt_column2.Visible = true;
                    txt_column3.Visible = true;
                    txt_column4.Visible = true;
                    txt_column5.Visible = true;
                    txt_column6.Visible = true;
                    txt_column7.Visible = true;
                    //Gets and displays the tables data

                    var resultCustomers = (from selected in context.Customers
                                           select new { FirstName = selected.FirstName.Trim(), LastName = selected.LastName.Trim(), PhoneNumber = selected.PhoneNumber.Trim(), Email = selected.Email.Trim(), Username = selected.Username.Trim(), selected.CusId, selected.CusTypeId }).ToList();
                    //Resolved weird issue where CusType_ID column would move to the front
                    dgv_Data.DataSource = null;
                    dgv_Data.DataSource = resultCustomers;
                    break;

                //Customer types table needs to have these fields and only enough txt boxes and lbls for those fields
                case "Customer Types":
                    lbl_Column1.Text = "";
                    lbl_Column2.Text = "";
                    lbl_Column3.Text = "";
                    lbl_Column4.Text = "";
                    lbl_Column5.Text = "";
                    lbl_Column6.Text = "";
                    lbl_Column7.Text = "";

                    lbl_Column1.Visible = false;
                    lbl_Column2.Visible = false;
                    lbl_Column3.Visible = false;
                    lbl_Column4.Visible = false;
                    lbl_Column5.Visible = false;
                    lbl_Column6.Visible = false;
                    lbl_Column7.Visible = false;

                    txt_column1.Visible = false;
                    txt_column2.Visible = false;
                    txt_column3.Visible = false;
                    txt_column4.Visible = false;
                    txt_column5.Visible = false;
                    txt_column6.Visible = false;
                    txt_column7.Visible = false;
                    //Gets and displays the tables data

                    var resultCustomerTypes = (from selected in context.CustomerTypes
                                               select new { selected.CusTypeId, CustomerType = selected.CustomerType.Trim() }).ToList();
                    //Resolved weird issue where CusType_ID column would move to the front
                    dgv_Data.DataSource = null;
                    dgv_Data.DataSource = resultCustomerTypes;
                    break;

                //Products table needs to have these fields and only enough txt boxes and lbls for those fields
                case "Products":
                    lbl_Column1.Text = "Product ID";
                    lbl_Column2.Text = "Name";
                    lbl_Column3.Text = "Description";
                    lbl_Column4.Text = "Product Type ID";
                    lbl_Column5.Text = "Price";
                    lbl_Column6.Text = "";
                    lbl_Column7.Text = "";

                    lbl_Column1.Visible = true;
                    lbl_Column2.Visible = true;
                    lbl_Column3.Visible = true;
                    lbl_Column4.Visible = true;
                    lbl_Column5.Visible = true;
                    lbl_Column6.Visible = false;
                    lbl_Column7.Visible = false;

                    txt_column1.Visible = true;
                    txt_column2.Visible = true;
                    txt_column3.Visible = true;
                    txt_column4.Visible = true;
                    txt_column5.Visible = true;
                    txt_column6.Visible = false;
                    txt_column7.Visible = false;
                    //Gets and displays the tables data

                    var resultProducts = (from selected in context.Products
                                          select new { selected.ProdId, Name = selected.Name.Trim(), Desc = selected.Desc.Trim(), selected.TypeId, selected.Price }).ToList();
                    //Resolved weird issue where Type_ID column would move to the front
                    dgv_Data.DataSource = null;
                    dgv_Data.DataSource = resultProducts;
                    break;

                //Product Types table needs to have these fields and only enough txt boxes and lbls for those fields
                case "Product Types":
                    lbl_Column1.Text = "Product Type ID";
                    lbl_Column2.Text = "Product Type";
                    lbl_Column3.Text = "";
                    lbl_Column4.Text = "";
                    lbl_Column5.Text = "";
                    lbl_Column6.Text = "";
                    lbl_Column7.Text = "";

                    lbl_Column1.Visible = true;
                    lbl_Column2.Visible = true;
                    lbl_Column3.Visible = false;
                    lbl_Column4.Visible = false;
                    lbl_Column5.Visible = false;
                    lbl_Column6.Visible = false;
                    lbl_Column7.Visible = false;

                    txt_column1.Visible = true;
                    txt_column2.Visible = true;
                    txt_column3.Visible = false;
                    txt_column4.Visible = false;
                    txt_column5.Visible = false;
                    txt_column6.Visible = false;
                    txt_column7.Visible = false;
                    //Gets and displays the tables data

                    var resultProductsTypes = (from selected in context.ProductTypes
                                               select new { selected.TypeId, Type = selected.Type.Trim() }).ToList();
                    //Resolved weird issue where Type_ID column would move to the front
                    dgv_Data.DataSource = null;
                    dgv_Data.DataSource = resultProductsTypes;
                    break;
            }
        }
        //When the edit button is clicked it attempts to perform the Create Update or Delete with appropriate errors/validation
        private void btn_EditTable_Click(object sender, EventArgs e)
        {
            //Establish db connection
            DBContext context = new DBContext();
            //Trims text boxes incase extra spaces entered by user
            trimTxtBoxes();
            //This try catches any extra errors if something goes wrong
            try
            {
                if (cmbo_ChooseCRUD.Text == "Create new")
                {
                    //Txt has to be (filled in or disabled) ors visable to create new otherwise error
                    //Logic txtbox is not emmpty or not enable then true because if enabled it should have text
                    //if it is empty then it should be disabled, ie app will fill it in. This is a or so only one has
                    //to be true. If both are false then the text box should be not visable so it couldnt be filled in 
                    // or enable then true and operation can occure. If these are not met then fail and error with appropriate
                    //error messages
                    if (((Validation.NotEmpty(txt_column1.Text) || !txt_column1.Enabled) || !txt_column1.Visible) &&
                        ((Validation.NotEmpty(txt_column2.Text) || !txt_column2.Enabled) || !txt_column2.Visible) &&
                        ((Validation.NotEmpty(txt_column3.Text) || !txt_column3.Enabled) || !txt_column3.Visible) &&
                        ((Validation.NotEmpty(txt_column4.Text) || !txt_column4.Enabled) || !txt_column4.Visible) &&
                        ((Validation.NotEmpty(txt_column5.Text) || !txt_column5.Enabled) || !txt_column5.Visible) &&
                        ((Validation.NotEmpty(txt_column6.Text) || !txt_column6.Enabled) || !txt_column6.Visible) &&
                        ((Validation.NotEmpty(txt_column7.Text) || !txt_column7.Enabled) || !txt_column7.Visible))
                    {
                        //If gets to this switch then boxes are filled in atleast with text. Validation occurs
                        //Base on what table is displayed validation uses Validation classes static methods to determine
                        //If input is valid or not
                        switch (cmbo_TableToEdit.Text)
                        {
                            case "Logins":
                                //Validates input before doing anything to avoid errors if error would be cause
                                //The appropriate error mesage is displayed
                                if (Validation.IsBool(txt_column3.Text) &&
                                    Validation.IsUserCreated(txt_column1.Text) &&
                                    !Validation.LoginExists(txt_column1.Text))
                                {
                                    Logins loginToAdd = new Logins();
                                    loginToAdd.Username = txt_column1.Text;
                                    loginToAdd.Password = txt_column2.Text;
                                    loginToAdd.Admin = bool.Parse(txt_column3.Text);
                                    //Grabs CusID from db so it cant be wrong
                                    loginToAdd.CusId = (from a in context.Customers
                                                        where a.Username == txt_column1.Text
                                                        select a.CusId).ToList()[0];
                                    context.Logins.Add(loginToAdd);
                                    context.SaveChanges();
                                }
                                //Something is entered wrong so display the message
                                else
                                {
                                    var errorMessage = "";
                                    if (!Validation.IsBool(txt_column3.Text))
                                    {
                                        errorMessage += Environment.NewLine + "Please use \"True\" or \"False\" for the Admin field";
                                    }
                                    if (!Validation.IsUserCreated(txt_column1.Text))
                                    {
                                        errorMessage += Environment.NewLine + "Username is not used by a customer";
                                    }
                                    if (Validation.LoginExists(txt_column1.Text))
                                    {
                                        errorMessage += Environment.NewLine + "Login for username already exists";
                                    }
                                    ErrorForm error = new ErrorForm(errorMessage);
                                    error.Show();
                                }
                                break;
                            case "Customers":
                                //Validate input
                                if (!Validation.CustomerExists(txt_column1.Text, txt_column2.Text) &&
                                    Validation.IsPhoneNumber(txt_column3.Text) &&
                                    Validation.IsEmail(txt_column4.Text) &&
                                    !Validation.LoginExists(txt_column5.Text) &&
                                    Validation.ValidCustomerType(txt_column7.Text))
                                {
                                    //Add cutomser if here input valid
                                    Customers customerToAdd = new Customers();
                                    customerToAdd.FirstName = txt_column1.Text;
                                    customerToAdd.LastName = txt_column2.Text;
                                    customerToAdd.PhoneNumber = txt_column3.Text;
                                    customerToAdd.Email = txt_column4.Text;
                                    customerToAdd.Username = txt_column5.Text;
                                    customerToAdd.CusTypeId = int.Parse(txt_column7.Text);
                                    context.Customers.Add(customerToAdd);
                                    context.SaveChanges();
                                }
                                //Invalid input
                                else
                                {
                                    var errorMessage = "";
                                    if (Validation.CustomerExists(txt_column1.Text, txt_column2.Text))
                                    {
                                        errorMessage += Environment.NewLine + "Customer already exists";
                                    }
                                    if (!Validation.IsPhoneNumber(txt_column3.Text))
                                    {
                                        errorMessage += Environment.NewLine + "Phone number is not valid enter like 111-111-1111";
                                    }
                                    if (!Validation.IsEmail(txt_column4.Text))
                                    {
                                        errorMessage += Environment.NewLine + "Email invalid enter like example@email.com";
                                    }
                                    if (Validation.LoginExists(txt_column5.Text))
                                    {
                                        errorMessage += Environment.NewLine + "That username is already in use";
                                    }
                                    if (!Validation.ValidCustomerType(txt_column7.Text))
                                    {
                                        //Display all the cus.id for convience so valid one can be used
                                        errorMessage += Environment.NewLine + "Customer type not valid try one of these";
                                        var customerTypes = (from cusTypes in context.CustomerTypes
                                                             select new { cusTypes.CustomerType, cusTypes.CusTypeId }).ToList();
                                        foreach (var type in customerTypes)
                                        {
                                            errorMessage += Environment.NewLine + type.CustomerType.Trim() + " ID: " + type.CusTypeId.ToString().Trim();
                                        }
                                    }
                                    ErrorForm error = new ErrorForm(errorMessage);
                                    error.Show();
                                }
                                break;
                            case "Products":
                                //Validate input
                                if (Validation.IsPrice(txt_column5.Text) &&
                                    Validation.ValidProductType(txt_column4.Text))
                                {
                                    Products productToAdd = new Products();
                                    productToAdd.Name = txt_column2.Text;
                                    productToAdd.Desc = txt_column3.Text;
                                    productToAdd.TypeId = int.Parse(txt_column4.Text);
                                    productToAdd.Price = decimal.Round(decimal.Parse(txt_column5.Text), 2);
                                    context.Products.Add(productToAdd);
                                    context.SaveChanges();
                                }
                                //Invalid input
                                else
                                {
                                    var errorMessage = "";
                                    if (!Validation.IsPrice(txt_column5.Text))
                                    {
                                        errorMessage += Environment.NewLine + "Please enter a valid price like 5.00 for $5.00";
                                    }
                                    if (!Validation.ValidProductType(txt_column7.Text))
                                    {
                                        //Displays all the different productTypes for convince 
                                        errorMessage += Environment.NewLine + "Product type not valid try one of these";
                                        var productTypes = (from prodTypes in context.ProductTypes
                                                            select new { prodTypes.Type, prodTypes.TypeId }).ToList();
                                        foreach (var type in productTypes)
                                        {
                                            errorMessage += Environment.NewLine + type.Type.Trim() + " ID: " + type.TypeId.ToString().Trim();
                                        }
                                    }
                                    ErrorForm error = new ErrorForm(errorMessage);
                                    error.Show();
                                }
                                break;
                            case "Product Types":
                                //No validation as productType can be anything
                                ProductTypes productTypeToAdd = new ProductTypes();
                                productTypeToAdd.Type = txt_column2.Text;
                                context.ProductTypes.Add(productTypeToAdd);
                                context.SaveChanges();
                                break;
                        }
                    }
                    //A field was blank error
                    else
                    {
                        ErrorForm error = new ErrorForm(Environment.NewLine + "Do not leave any fields blank");
                        error.Show();
                    }
                }
                //Edit existing has the same validation checks as create new just that the operation is update instead of add/create
                //Refer to create new for logic
                else if (cmbo_ChooseCRUD.Text == "Edit existing")
                {
                    if (findNotice)
                    {
                        //Refer to logic from create new
                        if (((Validation.NotEmpty(txt_column1.Text) || !txt_column1.Enabled) || !txt_column1.Visible) &&
                        ((Validation.NotEmpty(txt_column2.Text) || !txt_column2.Enabled) || !txt_column2.Visible) &&
                        ((Validation.NotEmpty(txt_column3.Text) || !txt_column3.Enabled) || !txt_column3.Visible) &&
                        ((Validation.NotEmpty(txt_column4.Text) || !txt_column4.Enabled) || !txt_column4.Visible) &&
                        ((Validation.NotEmpty(txt_column5.Text) || !txt_column5.Enabled) || !txt_column5.Visible) &&
                        ((Validation.NotEmpty(txt_column6.Text) || !txt_column6.Enabled) || !txt_column6.Visible) &&
                        ((Validation.NotEmpty(txt_column7.Text) || !txt_column7.Enabled) || !txt_column7.Visible))
                        {
                            switch (cmbo_TableToEdit.Text)
                            {
                                case "Logins":
                                    if (Validation.IsBool(txt_column3.Text) && Validation.IsUserCreated(txt_column1.Text))
                                    {
                                        Logins loginToAdd = new Logins();
                                        loginToAdd.Username = txt_column1.Text;
                                        loginToAdd.Password = txt_column2.Text;
                                        loginToAdd.Admin = Convert.ToBoolean(txt_column3.Text);
                                        loginToAdd.CusId = (from a in context.Customers
                                                            where a.Username == txt_column1.Text
                                                            select a.CusId).ToList()[0];
                                        context.Logins.Update(loginToAdd);
                                        context.SaveChanges();
                                    }
                                    else
                                    {
                                        var errorMessage = "";
                                        if (!Validation.IsBool(txt_column3.Text))
                                        {
                                            errorMessage = Environment.NewLine + "Please use \"True\" or \"False\" for the Admin field";
                                        }
                                        if (!Validation.IsUserCreated(txt_column1.Text))
                                        {
                                            errorMessage = Environment.NewLine + "Username is not used by a customer";
                                        }
                                        ErrorForm error = new ErrorForm(errorMessage);
                                        error.Show();
                                    }
                                    break;
                                case "Customers":
                                    if (Validation.IsPhoneNumber(txt_column3.Text) &&
                                        Validation.IsEmail(txt_column4.Text) &&
                                        !Validation.LoginExists(txt_column5.Text) &&
                                        Validation.ValidCustomerType(txt_column7.Text))
                                    {
                                        Customers customerToAdd = new Customers();
                                        customerToAdd.FirstName = txt_column1.Text;
                                        customerToAdd.LastName = txt_column2.Text;
                                        customerToAdd.PhoneNumber = txt_column3.Text;
                                        customerToAdd.Email = txt_column4.Text;
                                        customerToAdd.Username = txt_column5.Text;
                                        customerToAdd.CusId = int.Parse(txt_column6.Text);
                                        customerToAdd.CusTypeId = int.Parse(txt_column7.Text);
                                        context.Customers.Update(customerToAdd);
                                        context.SaveChanges();
                                    }
                                    else
                                    {
                                        var errorMessage = "";
                                        if (!Validation.IsPhoneNumber(txt_column3.Text))
                                        {
                                            errorMessage += Environment.NewLine + "Phone number is not valid enter like 111-111-1111";
                                        }
                                        if (!Validation.IsEmail(txt_column4.Text))
                                        {
                                            errorMessage += Environment.NewLine + "Email invalid enter like example@email.com";
                                        }
                                        if (Validation.LoginExists(txt_column5.Text))
                                        {
                                            errorMessage += Environment.NewLine + "That username is already in use";
                                        }
                                        if (!Validation.ValidCustomerType(txt_column7.Text))
                                        {
                                            errorMessage += Environment.NewLine + "Customer type not valid try one of these";
                                            var customerTypes = (from cusTypes in context.CustomerTypes
                                                                 select new { cusTypes.CustomerType, cusTypes.CusTypeId }).ToList();
                                            foreach (var type in customerTypes)
                                            {
                                                errorMessage += Environment.NewLine + type.CustomerType.Trim() + " ID: " + type.CusTypeId.ToString().Trim();
                                            }
                                        }
                                        ErrorForm error = new ErrorForm(errorMessage);
                                        error.Show();
                                    }
                                    break;
                                case "Products":
                                    if (Validation.IsPrice(txt_column5.Text) &&
                                        Validation.ValidProductType(txt_column4.Text))
                                    {
                                        Products productToAdd = new Products();
                                        productToAdd.ProdId = int.Parse(txt_column1.Text);
                                        productToAdd.Name = txt_column2.Text;
                                        productToAdd.Desc = txt_column3.Text;
                                        productToAdd.TypeId = int.Parse(txt_column4.Text);
                                        productToAdd.Price = decimal.Round(decimal.Parse(txt_column5.Text), 2);
                                        context.Products.Update(productToAdd);
                                        context.SaveChanges();
                                    }
                                    else
                                    {
                                        var errorMessage = "";
                                        if (!Validation.IsPrice(txt_column5.Text))
                                        {
                                            errorMessage += Environment.NewLine + "Please enter a valid price like 5.00 for $5.00";
                                        }
                                        if (!Validation.ValidProductType(txt_column7.Text))
                                        {
                                            errorMessage += Environment.NewLine + "Product type not valid try one of these";
                                            var productTypes = (from prodTypes in context.ProductTypes
                                                                select new { prodTypes.Type, prodTypes.TypeId }).ToList();
                                            foreach (var type in productTypes)
                                            {
                                                errorMessage += Environment.NewLine + type.Type.Trim() + " ID: " + type.TypeId.ToString().Trim();
                                            }
                                        }
                                        ErrorForm error = new ErrorForm(errorMessage);
                                        error.Show();
                                    }
                                    break;
                                case "Product Types":
                                    ProductTypes productTypeToAdd = new ProductTypes();
                                    productTypeToAdd.TypeId = int.Parse(txt_column1.Text);
                                    productTypeToAdd.Type = txt_column2.Text;
                                    context.ProductTypes.Update(productTypeToAdd);
                                    context.SaveChanges();
                                    break;
                            }
                        }
                        else
                        {
                            ErrorForm error = new ErrorForm(Environment.NewLine + "Do not leave any fields blank");
                            error.Show();
                        }
                    }
                    else
                    {
                        lbl_FindNotice.Text = "Can't edit if not found!";
                    }
                }
                //Only validation require for deleting is if the thing being deleted is a foriegn key and is still referenced
                //In the case of a customer the login has to be deleted first to delete a customer
                //In the case of a product there must be no transactions buying it to delete it
                //For product type no product must use the type to be deleted
                //If these are not met the appropriate error will occur
                else if (cmbo_ChooseCRUD.Text == "Delete existing")
                {
                    if (findNotice)
                    {
                        //Refer to logic from create new
                        if (((Validation.NotEmpty(txt_column1.Text) || !txt_column1.Enabled) || !txt_column1.Visible) &&
                        ((Validation.NotEmpty(txt_column2.Text) || !txt_column2.Enabled) || !txt_column2.Visible) &&
                        ((Validation.NotEmpty(txt_column3.Text) || !txt_column3.Enabled) || !txt_column3.Visible) &&
                        ((Validation.NotEmpty(txt_column4.Text) || !txt_column4.Enabled) || !txt_column4.Visible) &&
                        ((Validation.NotEmpty(txt_column5.Text) || !txt_column5.Enabled) || !txt_column5.Visible) &&
                        ((Validation.NotEmpty(txt_column6.Text) || !txt_column6.Enabled) || !txt_column6.Visible) &&
                        ((Validation.NotEmpty(txt_column7.Text) || !txt_column7.Enabled) || !txt_column7.Visible))
                        {
                            switch (cmbo_TableToEdit.Text)
                            {
                                case "Logins":
                                    Logins loginToRemove = new Logins();
                                    loginToRemove.Username = txt_column1.Text;
                                    loginToRemove.Password = txt_column2.Text;
                                    loginToRemove.Admin = Convert.ToBoolean(txt_column3.Text);
                                    loginToRemove.CusId = (from a in context.Customers
                                                           where a.Username == txt_column1.Text
                                                           select a.CusId).ToList()[0];
                                    context.Logins.Remove(loginToRemove);
                                    context.SaveChanges();
                                    break;
                                case "Customers":
                                    if (Validation.NoLogin(txt_column5.Text))
                                    {
                                        Customers customerToRemove = new Customers();
                                        customerToRemove.FirstName = txt_column1.Text;
                                        customerToRemove.LastName = txt_column2.Text;
                                        customerToRemove.PhoneNumber = txt_column3.Text;
                                        customerToRemove.Email = txt_column4.Text;
                                        customerToRemove.Username = txt_column5.Text;
                                        customerToRemove.CusId = int.Parse(txt_column6.Text);
                                        customerToRemove.CusTypeId = int.Parse(txt_column7.Text);
                                        context.Customers.Remove(customerToRemove);
                                        context.SaveChanges();
                                    }
                                    else
                                    {
                                        var errorMessage = "";
                                        if (!Validation.NoLogin(txt_column5.Text))
                                        {
                                            errorMessage += "The customers login must be deleted first";
                                        }
                                        ErrorForm error = new ErrorForm(Environment.NewLine + errorMessage);
                                        error.Show();
                                    }
                                    break;
                                case "Products":
                                    if (!Validation.StillTransactionsForProduct(txt_column1.Text))
                                    {
                                        Products productToRemove = new Products();
                                        productToRemove.ProdId = int.Parse(txt_column1.Text);
                                        productToRemove.Name = txt_column2.Text;
                                        productToRemove.Desc = txt_column3.Text;
                                        productToRemove.TypeId = int.Parse(txt_column4.Text);
                                        productToRemove.Price = decimal.Round(decimal.Parse(txt_column5.Text), 2);
                                        context.Products.Remove(productToRemove);
                                        context.SaveChanges();
                                    }
                                    else
                                    {
                                        var errorMessage = "";
                                        if (Validation.StillTransactionsForProduct(txt_column1.Text))
                                        {
                                            errorMessage += "There are transactions with this item can not delete";
                                        }
                                        ErrorForm error = new ErrorForm(Environment.NewLine + errorMessage);
                                        error.Show();
                                    }
                                    break;
                                case "Product Types":
                                    if (!Validation.StillProductsForType(txt_column1.Text))
                                    {
                                        ProductTypes productTypeToRemove = new ProductTypes();
                                        productTypeToRemove.TypeId = int.Parse(txt_column1.Text);
                                        productTypeToRemove.Type = txt_column2.Text;
                                        context.ProductTypes.Remove(productTypeToRemove);
                                        context.SaveChanges();
                                    }
                                    else
                                    {
                                        var errorMessage = "";
                                        if (Validation.StillProductsForType(txt_column1.Text))
                                        {
                                            errorMessage += "There are still products that use this type can't delete";
                                        }
                                        ErrorForm error = new ErrorForm(Environment.NewLine + errorMessage);
                                        error.Show();
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            ErrorForm error = new ErrorForm(Environment.NewLine + "Do not leave any fields blank");
                            error.Show();
                        }
                    }
                    else
                    {
                        lbl_FindNotice.Text = "Can't delete if not found!";
                    }
                }

                //Get rid of data after successful operation meaning the found bool has to be true
                if (findNotice)
                {
                    txt_column1.Text = "";
                    txt_column2.Text = "";
                    txt_column3.Text = "";
                    txt_column4.Text = "";
                    txt_column5.Text = "";
                    txt_column6.Text = "";
                    txt_column7.Text = "";
                    findNotice = false;
                }
                //Run these to refresh the tables after operations (see update, delete, create)

                setAndShowLablesAndTextBoxes();
                whatToDisplayBasedOnChooseCRUD();
            }
            catch (Exception)
            {
                ErrorForm error = new ErrorForm("Something went wrong");
            }

        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            find();
        }
    }
}
