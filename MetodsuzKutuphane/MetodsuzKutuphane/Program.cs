using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MetodsuzKutuphane
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            #region Kitaplar

            Kitapbilgileri[] kitap = new Kitapbilgileri[12];
            kitap[0] = new Kitapbilgileri() { isbnno = "9786052980001", kitapadi = "Kırmızı Pazartesi", sayfasayisi = 112, tur = "Roman", yazaradi = "Gabriel", yazarsoyadi = "Márquez", yayineviadi = " Ay     Yayınları", kutuphanestogu = 2 };
            kitap[1] = new Kitapbilgileri() { isbnno = "9789750723843", kitapadi = "İstanbul Hatırası", sayfasayisi = 590, tur = "Roman", yazaradi = "Ahmet", yazarsoyadi = "Ümit", yayineviadi = " Ay     Yayınları", kutuphanestogu = 1 };
            kitap[2] = new Kitapbilgileri() { isbnno = "9789753638013", kitapadi = "Sineklerin Tanrısı", sayfasayisi = 261, tur = "Roman", yazaradi = "William", yazarsoyadi = "Golding", yayineviadi = " Ay     Yayınları", kutuphanestogu = 1 };
            kitap[3] = new Kitapbilgileri() { isbnno = "9789750725236", kitapadi = "Kürk Mantolu Madonna", sayfasayisi = 192, tur = "Roman", yazaradi = "Sabahattin", yazarsoyadi = "Ali", yayineviadi = " Ay     Yayınları", kutuphanestogu = 3 };
            kitap[4] = new Kitapbilgileri() { isbnno = "9789753638044", kitapadi = "1984", sayfasayisi = 352, tur = "Roman", yazaradi = "George", yazarsoyadi = "Orwell", yayineviadi = " Güneş  Yayınları", kutuphanestogu = 1 };
            kitap[5] = new Kitapbilgileri() { isbnno = "9786053753468", kitapadi = "Zeyrek Cinayeti", sayfasayisi = 296, tur = "Pols.", yazaradi = "Peyami", yazarsoyadi = "Safa", yayineviadi = " Güneş  Yayınları", kutuphanestogu = 1 };
            kitap[6] = new Kitapbilgileri() { isbnno = "9789750738588", kitapadi = "Dönüşüm", sayfasayisi = 180, tur = "Roman", yazaradi = "Franz", yazarsoyadi = "Kafka", yayineviadi = " Güneş  Yayınları", kutuphanestogu = 1 };
            kitap[7] = new Kitapbilgileri() { isbnno = "9789754055856", kitapadi = "Medyum", sayfasayisi = 447, tur = "Korku", yazaradi = "Stephan", yazarsoyadi = "King", yayineviadi = " Güneş  Yayınları", kutuphanestogu = 1 };
            kitap[8] = new Kitapbilgileri() { isbnno = "9789754050943", kitapadi = "Doğu Ekspresinde Cinayet", sayfasayisi = 147, tur = "Pols.", yazaradi = "Agatha", yazarsoyadi = "Christie", yayineviadi = " Güneş  Yayınları", kutuphanestogu = 2 };
            kitap[9] = new Kitapbilgileri() { isbnno = "9786057572189", kitapadi = "Rezonans Kanunu", sayfasayisi = 206, tur = "Kiş.G.", yazaradi = "Pierre", yazarsoyadi = "Franckh", yayineviadi = "Yıldız Yayınları", kutuphanestogu = 2 };
            kitap[10] = new Kitapbilgileri() { isbnno = "9786056949586", kitapadi = "Düşüncenin Gücü", sayfasayisi = 120, tur = "Kiş.G.", yazaradi = "James", yazarsoyadi = "Allen", yayineviadi = "Yıldız Yayınları", kutuphanestogu = 1 };
            kitap[11] = new Kitapbilgileri() { isbnno = "9789754051520", kitapadi = "Hayvan Mezarlığı", sayfasayisi = 375, tur = "Korku", yazaradi = "Stephan", yazarsoyadi = "King", yayineviadi = "Yıldız Yayınları", kutuphanestogu = 1 };

            #endregion

            #region Kütüphane Envanter

            #region Emanet Alanların Kayıt Dizisi

            string[] emanetalaninadi = new string[0];
            string[] emanetalaninsoyadi = new string[0];
            string[] emanetalanintc = new string[0];
            string[] emanetalistarihi = new string[0];
            string[] emanetalanisbnno = new string[0];
            string[] emanetalankitapadi = new string[0];



            #endregion

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Morpheus Kütüphanesine Hoşgeldiniz");
                Console.ResetColor();
                Console.WriteLine("1.) Envanter Kontrolü");
                Console.WriteLine("2.) Emanet Kitap Alma");
                Console.WriteLine("3.) Emanet Alanların Listesi");
                Console.Write("Lütfen Yapmak İstediğiniz İşlemi Seciniz= ");
                Console.ForegroundColor = ConsoleColor.Green;
                byte islemsecim = Convert.ToByte(Console.ReadLine());
                Console.ResetColor();

                switch (islemsecim)
                {
                    case 1:
                        Console.WriteLine("No  İsbn No        Yayınevi Adı         Stok Mik.  Tür          Yazar           Kitap ");
                        Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                        for (int i = 0; i < kitap.Length; i++)
                        {
                            Console.WriteLine($"{(i + 1)}.) {kitap[i].isbnno} {kitap[i].yayineviadi}\t{kitap[i].kutuphanestogu}\t   {kitap[i].tur}\t{kitap[i].yazaradi} {kitap[i].yazarsoyadi}\t{kitap[i].kitapadi}  ");
                        }
                        break;

                    case 2:

                        #region Emanet Alımındaki Kitap Listesi
                        Console.WriteLine("No  İsbn No        Yayınevi Adı         Stok Mik.  Tür          Yazar           Kitap ");
                        Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                        for (int i = 0; i < kitap.Length; i++)
                        {
                            Console.WriteLine($"{(i + 1)}.) {kitap[i].isbnno} {kitap[i].yayineviadi}\t{kitap[i].kutuphanestogu}\t   {kitap[i].tur}\t{kitap[i].yazaradi} {kitap[i].yazarsoyadi}\t{kitap[i].kitapadi}  ");
                        }
                        #endregion

                        Console.Write("Kaç Adet Kitap Emanet Almak İstiyorsunuz= ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        byte miktar = Convert.ToByte(Console.ReadLine());
                        Console.ResetColor();

                        Console.Write("Emanet alan kişinin adını giriniz= ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        string alaninadi = Console.ReadLine();
                        Console.ResetColor();

                        Console.Write("Emanet alan kişinin soyadını giriniz= ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        string alaninsoyadi = Console.ReadLine();
                        Console.ResetColor();

                        Console.Write("Emanet alan kişinin TC numarasını giriniz= ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        string gecicitc = Console.ReadLine();
                        string alanintc = "";
                        for (int i = 0; i < 11; i++) // Girilen tc kimlik numarasının sadece 11 hanesini almak için döngü kuruyoruz. Kim.no girenin hatalı girdiğini varsayıyoruz.
                        {
                            alanintc += gecicitc[i];
                            Console.ResetColor();
                        }

                        Console.Write("Emanet alış tarihini giriniz (gg.aa.yyyy)= ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        string alistarihi = Console.ReadLine();
                        Console.ResetColor();


                        if ((miktar > 0 && miktar < 4))
                        {
                            for (int i = 0; i < miktar; i++)
                            {
                                string[] gecicialaninadi = new string[emanetalaninadi.Length + 1];
                                string[] gecicialaninsoyadi = new string[emanetalaninsoyadi.Length + 1];
                                string[] gecicialanintc = new string[emanetalanintc.Length + 1];
                                string[] gecicialistarihi = new string[emanetalistarihi.Length + 1];
                                string[] gecicialanisbnno = new string[emanetalanisbnno.Length + 1];
                                string[] gecicialankitapadi = new string[emanetalankitapadi.Length + 1];

                                Console.Write("Almak istediğiniz kitabın sıra numarasını seçiniz= ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                byte sirano = Convert.ToByte(Console.ReadLine());
                                Console.ResetColor();

                                if (kitap[sirano - 1].kutuphanestogu != 0)
                                {
                                    kitap[sirano - 1].kutuphanestogu -= 1;
                                    for (int j = 0; j < emanetalaninadi.Length; j++)
                                    {
                                        gecicialaninadi[j] = emanetalaninadi[j];
                                        gecicialaninsoyadi[j] = emanetalaninsoyadi[j];
                                        gecicialanintc[j] = emanetalanintc[j];
                                        gecicialanisbnno[j] = emanetalanisbnno[j];
                                        gecicialankitapadi[j] = emanetalankitapadi[j];
                                        gecicialistarihi[j] = emanetalistarihi[j];
                                    }

                                    gecicialaninadi[gecicialaninadi.Length - 1] = alaninadi;
                                    gecicialaninsoyadi[gecicialaninsoyadi.Length - 1] = alaninsoyadi;
                                    gecicialanintc[gecicialanintc.Length - 1] = alanintc;
                                    gecicialistarihi[gecicialistarihi.Length - 1] = alistarihi;
                                    gecicialanisbnno[gecicialanisbnno.Length - 1] = kitap[sirano - 1].isbnno;
                                    gecicialankitapadi[gecicialankitapadi.Length - 1] = kitap[sirano - 1].kitapadi;

                                    emanetalaninadi = gecicialaninadi;
                                    emanetalaninsoyadi = gecicialaninsoyadi;
                                    emanetalanintc = gecicialanintc;
                                    emanetalistarihi = gecicialistarihi;
                                    emanetalanisbnno = gecicialanisbnno;
                                    emanetalankitapadi = gecicialankitapadi;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Almak istediğiniz kitabın stoğu yetersizdir! Lütfen başka bir kitap seçiniz.");
                                    Console.ResetColor();
                                    i--;// Uyarıyı verdikten sonra i değerinin yukarıdaki artışını geçersiz kılması için i değerini 1 azaltıyoruz.
                                }
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Sadece 3 adet kitap emanet alabilirsiniz");
                            Console.ResetColor();
                        }

                        break;

                    case 3:
                        Console.WriteLine("{0}  {1}\t\t{2}\t {3}     {4}        {5}", "No", "TC", "  Adı Soyadı", "Alış Tar.", "İsbn", "Kitap Adı");
                        for (int i = 0; i < emanetalaninadi.Length; i++)
                        {
                            TimeSpan gecensure = DateTime.Now - Convert.ToDateTime(emanetalistarihi[i]);
                            if (gecensure.Days > 14)
                            {
                                Console.Write($"{(i + 1)}.) {emanetalanintc[i]}   {emanetalaninadi[i].ToUpper()} {emanetalaninsoyadi[i].ToUpper()}   {emanetalistarihi[i]} {emanetalanisbnno[i]}  {emanetalankitapadi[i]} ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"{"Emanette Geçen Süre=" + gecensure.Days + "gün, 14 günlük süre aşılmış."}");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine($"{(i + 1)}.) {emanetalanintc[i]}   {emanetalaninadi[i].ToUpper()} {emanetalaninsoyadi[i].ToUpper()}   {emanetalistarihi[i]} {emanetalanisbnno[i]}  {emanetalankitapadi[i]} {"Emanette Geçen Süre=" + gecensure.Days + "gün"}");
                            }
                        }
                        break;

                }
                Console.Write("Başka bir işlem yapmak istiyor musunuz? e/h = ");
                Console.ForegroundColor = ConsoleColor.Green;
                string secenekeh = Console.ReadLine();
                Console.ResetColor();
                if (secenekeh != "e")
                {
                    break;
                }
                islemsecim = 0;
                Console.Clear();
            }
            #endregion

        }
    }
}
