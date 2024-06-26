﻿using System;
using System.Text.RegularExpressions;

namespace ContactsApp.Model
{
	/// <summary>
	/// Класс содержащий информацию о контакте.
	/// </summary>
	public class Contact
	{
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
							"The name field cannot be empty.");

				}
				else
					throw new ArgumentException(
						"The name cannot be longer than 100 characters.");
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
					throw new ArgumentException(
						"The email address cannot be longer than 100 characters.");
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
				//Regex содержит ограничения на правильность ввода номера телефона.
				//Правильный вариант: +0(000)-000-00-00
				string pattern = @"^\+\d{1}\(\d{3}\)\-\d{3}\-\d{2}\-\d{2}$";
				if (Regex.IsMatch(value, pattern))
				{
					_phone = value;
				}
				else
				{
					throw new ArgumentException(
						"The phone number is entered incorrectly. " +
						"Correct input option: +X(XXX)-XXX-XX-XX.");
				}
			}
		}

		/// <summary>
		/// Возвращает или задаёт ссылку на VK.
		/// </summary>
		public string VKID
		{
			get => _vkID;


			set
			{
				if (value.Length < MaxVKIdLength)
				{
					_vkID = value;
				}
				else
					throw new ArgumentException(
						"The link to the VK profile cannot be longer than 50 characters.");
			}
		}

		/// <summary>
		/// Возвращает или задаёт дату рождения.
		/// </summary>
		public DateTime DateOfBirth
		{
			get => _dateOfBirth;

			set
			{
				if (value > DateTime.Today)
				{
					throw new ArgumentException(
						"The date of birth cannot be later than today.");
				}
				if (value.Date.Year == 1900)
				{
					throw new ArgumentException(
						"The date of birth cannot be earlier than 1900.");
				}
				_dateOfBirth = value;

			}
		}

		/// <summary>
		/// Метод, создающий клон контакта.
		/// </summary>
		/// <returns></returns>
		public Contact CloneContact()
		{
			Contact clone = new Contact(
				this.FullName,
				this.Email,
				this.Phone,
				this.DateOfBirth,
				this.VKID);
			return clone;
		}

		/// <summary>
		/// Конструктор класса <see cref="Contact"/>.
		/// </summary>
		public Contact() : this(
			"Nothing", 
			"someadress@mail.ru", 
			"+0(000)-000-00-00", 
			new DateTime(2023,1,1), 
			"vkid")
		{
		}

		/// <summary>
		/// Конструктор класса <see cref="Contact"/>.
		/// </summary>
		/// <param name="fullName">ФИО.</param>
		/// <param name="email">Электронная почта.</param>
		/// <param name="phone">Номер телефона.</param>
		/// <param name="dateOfBirth">Дата рождения.</param>
		/// <param name="vkId">Ссылка на ВКонтакте.</param>
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