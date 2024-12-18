using System;

namespace _01_MainSubjects
{
	internal class Program
	{
		static void Main(string[] args)
		{


			#region YazdırmaKomutları

			//Console.Write("Merhaba Dünya!");
			//Console.WriteLine("Selam");

			//Console.WriteLine("***** Yemek Katogorileri *****");
			//Console.WriteLine();
			//Console.WriteLine("1-Çorbalar");
			//Console.WriteLine("2-Anayemekler");
			//Console.WriteLine("3-Soğuk Başlanıçlar");
			//Console.WriteLine("4-Salatalar");
			//Console.WriteLine("5-İçeçekler");
			//Console.WriteLine("6-Tatlılar");
			//Console.WriteLine();
			//Console.WriteLine("***** Yemek Katogorileri *****");

			#endregion


			#region StringDeğişkenler
			//string 
			var name = "Enes";
			string lastname = "Sahin";
			string city, district, customerEmail;
			city = "İstanbul";
			district = "Ümraniye";
			customerEmail = "denem@gmail.com";

			Console.WriteLine("***** Rezervasyon Kartı *****");
			Console.WriteLine();
			Console.WriteLine("-------------------------------------------");
			Console.WriteLine("Müşteri Adı: " + name);
			Console.WriteLine("Müşteri Soyadı: " + lastname);
			Console.WriteLine("Şehir: " + city + "/" + district);
			Console.WriteLine("Email: " + customerEmail);
			#endregion

			#region Integer Değişkenler
			int hamburgerPrice = 259;
			int cokePrice = 25;
			int waterPrice = 10;
			int friesPrice = 50;
			int pizzaPrice = 299;
			int lemonadePrice = 299;

			Console.WriteLine("***** Restoran Menü Fiyatı *****");
			Console.WriteLine();
			Console.WriteLine("----- Hamburger Fiyatı: " + hamburgerPrice);
			Console.WriteLine("----- Cola Fiyatı: " + cokePrice);
			Console.WriteLine("----- Su Fiyatı" + waterPrice);
			Console.WriteLine("----- Kızartma Fiyatı" + friesPrice);
			Console.WriteLine("----- Pizza Fiyatı" + pizzaPrice);
			Console.WriteLine("----- Limonata Fiyatı" + lemonadePrice);
			Console.WriteLine();
			Console.WriteLine("***** Restoran Menü Fiyatı *****");


			Console.WriteLine();
			int hamburgerCount;
			int cokeCount;
			int waterCount;
			int friesCount;
			int pizzaCount;
			int lemonadeCount;

			int totalPrice = 0;

			hamburgerCount = 3;
			cokeCount = 3;
			waterCount = 3;
			friesCount = 1;
			pizzaCount = 0;
			lemonadeCount = 0;

			totalPrice = hamburgerCount * hamburgerPrice + cokePrice * cokeCount + waterPrice * waterCount + friesCount * friesPrice;
			Console.WriteLine("Toplam Ücret: " + totalPrice);
			#endregion




			Console.Read();
		}
	}
}



