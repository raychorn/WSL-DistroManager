namespace DistroManager
{
    partial class CloneDistroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloneDistroForm));
            this.distroNameLabel = new System.Windows.Forms.Label();
            this.distroName = new System.Windows.Forms.TextBox();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.removeCurrentDefaultUser = new System.Windows.Forms.CheckBox();
            this.removeLogsAndMailboxContents = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // distroNameLabel
            // 
            this.distroNameLabel.AutoSize = true;
            this.distroNameLabel.Location = new System.Drawing.Point(9, 9);
            this.distroNameLabel.Name = "distroNameLabel";
            this.distroNameLabel.Size = new System.Drawing.Size(92, 13);
            this.distroNameLabel.TabIndex = 0;
            this.distroNameLabel.Text = "&New distro name: ";
            // 
            // distroName
            // 
            this.distroName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.distroName.Location = new System.Drawing.Point(12, 29);
            this.distroName.Name = "distroName";
            this.distroName.Size = new System.Drawing.Size(280, 20);
            this.distroName.TabIndex = 1;
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Location = new System.Drawing.Point(9, 60);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(49, 13);
            this.optionsLabel.TabIndex = 2;
            this.optionsLabel.Text = "Options: ";
            // 
            // removeCurrentDefaultUser
            // 
            this.removeCurrentDefaultUser.AutoSize = true;
            this.removeCurrentDefaultUser.Enabled = false;
            this.removeCurrentDefaultUser.Location = new System.Drawing.Point(21, 85);
            this.removeCurrentDefaultUser.Name = "removeCurrentDefaultUser";
            this.removeCurrentDefaultUser.Size = new System.Drawing.Size(202, 17);
            this.removeCurrentDefaultUser.TabIndex = 3;
            this.removeCurrentDefaultUser.Text = "Remove &current default user account";
            this.removeCurrentDefaultUser.UseVisualStyleBackColor = true;
            // 
            // removeLogsAndMailboxContents
            // 
            this.removeLogsAndMailboxContents.AutoSize = true;
            this.removeLogsAndMailboxContents.Enabled = false;
            this.removeLogsAndMailboxContents.Location = new System.Drawing.Point(21, 108);
            this.removeLogsAndMailboxContents.Name = "removeLogsAndMailboxContents";
            this.removeLogsAndMailboxContents.Size = new System.Drawing.Size(191, 17);
            this.removeLogsAndMailboxContents.TabIndex = 4;
            this.removeLogsAndMailboxContents.Text = "Remove &logs and mailbox contents";
            this.removeLogsAndMailboxContents.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(217, 166);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmButton.Location = new System.Drawing.Point(136, 166);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "C&onfirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // CloneDistroForm
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removeLogsAndMailboxContents);
            this.Controls.Add(this.removeCurrentDefaultUser);
            this.Controls.Add(this.distroName);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.distroNameLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 240);
            this.Name = "CloneDistroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clone existing distro";
            this.Load += new System.EventHandler(this.CloneDistroForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label distroNameLabel;
        private System.Windows.Forms.TextBox distroName;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.CheckBox removeCurrentDefaultUser;
        private System.Windows.Forms.CheckBox removeLogsAndMailboxContents;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
    }
}