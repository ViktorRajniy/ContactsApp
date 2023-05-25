using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactsApp.Model
{
	/// <summary>
	/// Главный класс проекта. Содержит список контактов и методы сортировки.
	/// </summary>
	public class Project
	{
		/// <summary>
		/// Список контактов.
		/// </summary>
		private List<Contact> _contacts;

		public List<Contact> Contacts { get; set; } = new List<Contact>();

		/// <summary>
		/// Сортирует список контактов по полному имени.
		/// </summary>
		/// <param name="contacts">Список контактов.</param>
		/// <returns></returns>
		public List<Contact> SortContactsByFullName(List<Contact> contacts)
		{
			List<Contact> result = contacts.OrderBy(contact => contact.FullName).ToList();
			return result;
		}

		/// <summary>
		/// Находит именинников в списке контактов и возвращает их список.
		/// </summary>
		/// <param name="contacts">Список контактов.</param>
		/// <returns></returns>
		public List<Contact> FindBirthdays(List<Contact> contacts)
		{
			List<Contact> result = new List<Contact>();
			foreach (Contact contact in contacts)
				if (contact.DateOfBirth.Equals(DateTime.Today))
				{
					result.Add(contact);
				}
			return result;
		}

		/// <summary>
		/// 
		/// Ищет контакт по подстроке.
		/// </summary>
		/// <param name="contacts">Список контактов.</param>
		/// <param name="subString">Искомая подстрока.</param>
		/// <returns></returns>
		public List<Contact> FindContactBySubString(List<Contact> contacts, string subString)
		{
			List<Contact> result = new List<Contact>();
			foreach (Contact contact in contacts)
				if (contact.FullName.Contains(subString))
				{
					result.Add(contact);
				}
				else if (contact.Email.Contains(subString))
				{
					result.Add(contact);
				}
				else if (contact.Phone.Contains(subString))
				{
					result.Add(contact);
				}
				else if (contact.VKID.Contains(subString))
				{
					result.Add(contact);
				}
			return result;
		}

		/// <summary>
		/// Конструктор класса <see cref="Project"/>.
		/// </summary>
		public Project()
		{
			_contacts = new List<Contact>();
		}
	}
}
