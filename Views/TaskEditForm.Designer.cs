namespace TaskLink.Views
{
    partial class TaskEditForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Title";
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.AutoSize = true;
            this.lblTitle.TabIndex = 0;
            // txtTitle
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Location = new System.Drawing.Point(20, 35);
            this.txtTitle.Size = new System.Drawing.Size(400, 23);
            this.txtTitle.TabIndex = 1;
            // lblDesc
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Text = "Description";
            this.lblDesc.Location = new System.Drawing.Point(20, 70);
            this.lblDesc.AutoSize = true;
            this.lblDesc.TabIndex = 2;
            // txtDescription
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Location = new System.Drawing.Point(20, 90);
            this.txtDescription.Multiline = true;
            this.txtDescription.Size = new System.Drawing.Size(400, 90);
            this.txtDescription.TabIndex = 3;
            // lblCategory
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Text = "Category";
            this.lblCategory.Location = new System.Drawing.Point(20, 195);
            this.lblCategory.AutoSize = true;
            this.lblCategory.TabIndex = 4;
            // cmbCategory
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Location = new System.Drawing.Point(20, 215);
            this.cmbCategory.Size = new System.Drawing.Size(190, 23);
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.TabIndex = 5;
            // lblLocation
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Text = "Location";
            this.lblLocation.Location = new System.Drawing.Point(230, 195);
            this.lblLocation.AutoSize = true;
            this.lblLocation.TabIndex = 6;
            // txtLocation
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Location = new System.Drawing.Point(230, 215);
            this.txtLocation.Size = new System.Drawing.Size(190, 23);
            this.txtLocation.TabIndex = 7;
            // lblDeadline
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Text = "Deadline";
            this.lblDeadline.Location = new System.Drawing.Point(20, 250);
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.TabIndex = 8;
            // dtpDeadline
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Location = new System.Drawing.Point(20, 270);
            this.dtpDeadline.Size = new System.Drawing.Size(190, 23);
            this.dtpDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeadline.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpDeadline.TabIndex = 9;
            // btnSave
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(240, 315);
            this.btnSave.Size = new System.Drawing.Size(85, 32);
            this.btnSave.TabIndex = 10;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // btnCancel
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(335, 315);
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.TabIndex = 11;
            // add controls
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            // form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 365);
            this.Text = "Task";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.CancelButton = this.btnCancel;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
