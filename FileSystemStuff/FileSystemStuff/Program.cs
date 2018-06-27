using System;
using System.IO;
using Newtonsoft.Json;

namespace FileSystemStuff
{
    class Program
    {
        static void Main(string[] args)
        {
			var pet = new Pet()
			{
				Name = "Loretta",
				Age = 5,
				IsSpotted = true,
				Color = "Brown"
			};

			var petJson = JsonConvert.SerializeObject(pet);

			var path = @"C:\MyFiles\LorettaJson.txt";
			File.WriteAllText(path, petJson);


			var read = File.ReadAllText(path);
			var pet2 = JsonConvert.DeserializeObject<Pet>(read);

			
		}

		static void Example1()
		{
			//var name = "Third run!";
			var fileName = "Jeff.txt";
			var path = "C:\\MyFiles\\" + fileName;
			if (File.Exists(path))
			{
				var read = File.ReadAllText(path);
				Console.WriteLine(read);
			}
			else
			{
				File.WriteAllText(path, String.Empty);
			}
			File.Copy(path, path.Replace("Jeff", "Adam"));
			Console.ReadKey();
			//File.WriteAllText(path, name);
			//var read = File.ReadAllText(path);
		}
	}
}
