using ContactsApp.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ContactsApp.View
{
	public partial class MainForm : Form
	{
		/// <summary>
		/// 
		/// </summary>
		private Project _project = new Project();

		/// <summary>
		/// Главная форма программы.
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Обновляет список контактов.
		/// </summary>
		private void UpdateListBox()
		{
			contactsListBox.Items.Clear();
			foreach (Contact contact in _project.Contacts)
			{
				contactsListBox.Items.Add(contact.FullName);
			}
		}

		/// <summary>
		/// Добавляет новый контакт.
		/// </summary>
		private void AddContact()
		{
			List<string> _names = new List<string> {
				"Элайджа Вуд",
				"Иэн Маккелен",
				"Вигго Мортенсен",
				"Шон Бин",
				"Орландо Блум",
				"Джон Рин-Девис",
				"Иэн Холм",
				"Иванов",
				"Петров",
				"Сидоров",
				"Лукодёргов",
				"Янушев",
				"Ватрушкин" };
			Random random = new Random();
			Contact contact = new Contact(
				_names[random.Next(1, _names.Count)], 
				"", 
				"+0(000)-000-00-00",
				DateTime.Today, 
				"");
			_project.Contacts.Add(contact);
		}

		/// <summary>
		/// Удаляет контакт.
		/// </summary>
		/// <param name="index"></param>
		private void RemoveContact(int index)
		{
			if (index == -1)
			{
				return;
			}
			DialogResult result = MessageBox.Show("Do you really want to remove " +
				_project.Contacts[index].FullName +
				"?", "", MessageBoxButtons.OKCancel);
			if (result == DialogResult.OK)
			{
				_project.Contacts.RemoveAt(index);
			}
			UpdateListBox();
		}

		/// <summary>
		/// Событие, обновляющее данные на панели справа.
		/// </summary>
		/// <param name="index"></param>
		private void UpdateSelectedContact(int index)
		{
			fullNameTextBox.Text = _project.Contacts[index].FullName;
			emailTextBox.Text = _project.Contacts[index].Email;
			phoneTextBox.Text = _project.Contacts[index].Phone;
			vkTextBox.Text = _project.Contacts[index].VKID;
			dateBirthTextBox.Text = _project.Contacts[index].DateOfBirth.ToString();
		}

		/// <summary>
		/// Очищает все поля панели справа.
		/// </summary>
		private void ClearSelectedContact()
		{
			fullNameTextBox.Text = "";
			emailTextBox.Text = "";
			phoneTextBox.Text = "";
			vkTextBox.Text = "";
			dateBirthTextBox.Text = "";
		}

		private void RemoveContactButton_MouseLeave(object sender, EventArgs e)
		{
			RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
			RemoveContactButton.BackColor = Color.White;
		}

		private void RemoveContactButton_MouseEnter(object sender, EventArgs e)
		{
			RemoveContactButton.Image = Properties.Resources.remove_contact_32x32;
			RemoveContactButton.BackColor = ColorTranslator.FromHtml("#FAF5F5");
		}

		private void EditContactButton_MouseEnter(object sender, EventArgs e)
		{
			EditContactButton.Image = Properties.Resources.edit_contact_32x32;
			EditContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
		}

		private void EditContactButton_MouseLeave(object sender, EventArgs e)
		{
			EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
			EditContactButton.BackColor = Color.White;
		}

		private void AddContactButton_MouseEnter(object sender, EventArgs e)
		{
			AddContactButton.Image = Properties.Resources.add_contact_32x32;
			AddContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
		}

		private void AddContactButton_MouseLeave(object sender, EventArgs e)
		{
			AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
			AddContactButton.BackColor = Color.White;
		}

		/// <summary>
		/// Событиые, добавляющее контакт.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddContactButton_Click(object sender, EventArgs e)
		{
			var contactForm = new ContactForm();
			if (contactForm.ShowDialog() == DialogResult.OK)
			{
				AddContact();
			}
			UpdateListBox();
		}

		private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void fullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F1)
			{
				var aboutForm = new AboutForm();
				aboutForm.ShowDialog();
			}
		}

		/// <summary>
		/// Событие, редактирующее контакт.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EditContactButton_Click(object sender, EventArgs e)
		{
			var contactForm = new ContactForm();
			if (contactForm.ShowDialog() == DialogResult.OK)
			{
				AddContact();
			}
			UpdateListBox();
		}

		private void birthdayPanalCloseButton_Click(object sender, EventArgs e)
		{
			birthdayPanel.Visible = false;
		}

		private void phoneTextBox4_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void dateBirthTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void vkTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		/// <summary>
		/// Событие, удаляющее контакт из списка контактов.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RemoveContactButton_Click(object sender, EventArgs e)
		{
			RemoveContact(contactsListBox.SelectedIndex);
			UpdateListBox();
		}

		/// <summary>
		/// Событие, меняющее данные в панели справа.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void contactsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (contactsListBox.SelectedIndex == -1)
				ClearSelectedContact();
			else
				UpdateSelectedContact(contactsListBox.SelectedIndex);
		}

		/// <summary>
		/// Событие, вызывающее диалог при закрытии программы.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you really want to leave?", "", MessageBoxButtons.OKCancel);
			if (result == DialogResult.Cancel)
				e.Cancel = true;
		}
	}
}
