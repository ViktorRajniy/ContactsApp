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
		/// Объект, отвечающий за список контактов и сортировки.
		/// </summary>
		private Project _project = new Project();

		/// <summary>
		/// Объект, отвечающий за текущее расположение контактов в списке.
		/// </summary>
		private Project _currentProject = new Project();

		/// <summary>
		/// Главная форма программы.
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Обновляет список текущих контактов в списке.
		/// </summary>
		private void UpdateCurrentProject()
		{
			contactsListBox.Items.Clear();
			_currentProject.Contacts = _project.SortContactsByFullName(_project.Contacts);
		}

		/// <summary>
		/// Обновляет список контактов.
		/// </summary>
		/// <param name="selectedContact">Контакт, который нужно выделить в списке.</param>
		private void UpdateListBox(Contact selectedContact = null)
		{
			UpdateCurrentProject();
			foreach (Contact contact in _currentProject.Contacts)
			{
				contactsListBox.Items.Add(contact.FullName);
			}
			if (selectedContact != null)
			{
				int selectedIndex = _currentProject.Contacts.IndexOf(selectedContact);
				contactsListBox.SelectedIndex = selectedIndex;
				UpdateSelectedContact(selectedIndex);
			}
		}

		/// <summary>
		/// Добавляет новый контакт.
		/// </summary>
		private void AddContact()
		{
			ContactForm contactForm = new ContactForm();
			contactForm.ShowDialog();
			if (contactForm.DialogResult == DialogResult.OK)
			{
				Contact updatedContact = contactForm.Contact;
				_project.Contacts.Add(updatedContact);
				UpdateListBox(updatedContact);
			}
		}

		/// <summary>
		/// Редактирует выбранный контакт.
		/// </summary>
		/// <param name="selectedIndex"></param>
		private void EditContact(int selectedIndex)
		{
			//Клонирование контакта
			Contact selectedContact = _project.Contacts[selectedIndex].CloneContact();

			//Вызов формы
			ContactForm contactForm = new ContactForm();
			contactForm.Contact = selectedContact;
			contactForm.ShowDialog();

			//Если пользователь нажал ОК
			if (contactForm.DialogResult == DialogResult.OK)
			{
				//Взятие данных из формы
				Contact updatedContact = contactForm.Contact;
				//Замена обновлённого элемента в project
				_project.Contacts[selectedIndex] = updatedContact;
				//Обновление списка контактов. Отправка контакта, чтобы найти его в списке currentProject
				UpdateListBox(updatedContact);
			}
		}

		/// <summary>
		/// Удаляет контакт.
		/// </summary>
		/// <param name="index"></param>
		private void RemoveContact(int selectedIndex)
		{
			if (selectedIndex == -1)
			{
				return;
			}
			DialogResult result = MessageBox.Show("Do you really want to remove " +
				_project.Contacts[selectedIndex].FullName +
				"?", "", MessageBoxButtons.OKCancel);
			if (result == DialogResult.OK)
			{
				_project.Contacts.RemoveAt(selectedIndex);
				ClearSelectedContact();
			}
			UpdateCurrentProject();
			UpdateListBox();
		}

		/// <summary>
		/// Событие, обновляющее данные на панели справа.
		/// </summary>
		/// <param name="index"></param>
		private void UpdateSelectedContact(int index)
		{
			Contact contact = _currentProject.Contacts[index];
			fullNameTextBox.Text = contact.FullName;
			emailTextBox.Text = contact.Email;
			phoneTextBox.Text = contact.Phone;
			vkTextBox.Text = contact.VKID;
			dateBirthTextBox.Text = contact.DateOfBirth.ToString();
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

		/// <summary>
		/// Событие, меняющее цвет кнопки удаления контакта на серый.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RemoveContactButton_MouseLeave(object sender, EventArgs e)
		{
			RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
			RemoveContactButton.BackColor = Color.White;
		}

		/// <summary>
		/// Событие, меняющее цвет кнопки удаления контакта на красный.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RemoveContactButton_MouseEnter(object sender, EventArgs e)
		{
			RemoveContactButton.Image = Properties.Resources.remove_contact_32x32;
			RemoveContactButton.BackColor = ColorTranslator.FromHtml("#FAF5F5");
		}

		/// <summary>
		/// Событие, меняющее цвет кнопки редактирования контакта на синий.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EditContactButton_MouseEnter(object sender, EventArgs e)
		{
			EditContactButton.Image = Properties.Resources.edit_contact_32x32;
			EditContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
		}

		/// <summary>
		/// Событие, меняющее цвет кнопки редактирования контакта на серый.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EditContactButton_MouseLeave(object sender, EventArgs e)
		{
			EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
			EditContactButton.BackColor = Color.White;
		}

		/// <summary>
		/// Событие, меняющее цвет кнопки добавления контакта на синий.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddContactButton_MouseEnter(object sender, EventArgs e)
		{
			AddContactButton.Image = Properties.Resources.add_contact_32x32;
			AddContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
		}

		/// <summary>
		/// Событие, меняющее цвет кнопки добавления контакта на серый.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
			AddContact();
		}

		/// <summary>
		/// Событие, блокирующее ввод текста в поле с почтой контакта.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		/// <summary>
		/// Событие, блокирующее ввод текста в поле с именем контакта.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void fullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		/// <summary>
		/// Событие, выводящее окно About при нажатии F1.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
			int selectedIndex = contactsListBox.SelectedIndex;
			if (selectedIndex != -1)
			{
				EditContact(selectedIndex);
			}
		}

		/// <summary>
		/// Событие, скрывающее оповещение о днях рождения.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void birthdayPanalCloseButton_Click(object sender, EventArgs e)
		{
			birthdayPanel.Visible = false;
		}

		/// <summary>
		/// Событие, блокирующее ввод текста в поле номера телефона.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void phoneTextBox4_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		/// <summary>
		/// Событие, блокирующее ввод текста в поле даты рождения.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dateBirthTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		/// <summary>
		/// Событие, блокирующее ввод текста в поле ссылки ВК.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		private void findTextBox_TextChanged(object sender, EventArgs e)
		{
			UpdateListBox();
		}
	}
}
