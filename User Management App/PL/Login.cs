using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Management_App.Properties;

namespace User_Management_App.PL
{
    public partial class Login : Form
    {
        // variable to track whether the password is visible or not
        private bool isPasswordVisible = false;

        // Create instance of the Users class
        BL.Users cls_User = new BL.Users();

        // datatable to store all users
        DataTable dt = new DataTable();

        public Login()
        {
            InitializeComponent();

            // load all users from the database into the dataTable
            dt = cls_User.Get_All_Users();
        }

        // event when click on showPassword button
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            // check if the password is currently visible or not
            if (isPasswordVisible)
            {
                // if password is visible, hide it and change the button's image
                btnShowPassword.Image = Resources.iconeye;
                isPasswordVisible = false;
                txtPassword.PasswordChar = '*';
            }
            else
            {
                // if password is not visible, show it and change the button's image
                btnShowPassword.Image = Resources.iconhidden;
                isPasswordVisible = true;
                txtPassword.PasswordChar = '\0'; 
            }
        }

        // event when click on login button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // we need this variable to check validate username and password
            bool checkLogin = false;

            // this loop for around all the users of datatable
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // check if username and password match any user in the datatable
                if (txtUsername.Text == dt.Rows[i][1].ToString() && txtPassword.Text == dt.Rows[i][2].ToString())
                {
                    // if username and password is valid, change variable to true
                    checkLogin = true;

                    // get the current user role matched, we need it in the home form
                    string userRole = dt.Rows[i][3].ToString();

                    // if username and password is valid, open the Home form and pass the user's role as a parameter
                    // after that hide this form and exit in this loop
                    Home home = new Home(userRole);
                    home.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    // if username and password is not valid, set variable to false
                    checkLogin = false;
                }
            }

            // if username and password is not valid show error message
            if (!checkLogin)
            {
                MessageBox.Show("Error: Check username and password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            
        }

        // method to check if the users table is empty and add an admin if needed
        private void checkUsersTableIsEmpty()
        {
            // check if the users datatable is empty
            if (dt.Rows.Count == 0)
            {
                // default user info
                string username = "Admin";
                string password = "Admin";
                string role = "Admin";

                // add default user to the database
                cls_User.Add_User(username, password, role);
                dt = cls_User.Get_All_Users();

                // show label has login info to user in the firs login
                lblShowFirstLogin.Visible = true;
            }
        }

        // form load event
        private void Login_Load(object sender, EventArgs e)
        {
            // call checkUsersTableIsEmpty() method
            checkUsersTableIsEmpty();
        }

        // username textbox key press event
        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check if user click in 'enter' key
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                // prevent adding 'enter' to textbox
                e.Handled = true;
                // move focus to password textbox
                txtPassword.Focus();
            }
        }

        // password textbox key press event
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check if user click in 'enter' key
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                // prevent adding 'enter' to textbox
                e.Handled = true;
                // invoke login button click event
                btnLogin.PerformClick();
            }
        }

    }
}
