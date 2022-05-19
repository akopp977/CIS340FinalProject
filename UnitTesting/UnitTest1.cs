using Microsoft.VisualStudio.TestTools.UnitTesting;
using finalProject;
using finalProject.Models.DataLayer;
using System.Linq;
using System;

namespace UnitTesting
{
    [TestClass]
    //Data in each testing method should be either something that should/won't get removed so the test should always work
    //Like using Admin, or obsucure enough where noone should enter something in that has the same name like TestTestTestTest123456
    //Unless someone has access to the backend code they should not be able to break the tests easily without being extremely lucky
    public class UnitTest1
    {
        [TestMethod]
        public void IsBoolValid()
        {
            Assert.IsTrue(Validation.IsBool("False"));
            Assert.IsTrue(Validation.IsBool("True"));
        }
        [TestMethod]
        public void IsBoolInValid()
        {
            Assert.IsFalse(Validation.IsBool("no"));
            Assert.IsFalse(Validation.IsBool("yes"));
        }
        [TestMethod]
        public void NotEmptyEmpty()
        {
            Assert.IsFalse(Validation.NotEmpty(""));
            Assert.IsFalse(Validation.NotEmpty(" "));
        }
        [TestMethod]
        public void NotEmptyActullyNotEmpty()
        {
            Assert.IsTrue(Validation.NotEmpty("no"));
        }
        [TestMethod]
        public void IsUserCreated_Exists()
        {
            Assert.IsTrue(Validation.IsUserCreated("Admin"));
        }
        [TestMethod]
        public void IsUserCreated_NotExists()
        {
            Assert.IsFalse(Validation.IsUserCreated("THISACCOUNTSHOULDNOTEXISTSANDISRIDICULOUSIFITDOES"));
        }
        [TestMethod]
        public void LoginExists_Exists()
        {
            Assert.IsTrue(Validation.LoginExists("Admin"));
        }
        [TestMethod]
        public void LoginExists_NotExists()
        {
            Assert.IsFalse(Validation.LoginExists("THISACCOUNTSHOULDNOTEXISTSANDISRIDICULOUSIFITDOES"));
        }
        [TestMethod]
        public void IsInteger_Valid()
        {
            Assert.IsTrue(Validation.IsInteger("1"));
            Assert.IsTrue(Validation.IsInteger("10"));
            Assert.IsTrue(Validation.IsInteger("0"));
        }
        [TestMethod]
        public void IsInteger_InValid()
        {
            Assert.IsFalse(Validation.IsInteger("no"));
            Assert.IsFalse(Validation.IsInteger("1.0"));
        }
        [TestMethod]
        public void CustomerExists_Exists()
        {
            Assert.IsTrue(Validation.CustomerExists("Admin","Admin"));
        }
        [TestMethod]
        public void CustomerExists_NotExists()
        {
            Assert.IsFalse(Validation.CustomerExists("no", "THISACCOUNTSHOULDNOTEXISTSANDISRIDICULOUSIFITDOES"));
        }
        [TestMethod]
        public void IsPhoneNumber_Valid()
        {
            Assert.IsTrue(Validation.IsPhoneNumber("123-456-7890"));
        }
        [TestMethod]
        public void IsPhoneNumber_InValid()
        {
            Assert.IsFalse(Validation.IsPhoneNumber("no"));
            Assert.IsFalse(Validation.IsPhoneNumber("1111111111"));
            Assert.IsFalse(Validation.IsPhoneNumber("111-1111-1111"));
        }
        [TestMethod]
        public void IsEmail_Valid()
        {
            Assert.IsTrue(Validation.IsEmail("yes@email.com"));
        }
        [TestMethod]
        public void IsEmail_InValid()
        {
            Assert.IsFalse(Validation.IsEmail("no"));
            Assert.IsFalse(Validation.IsEmail("no@email"));
            Assert.IsFalse(Validation.IsEmail("no@email..com"));
            Assert.IsFalse(Validation.IsEmail("no@@email.com"));
        }
        [TestMethod]
        public void IsPrice_Valid()
        {
            Assert.IsTrue(Validation.IsPrice("120134.13"));
            Assert.IsTrue(Validation.IsPrice("120134.13213145"));
            Assert.IsTrue(Validation.IsPrice("12"));
            Assert.IsTrue(Validation.IsPrice("0"));
        }
        [TestMethod]
        public void IsPrice_InValid()
        {
            Assert.IsFalse(Validation.IsPrice("no"));
        }
        [TestMethod]
        public void NoLogin_Exists()
        {
            Assert.IsFalse(Validation.NoLogin("Admin"));
        }
        [TestMethod]
        public void NoLogin_NotExists()
        {
            Assert.IsTrue(Validation.NoLogin("THISACCOUNTSHOULDNOTEXISTSANDISRIDICULOUSIFITDOES"));
        }
        [TestMethod]
        public void ValidCustomerType_Valid()
        {
            Assert.IsTrue(Validation.ValidCustomerType("1"));
        }
        [TestMethod]
        public void ValidCustomerType_InValid()
        {
            Assert.IsFalse(Validation.ValidCustomerType("no"));
            Assert.IsFalse(Validation.ValidCustomerType("veteran"));
            Assert.IsFalse(Validation.ValidCustomerType(""));
        }
        [TestMethod]
        public void ValidProductType_Valid()
        {
            DBContext context = new DBContext();
            ProductTypes newProductType = new ProductTypes();
            newProductType.Type = "Test";
            //Looks for it in the types
            var searchForTest = (from T in context.ProductTypes
                                where T.Type == "Test"
                                select T).ToList();
            //If its in the types remove it
            if (searchForTest.Count>0)
            {
                context.ProductTypes.Remove(searchForTest[0]);
                context.SaveChanges();
            }
            context.ProductTypes.Add(newProductType);
            context.SaveChanges();
            var searchForTest_ID = (from T in context.ProductTypes
                                 where T.Type == "Test"
                                 select T.TypeId).ToList()[0].ToString().Trim();
            Assert.IsTrue(Validation.ValidProductType(searchForTest_ID));
            newProductType.TypeId = int.Parse(searchForTest_ID);
            context.ProductTypes.Remove(newProductType);
            context.SaveChanges();
        }
        [TestMethod]
        public void ValidProductType_InValid()
        {
            Assert.IsFalse(Validation.ValidProductType("no"));
            Assert.IsFalse(Validation.ValidProductType("999999999999"));
            Assert.IsFalse(Validation.ValidProductType("1.01"));
        }
        [TestMethod]
        public void StillProductsForType_Exists()
        {
            DBContext context = new DBContext();
            //Create type for test product
            ProductTypes newProductType = new ProductTypes();
            newProductType.Type = "TestTestTestTest123456";
            //Add the new type
            context.ProductTypes.Add(newProductType);
            context.SaveChanges();
            //Get the new test types ID
            var searchForTest_ID = (from T in context.ProductTypes
                                    where T.Type == "TestTestTestTest123456"
                                    select T.TypeId).ToList()[0].ToString().Trim();
            newProductType.TypeId = int.Parse(searchForTest_ID);

            //Create new test product
            Products productToAdd = new Products();
            productToAdd.Name = "TestTestTestTest123456";
            productToAdd.Desc = "TestTestTestTest123456 product";
            productToAdd.TypeId = int.Parse(searchForTest_ID);
            productToAdd.Price = 1.69M;
            //Add new test product
            context.Products.Add(productToAdd);
            context.SaveChanges();
            var testProductType_ID = (from T in context.Products
                                      where T.Name == "TestTestTestTest123456"
                                      select T.TypeId).ToList()[0].ToString().Trim();
            Assert.IsTrue(Validation.StillProductsForType(testProductType_ID));
            //Remove new test product then type
            context.Products.Remove(productToAdd);
            context.SaveChanges();
            context.ProductTypes.Remove(newProductType);
            context.SaveChanges();
        }
        [TestMethod]
        public void StillProductsForType_NotExists()
        {
            Assert.IsFalse(Validation.StillProductsForType("999999999999"));
        }
        [TestMethod]
        public void StillTransactionsForProduct_Exists()
        {
            //1 should be football and it had been bought so it can't be removed should always be there
            Assert.IsTrue(Validation.StillTransactionsForProduct("1"));
        }
        [TestMethod]
        public void StillTransactionsForProduct_NotExists()
        {
            DBContext context = new DBContext();
            Products productToAdd = new Products();
            productToAdd.Name = "TestTestTestTest123456";
            productToAdd.Desc = "TestTestTestTest product";
            //5 is sports it is football, football has been bought, i.e. cannot delete sports type
            productToAdd.TypeId = 5;
            productToAdd.Price = 1.69M;
            //Add new test product
            context.Products.Add(productToAdd);
            context.SaveChanges();
            var testProductID = (from T in context.Products
                                      where T.Name == "TestTestTestTest123456"
                                      select T.ProdId).ToList()[0].ToString().Trim();
            Assert.IsFalse(Validation.StillTransactionsForProduct(testProductID));
            productToAdd.ProdId = int.Parse(testProductID);
            context.Remove(productToAdd);
            context.SaveChanges();
        }
    }
}
