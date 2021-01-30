
namespace RPC_Changer
{
    partial class discordPresenceChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(discordPresenceChanger));
            this.detailsBox = new System.Windows.Forms.TextBox();
            this.largeImageBox = new System.Windows.Forms.TextBox();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.largeImageTextBox = new System.Windows.Forms.TextBox();
            this.smallImageBox = new System.Windows.Forms.TextBox();
            this.initializeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.clientBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // detailsBox
            // 
            this.detailsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(167)))), ((int)(((byte)(227)))));
            this.detailsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailsBox.Location = new System.Drawing.Point(12, 12);
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Size = new System.Drawing.Size(100, 13);
            this.detailsBox.TabIndex = 0;
            this.detailsBox.Text = "Details";
            this.detailsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // largeImageBox
            // 
            this.largeImageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(167)))), ((int)(((byte)(227)))));
            this.largeImageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.largeImageBox.Location = new System.Drawing.Point(292, 12);
            this.largeImageBox.Name = "largeImageBox";
            this.largeImageBox.Size = new System.Drawing.Size(100, 13);
            this.largeImageBox.TabIndex = 1;
            this.largeImageBox.Text = "Large Image Key";
            this.largeImageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stateBox
            // 
            this.stateBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(167)))), ((int)(((byte)(227)))));
            this.stateBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stateBox.Location = new System.Drawing.Point(152, 12);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(100, 13);
            this.stateBox.TabIndex = 2;
            this.stateBox.Text = "State";
            this.stateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // largeImageTextBox
            // 
            this.largeImageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(167)))), ((int)(((byte)(227)))));
            this.largeImageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.largeImageTextBox.Location = new System.Drawing.Point(12, 38);
            this.largeImageTextBox.Name = "largeImageTextBox";
            this.largeImageTextBox.Size = new System.Drawing.Size(100, 13);
            this.largeImageTextBox.TabIndex = 3;
            this.largeImageTextBox.Text = "Large Image Text";
            this.largeImageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // smallImageBox
            // 
            this.smallImageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(167)))), ((int)(((byte)(227)))));
            this.smallImageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.smallImageBox.Location = new System.Drawing.Point(292, 38);
            this.smallImageBox.Name = "smallImageBox";
            this.smallImageBox.Size = new System.Drawing.Size(100, 13);
            this.smallImageBox.TabIndex = 4;
            this.smallImageBox.Text = "Small Image Key";
            this.smallImageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // initializeButton
            // 
            this.initializeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(167)))), ((int)(((byte)(227)))));
            this.initializeButton.FlatAppearance.BorderSize = 0;
            this.initializeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.initializeButton.Location = new System.Drawing.Point(165, 102);
            this.initializeButton.Name = "initializeButton";
            this.initializeButton.Size = new System.Drawing.Size(75, 34);
            this.initializeButton.TabIndex = 5;
            this.initializeButton.Text = "Initialize";
            this.initializeButton.UseVisualStyleBackColor = false;
            this.initializeButton.Click += new System.EventHandler(this.initializeButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(167)))), ((int)(((byte)(227)))));
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Location = new System.Drawing.Point(165, 142);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 34);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // clientBox
            // 
            this.clientBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(167)))), ((int)(((byte)(227)))));
            this.clientBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientBox.Location = new System.Drawing.Point(135, 182);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(135, 13);
            this.clientBox.TabIndex = 7;
            this.clientBox.Text = "Application Client ID";
            this.clientBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // discordPresenceChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(404, 238);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.initializeButton);
            this.Controls.Add(this.smallImageBox);
            this.Controls.Add(this.largeImageTextBox);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.largeImageBox);
            this.Controls.Add(this.detailsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "discordPresenceChanger";
            this.Text = "Discord Presence Changer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox detailsBox;
        private System.Windows.Forms.TextBox largeImageBox;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.TextBox largeImageTextBox;
        private System.Windows.Forms.TextBox smallImageBox;
        private System.Windows.Forms.Button initializeButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox clientBox;
    }
}

