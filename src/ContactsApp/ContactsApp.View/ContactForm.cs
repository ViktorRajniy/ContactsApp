using System;
using ContactsApp.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
	public partial class ContactForm : Form
	{
		private readonly Color ErrorColor = Color.LightPink;

		private readonly Color DefaultColor = Color.White;

		private string _fullNameError;

		Contact _contact = new Contact(
			"Enter your name",
			"Enter your e-mail",
			"+7(000)-000-00-00", 
			DateTime.Today,
			"http://vk.com");
		public ContactForm()
		{
			InitializeComponent();
			UpdateForm();
		}

		private void UpdateForm()
		{
			fullNameTextBox.Text = _contact.FullName;
			emailTextBox.Text = _contact.Email;
			phoneTextBox.Text = _contact.Phone;
			vkTextBox.Text = _contact.VKID;
			DateOfBirthPicker.Value = _contact.DateOfBirth;
		}

		private void OkButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult=DialogResult.Cancel;
		}

		private void AddPhotoButton_MouseEnter(object sender, EventArgs e)
		{
			AddPhotoButton.Image = Properties.Resources.add_photo_32x32;
		}

		private void AddPhotoButton_MouseLeave(object sender, EventArgs e)
		{
			AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
		}

		private void fullNameTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (fullNameTextBox.Text.Length < 100)
				{
					if (fullNameTextBox.Text != "")
						_contact.FullName = fullNameTextBox.Text;
					else
						throw new ArgumentException(
							"The name field cannot be empty.");

				}
				else
					throw new ArgumentException(
						"The name is too long.");
				fullNameTextBox.BackColor = DefaultColor;
				_fullNameError = "";
			}
			catch (ArgumentException exception)
			{
				fullNameTextBox.BackColor = ErrorColor;
				_fullNameError = exception.Message;
			}
		}
	}
}
