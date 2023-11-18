namespace CalculatorExample
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool durum=true; 
			while(durum)
			{
				Console.WriteLine("-------- Hesaplama İşlemleri --------");
				Console.WriteLine("-------------------------------------");
				Console.WriteLine("------------ İşlem Seçiniz ----------");
				Console.WriteLine("Hesap Makinesi           (H)");
				Console.WriteLine("Dikdörtgen Alanı Hesabı  (D)");
				Console.WriteLine("Programdan Çık           (Q)");
				Console.Write("Seçminiz: ");
				char secim = Convert.ToChar(Console.ReadLine().ToLower().Substring(0,1));

				switch (secim)
				{
					case 'h':
						Console.Clear();
						Console.WriteLine("---------- Hesap Makinesi -----------");
						Console.WriteLine("-------------------------------------");
						Console.Write("1. Sayı: ");
						double sayi1 = Convert.ToDouble(Console.ReadLine());
						Console.Write("2. Sayı: ");							
						double sayi2 = Convert.ToDouble(Console.ReadLine());
						Console.Write("Operator (+-*/%): ");							
						char oprt = Convert.ToChar(Console.ReadLine().Substring(0,1));

                        Console.WriteLine(	oprt == '+'?sayi1+sayi2: 
											oprt == '-' ? sayi1 - sayi2: 
											oprt == '*' ? sayi1 * sayi2: 
											oprt == '/' ? sayi1 / sayi2: 
											oprt == '%' ? sayi1 % sayi2:"Hatalı Operatör Girildi");

                        break;
					case 'd':
						Console.Clear();
						Console.WriteLine("------ Dikdörtgen Alanı Hesabı ------");
						Console.WriteLine("-------------------------------------");
                        Console.Write("Uzun Kenar: ");
                        double uzunKenar=Convert.ToDouble(Console.ReadLine());
                        Console.Write("Kısa Kenar: ");
                        double kisaKenar=Convert.ToDouble(Console.ReadLine());

						double sonuc = kisaKenar * uzunKenar;
                        Console.WriteLine("Dikdörgenin alanı: "+ sonuc);
						Console.ReadLine();
						Console.WriteLine("Başa dönmek için bir tuşa basınız");

                        break;
					case 'q':
						Console.WriteLine("Program Kapatılır...\nBir Tuşa Basınız.");
						durum = !durum;
						break;
					default: 
						Console.WriteLine("Yanlış Seçim Tekrar Deneyiniz.");
						
						break;
				}
				Console.ReadLine();
				Console.Clear();
			}
		}
	}
}