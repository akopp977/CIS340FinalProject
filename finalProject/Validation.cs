using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using finalProject.Models.DataLayer;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace finalProject
{
    //This class contains all the validation methods to be called to ensure anything the user enters is valid and 
    //will not cause any errors.
    public class Validation
    {
        //Checks if the string is empty
        public static bool NotEmpty(string text)
        {
            if (text.Trim() == "")
            {
                return false;
            }
            else return true;
        }
        //Checks if the string is a bool. i.e. It will parse as a bool
        public static bool IsBool(string text)
        {
            try
            {
                bool.Parse(text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Checks whether there is a customer using the username (text) or not
        public static bool IsUserCreated(string text)
        {
            try
            {
                DBContext context = new DBContext();
                var loginToAdd = (from a in context.Customers
                                  where a.Username == text
                                  select a.CusId).ToList()[0];
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Check if there is alreayd a login using the username
        public static bool LoginExists(string text)
        {
            try
            {
                DBContext context = new DBContext();
                var searchResult = (from results in context.Logins
                                    where results.Username == text
                                    select results).ToList()[0];
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Checks if text is an integer using regex
        public static bool IsInteger(string text)
        {
            return Regex.IsMatch(text.Trim(), "^[0-9]*$");
        }
        //Check is the cusomer already exists via firstname and lastname 
        public static bool CustomerExists(string text, string text2)
        {
            try
            {
                DBContext context = new DBContext();
                var searchResult = (from results in context.Customers
                                    where results.FirstName == text & results.LastName == text2
                                    select results).ToList()[0];
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Checks if a phone number is valid or not using regex
        public static bool IsPhoneNumber(string text)
        {
            return Regex.IsMatch(text.Trim(), "([0-9]{3})-([0-9]{3})-([0-9]{4})");
        }
        //Checks if a email is valid or not using regex
        public static bool IsEmail(string text)
        {
            return Regex.IsMatch(text.Trim(), @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
        //Basically checks if entered infor can be parsed for decimal
        public static bool IsPrice(string text)
        {
            try
            {
                decimal.Parse(text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Checks if there are still references to the Type
        public static bool StillProductsForType(string text)
        {
            try
            {
                DBContext context = new DBContext();
                var foundProduct = (from products in context.Products
                                    where products.TypeId == int.Parse(text)
                                    select products).ToList()[0];
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Checks if there are still references to the Product in transaction items
        public static bool StillTransactionsForProduct(string text)
        {
            try
            {
                DBContext context = new DBContext();
                var foundTransaction = (from T in context.TransactionItems
                                        where T.ProdId == int.Parse(text.Trim())
                                        select T).ToList()[0];
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Checks if there are still references to the customers username in the logins table
        public static bool NoLogin(string text)
        {
            try
            {
                DBContext context = new DBContext();
                var foundLogin = (from L in context.Logins
                                  where L.Username == text
                                  select L).ToList()[0];
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }

        //Checks if the entered customer type is a valid type
        public static bool ValidCustomerType(string text)
        {
            try
            {
                DBContext context = new DBContext();
                var returnedType = (from T in context.CustomerTypes
                                    where T.CusTypeId == int.Parse(text)
                                    select T).ToList()[0];
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Checks if the entered product type is a valid type
        public static bool ValidProductType(string text)
        {
            try
            {
                DBContext context = new DBContext();
                var returnedType = (from T in context.ProductTypes
                                    where T.TypeId == int.Parse(text)
                                    select T).ToList()[0];
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
