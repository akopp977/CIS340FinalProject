using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace finalProject
{
    //Form that lets used naviagte the app. Depending on if they are an admin they will see shop and invoices or edit db and invoices
    public partial class ShopEasy : Form
    {
        //Contructor
        public ShopEasy()
        {
            InitializeComponent();
        }
        //On load displays what user can do based on wether they are an admin or not.
        private void ShopEasy_Load(object sender, EventArgs e)
        {
            //Checks the LoginForm to see if the are an admin
            if (LoginForm.IsAdmin)
            {
                //Only admins should be able to edit DB
                cmbo_WhatToDo.Items.Add("Edit DB");
            }
            if (!LoginForm.IsAdmin)
            {
                //Only customers should be able to shop
                cmbo_WhatToDo.Items.Add("Shop");
            }
            //Everyone can view invoices admin can see all invoices however
            cmbo_WhatToDo.Items.Add("View invoices");

            //Lets user know who is signed in
            lbl_Welcome_Box.Text = "Welcome " + LoginForm.Username.Trim() + "!";

        }
        //BUtton only visable after user selects an action to do
        private void btn_DoAction_Click(object sender, EventArgs e)
        {
            string formToOpen = cmbo_WhatToDo.Text.ToString();
            //Switch case for what form to open
            switch (formToOpen)
            {
                case "Shop":
                    Shop shop = new Shop();
                    shop.ShowDialog();
                    break;
                case "View invoices":
                    Invoices invoices = new Invoices();
                    invoices.ShowDialog();
                    break;
                case "Edit DB":
                    EditDBForm form = new EditDBForm();
                    form.ShowDialog();
                    break;
            }
        }
        //Shows button on selecting an option
        private void cmbo_WhatToDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_DoAction.Visible = true;
        }
        //Signs user out and goes back to sign in page for a new user to login
        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
