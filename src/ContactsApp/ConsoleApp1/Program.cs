using ContactsApp.Model;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace ConsoleApp1;

public class Program
{
	public static void Main()
	{
		Project test = new Project();
		Console.WriteLine("BEFORE");
		test.Contacts.Add(new Contact("a1", "someadress@mail.ru", "+0(000)-000-00-00", DateTime.Today, "vkid"));
		test.Contacts.Add(new Contact("d4", "someadress@mail.ru", "+0(000)-000-00-00", DateTime.Today, "vkid"));
		test.Contacts.Add(new Contact("c3", "someadress@mail.ru", "+0(000)-000-00-00", DateTime.Today, "vkid"));
		test.Contacts.Add(new Contact("b2", "someadress@mail.ru", "+0(000)-000-00-00", DateTime.Today, "vkid"));

		foreach(Contact contact in test.Contacts)
		{
			Console.WriteLine(contact.FullName);
		}

		Console.WriteLine("");
		Console.WriteLine("AFTER");
		test.Contacts = test.SortContactsByFullName(test.Contacts);
		foreach (Contact contact in test.Contacts)
		{
			Console.WriteLine(contact.FullName);
		}
	}
}