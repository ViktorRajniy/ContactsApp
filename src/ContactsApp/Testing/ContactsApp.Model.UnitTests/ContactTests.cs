using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ContactsApp.Model;
using NUnit.Framework;

namespace ContactsApp.Model.UnitTests
{
	[TestFixture]
	public class ContactTests
	{
		[TestCase(
			"",
			"Должно возникать исключение, если полное имя - пустая строка")]
		[TestCase(
			"МояФамилияМояФамилияМояФамилияМояФамилияМояФамилияМояФамилияМояФамилияМояФамилияМояФамилияМояФамилияМояФамилия",
			"Должно возникать исключение, если полное имя - строка больше 100 символов")]
		public void FullName_SetIncorrectValue_ThrowsArgumentException(string wrongsFullname, string message)
		{
			// Setup: 
			var contact = new Contact();

			// Assert:
			Assert.Throws<ArgumentException>(
				() =>
				{
					// Testing:
					contact.FullName = wrongsFullname;
				},
				message);
		}

		[Test(Description = "Позитивный тест сеттера Fullname")]
		public void Fullname_SetCorrectValue_ValueIsSetted()
		{
			// Setup:
			var expected = "Сидоров Иван Сергеевич";
			var contact = new Contact();

			// Testing:
			contact.FullName = expected;

			// Assert:
			Assert.AreEqual(
				contact.FullName, 
				expected, 
				"Сеттер Fullname не принимает правильное значение");
		}

		[Test(Description = "Позвитивный тест геттера Fullname")]
		public void FullName_GetCorrectValue_ValueGetted()
		{
			// Setup: 
			var expected = "Сидоров Иван Сергеевич";
			var contact = new Contact();

			// Testing:
			contact.FullName = expected;
			var actual = contact.FullName;

			// Assert:
			Assert.AreEqual(
				expected, 
				actual, 
				"Геттер Fullname возвращает неправильное полное имя");
		}

		[Test(Description = "Негативный тест сеттера Email")]
		public void Email_SetIncorrectValue_ThrowsArgumentException()
		{
			// Setup: 
			var wrongEmail =
				"emailemailemailemailemailemailemailemailemailemailemailemailemailemailemailemailemailemailemailemailemailemail";
			var contact = new Contact();

			//Assert
			Assert.Throws<ArgumentException>(
				() =>
				{
					// Testing:
					contact.Email = wrongEmail;
				},
				"Сеттер принимает неправильное значение");
		}

		[Test(Description = "Позитивный тест сеттера Email")]
		public void Email_SetCorrectValue_ValueIsSetted()
		{
			// Setup:
			var expected = "smirnov@yandex.ru";
			var contact = new Contact();

			// Testing:
			contact.Email = expected;

			// Assert:
			Assert.AreEqual(
				contact.Email, 
				expected, 
				"Сеттер Email не принимает правильное значение");
		}

		[Test(Description = "Позвитивный тест геттера Email")]
		public void Email_GetCorrectValue_ValueGetted()
		{
			// Setup: 
			var expected = "smirnov@yandex.ru";
			var contact = new Contact();

			// Testing:
			contact.Email = expected;
			var actual = contact.Email;

			// Assert:
			Assert.AreEqual(
				expected, 
				actual, 
				"Геттер Email возвращает неправильный Email");
		}

		[Test(Description = "Негативный тест сеттера Phone")]
		public void Phone_SetIncorrectValue_ThrowsArgumentException()
		{
			// Setup: 
			var wrongPhone =
				"123132132132132132123";
			var contact = new Contact();

			//Assert
			Assert.Throws<ArgumentException>(
				() =>
				{
					// Testing:
					contact.Phone = wrongPhone;
				},
				"Сеттер принимает неправильное значение");
		}

		[Test(Description = "Позитивный тест сеттера Phone")]
		public void Phone_SetCorrectValue_ValueIsSetted()
		{
			// Setup:
			var expected = "+7(998)-345-34-21";
			var contact = new Contact();

			// Testing:
			contact.Phone = expected;

			// Assert:
			Assert.AreEqual(
				contact.Phone, 
				expected, 
				"Сеттер Phone не принимает правильное значение");
		}

		[Test(Description = "Позвитивный тест геттера Phone")]
		public void Phone_GetCorrectValue_ValueGetted()
		{
			// Setup: 
			var expected = "+7(998)-345-34-21";
			var contact = new Contact();

			// Testing:
			contact.Phone = expected;
			var actual = contact.Phone;

			// Assert:
			Assert.AreEqual(
				expected, 
				actual, 
				"Геттер Phone возвращает неправильный Phone");
		}

