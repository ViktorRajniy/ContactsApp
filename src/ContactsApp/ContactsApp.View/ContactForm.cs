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
		/// <summary>
		/// Константа цвет ошибки.
		/// </summary>
		private readonly Color ErrorColor = Color.LightPink;

		/// <summary>
		/// Константа стандартный цвет текстового поля.
		/// </summary>
		private readonly Color DefaultColor = Color.White;

		/// <summary>
		/// Текст ошибки при вводе полного имени контакта.
		/// </summary>
		private string _fullNameError;

		/// <summary>
		/// Текст ошибки при вводе электронной почты контакта.
		/// </summary>
		private string _emailError;

		/// <summary>
		/// Текст ошибки при вводе номера телефона контакта.
		/// </summary>
		private string _phoneError;

		/// <summary>
		/// Текст ошибки при вводе ссылки на профиль ВКонтакте контакта.
		/// </summary>
		private string _vkError;

		/// <summary>
		/// Текст ошибки при вводе даты рождения контакта.
		/// </summary>
		private string _dateOfBirthError;

		/// <summary>
		/// Метод, проверяющий наличие ошибок при вводе данных. 
		/// Возвращает true, если ошибок нет.
		/// </summary>
		/// <returns></returns>
		private bool CheckFormOnErrors()
		{
			if (
				_fullNameError != "" |
				_emailError != "" |
				_phoneError != "" |
				_vkError != "" |
				_dateOfBirthError != "")
			{
				MessageBox.Show(_fullNameError +
					_emailError + 
					_phoneError + 
					_vkError + 
					_dateOfBirthError);
				return false;
			}
			else
				return true;

		}

		/// <summary>
		/// Основная переменная формы. Содержит информацию о контакте.
		/// </summary>
		Contact _contact = new Contact(
			"Enter your name",
			"Enter your e-mail",
			"+7(000)-000-00-00",
			DateTime.Today,
			"http://vk.com");

		/// <summary>
		/// Конструктор формы.
		/// </summary>
		public ContactForm()
		{
			InitializeComponent();
			UpdateForm();
		}

		/// <summary>
		/// Метод, обновляющий поля формы в соответствии со значениями в классе _contact.
		/// </summary>
		private void UpdateForm()
		{
			fullNameTextBox.Text = _contact.FullName;
			emailTextBox.Text = _contact.Email;
			phoneTextBox.Text = _contact.Phone;
			vkTextBox.Text = _contact.VKID;
			DateOfBirthPicker.Value = _contact.DateOfBirth;
		}

		/// <summary>
		/// Метод, обновляющий значения контакта, в соответствии со значениями полей формы.
		/// </summary>
		private void UpdateContact()
		{
			_contact = new Contact(
				fullNameTextBox.Text,
				emailTextBox.Text,
				phoneTextBox.Text,
				DateOfBirthPicker.Value,
				vkTextBox.Text);
		}

		/// <summary>
		/// Событие, при нажатии кнопки ОК. Обновляет значение контакта и закрывает форму, 
		/// если нет ошибок на форме.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OkButton_Click(object sender, EventArgs e)
		{
			if(CheckFormOnErrors())
			{
				UpdateContact();
				DialogResult = DialogResult.OK;
			}
		}

		/// <summary>
		/// Событие, закрывающее форму при нажатии кнопки Cancel.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		/// <summary>
		/// Событие, меняющее цвет кнопки на синий, при наведении курсора.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddPhotoButton_MouseEnter(object sender, EventArgs e)
		{
			AddPhotoButton.Image = Properties.Resources.add_photo_32x32;
		}

		/// <summary>
		/// Событие, меняющее цвет кнопки на серый, при отведении курсора.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddPhotoButton_MouseLeave(object sender, EventArgs e)
		{
			AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
		}

		/// <summary>
		/// Событие, проверяющее правильность ввода полного имени контакта в textBox. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void fullNameTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				_contact.FullName = fullNameTextBox.Text;
				fullNameTextBox.BackColor = DefaultColor;
				_fullNameError = "";
			}
			catch (ArgumentException exception)
			{
				fullNameTextBox.BackColor = ErrorColor;
				_fullNameError = exception.Message+"\n";
			}
		}

		/// <summary>
		/// Событие, проверяющее правильность ввода электронной почты контакта в textBox.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void emailTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				_contact.Email = emailTextBox.Text;
				emailTextBox.BackColor = DefaultColor;
				_emailError = "";

			}
			catch (ArgumentException exception)
			{
				emailTextBox.BackColor = ErrorColor;
				_emailError = exception.Message + "\n";
			}
		}

		/// <summary>
		/// Событие, проверяющее правильность ввода номера телефона контакта в textBox.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void phoneTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				_contact.Phone = phoneTextBox.Text;
				phoneTextBox.BackColor = DefaultColor;
				_phoneError = "";
			}
			catch (ArgumentException exception)
			{
				phoneTextBox.BackColor = ErrorColor;
				_phoneError = exception.Message + "\n";
			}
		}

		/// <summary>
		/// Событие, проверяющее правильность ввода ссылки на профиль ВКонтакте контакта в textBox.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void vkTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				_contact.VKID = vkTextBox.Text;
				vkTextBox.BackColor = DefaultColor;
				_vkError = "";
			}
			catch (ArgumentException exception)
			{
				vkTextBox.BackColor = ErrorColor;
				_vkError = exception.Message + "\n";
			}
		}

		/// <summary>
		/// Событие, проверяющее правильность ввода даты рождения контакта в datePicker.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DateOfBirthPicker_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				_contact.DateOfBirth = DateOfBirthPicker.Value;
				DateOfBirthPicker.BackColor = DefaultColor;
				_dateOfBirthError = "";
			}
			catch (ArgumentException exception)
			{
				DateOfBirthPicker.BackColor = ErrorColor;
				_dateOfBirthError = exception.Message + "\n";
			}
		}
	}
}
