using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Management_App.PL
{
    public partial class Home : Form
    {
        BL.Users cls_user = new BL.Users();

        public string userRole;

        public Home()
        {
            InitializeComponent();

            
        }

        public Home(string roles)
        {
            InitializeComponent();

            userRole = roles;

            try
            {
                if (userRole == "Admin")
                {
                    this.dgvUsers.DataSource = cls_user.Get_All_Users();
                    this.dgvUsers.Columns[0].Visible = false;
                }
                else
                {
                    groupBoxFilter.Visible = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    radioBAdmin.Enabled = false;
                    radioBEmployee.Checked = true;
                    this.dgvUsers.DataSource = cls_user.Get_Employee_Users();
                    this.dgvUsers.Columns[0].Visible = false;
                }

            }
            catch
            {
                return;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
                {
                    string role;

                    if (radioBAdmin.Checked == true)
                    {
                        role = "Admin";
                    }
                    else
                    {
                        role = "Employee";
                    }

                    cls_user.Add_User(txtUsername.Text, txtPassword.Text, role);
                    MessageBox.Show("Added Successfully!", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (userRole == "Admin")
                    {
                        this.dgvUsers.DataSource = cls_user.Get_All_Users();
                        ResizeTextBox();
                    }
                    else
                    {
                        this.dgvUsers.DataSource = cls_user.Get_Employee_Users();
                        ResizeTextBox();
                        radioBEmployee.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("Enter Username and Password to create a new user.", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                return;
            }
        }

        private void ResizeTextBox()
        {
            try
            {
                txtUsername.Clear();
                txtPassword.Clear();
                radioBAdmin.Checked = true;
            }
            catch
            {
                return;
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtUsername.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
                txtPassword.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
                if (dgvUsers.CurrentRow.Cells[3].Value.ToString() == "Admin")
                {
                    radioBAdmin.Checked = true;
                }
                else
                {
                    radioBEmployee.Checked = true;
                }
            }
            catch
            {
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.Rows.Count != 0)
                {
                    if (this.dgvUsers.CurrentRow.Selected == true && (txtUsername.Text != string.Empty || txtPassword.Text != string.Empty))
                    {
                        if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
                        {
                            string role;

                            if (radioBAdmin.Checked == true)
                            {
                                role = "Admin";
                            }
                            else
                            {
                                role = "Employee";
                            }

                            cls_user.Update_User(Convert.ToInt32(this.dgvUsers.CurrentRow.Cells[0].Value), txtUsername.Text, txtPassword.Text, role);
                            MessageBox.Show("Modified Successfully!", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.dgvUsers.DataSource = cls_user.Get_All_Users();
                            ResizeTextBox();
                        }
                        else
                        {
                            MessageBox.Show("Enter Username and Password to create a new user.", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select the user you want to update from the table below.", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.Rows.Count != 0)
                {
                    if (this.dgvUsers.CurrentRow.Selected == true && (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty))
                    {
                        if (MessageBox.Show("Alert: Do you want to remove the current selected user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            cls_user.Delete_User(Convert.ToInt32(this.dgvUsers.CurrentRow.Cells[0].Value));
                            MessageBox.Show("Deleted Successfully!", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.dgvUsers.DataSource = cls_user.Get_All_Users();
                            ResizeTextBox();
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select the user you want to Delete from the table below.", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string filterRole;

                if (radioBFilterAdmin.Checked == true)
                {
                    filterRole = "Admin";
                }
                else if (radioBFilterEmployee.Checked == true)
                {
                    filterRole = "Employee";
                }
                else
                {
                    filterRole = "";
                }

                this.dgvUsers.DataSource = cls_user.Filter_Users(txtSearch.Text, filterRole);
            }
            catch
            {
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.dgvUsers.DataSource = cls_user.Get_All_Users();
            txtSearch.Clear();
            radioBFilterAll.Checked = true;
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
