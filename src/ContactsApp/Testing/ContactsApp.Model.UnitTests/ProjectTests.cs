using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApp.Model;

namespace ContactsApp.Model.UnitTests
{
	internal class ProjectTests
	{
		[Test(Description = "Позитивный тест сеттера Contacts")]
		public void Contacts_SetCorrectValue_ValueIsSetted()
		{
			// Setup:
			var expected = new List<Contact>();
			var project = new Project();

			// Testing:
			project.Contacts = expected;

			// Assert:
			Assert.AreEqual(
				project.Contacts,
				expected,
				"Сеттер Contacts не принимает правильное значение");
		}

		[Test(Description = "Позвитивный тест геттера Contacts")]
		public void Contacts_GetCorrectValue_ValueGetted()
		{
			// Setup:
			var expected = new List<Contact>();
			var project = new Project();

			// Testing:
			project.Contacts = expected;
			var actual = project.Contacts;

			// Assert:
			Assert.AreEqual(
				expected,
				actual,
				"Геттер Contacts возвращает неправильный список");
		}

		[Test(Description = "Позвитивный тест метода SortContactsByFullName")]
		public void SortContactsByFullName_GetCorrectValue_ValueSorted()
		{
			// Setup:
			var firstContact = new Contact(
				"1",
				"firstContact",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk");
			var secondContact = new Contact(
				"2",
				"secondContact",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk");
			var thirdContact = new Contact(
				"3",
				"thirdContact",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk");
			var fourthContact = new Contact(
				"4",
				"fourthContact",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk");
			var expected = new List<Contact>()
			{
				firstContact,
				secondContact,
				thirdContact,
				fourthContact
			};

			var project = new Project();
			project.Contacts.Add(secondContact);
			project.Contacts.Add(fourthContact);
			project.Contacts.Add(firstContact);
			project.Contacts.Add(thirdContact);

			// Testing:
			project.Contacts = project.SortContactsByFullName(project.Contacts);
			var actual = project.Contacts;

			// Assert:
			Assert.AreEqual(
				expected,
				actual,
				"Метод SortContactsByFullName возвращает неправильный список");
		}

		[Test(Description = "Позвитивный тест метода FindBirthdays. " +
			"Отправка списка из 0 контактов")]
		public void FindBirthdays_GetNullValue_ReturnNull()
		{
			// Setup:
			var expected = new List<Contact>();

			var project = new Project();

			// Testing:
			var actual = project.FindBirthdays(project.Contacts);

			// Assert:
			Assert.AreEqual(
				expected,
				actual,
				"Метод FindBirthdays возвращает неправильный список");
		}

		[Test(Description = "Позвитивный тест метода FindBirthdays. " +
			"Отправка списка из нескольких контактов")]
		public void FindBirthdays_GetSomeValue_ReturnNull()
		{
			// Setup:
			var firstContact = new Contact(
				"1",
				"firstContact",
				"+0(000)-000-00-00",
				DateTime.Today.AddDays(-2),
				"vk");
			var secondContact = new Contact(
				"2",
				"secondContact",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk");
			var thirdContact = new Contact(
				"3",
				"thirdContact",
				"+0(000)-000-00-00",
				DateTime.Today.AddDays(-1),
				"vk");
			var fourthContact = new Contact(
				"4",
				"fourthContact",
				"+0(000)-000-00-00",
				DateTime.Today.AddDays(-3),
				"vk");
			var expected = new List<Contact>()
			{
				secondContact
			};

			var project = new Project();
			project.Contacts.Add(secondContact);
			project.Contacts.Add(fourthContact);
			project.Contacts.Add(firstContact);
			project.Contacts.Add(thirdContact);

			// Testing:
			var actual = project.FindBirthdays(project.Contacts);

			// Assert:
			Assert.AreEqual(
				expected,
				actual,
				"Метод FindBirthdays возвращает неправильный список");
		}

		[Test(Description = "Позвитивный тест метода FindContactBySubString. " +
			"Отправка списка из 0 контактов. Произвольная строка")]
		public void FindContactBySubString_GetNullList_ReturnNull()
		{
			// Setup:
			var expected = new List<Contact>();

			var project = new Project();

			// Testing:
			var actual = project.FindContactBySubString(project.Contacts, "");

			// Assert:
			Assert.AreEqual(
				expected,
				actual,
				"Метод FindContactBySubString неправильно заходит в цикл");
		}

		[Test(Description = "Позвитивный тест метода FindContactBySubString. " +
			"Не совпадающая ни с чем строка")]
		public void FindContactBySubString_GetMismatchedString_ReturnNull()
		{
			// Setup:
			var firstContact = new Contact(
				"firstContact",
				"firstContact",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk");
			var secondContact = new Contact(
				"secondContact",
				"secondContact",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk");
			var thirdContact = new Contact(
				"thirdContact",
				"thirdContact",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk");
			var fourthContact = new Contact(
				"fourthContact",
				"fourthContact",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk");

			var project = new Project();
			project.Contacts.Add(firstContact);
			project.Contacts.Add(secondContact);
			project.Contacts.Add(thirdContact);
			project.Contacts.Add(fourthContact);

			var expected = new List<Contact>();

			string mismathedString = "qwe";

			// Testing:
			var actual = project.FindContactBySubString(project.Contacts, mismathedString);

			// Assert:
			Assert.AreEqual(
				expected,
				actual,
				"Метод FindContactBySubString неправильно сравнивает");
		}

		[Test(Description = "Позвитивный тест метода FindContactBySubString. " +
			"Совпадающая с именем строка")]
		public void FindContactBySubString_GetFullnameLikeString_ReturnContacts()
		{
			// Setup:
			var firstContact = new Contact(
				"firstContact",
				"@com",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk");
			var secondContact = new Contact(
				"secondContact",
				"@com",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk");
			var thirdContact = new Contact(
				"thirdContact",
				"@com",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk");
			var fourthContact = new Contact(
				"fourthContact",
				"@com",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk");

			var project = new Project();
			project.Contacts.Add(firstContact);
			project.Contacts.Add(secondContact);
			project.Contacts.Add(thirdContact);
			project.Contacts.Add(fourthContact);

			var expected = new List<Contact>();
			expected.Add(firstContact);
			expected.Add(fourthContact);

			string mismathedString = "f";

			// Testing:
			var actual = project.FindContactBySubString(project.Contacts, mismathedString);

			// Assert:
			Assert.AreEqual(
				expected,
				actual,
				"Метод FindContactBySubString неправильно сравнивает имена");
		}

		[Test(Description = "Позвитивный тест метода FindContactBySubString. " +
			"Совпадающая с именем строка")]
		public void FindContactBySubString_GetEmailLikeString_ReturnContacts()
		{
			// Setup:
			var firstContact = new Contact(
				"firstName",
				"@com",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk");
			var secondContact = new Contact(
				"secondName",
				"com",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk");
			var thirdContact = new Contact(
				"thirdName",
				"com",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk");
			var fourthContact = new Contact(
				"fourthName",
				"@com",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk");

			var project = new Project();
			project.Contacts.Add(firstContact);
			project.Contacts.Add(secondContact);
			project.Contacts.Add(thirdContact);
			project.Contacts.Add(fourthContact);

			var expected = new List<Contact>();
			expected.Add(firstContact);
			expected.Add(fourthContact);

			string mismathedString = "@";

			// Testing:
			var actual = project.FindContactBySubString(project.Contacts, mismathedString);

			// Assert:
			Assert.AreEqual(
				expected,
				actual,
				"Метод FindContactBySubString неправильно сравнивает адреса почт");
		}

		[Test(Description = "Позвитивный тест метода FindContactBySubString. " +
			"Совпадающая с номером телефона строка")]
		public void FindContactBySubString_GetPhoneLikeString_ReturnContacts()
		{
			// Setup:
			var firstContact = new Contact(
				"firstContact",
				"@com",
				"+7(000)-000-00-00",
				DateTime.Today,
				"vk");
			var secondContact = new Contact(
				"secondContact",
				"@com",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk");
			var thirdContact = new Contact(
				"thirdContact",
				"@com",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk");
			var fourthContact = new Contact(
				"fourthContact",
				"@com",
				"+7(000)-000-00-00",
				DateTime.Today,
				"vk");

			var project = new Project();
			project.Contacts.Add(firstContact);
			project.Contacts.Add(secondContact);
			project.Contacts.Add(thirdContact);
			project.Contacts.Add(fourthContact);

			var expected = new List<Contact>();
			expected.Add(firstContact);
			expected.Add(fourthContact);

			string mismathedString = "f";

			// Testing:
			var actual = project.FindContactBySubString(project.Contacts, mismathedString);

			// Assert:
			Assert.AreEqual(
				expected,
				actual,
				"Метод FindContactBySubString неправильно сравнивает номера телефона");
		}

		[Test(Description = "Позвитивный тест метода FindContactBySubString. " +
			"Совпадающая с ссылкой на профиль ВК")]
		public void FindContactBySubString_GetVKLikeString_ReturnContacts()
		{
			// Setup:
			var firstContact = new Contact(
				"firstName",
				"@com",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk//profile//vanyaPic");
			var secondContact = new Contact(
				"secondName",
				"com",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk//profile//alexandr");
			var thirdContact = new Contact(
				"thirdName",
				"com",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk//profile//maxim");
			var fourthContact = new Contact(
				"fourthName",
				"@com",
				"+0(000)-000-00-00",
				DateTime.Today,
				"vk//profile//vanyaNik");

			var project = new Project();
			project.Contacts.Add(firstContact);
			project.Contacts.Add(secondContact);
			project.Contacts.Add(thirdContact);
			project.Contacts.Add(fourthContact);

			var expected = new List<Contact>();
			expected.Add(firstContact);
			expected.Add(fourthContact);

			string mismathedString = "@";

			// Testing:
			var actual = project.FindContactBySubString(project.Contacts, mismathedString);

			// Assert:
			Assert.AreEqual(
				expected,
				actual,
				"Метод FindContactBySubString неправильно сравнивает ссылки на профиль ВК");
		}

	}
}
