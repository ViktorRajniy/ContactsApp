namespace ContactsApp.View
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.contactPanel = new System.Windows.Forms.Panel();
			this.infoPanel = new System.Windows.Forms.Panel();
			this.contactsListBox = new System.Windows.Forms.ListBox();
			this.findTextBox = new System.Windows.Forms.TextBox();
			this.findLabel = new System.Windows.Forms.Label();
			this.buttonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.fullNameLabel = new System.Windows.Forms.Label();
			this.fullNameTextBox = new System.Windows.Forms.TextBox();
			this.emailLabel = new System.Windows.Forms.Label();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.phoneTextBox4 = new System.Windows.Forms.TextBox();
			this.phoneNumberLabel = new System.Windows.Forms.Label();
			this.dateBirthTextBox = new System.Windows.Forms.TextBox();
			this.dateOfBirthLabel = new System.Windows.Forms.Label();
			this.vkTextBox = new System.Windows.Forms.TextBox();
			this.vkLabel = new System.Windows.Forms.Label();
			this.birthdayPanel = new System.Windows.Forms.Panel();
			this.birthdayLabel = new System.Windows.Forms.Label();
			this.birthdaySurnamesLable = new System.Windows.Forms.Label();
			this.addContactButton = new System.Windows.Forms.Button();
			this.editContactButton = new System.Windows.Forms.Button();
			this.removeContactButton = new System.Windows.Forms.Button();
			this.birthdayPanalCloseButton = new System.Windows.Forms.Button();
			this.birthdayPictureBox = new System.Windows.Forms.PictureBox();
			this.photoPictureBox = new System.Windows.Forms.PictureBox();
			this.mainTableLayoutPanel.SuspendLayout();
			this.contactPanel.SuspendLayout();
			this.infoPanel.SuspendLayout();
			this.buttonTableLayoutPanel.SuspendLayout();
			this.birthdayPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.birthdayPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// mainTableLayoutPanel
			// 
			this.mainTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mainTableLayoutPanel.ColumnCount = 2;
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainTableLayoutPanel.Controls.Add(this.contactPanel, 0, 0);
			this.mainTableLayoutPanel.Controls.Add(this.infoPanel, 1, 0);
			this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
			this.mainTableLayoutPanel.RowCount = 1;
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainTableLayoutPanel.Size = new System.Drawing.Size(884, 461);
			this.mainTableLayoutPanel.TabIndex = 0;
			// 
			// contactPanel
			// 
			this.contactPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.contactPanel.Controls.Add(this.buttonTableLayoutPanel);
			this.contactPanel.Controls.Add(this.findLabel);
			this.contactPanel.Controls.Add(this.findTextBox);
			this.contactPanel.Controls.Add(this.contactsListBox);
			this.contactPanel.Location = new System.Drawing.Point(3, 3);
			this.contactPanel.Name = "contactPanel";
			this.contactPanel.Size = new System.Drawing.Size(244, 455);
			this.contactPanel.TabIndex = 0;
			// 
			// infoPanel
			// 
			this.infoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.infoPanel.Controls.Add(this.birthdayPanel);
			this.infoPanel.Controls.Add(this.vkTextBox);
			this.infoPanel.Controls.Add(this.vkLabel);
			this.infoPanel.Controls.Add(this.dateBirthTextBox);
			this.infoPanel.Controls.Add(this.dateOfBirthLabel);
			this.infoPanel.Controls.Add(this.phoneTextBox4);
			this.infoPanel.Controls.Add(this.phoneNumberLabel);
			this.infoPanel.Controls.Add(this.emailTextBox);
			this.infoPanel.Controls.Add(this.emailLabel);
			this.infoPanel.Controls.Add(this.fullNameTextBox);
			this.infoPanel.Controls.Add(this.fullNameLabel);
			this.infoPanel.Controls.Add(this.photoPictureBox);
			this.infoPanel.Location = new System.Drawing.Point(253, 3);
			this.infoPanel.Name = "infoPanel";
			this.infoPanel.Size = new System.Drawing.Size(628, 455);
			this.infoPanel.TabIndex = 1;
			// 
			// contactsListBox
			// 
			this.contactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.contactsListBox.FormattingEnabled = true;
			this.contactsListBox.IntegralHeight = false;
			this.contactsListBox.Items.AddRange(new object[] {
            "Элайджа Вуд",
            "Иэн Маккелен",
            "Вигго Мортенсен",
            "Шон Бин",
            "Орландо Блум",
            "Джон Рин-Девис",
            "Иэн Холм",
            "Шон Эстин",
            "Билли Бойд",
            "Доминик Монаган",
            "Хьюго Уивинг",
            "Кейт Бланшетт",
            "Лив Тайлер",
            "Кристофер Ли",
            "Энди Серкис"});
			this.contactsListBox.Location = new System.Drawing.Point(0, 29);
			this.contactsListBox.Name = "contactsListBox";
			this.contactsListBox.Size = new System.Drawing.Size(244, 386);
			this.contactsListBox.TabIndex = 0;
			// 
			// findTextBox
			// 
			this.findTextBox.Location = new System.Drawing.Point(45, 3);
			this.findTextBox.Name = "findTextBox";
			this.findTextBox.Size = new System.Drawing.Size(199, 20);
			this.findTextBox.TabIndex = 1;
			// 
			// findLabel
			// 
			this.findLabel.AutoSize = true;
			this.findLabel.Location = new System.Drawing.Point(9, 6);
			this.findLabel.Name = "findLabel";
			this.findLabel.Size = new System.Drawing.Size(30, 13);
			this.findLabel.TabIndex = 2;
			this.findLabel.Text = "Find:";
			// 
			// buttonTableLayoutPanel
			// 
			this.buttonTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonTableLayoutPanel.ColumnCount = 3;
			this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.buttonTableLayoutPanel.Controls.Add(this.addContactButton, 0, 0);
			this.buttonTableLayoutPanel.Controls.Add(this.editContactButton, 1, 0);
			this.buttonTableLayoutPanel.Controls.Add(this.removeContactButton, 2, 0);
			this.buttonTableLayoutPanel.Location = new System.Drawing.Point(0, 415);
			this.buttonTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.buttonTableLayoutPanel.Name = "buttonTableLayoutPanel";
			this.buttonTableLayoutPanel.RowCount = 1;
			this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.buttonTableLayoutPanel.Size = new System.Drawing.Size(244, 40);
			this.buttonTableLayoutPanel.TabIndex = 3;
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.Location = new System.Drawing.Point(110, 5);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(57, 13);
			this.fullNameLabel.TabIndex = 1;
			this.fullNameLabel.Text = "Full Name:";
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameTextBox.Location = new System.Drawing.Point(113, 21);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(506, 20);
			this.fullNameTextBox.TabIndex = 2;
			this.fullNameTextBox.Text = "Оксингерт Виктор Константинович";
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Location = new System.Drawing.Point(110, 54);
			this.emailLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(38, 13);
			this.emailLabel.TabIndex = 3;
			this.emailLabel.Text = "E-mail:";
			// 
			// emailTextBox
			// 
			this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.emailTextBox.Location = new System.Drawing.Point(113, 70);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(506, 20);
			this.emailTextBox.TabIndex = 4;
			this.emailTextBox.Text = "rajniyviktor@yandex.ru";
			// 
			// phoneTextBox4
			// 
			this.phoneTextBox4.Location = new System.Drawing.Point(113, 119);
			this.phoneTextBox4.Name = "phoneTextBox4";
			this.phoneTextBox4.Size = new System.Drawing.Size(175, 20);
			this.phoneTextBox4.TabIndex = 6;
			this.phoneTextBox4.Text = "+7 (996) 938-67-94";
			// 
			// phoneNumberLabel
			// 
			this.phoneNumberLabel.AutoSize = true;
			this.phoneNumberLabel.Location = new System.Drawing.Point(110, 103);
			this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.phoneNumberLabel.Name = "phoneNumberLabel";
			this.phoneNumberLabel.Size = new System.Drawing.Size(80, 13);
			this.phoneNumberLabel.TabIndex = 5;
			this.phoneNumberLabel.Text = "PhomeNumber:";
			// 
			// dateBirthTextBox
			// 
			this.dateBirthTextBox.Location = new System.Drawing.Point(113, 168);
			this.dateBirthTextBox.Name = "dateBirthTextBox";
			this.dateBirthTextBox.Size = new System.Drawing.Size(175, 20);
			this.dateBirthTextBox.TabIndex = 8;
			// 
			// dateOfBirthLabel
			// 
			this.dateOfBirthLabel.AutoSize = true;
			this.dateOfBirthLabel.Location = new System.Drawing.Point(110, 152);
			this.dateOfBirthLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.dateOfBirthLabel.Name = "dateOfBirthLabel";
			this.dateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
			this.dateOfBirthLabel.TabIndex = 7;
			this.dateOfBirthLabel.Text = "Date of Birth:";
			// 
			// vkTextBox
			// 
			this.vkTextBox.Location = new System.Drawing.Point(113, 217);
			this.vkTextBox.Name = "vkTextBox";
			this.vkTextBox.Size = new System.Drawing.Size(175, 20);
			this.vkTextBox.TabIndex = 10;
			// 
			// vkLabel
			// 
			this.vkLabel.AutoSize = true;
			this.vkLabel.Location = new System.Drawing.Point(110, 201);
			this.vkLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.vkLabel.Name = "vkLabel";
			this.vkLabel.Size = new System.Drawing.Size(24, 13);
			this.vkLabel.TabIndex = 9;
			this.vkLabel.Text = "VK:";
			// 
			// birthdayPanel
			// 
			this.birthdayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.birthdayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
			this.birthdayPanel.Controls.Add(this.birthdayPanalCloseButton);
			this.birthdayPanel.Controls.Add(this.birthdaySurnamesLable);
			this.birthdayPanel.Controls.Add(this.birthdayLabel);
			this.birthdayPanel.Controls.Add(this.birthdayPictureBox);
			this.birthdayPanel.Location = new System.Drawing.Point(3, 377);
			this.birthdayPanel.Name = "birthdayPanel";
			this.birthdayPanel.Size = new System.Drawing.Size(622, 75);
			this.birthdayPanel.TabIndex = 11;
			// 
			// birthdayLabel
			// 
			this.birthdayLabel.AutoSize = true;
			this.birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.birthdayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
			this.birthdayLabel.Location = new System.Drawing.Point(78, 15);
			this.birthdayLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
			this.birthdayLabel.Name = "birthdayLabel";
			this.birthdayLabel.Size = new System.Drawing.Size(124, 13);
			this.birthdayLabel.TabIndex = 1;
			this.birthdayLabel.Text = "Today is Birthday of:";
			// 
			// birthdaySurnamesLable
			// 
			this.birthdaySurnamesLable.AutoSize = true;
			this.birthdaySurnamesLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.birthdaySurnamesLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
			this.birthdaySurnamesLable.Location = new System.Drawing.Point(78, 43);
			this.birthdaySurnamesLable.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
			this.birthdaySurnamesLable.Name = "birthdaySurnamesLable";
			this.birthdaySurnamesLable.Size = new System.Drawing.Size(316, 13);
			this.birthdaySurnamesLable.TabIndex = 2;
			this.birthdaySurnamesLable.Text = "Оксингерт, Оксенгерт, Оксингирт, Оксенгирт и др.";
			// 
			// addContactButton
			// 
			this.addContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.addContactButton.FlatAppearance.BorderSize = 0;
			this.addContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addContactButton.Image = global::ContactsApp.View.Properties.Resources.add_contact_32x32_gray;
			this.addContactButton.Location = new System.Drawing.Point(0, 0);
			this.addContactButton.Margin = new System.Windows.Forms.Padding(0);
			this.addContactButton.Name = "addContactButton";
			this.addContactButton.Size = new System.Drawing.Size(81, 40);
			this.addContactButton.TabIndex = 0;
			this.addContactButton.UseVisualStyleBackColor = true;
			// 
			// editContactButton
			// 
			this.editContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editContactButton.FlatAppearance.BorderSize = 0;
			this.editContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.editContactButton.Image = global::ContactsApp.View.Properties.Resources.edit_contact_32x32_gray;
			this.editContactButton.Location = new System.Drawing.Point(81, 0);
			this.editContactButton.Margin = new System.Windows.Forms.Padding(0);
			this.editContactButton.Name = "editContactButton";
			this.editContactButton.Size = new System.Drawing.Size(81, 40);
			this.editContactButton.TabIndex = 1;
			this.editContactButton.UseVisualStyleBackColor = true;
			// 
			// removeContactButton
			// 
			this.removeContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.removeContactButton.FlatAppearance.BorderSize = 0;
			this.removeContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.removeContactButton.Image = global::ContactsApp.View.Properties.Resources.remove_contact_32x32_gray;
			this.removeContactButton.Location = new System.Drawing.Point(162, 0);
			this.removeContactButton.Margin = new System.Windows.Forms.Padding(0);
			this.removeContactButton.Name = "removeContactButton";
			this.removeContactButton.Size = new System.Drawing.Size(82, 40);
			this.removeContactButton.TabIndex = 2;
			this.removeContactButton.UseVisualStyleBackColor = true;
			// 
			// birthdayPanalCloseButton
			// 
			this.birthdayPanalCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.birthdayPanalCloseButton.FlatAppearance.BorderSize = 0;
			this.birthdayPanalCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.birthdayPanalCloseButton.Image = global::ContactsApp.View.Properties.Resources.close_32x32;
			this.birthdayPanalCloseButton.Location = new System.Drawing.Point(587, 3);
			this.birthdayPanalCloseButton.Name = "birthdayPanalCloseButton";
			this.birthdayPanalCloseButton.Size = new System.Drawing.Size(32, 32);
			this.birthdayPanalCloseButton.TabIndex = 3;
			this.birthdayPanalCloseButton.UseVisualStyleBackColor = true;
			// 
			// birthdayPictureBox
			// 
			this.birthdayPictureBox.Image = global::ContactsApp.View.Properties.Resources.info_48x48;
			this.birthdayPictureBox.Location = new System.Drawing.Point(3, 3);
			this.birthdayPictureBox.Name = "birthdayPictureBox";
			this.birthdayPictureBox.Size = new System.Drawing.Size(69, 69);
			this.birthdayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.birthdayPictureBox.TabIndex = 0;
			this.birthdayPictureBox.TabStop = false;
			// 
			// photoPictureBox
			// 
			this.photoPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
			this.photoPictureBox.Location = new System.Drawing.Point(3, 3);
			this.photoPictureBox.Name = "photoPictureBox";
			this.photoPictureBox.Size = new System.Drawing.Size(100, 100);
			this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.photoPictureBox.TabIndex = 0;
			this.photoPictureBox.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(884, 461);
			this.Controls.Add(this.mainTableLayoutPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "ContactsApp";
			this.mainTableLayoutPanel.ResumeLayout(false);
			this.contactPanel.ResumeLayout(false);
			this.contactPanel.PerformLayout();
			this.infoPanel.ResumeLayout(false);
			this.infoPanel.PerformLayout();
			this.buttonTableLayoutPanel.ResumeLayout(false);
			this.birthdayPanel.ResumeLayout(false);
			this.birthdayPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.birthdayPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
		private System.Windows.Forms.Panel contactPanel;
		private System.Windows.Forms.Label findLabel;
		private System.Windows.Forms.TextBox findTextBox;
		private System.Windows.Forms.ListBox contactsListBox;
		private System.Windows.Forms.Panel infoPanel;
		private System.Windows.Forms.TableLayoutPanel buttonTableLayoutPanel;
		private System.Windows.Forms.Button addContactButton;
		private System.Windows.Forms.Button editContactButton;
		private System.Windows.Forms.Button removeContactButton;
		private System.Windows.Forms.PictureBox photoPictureBox;
		private System.Windows.Forms.Label fullNameLabel;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.TextBox fullNameTextBox;
		private System.Windows.Forms.TextBox vkTextBox;
		private System.Windows.Forms.Label vkLabel;
		private System.Windows.Forms.TextBox dateBirthTextBox;
		private System.Windows.Forms.Label dateOfBirthLabel;
		private System.Windows.Forms.TextBox phoneTextBox4;
		private System.Windows.Forms.Label phoneNumberLabel;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.Panel birthdayPanel;
		private System.Windows.Forms.PictureBox birthdayPictureBox;
		private System.Windows.Forms.Button birthdayPanalCloseButton;
		private System.Windows.Forms.Label birthdaySurnamesLable;
		private System.Windows.Forms.Label birthdayLabel;
	}
}