		[Test(Description = "Негативный тест сеттера VKID")]
		public void VKID_SetIncorrectValue_ThrowsArgumentException()
		{
			// Setup: 
			var wrongVKID =
				"http://///http://///http://///http://///http://///http://///";
			var contact = new Contact();

			//Assert
			Assert.Throws<ArgumentException>(
				() =>
				{
					// Testing:
					contact.VKID = wrongVKID;
				},
				"Сеттер принимает неправильное значение");
		}

		[Test(Description = "Позитивный тест сеттера VKID")]
		public void VKID_SetCorrectValue_ValueIsSetted()
		{
			// Setup:
			var expected = "http://vk";
			var contact = new Contact();

			// Testing:
			contact.VKID = expected;

			// Assert:
			Assert.AreEqual(
				contact.VKID, 
				expected, 
				"Сеттер VKID не принимает правильное значение");
		}

		[Test(Description = "Позвитивный тест геттера VKID")]
		public void VKID_GetCorrectValue_ValueGetted()
		{
			// Setup: 
			var expected = "http://vk";
			var contact = new Contact();

			// Testing:
			contact.VKID = expected;
			var actual = contact.VKID;

			// Assert:
			Assert.AreEqual(
				expected, 
				actual, 
				"Геттер Phone возвращает неправильный VKID");
		}

		[Test(Description = "Негативный тест сеттера DateOfBirth")]
		public void DateOfBirth_Set1900_ThrowsArgumentException()
		{
			// Setup: 
			var wrongDateOfBirth = DateTime.Parse("1900-01-01T00:00:00");
			var contact = new Contact();

			//Assert
			Assert.Throws<ArgumentException>(
				() =>
				{
					// Testing:
					contact.DateOfBirth = wrongDateOfBirth;
				},
				"Сеттер принимает неправильное значение");
		}

		[Test(Description = "Негативный тест сеттера DateOfBirth")]
		public void DateOfBirth_SetToday_ThrowsArgumentException()
		{
			// Setup: 
			var wrongDateOfBirth = DateTime.Today.AddDays(1);
			var contact = new Contact();

			//Assert
			Assert.Throws<ArgumentException>(
				() =>
				{
					// Testing:
					contact.DateOfBirth = wrongDateOfBirth;
				},
				"Сеттер принимает неправильное значение");
		}

		[Test(Description = "Позитивный тест сеттера DateOfBirth")]
		public void DateOfBirth_SetCorrectValue_ValueIsSetted()
		{
			// Setup:
			var expected = DateTime.Today.AddDays(-2);
			var contact = new Contact();

			// Testing:
			contact.DateOfBirth = expected;

			// Assert:
			Assert.AreEqual(
				contact.DateOfBirth, 
				expected, 
				"Сеттер DateOfBirth не принимает правильное значение");
		}

		[Test(Description = "Позвитивный тест геттера DateOfBirth")]
		public void DateOfBirth_GetCorrectValue_ValueGetted()
		{
			// Setup: 
			var expected = DateTime.Today.AddDays(-2);
			var contact = new Contact();

			// Testing:
			contact.DateOfBirth = expected;
			var actual = contact.DateOfBirth;

			// Assert:
			Assert.AreEqual(
				expected, 
				actual, 
				"Геттер DateOfBirth возвращает неправильную дату рождения");
		}

		[Test(Description = "Позвитивный тест метода CloneContact")]
		public void CloneContact_AssertOnClone_ContactCloned()
		{
			// Setup: 
			var contact = new Contact(
				"Name Surname",
				"email@mail.com",
				"+0(123)-345-56-78",
				DateTime.Today.AddDays(-2),
				"vkvkvk");

			// Testing:
			var actual = contact.CloneContact();

			// Assert:
			Assert.AreEqual(contact.FullName,actual.FullName,
				"Метод CloneContact возвращает клон с неправильным именем");
			Assert.AreEqual(contact.Email, actual.Email,
				"Метод CloneContact возвращает клон с неправильной почтой");
			Assert.AreEqual(contact.Phone, actual.Phone,
				"Метод CloneContact возвращает клон с неправильным номером телефона");
			Assert.AreEqual(contact.VKID, actual.VKID,
				"Метод CloneContact возвращает  клон с неправильной ссылкой на вк");
			Assert.AreEqual(contact.DateOfBirth, actual.DateOfBirth,
				"Метод CloneContact возвращает клон с неправильной датой рожддения");
		}
	}
}