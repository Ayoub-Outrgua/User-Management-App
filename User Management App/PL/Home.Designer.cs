namespace User_Management_App.PL
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxOperations = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioBEmployee = new System.Windows.Forms.RadioButton();
            this.radioBAdmin = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioBFilterAll = new System.Windows.Forms.RadioButton();
            this.radioBFilterEmployee = new System.Windows.Forms.RadioButton();
            this.radioBFilterAdmin = new System.Windows.Forms.RadioButton();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.groupBoxOperations.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOperations
            // 
            this.groupBoxOperations.Controls.Add(this.btnDelete);
            this.groupBoxOperations.Controls.Add(this.btnEdit);
            this.groupBoxOperations.Controls.Add(this.btnAdd);
            this.groupBoxOperations.Controls.Add(this.groupBox3);
            this.groupBoxOperations.Controls.Add(this.label2);
            this.groupBoxOperations.Controls.Add(this.label1);
            this.groupBoxOperations.Controls.Add(this.txtPassword);
            this.groupBoxOperations.Controls.Add(this.txtUsername);
            this.groupBoxOperations.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOperations.Name = "groupBoxOperations";
            this.groupBoxOperations.Size = new System.Drawing.Size(493, 164);
            this.groupBoxOperations.TabIndex = 0;
            this.groupBoxOperations.TabStop = false;
            this.groupBoxOperations.Text = "Operations";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(372, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 37);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(372, 64);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 37);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(372, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 37);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioBEmployee);
            this.groupBox3.Controls.Add(this.radioBAdmin);
            this.groupBox3.Location = new System.Drawing.Point(248, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 105);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Role";
            // 
            // radioBEmployee
            // 
            this.radioBEmployee.AutoSize = true;
            this.radioBEmployee.Location = new System.Drawing.Point(18, 72);
            this.radioBEmployee.Name = "radioBEmployee";
            this.radioBEmployee.Size = new System.Drawing.Size(71, 17);
            this.radioBEmployee.TabIndex = 7;
            this.radioBEmployee.Text = "Employee";
            this.radioBEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBEmployee.UseVisualStyleBackColor = true;
            // 
            // radioBAdmin
            // 
            this.radioBAdmin.AutoSize = true;
            this.radioBAdmin.Checked = true;
            this.radioBAdmin.Location = new System.Drawing.Point(18, 35);
            this.radioBAdmin.Name = "radioBAdmin";
            this.radioBAdmin.Size = new System.Drawing.Size(54, 17);
            this.radioBAdmin.TabIndex = 6;
            this.radioBAdmin.TabStop = true;
            this.radioBAdmin.Text = "Admin";
            this.radioBAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBAdmin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(21, 109);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(221, 37);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(21, 41);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(221, 37);
            this.txtUsername.TabIndex = 0;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.btnSearch);
            this.groupBoxFilter.Controls.Add(this.btnReset);
            this.groupBoxFilter.Controls.Add(this.label3);
            this.groupBoxFilter.Controls.Add(this.txtSearch);
            this.groupBoxFilter.Controls.Add(this.groupBox4);
            this.groupBoxFilter.Location = new System.Drawing.Point(511, 12);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(428, 164);
            this.groupBoxFilter.TabIndex = 1;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Search - Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(146, 103);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 37);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(293, 103);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 37);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(146, 47);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(262, 37);
            this.txtSearch.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioBFilterAll);
            this.groupBox4.Controls.Add(this.radioBFilterEmployee);
            this.groupBox4.Controls.Add(this.radioBFilterAdmin);
            this.groupBox4.Location = new System.Drawing.Point(19, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(118, 121);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Roles";
            // 
            // radioBFilterAll
            // 
            this.radioBFilterAll.AutoSize = true;
            this.radioBFilterAll.Checked = true;
            this.radioBFilterAll.Location = new System.Drawing.Point(18, 34);
            this.radioBFilterAll.Name = "radioBFilterAll";
            this.radioBFilterAll.Size = new System.Drawing.Size(36, 17);
            this.radioBFilterAll.TabIndex = 8;
            this.radioBFilterAll.TabStop = true;
            this.radioBFilterAll.Text = "All";
            this.radioBFilterAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBFilterAll.UseVisualStyleBackColor = true;
            // 
            // radioBFilterEmployee
            // 
            this.radioBFilterEmployee.AutoSize = true;
            this.radioBFilterEmployee.Location = new System.Drawing.Point(18, 94);
            this.radioBFilterEmployee.Name = "radioBFilterEmployee";
            this.radioBFilterEmployee.Size = new System.Drawing.Size(71, 17);
            this.radioBFilterEmployee.TabIndex = 7;
            this.radioBFilterEmployee.Text = "Employee";
            this.radioBFilterEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBFilterEmployee.UseVisualStyleBackColor = true;
            // 
            // radioBFilterAdmin
            // 
            this.radioBFilterAdmin.AutoSize = true;
            this.radioBFilterAdmin.Location = new System.Drawing.Point(18, 65);
            this.radioBFilterAdmin.Name = "radioBFilterAdmin";
            this.radioBFilterAdmin.Size = new System.Drawing.Size(54, 17);
            this.radioBFilterAdmin.TabIndex = 6;
            this.radioBFilterAdmin.Text = "Admin";
            this.radioBFilterAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBFilterAdmin.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(12, 182);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(927, 302);
            this.dgvUsers.TabIndex = 2;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(951, 496);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.groupBoxOperations);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.groupBoxOperations.ResumeLayout(false);
            this.groupBoxOperations.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOperations;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioBEmployee;
        private System.Windows.Forms.RadioButton radioBAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioBFilterAll;
        private System.Windows.Forms.RadioButton radioBFilterEmployee;
        private System.Windows.Forms.RadioButton radioBFilterAdmin;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvUsers;
    }
}