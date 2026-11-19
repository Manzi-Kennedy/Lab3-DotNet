namespace TaskLink.Views
{
    partial class RatingForm
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
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.numScore = new System.Windows.Forms.NumericUpDown();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblTarget
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Text = "Rate user";
            this.lblTarget.Location = new System.Drawing.Point(20, 15);
            this.lblTarget.AutoSize = true;
            this.lblTarget.TabIndex = 0;
            // lblScore
            this.lblScore.Name = "lblScore";
            this.lblScore.Text = "Score (1-5)";
            this.lblScore.Location = new System.Drawing.Point(20, 50);
            this.lblScore.AutoSize = true;
            this.lblScore.TabIndex = 1;
            // numScore
            this.numScore.Name = "numScore";
            this.numScore.Location = new System.Drawing.Point(20, 70);
            this.numScore.Size = new System.Drawing.Size(80, 23);
            this.numScore.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numScore.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.numScore.Value = new decimal(new int[] { 5, 0, 0, 0 });
            this.numScore.TabIndex = 2;
            // lblComment
            this.lblComment.Name = "lblComment";
            this.lblComment.Text = "Comment (optional)";
            this.lblComment.Location = new System.Drawing.Point(20, 105);
            this.lblComment.AutoSize = true;
            this.lblComment.TabIndex = 3;
            // txtComment
            this.txtComment.Name = "txtComment";
            this.txtComment.Location = new System.Drawing.Point(20, 125);
            this.txtComment.Multiline = true;
            this.txtComment.Size = new System.Drawing.Size(320, 80);
            this.txtComment.TabIndex = 4;
            // btnSubmit
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Location = new System.Drawing.Point(150, 220);
            this.btnSubmit.Size = new System.Drawing.Size(90, 32);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // btnCancel
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(250, 220);
            this.btnCancel.Size = new System.Drawing.Size(90, 32);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.TabIndex = 6;
            // add controls
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.numScore);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            // form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 270);
            this.Text = "Rating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.CancelButton = this.btnCancel;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.NumericUpDown numScore;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}
