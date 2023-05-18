namespace ContactsApp.View
{
	partial class ContactForm
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
			this.vkTextBox = new System.Windows.Forms.TextBox();
			this.vkLabel = new System.Windows.Forms.Label();
			this.dateOfBirthLabel = new System.Windows.Forms.Label();
			this.phoneTextBox = new System.Windows.Forms.TextBox();
			this.phoneNumberLabel = new System.Windows.Forms.Label();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.emailLabel = new System.Windows.Forms.Label();
			this.fullNameTextBox = new System.Windows.Forms.TextBox();
			this.fullNameLabel = new System.Windows.Forms.Label();
			this.DateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
			this.bottomPanel = new System.Windows.Forms.Panel();
			this.CancelButton = new System.Windows.Forms.Button();
			this.OkButton = new System.Windows.Forms.Button();
			this.photoPictureBox = new System.Windows.Forms.PictureBox();
			this.AddPhotoButton = new System.Windows.Forms.PictureBox();
			this.bottomPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPhotoButton)).BeginInit();
			this.SuspendLayout();
			// 
			// vkTextBox
			// 
			this.vkTextBox.Location = new System.Drawing.Point(122, 226);
			this.vkTextBox.Name = "vkTextBox";
			this.vkTextBox.Size = new System.Drawing.Size(175, 20);
			this.vkTextBox.TabIndex = 21;
			// 
			// vkLabel
			// 
			this.vkLabel.AutoSize = true;
			this.vkLabel.Location = new System.Drawing.Point(119, 210);
			this.vkLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.vkLabel.Name = "vkLabel";
			this.vkLabel.Size = new System.Drawing.Size(24, 13);
			this.vkLabel.TabIndex = 20;
			this.vkLabel.Text = "VK:";
			// 
			// dateOfBirthLabel
			// 
			this.dateOfBirthLabel.AutoSize = true;
			this.dateOfBirthLabel.Location = new System.Drawing.Point(119, 161);
			this.dateOfBirthLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.dateOfBirthLabel.Name = "dateOfBirthLabel";
			this.dateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
			this.dateOfBirthLabel.TabIndex = 18;
			this.dateOfBirthLabel.Text = "Date of Birth:";
			// 
			// phoneTextBox
			// 
			this.phoneTextBox.Location = new System.Drawing.Point(122, 128);
			this.phoneTextBox.Name = "phoneTextBox";
			this.phoneTextBox.Size = new System.Drawing.Size(175, 20);
			this.phoneTextBox.TabIndex = 17;
			this.phoneTextBox.Text = "+7 (996) 938-67-94";
			// 
			// phoneNumberLabel
			// 
			this.phoneNumberLabel.AutoSize = true;
			this.phoneNumberLabel.Location = new System.Drawing.Point(119, 112);
			this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.phoneNumberLabel.Name = "phoneNumberLabel";
			this.phoneNumberLabel.Size = new System.Drawing.Size(80, 13);
			this.phoneNumberLabel.TabIndex = 16;
			this.phoneNumberLabel.Text = "PhomeNumber:";
			// 
			// emailTextBox
			// 
			this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.emailTextBox.Location = new System.Drawing.Point(122, 79);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(450, 20);
			this.emailTextBox.TabIndex = 15;
			this.emailTextBox.Text = "rajniyviktor@yandex.ru";
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Location = new System.Drawing.Point(119, 63);
			this.emailLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(38, 13);
			this.emailLabel.TabIndex = 14;
			this.emailLabel.Text = "E-mail:";
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameTextBox.Location = new System.Drawing.Point(122, 30);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(450, 20);
			this.fullNameTextBox.TabIndex = 13;
			this.fullNameTextBox.Text = "Оксингерт Виктор Константинович";
			this.fullNameTextBox.TextChanged += new System.EventHandler(this.fullNameTextBox_TextChanged);
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.Location = new System.Drawing.Point(119, 14);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(57, 13);
			this.fullNameLabel.TabIndex = 12;
			this.fullNameLabel.Text = "Full Name:";
			// 
			// DateOfBirthPicker
			// 
			this.DateOfBirthPicker.Location = new System.Drawing.Point(122, 177);
			this.DateOfBirthPicker.Name = "DateOfBirthPicker";
			this.DateOfBirthPicker.Size = new System.Drawing.Size(175, 20);
			this.DateOfBirthPicker.TabIndex = 22;
			// 
			// bottomPanel
			// 
			this.bottomPanel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bottomPanel.Controls.Add(this.CancelButton);
			this.bottomPanel.Controls.Add(this.OkButton);
			this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomPanel.Location = new System.Drawing.Point(0, 311);
			this.bottomPanel.Name = "bottomPanel";
			this.bottomPanel.Size = new System.Drawing.Size(584, 50);
			this.bottomPanel.TabIndex = 23;
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(497, 15);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 1;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// OkButton
			// 
			this.OkButton.Location = new System.Drawing.Point(416, 15);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 0;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// photoPictureBox
			// 
			this.photoPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
			this.photoPictureBox.Location = new System.Drawing.Point(12, 12);
			this.photoPictureBox.Name = "photoPictureBox";
			this.photoPictureBox.Size = new System.Drawing.Size(100, 100);
			this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.photoPictureBox.TabIndex = 11;
			this.photoPictureBox.TabStop = false;
			// 
			// AddPhotoButton
			// 
			this.AddPhotoButton.Image = global::ContactsApp.View.Properties.Resources.add_photo_32x32_gray;
			this.AddPhotoButton.Location = new System.Drawing.Point(48, 118);
			this.AddPhotoButton.Name = "AddPhotoButton";
			this.AddPhotoButton.Size = new System.Drawing.Size(32, 32);
			this.AddPhotoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.AddPhotoButton.TabIndex = 24;
			this.AddPhotoButton.TabStop = false;
			this.AddPhotoButton.MouseEnter += new System.EventHandler(this.AddPhotoButton_MouseEnter);
			this.AddPhotoButton.MouseLeave += new System.EventHandler(this.AddPhotoButton_MouseLeave);
			// 
			// ContactForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.AddPhotoButton);
			this.Controls.Add(this.bottomPanel);
			this.Controls.Add(this.DateOfBirthPicker);
			this.Controls.Add(this.vkTextBox);
			this.Controls.Add(this.vkLabel);
			this.Controls.Add(this.dateOfBirthLabel);
			this.Controls.Add(this.phoneTextBox);
			this.Controls.Add(this.phoneNumberLabel);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(this.emailLabel);
			this.Controls.Add(this.fullNameTextBox);
			this.Controls.Add(this.fullNameLabel);
			this.Controls.Add(this.photoPictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "ContactForm";
			this.ShowIcon = false;
			this.bottomPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddPhotoButton)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox vkTextBox;
		private System.Windows.Forms.Label vkLabel;
		private System.Windows.Forms.Label dateOfBirthLabel;
		private System.Windows.Forms.TextBox phoneTextBox;
		private System.Windows.Forms.Label phoneNumberLabel;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.TextBox fullNameTextBox;
		private System.Windows.Forms.Label fullNameLabel;
		private System.Windows.Forms.PictureBox photoPictureBox;
		private System.Windows.Forms.DateTimePicker DateOfBirthPicker;
		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.PictureBox AddPhotoButton;
	}
}