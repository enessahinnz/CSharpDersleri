using System;

namespace _03_MakingDecision
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region If
			//Console.Write("Lütfen şifrenizi giriniz: ");

			//string passw = Console.ReadLine();

			//if (passw != "abcd")
			//{
			//	Console.WriteLine("Şifre yanlış");

			//}
			//else
			//{
			//	Console.WriteLine("Şifre Doğru");
			//}

			#endregion


			#region Çoklu if
			//string country = Console.ReadLine();
			//string capital = Console.ReadLine();
			//if (country == "turkiye" && capital == "ankara")
			//{
			//	Console.WriteLine("Doğru");

			//}
			//else
			//{
			//	Console.WriteLine("Yanlış");
			//}
			#endregion


			#region Else if

			//int examl, exam2, exam3, average;
			//Console.Write("1. Sınav Notunuzu Giriniz: ");
			//examl = int.Parse(Console.ReadLine());
			//Console.Write("2. Sınav Notunuzu Giriniz: ");
			//exam2 = int.Parse(Console.ReadLine());
			//Console.Write("3. Sınav Notunuzu Giriniz: ");
			//exam3 = int.Parse(Console.ReadLine());
			//average = (examl + exam2 + exam3) / 3;
			//Console.WriteLine("Ortalamanız: " + average);
			//if (average <= 50 && average >= 0)
			//{
			//	Console.WriteLine("Kötü");

			//}
			//else if (average <= 70 && average >= 50)
			//{
			//	Console.WriteLine("Orta");

			//}
			//else if (average <= 84 && average >= 70)
			//{
			//	Console.WriteLine("İyi");

			//}
			//else
			//{
			//	Console.WriteLine("Çok İyi");


			//}

			#endregion


			#region Switch Case

			Console.WriteLine("Lütfen Bir Ay seçiniz: ");
			int monthNumber = int.Parse(Console.ReadLine());

			switch (monthNumber)
			{
				case 1: Console.WriteLine("Ocak"); break;
				case 2: Console.WriteLine("Şubat"); break;
				case 3: Console.WriteLine("Mart"); break;
				case 4: Console.WriteLine("Nisan"); break;
				case 5: Console.WriteLine("Mayıs"); break;
				case 6: Console.WriteLine("Haziran"); break;
				case 7: Console.WriteLine("Temmuz"); break;
				case 8: Console.WriteLine("Ağustos"); break;
				case 9: Console.WriteLine("Eylül"); break;
				case 10: Console.WriteLine("Ekim"); break;
				case 11: Console.WriteLine("Kasım"); break;
				case 12: Console.WriteLine("Aralık"); break;
				default: Console.WriteLine("Hatalı Giriş"); break;
			}



			#endregion


			int number1, number2, result;
			char symbol;

			Console.Write("1. Sayıyı Giriniz: ");
			number1 = int.Parse(Console.ReadLine());
			Console.Write("2. Sayıyı Giriniz: ");
			number2 = int.Parse(Console.ReadLine());
			Console.Write("İşlem Tipini Giriniz: ");
			symbol = char.Parse(Console.ReadLine());

			switch (symbol)
			{
				case '+':
					result = number1 + number2;
					Console.WriteLine("Sonuç: " + result); break;

				case '-':
					result = number1 - number2;
					Console.WriteLine("Sonuç: " + result); break;
				case '*':
					result = number1 * number2;
					Console.WriteLine("Sonuç: " + result); break;
				case '/':
					result = number1 / number2;
					Console.WriteLine("Sonuç: " + result); break;
				default: result = 0; break;
			}
















			Console.Read();
		}
	}
}
