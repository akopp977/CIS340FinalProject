using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using finalProject.Models.DataLayer;

namespace finalProject
{
    public partial class LoginForm : Form
    {
        //These are all static as they are used also they should not change throught the user using the form
        //If they sign out they can/will change to whoever signs in next
        //Field to tell is user is admin or not used to decied what forms to allow user to go to
        public static bool IsAdmin { get; set; }
        //Field used to hold username
        public static string Username { get; set; }
        //Field to hold customer ID
        public static int CUS_ID { get; set; }
        //Consructor
        public LoginForm()
        {
            InitializeComponent();
        }
        //Defualt IsAdmin to false on load
        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm.IsAdmin = false;
        }
        //When sign in clicked it checks with the DB if valid username/login
        //If it is it assigns the fields and also opens next form (shopEasy)
        //If not give error message on screen
        private void button1_Click(object sender, EventArgs e)
        {
            DBContext context = new DBContext();
            var result = context.Logins.Where(i => i.Username == txt_Username.Text & i.Password == txt_Password.Text).ToList();
            if (result.Any())
            {
                if (result[0].Admin) LoginForm.IsAdmin = true;
                LoginForm.Username = result[0].Username;
                LoginForm.CUS_ID = (int)result[0].CusId;
                this.Hide();
                ShopEasy shopEasy = new ShopEasy();
                shopEasy.Show();
            }
            else login_test_lbl.Text = "Invalid username or password";
        }
    }
}
