//#define Binary
//#define Soap
//#define XML
#define JSON

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Подключение пространства имен для сериализации
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Text.Json;
//using static System.Net.Mime.MediaTypeNames;

namespace CW_Serialization
{
    //Разные форматы сериализации
    //1.Двоичный формат
    //2.SOAP
    //3.XML
    //4.JSON
    //Атрибуты сериализации

    //Установка атрибута перед классом
    [Serializable] //Сериализуются только поля public!!!! 
    public class Human
    {
        public int ID { get; set; }
        //Не сериализуется
        [NonSerialized]
        const string Group = "GRRRR";
        public string Name { get; set; }
        public int Age { get; set; }

        //Требование XML
        public Human() { }
        public Human(int arg_id)
        {
            ID = arg_id;
        }
        public Human(int _id, string name, int age)
        {
            ID = _id;
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"{ID} {Name} {Age} {Group}";
        }
        public void Insert()
        {
            ID = Convert.ToInt32(Console.ReadLine());
            Name = Console.ReadLine();
            Age = Convert.ToInt32(Console.ReadLine());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human(1) { Name = "Ivan", Age = 18 };
            Human h2 = new Human(1) { Name = "Ivan2", Age = 19 };
            Human h3 = new Human(1) { Name = "Ivan2", Age = 20 };
            Human[] humans = new Human[] { h, h2, h3 };

#if Binary

			//1.binary
			BinaryFormatter bf = new BinaryFormatter();
			try
			{
				using (Stream fstr = File.Create("test.bin"))
				{
					bf.Serialize(fstr, humans);
				}
				Console.WriteLine("Сериализация прошла успешно");

				Human h_new = null;
				using (Stream fsteread = File.OpenRead("test.bin"))
				{

					//h_new = (Human)bf.Deserialize(fsteread);
					Human[] h_new_arr =  (Human[])bf.Deserialize(fsteread);
					foreach (var item in h_new_arr)
					{
						Console.WriteLine(item);
					}

				}
			}
			catch (Exception)
			{

				throw;
			}


#endif

#if Soap
			// 2. SOAP // Сериализует все подряд
			SoapFormatter bf = new SoapFormatter();
			try
			{
				using (Stream fstr = File.Create("test.soap"))
				{
					bf.Serialize(fstr, h);
				}
				Console.WriteLine("Сериализация прошла успешно");

				Human h_new = null;
				using (Stream fsteread = File.OpenRead("test.soap"))
				{
					h_new = (Human)bf.Deserialize(fsteread);
					Console.WriteLine(h_new);
				}
			}
			catch (Exception)
			{

				throw;
			}
#endif

#if XML
			// XML не требует [Serialization], у класса должен быть public, у класс должен быть конструктор не принимающий параметров


			XmlSerializer bf = new XmlSerializer(typeof(Human));
			try
			{
				using (Stream fstr = File.Create("test.xml"))
				{
					bf.Serialize(fstr, h);
				}
				Console.WriteLine("Сериализация прошла успешно");

				Human h_new = null;
				using (Stream fsteread = File.OpenRead("test.xml"))
				{

					h_new = (Human)bf.Deserialize(fsteread);
					//Human[] h_new_arr = (Human[])bf.Deserialize(fsteread);
					//foreach (var item in h_new_arr)
					//{
					//	Console.WriteLine(item);
					//}

				}
			}
			catch (Exception)
			{

				throw;
			}


#endif

#if JSON
            //Клас должен быть public
            Human jh = new Human { ID = 1, Name = "Jay", Age = 50 };
            string json_human = JsonSerializer.Serialize(jh);
            Console.WriteLine(json_human);
            Human h_new = JsonSerializer.Deserialize<Human>(json_human);
            Console.WriteLine(h_new);
            // 4.1
            using (FileStream fs = new FileStream("human.json", FileMode.OpenOrCreate))
            {
                Human jh2 = new Human { ID = 1, Name = "Jay", Age = 50 };
                JsonSerializer.Serialize<Human>(fs, jh2);
                Console.WriteLine("OK");
            }
            using (FileStream fs = new FileStream("human.json", FileMode.OpenOrCreate))
            {
                Human jh3 = JsonSerializer.Deserialize<Human>(fs);
                Console.WriteLine(jh3);
            }

#endif

        }
    }
}

