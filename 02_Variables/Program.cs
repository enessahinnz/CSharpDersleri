using System;

namespace _02_Variables
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region Double Değişkenler
			//double applePrice, tomatoPrice, orangePrice, strawberryPrice, potatoPrice;
			//applePrice = 15.5;
			//tomatoPrice = 11.25;
			//orangePrice = 18.37;
			//strawberryPrice = 19.85;
			//potatoPrice = 9.57;
			//Console.WriteLine("***** Meyve Fiyatları *****");
			//Console.WriteLine("---- Elma Birim Fiyatı" + applePrice);
			//Console.WriteLine("---- Domates Birim Fiyatı" + tomatoPrice);
			//Console.WriteLine("---- Portakal Birim Fiyatı" + orangePrice);
			//Console.WriteLine("---- Çilek Birim Fiyatı" + strawberryPrice);
			//Console.WriteLine("---- Patates Birim Fiyatı" + potatoPrice);


			//double appleGram, tomatoGram, orangeGram, strawberryGram, potatoGram;

			//appleGram = 1.24;
			//tomatoGram = 3.745;
			//orangeGram = 2.650;
			//strawberryGram = 0.750;
			//potatoGram = 4.859;

			//double appleTotalPrice = applePrice * appleGram;
			//double tomatoTotalPrice = tomatoPrice * tomatoGram;
			//double orangeTotalPrice = orangePrice * orangeGram;
			//double strawberryTotalPrice = strawberryPrice * strawberryGram;
			//double potatoTotalPrice = potatoPrice * potatoGram;

			//Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat:" + applePrice + " - Gramaj:" + appleGram + " - Toplam Tutar: " + appleTotalPrice);
			//Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat:" + tomatoPrice + " - Gramaj:" + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);
			//Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat:" + orangePrice + " - Gramaj:" + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
			//Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat:" + strawberryPrice + " - Gramaj:" + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
			//Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat:" + potatoPrice + " - Gramaj:" + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);

			//double shoppingTotalPrice = appleTotalPrice + tomatoTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice;
			//Console.WriteLine();
			//Console.WriteLine();

			//Console.WriteLine("Toplam Fiyat: " + shoppingTotalPrice);
			#endregion

			#region Char Değişkenler

			//char symbol = 'A';

			#endregion

			#region Klavyeden String Veri Girişleri

			//Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
			//Console.WriteLine();

			//string passengerName, passengerSurname, passengerDistrict, passengerAge, passengerCity, passengerIdentityNumber;

			//Console.Write("Yolcu Adı:");
			//passengerName = Console.ReadLine();

			//Console.Write("Yolcu Soyadı:");
			//passengerSurname = Console.ReadLine();

			//Console.Write("Yolcu İlçe Bilgisi:");
			//passengerDistrict = Console.ReadLine();

			//Console.Write("Yolcu Yaşı:");
			//passengerAge = Console.ReadLine();

			//Console.Write("Yolcu Şehir Bilgisi:");
			//passengerCity = Console.ReadLine();

			//Console.Write("Yolcu TC Kimlik No:");
			//passengerIdentityNumber = Console.ReadLine();

			//Console.WriteLine();

			//Console.WriteLine("----------------------");

			//Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " - Yolcu Adı: " + passengerName + " - Yolcu Soyadı: " + passengerSurname + " - Yolcu Yaşı: " + passengerAge + " - Yolcu Şehir Bilgisi: " + passengerCity);


			#endregion

			#region Klavyeden Sayı Girişleri

			int shoesPrice, computerPrice, chairPrice, tvPrice;

			shoesPrice = 125;
			computerPrice = 355;
			chairPrice = 255;
			tvPrice = 514;



			int shoesCount, computerCount, chairCount, tvCount;

			Console.Write("Ayakkabı Adetini Giriniz: ");
			shoesCount = int.Parse(Console.ReadLine());

			Console.Write("Bilgisayar Adetini Giriniz: ");
			computerCount = int.Parse(Console.ReadLine());

			Console.Write("Sandalye Adetini Giriniz: ");
			chairCount = int.Parse(Console.ReadLine());

			Console.Write("Televizyon Adetini Giriniz: ");
			tvCount = int.Parse(Console.ReadLine());

			int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;


			Console.WriteLine();
			Console.WriteLine("Toplam Fiyat: " + totalPrice);

			#endregion


			Console.Read();

		}
	}
}
