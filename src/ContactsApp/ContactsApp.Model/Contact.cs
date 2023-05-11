using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ContactsApp.Model
{
	public class Contact
	{
		/// <summary>
		/// Допустимые символы в номере телефона.
		/// </summary>
		private const string ValidPhoneSimbols = "1234567890 +()-";

		/// <summary>
		/// Максимальное количество символов в имени.
		/// </summary>
		private const int MaxFullNameLength = 100;

		/// <summary>
		/// Максимальная длинна e-mail.
		/// </summary>
		private const int MaxEmailLength = 100;

		/// <summary>
		/// Максимальная длина ссылки VK.
		/// </summary>
		private const int MaxVKIdLength = 50;

		/// <summary>
		/// ФИО.
		/// </summary>
		private string _fullName;

		/// <summary>
		/// Электронная почта.
		/// </summary>
		private string _email;

		/// <summary>
		/// Номер телефона.
		/// </summary>
		private string _phone;

		/// <summary>
		/// Дата рождения.
		/// </summary>
		private DateTime _dateOfBirth;

		/// <summary>
		/// Ссылка на VK.
		/// </summary>
		private string _vkID;

		/// <summary>
		/// Возвращает или задаёт ФИО.
		/// </summary>
		public string FullName
		{
			get => _fullName;

			set
			{
				if (value.Length < MaxFullNameLength)
				{
					if (value != "")
						_fullName = value;
					else
						throw new ArgumentException(
							"Имя не может быть пустым.");

				}
				else
					throw new ArgumentException(
						"Имя слишком длинное.");
			}
		}

		/// <summary>
		/// Возвращает или задаёт e-mail.
		/// </summary>
		public string Email
		{
			get => _email;

			set
			{
				if (value.Length < MaxEmailLength)
				{
					_email = value;
				}
				else
					throw new ArgumentException("Адрес почты слишком длинный.");
			}
		}

		/// <summary>
		/// Возвращает или задаёт номер телефона.
		/// </summary>
		public string Phone
		{
			get => _phone;

			set
			{
				string pattern = @"^\+\d{1}\(\d{3}\)\-\d{3}\-\d{2}\-\d{2}";
				if (Regex.IsMatch(value, pattern))
				{
					_phone = value;
				}
				else
				{
				throw new ArgumentException("Номер телефона введён неверно.");
				}
			}
		}

		/// <summary>
		/// Возвращает или задаёт ссылку на VK.
		/// </summary>
		public string VKID
		{
			get => _vkID;

			set => _vkID = value;
		}

		/// <summary>
		/// Возвращает или задаёт дату рождения.
		/// </summary>
		public DateTime DateOfBirth
		{
			get => _dateOfBirth;

			set
			{
				if (DateTime.Compare(value, DateTime.Today) > 0)
				{
					throw new ArgumentException(
						"День рождения не может позднее сегодня.");
				}
				if (value.Date.Year == 1900)
				{
					throw new ArgumentException(
						"Дата рождения не может быть раньше 1900 года.");
				}
				_dateOfBirth = value;

			}
		}

		/// <summary>
		/// Конструктор класса <see cref="Contact"/>.
		/// </summary>
		public Contact() : this("Nothing", "someadress@mail.ru", "+0(000)-000-00-00", DateTime.Today, "vkid")
		{
		}

		/// <summary>
		/// Конструктор класса <see cref="Contact"/>.
		/// </summary>
		/// <param name="fullName">ФИО.</param>
		/// <param name="email">Электронная почта.</param>
		/// <param name="phone">Номер телефона.</param>
		/// <param name="dateOfBirth">Дата рождения.</param>
		/// <param name="vk	Id">Ссылка на ВКонтакте.</param>
		public Contact(
			string fullName,
			string email,
			string phone,
			DateTime dateOfBirth,
			string vkID)
		{
			FullName = fullName;
			Email = email;
			Phone = phone;
			DateOfBirth = dateOfBirth;
			VKID = vkID;
		}
	}
}