namespace ContactsApp.View
{
	partial class AboutForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.ContactsAppLable = new System.Windows.Forms.Label();
			this.VersionLable = new System.Windows.Forms.Label();
			this.AuthorLable = new System.Windows.Forms.Label();
			this.EmailLable = new System.Windows.Forms.Label();
			this.GithubLable = new System.Windows.Forms.Label();
			this.LicenseTextBox = new System.Windows.Forms.TextBox();
			this.LinksLable = new System.Windows.Forms.Label();
			this.Icons8Lable = new System.Windows.Forms.LinkLabel();
			this.EmailValueLable = new System.Windows.Forms.Label();
			this.AuthorNameLable = new System.Windows.Forms.Label();
			this.GithubLinkLable = new System.Windows.Forms.LinkLabel();
			this.OkButton = new System.Windows.Forms.Button();
			this.BottomPanel = new System.Windows.Forms.Panel();
			this.BottomPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// ContactsAppLable
			// 
			this.ContactsAppLable.AutoSize = true;
			this.ContactsAppLable.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ContactsAppLable.Location = new System.Drawing.Point(12, 9);
			this.ContactsAppLable.Name = "ContactsAppLable";
			this.ContactsAppLable.Size = new System.Drawing.Size(184, 32);
			this.ContactsAppLable.TabIndex = 0;
			this.ContactsAppLable.Text = "ContactsApp";
			// 
			// VersionLable
			// 
			this.VersionLable.AutoSize = true;
			this.VersionLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.VersionLable.Location = new System.Drawing.Point(15, 51);
			this.VersionLable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.VersionLable.Name = "VersionLable";
			this.VersionLable.Size = new System.Drawing.Size(32, 15);
			this.VersionLable.TabIndex = 1;
			this.VersionLable.Text = "v 1.0";
			// 
			// AuthorLable
			// 
			this.AuthorLable.AutoSize = true;
			this.AuthorLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AuthorLable.Location = new System.Drawing.Point(15, 76);
			this.AuthorLable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.AuthorLable.Name = "AuthorLable";
			this.AuthorLable.Size = new System.Drawing.Size(45, 15);
			this.AuthorLable.TabIndex = 2;
			this.AuthorLable.Text = "Author:";
			// 
			// EmailLable
			// 
			this.EmailLable.AutoSize = true;
			this.EmailLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.EmailLable.Location = new System.Drawing.Point(15, 101);
			this.EmailLable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.EmailLable.Name = "EmailLable";
			this.EmailLable.Size = new System.Drawing.Size(46, 15);
			this.EmailLable.TabIndex = 3;
			this.EmailLable.Text = "E-mail:";
			// 
			// GithubLable
			// 
			this.GithubLable.AutoSize = true;
			this.GithubLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.GithubLable.Location = new System.Drawing.Point(15, 126);
			this.GithubLable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.GithubLable.Name = "GithubLable";
			this.GithubLable.Size = new System.Drawing.Size(46, 15);
			this.GithubLable.TabIndex = 4;
			this.GithubLable.Text = "Github:";
			// 
			// LicenseTextBox
			// 
			this.LicenseTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LicenseTextBox.Location = new System.Drawing.Point(18, 151);
			this.LicenseTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.LicenseTextBox.Multiline = true;
			this.LicenseTextBox.Name = "LicenseTextBox";
			this.LicenseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.LicenseTextBox.Size = new System.Drawing.Size(504, 139);
			this.LicenseTextBox.TabIndex = 5;
			this.LicenseTextBox.Text = resources.GetString("LicenseTextBox.Text");
			this.LicenseTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// LinksLable
			// 
			this.LinksLable.AutoSize = true;
			this.LinksLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LinksLable.Location = new System.Drawing.Point(15, 303);
			this.LinksLable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.LinksLable.Name = "LinksLable";
			this.LinksLable.Size = new System.Drawing.Size(200, 15);
			this.LinksLable.TabIndex = 6;
			this.LinksLable.Text = "All used images are download from";
			// 
			// Icons8Lable
			// 
			this.Icons8Lable.AutoSize = true;
			this.Icons8Lable.Location = new System.Drawing.Point(221, 305);
			this.Icons8Lable.Name = "Icons8Lable";
			this.Icons8Lable.Size = new System.Drawing.Size(61, 13);
			this.Icons8Lable.TabIndex = 7;
			this.Icons8Lable.TabStop = true;
			this.Icons8Lable.Text = "icons8.com";
			this.Icons8Lable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// EmailValueLable
			// 
			this.EmailValueLable.AutoSize = true;
			this.EmailValueLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.EmailValueLable.Location = new System.Drawing.Point(81, 101);
			this.EmailValueLable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.EmailValueLable.Name = "EmailValueLable";
			this.EmailValueLable.Size = new System.Drawing.Size(129, 15);
			this.EmailValueLable.TabIndex = 9;
			this.EmailValueLable.Text = "rajniyviktor@yandex.ru";
			// 
			// AuthorNameLable
			// 
			this.AuthorNameLable.AutoSize = true;
			this.AuthorNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AuthorNameLable.Location = new System.Drawing.Point(81, 76);
			this.AuthorNameLable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.AuthorNameLable.Name = "AuthorNameLable";
			this.AuthorNameLable.Size = new System.Drawing.Size(92, 15);
			this.AuthorNameLable.TabIndex = 8;
			this.AuthorNameLable.Text = "Viktor Oksingert";
			// 
			// GithubLinkLable
			// 
			this.GithubLinkLable.AutoSize = true;
			this.GithubLinkLable.Location = new System.Drawing.Point(84, 126);
			this.GithubLinkLable.Name = "GithubLinkLable";
			this.GithubLinkLable.Size = new System.Drawing.Size(156, 13);
			this.GithubLinkLable.TabIndex = 10;
			this.GithubLinkLable.TabStop = true;
			this.GithubLinkLable.Text = "https://github.com/ViktorRajniy";
			this.GithubLinkLable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// OkButton
			// 
			this.OkButton.Location = new System.Drawing.Point(447, 15);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 0;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// BottomPanel
			// 
			this.BottomPanel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BottomPanel.Controls.Add(this.OkButton);
			this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BottomPanel.Location = new System.Drawing.Point(0, 361);
			this.BottomPanel.Name = "BottomPanel";
			this.BottomPanel.Size = new System.Drawing.Size(534, 50);
			this.BottomPanel.TabIndex = 24;
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(534, 411);
			this.Controls.Add(this.BottomPanel);
			this.Controls.Add(this.GithubLinkLable);
			this.Controls.Add(this.EmailValueLable);
			this.Controls.Add(this.AuthorNameLable);
			this.Controls.Add(this.Icons8Lable);
			this.Controls.Add(this.LinksLable);
			this.Controls.Add(this.LicenseTextBox);
			this.Controls.Add(this.GithubLable);
			this.Controls.Add(this.EmailLable);
			this.Controls.Add(this.AuthorLable);
			this.Controls.Add(this.VersionLable);
			this.Controls.Add(this.ContactsAppLable);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "AboutForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.BottomPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ContactsAppLable;
		private System.Windows.Forms.Label VersionLable;
		private System.Windows.Forms.Label AuthorLable;
		private System.Windows.Forms.Label EmailLable;
		private System.Windows.Forms.Label GithubLable;
		private System.Windows.Forms.TextBox LicenseTextBox;
		private System.Windows.Forms.Label LinksLable;
		private System.Windows.Forms.LinkLabel Icons8Lable;
		private System.Windows.Forms.Label EmailValueLable;
		private System.Windows.Forms.Label AuthorNameLable;
		private System.Windows.Forms.LinkLabel GithubLinkLable;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Panel BottomPanel;
	}
}