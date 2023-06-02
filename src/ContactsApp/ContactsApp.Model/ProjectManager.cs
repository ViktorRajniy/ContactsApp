using Newtonsoft.Json;
using System;
using System.IO;
using static System.Environment;

namespace ContactsApp.Model
{
	public static class ProjectManager
	{
		static string Filename { get; set; } = 
			Environment.GetFolderPath(SpecialFolder.ApplicationData) + 
			"\\Oxingert\\ContactsApp\\userdata.json";
		static void SaveToFile(Project project)
		{
			//Создаём экземпляр сериализатора
			JsonSerializer serializer = new JsonSerializer();

			//Если файла не существует
			if (!File.Exists(Filename))
			{
				DirectoryInfo directory = Directory.CreateDirectory(Filename);
			}

			//Открываем поток для записи в файл с указанием пути
			StreamWriter sw = new StreamWriter(@Filename);
			JsonWriter writer = new JsonTextWriter(sw);

			//Вызываем сериализацию и передаем объект, который хотим сериализовать
			serializer.Serialize(writer, project);

		}

		static Project LoadFromFile()
		{
			//Создаём переменную, в которую поместим результат десериализации
			Project project = null;

			//Если файла не существует
			if (!File.Exists(Filename))
			{
				DirectoryInfo directory = Directory.CreateDirectory(Filename);
				return project;
			}

			//Создаём экземпляр сериализатора
			JsonSerializer serializer = new JsonSerializer();

			//Открываем поток для чтения из файла с указанием пути
			StreamReader sr = new StreamReader(@Filename);
			JsonReader reader = new JsonTextReader(sr);
			return project = (Project)serializer.Deserialize(reader);
		}

	}
}
