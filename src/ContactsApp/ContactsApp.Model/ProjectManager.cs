using Newtonsoft.Json;
using System;
using System.IO;
using static System.Environment;

namespace ContactsApp.Model
{
	public static class ProjectManager
	{
		/// <summary>
		/// Путь до папки AppData.
		/// </summary>
		private static string _appDataPath = Environment.GetFolderPath(SpecialFolder.ApplicationData);
		/// <summary>
		/// Путь до папки приложения.
		/// </summary>
		private static string _directoryPath = $"{_appDataPath}\\Oxingert\\ContactsApp";

		/// <summary>
		/// Пусть файла, где хранится информация.
		/// </summary>
		static string Filename { get; set; } =
			_directoryPath + "\\userdata.json";

		/// <summary>
		/// Функция сохранения в файл по пути _directoryPath.
		/// </summary>
		/// <param name="project"></param>
		public static void SaveToFile(Project project)
		{
			JsonSerializer serializer = new JsonSerializer();

			//Если папки не существует
			if (!Directory.Exists(_directoryPath))
			{
				Directory.CreateDirectory(_directoryPath);
			}
			//Если файла не существует
			if (!File.Exists(_directoryPath))
			{
				var fileStream = File.Create(Filename);
				fileStream.Close();
			}

			File.WriteAllText(Filename, JsonConvert.SerializeObject(project));

		}

		/// <summary>
		/// Функция загрузки информации из файла по пути _directoryPath.
		/// </summary>
		/// <returns></returns>
		public static Project LoadFromFile()
		{
			try
			{
				//Создаём переменную, в которую поместим результат десериализации
				Project project = null;

				//Если файла не существует
				if (!File.Exists(Filename))
				{
					return new Project();
				}
				using (StreamReader reader = new StreamReader(Filename))
				{
					string jsonData = reader.ReadToEnd();
					project = JsonConvert.DeserializeObject<Project>(jsonData);
				}
				return project ?? new Project();
			}
			catch (Exception e)
			{
				return new Project();
			}
		}

	}
}
