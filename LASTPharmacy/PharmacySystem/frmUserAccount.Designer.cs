﻿namespace PharmacySystem
{
    partial class frmUserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAccount));
            this.grpAddStaff = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtUsertypeM = new System.Windows.Forms.TextBox();
            this.txtUsernameM = new System.Windows.Forms.TextBox();
            this.txtUserIDM = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listUser = new System.Windows.Forms.ListView();
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button18 = new System.Windows.Forms.Button();
            this.txtSearchStaff = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grpAddStaff.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddStaff
            // 
            this.grpAddStaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpAddStaff.Controls.Add(this.btnDelete);
            this.grpAddStaff.Controls.Add(this.txtUsertypeM);
            this.grpAddStaff.Controls.Add(this.txtUsernameM);
            this.grpAddStaff.Controls.Add(this.txtUserIDM);
            this.grpAddStaff.Controls.Add(this.label13);
            this.grpAddStaff.Controls.Add(this.label8);
            this.grpAddStaff.Controls.Add(this.label7);
            this.grpAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddStaff.Location = new System.Drawing.Point(353, 28);
            this.grpAddStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAddStaff.Name = "grpAddStaff";
            this.grpAddStaff.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAddStaff.Size = new System.Drawing.Size(376, 347);
            this.grpAddStaff.TabIndex = 3;
            this.grpAddStaff.TabStop = false;
            this.grpAddStaff.Text = "Manage User Account";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::PharmacySystem.Properties.Resources.gear__minus;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(77, 251);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(232, 42);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtUsertypeM
            // 
            this.txtUsertypeM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsertypeM.Location = new System.Drawing.Point(141, 146);
            this.txtUsertypeM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsertypeM.Name = "txtUsertypeM";
            this.txtUsertypeM.Size = new System.Drawing.Size(223, 26);
            this.txtUsertypeM.TabIndex = 16;
            this.txtUsertypeM.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtUsernameM
            // 
            this.txtUsernameM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameM.Location = new System.Drawing.Point(141, 107);
            this.txtUsernameM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsernameM.Name = "txtUsernameM";
            this.txtUsernameM.Size = new System.Drawing.Size(223, 26);
            this.txtUsernameM.TabIndex = 11;
            // 
            // txtUserIDM
            // 
            this.txtUserIDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserIDM.Location = new System.Drawing.Point(141, 73);
            this.txtUserIDM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserIDM.Name = "txtUserIDM";
            this.txtUserIDM.Size = new System.Drawing.Size(223, 26);
            this.txtUserIDM.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 155);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Usertype:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Username:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "User ID:";
            // 
            // listUser
            // 
            this.listUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader25});
            this.listUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUser.GridLines = true;
            this.listUser.Location = new System.Drawing.Point(43, 63);
            this.listUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listUser.Name = "listUser";
            this.listUser.Size = new System.Drawing.Size(285, 453);
            this.listUser.TabIndex = 45;
            this.listUser.UseCompatibleStateImageBehavior = false;
            this.listUser.View = System.Windows.Forms.View.Details;
            this.listUser.SelectedIndexChanged += new System.EventHandler(this.listUser_SelectedIndexChanged);
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "User ID";
            this.columnHeader25.Width = 211;
            // 
            // button18
            // 
            this.button18.Image = global::PharmacySystem.Properties.Resources.box_search_result;
            this.button18.Location = new System.Drawing.Point(273, 23);
            this.button18.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(56, 25);
            this.button18.TabIndex = 47;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // txtSearchStaff
            // 
            this.txtSearchStaff.Location = new System.Drawing.Point(43, 23);
            this.txtSearchStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchStaff.Name = "txtSearchStaff";
            this.txtSearchStaff.Size = new System.Drawing.Size(237, 22);
            this.txtSearchStaff.TabIndex = 46;
            this.txtSearchStaff.Text = "Search UserID";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.pictureBox3);
            this.groupBox4.Controls.Add(this.button18);
            this.groupBox4.Controls.Add(this.grpAddStaff);
            this.groupBox4.Controls.Add(this.txtSearchStaff);
            this.groupBox4.Controls.Add(this.listUser);
            this.groupBox4.Location = new System.Drawing.Point(31, 49);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(763, 548);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::PharmacySystem.Properties.Resources.medex_Logo;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(431, 437);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(213, 80);
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Location = new System.Drawing.Point(423, 118);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(819, 623);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            // 
            // frmUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PharmacySystem.Properties.Resources.backgroundDefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1681, 871);
            this.Controls.Add(this.groupBox5);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHARMACY MANAGEMENT SYSTEM - CREATE USER ACCOUNT";
            this.Load += new System.EventHandler(this.frmUserAccount_Load);
            this.grpAddStaff.ResumeLayout(false);
            this.grpAddStaff.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpAddStaff;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtUsertypeM;
        private System.Windows.Forms.TextBox txtUsernameM;
        private System.Windows.Forms.TextBox txtUserIDM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listUser;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.TextBox txtSearchStaff;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}