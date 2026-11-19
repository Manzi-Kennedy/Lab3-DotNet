namespace TaskLink.Views
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblName
            this.lblName.Name = "lblName";
            this.lblName.Text = "Full name";
            this.lblName.Location = new System.Drawing.Point(30, 15);
            this.lblName.AutoSize = true;
            this.lblName.TabIndex = 0;
            // txtName
            this.txtName.Name = "txtName";
            this.txtName.Location = new System.Drawing.Point(30, 35);
            this.txtName.Size = new System.Drawing.Size(300, 23);
            this.txtName.TabIndex = 1;
            // lblEmail
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new System.Drawing.Point(30, 70);
            this.lblEmail.AutoSize = true;
            this.lblEmail.TabIndex = 2;
            // txtEmail
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Location = new System.Drawing.Point(30, 90);
            this.txtEmail.Size = new System.Drawing.Size(300, 23);
            this.txtEmail.TabIndex = 3;
            // lblPassword
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Text = "Password (min 8 chars)";
            this.lblPassword.Location = new System.Drawing.Point(30, 125);
            this.lblPassword.AutoSize = true;
            this.lblPassword.TabIndex = 4;
            // txtPassword
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Location = new System.Drawing.Point(30, 145);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(300, 23);
            this.txtPassword.TabIndex = 5;
            // lblConfirm
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Text = "Confirm password";
            this.lblConfirm.Location = new System.Drawing.Point(30, 180);
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.TabIndex = 6;
            // txtConfirm
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Location = new System.Drawing.Point(30, 200);
            this.txtConfirm.UseSystemPasswordChar = true;
            this.txtConfirm.Size = new System.Drawing.Size(300, 23);
            this.txtConfirm.TabIndex = 7;
            // btnRegister
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Text = "Register";
            this.btnRegister.Location = new System.Drawing.Point(30, 245);
            this.btnRegister.Size = new System.Drawing.Size(140, 32);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // btnCancel
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(190, 245);
            this.btnCancel.Size = new System.Drawing.Size(140, 32);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.TabIndex = 9;
            // add controls
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancel);
            // form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 295);
            this.Text = "TaskLink - Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.CancelButton = this.btnCancel;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
    }
}
