﻿namespace UsersAndAwards.PL.WinForms
{
    partial class DeleteUserForm
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
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtBirthdate = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.ctlErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ctlErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(292, 84);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 35);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(180, 84);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(82, 35);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.Location = new System.Drawing.Point(274, 28);
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.Size = new System.Drawing.Size(100, 20);
            this.txtBirthdate.TabIndex = 13;
            this.txtBirthdate.Validating += new System.ComponentModel.CancelEventHandler(this.txtBirthdate_Validating);
            this.txtBirthdate.Validated += new System.EventHandler(this.txtBirthdate_Validated);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(140, 28);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 12;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            this.txtLastName.Validated += new System.EventHandler(this.txtLastName_Validated);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(12, 28);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 11;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            this.txtFirstName.Validated += new System.EventHandler(this.txtFirstName_Validated);
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(271, 9);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(49, 13);
            this.lblBirthdate.TabIndex = 10;
            this.lblBirthdate.Text = "Birthdate";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(137, 9);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(9, 9);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First name";
            // 
            // ctlErrorProvider
            // 
            this.ctlErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ctlErrorProvider.ContainerControl = this;
            // 
            // DeleteUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 143);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtBirthdate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.MaximumSize = new System.Drawing.Size(416, 182);
            this.MinimumSize = new System.Drawing.Size(416, 182);
            this.Name = "DeleteUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Deleting user";
            ((System.ComponentModel.ISupportInitialize)(this.ctlErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtBirthdate;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ErrorProvider ctlErrorProvider;
    }
}