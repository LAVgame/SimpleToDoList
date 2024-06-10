using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SimpleToDoList
{
	public class ToDo
	{
		public string Title { get; set; }
		public string Description { get; set; }
		private bool IsDone { get; set; }

		public ToDo()
		{

		}

		public ToDo(string title, string description, bool isDone)
		{
			Title = title;
			Description = description;
			IsDone = isDone;
		}
		public async void ListTasks(string path)
		{
			try
			{
				using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
				{
					ToDo? todo = await JsonSerializer.DeserializeAsync<ToDo>(fs);
					Console.WriteLine($"Title: {todo?.Title}");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("[sys_mes]: Код ошибки 000: При чтение файла tasks.json:  \n[sys_mes]: " + ex.Message);
			}

		}
		//@"D:\\LAV\\Files\\Programming\\Plan\\less5\\textfiles\tasks.json"
		public async void WriteTask(string path)
		{

			// сохранение данных
			using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
			{
				Console.Write("[sys_mes]: Заголовок: ");
				string title = Console.ReadLine();
				Console.Write("[sys_mes]: Описание: ");
				string desc = Console.ReadLine();
				Console.Write("[sys_mes]: Пометить выполненым? (х), y - Да, n - Нет: ");
				string isdoneText = Console.ReadLine();
				bool isdone;
				if (isdoneText == "y" || isdoneText == "Y") isdone = true;
				else isdone = false;
				ToDo todo = new ToDo(title, desc, isdone);

				await JsonSerializer.SerializeAsync<ToDo>(fs, todo);
				Console.WriteLine("Фйл сохранён!");
			}

			/*
            string bl = "";
            if (isdone == true) bl = "X";
            string filetext = $"Title: {Title} \nDescription: {dec} \nIs Done: {bl}";
            File.WriteAllText(@"D:\\LAV\\Files\\Programming\\Plan\\less5\\textfiles\tasks.json", filetext);
            */
		}

	}
}
