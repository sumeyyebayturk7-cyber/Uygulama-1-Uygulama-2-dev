using System;


namespace ÖDÜNÇ_SÜRESİ_KONTROL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OduncKontrolu();
        }

        static void OduncKontrolu()
        {
            bool devamEt = true;
            bool oduncteMi = false;

            while (devamEt)
            {
                Console.Write("Gün sayısı gir: ");
                string giris = Console.ReadLine();

                if (!int.TryParse(giris, out int gun))
                {
                    Console.WriteLine("Hata:Sayı olmayan giriş yapıldı, reddedildi.");
                }
                else if (gun < 1 || gun > 7)
                {
                    Console.WriteLine("Hata:1 ile 7 aralığı dışındaki girişler reddedildi.");
                }
                else if (oduncteMi)
                {
                    Console.WriteLine("Hata: Ekipman ödünçte olduğu için talep reddedildi.");
                }
                else
                {
                    Console.WriteLine($"Talebiniz onaylandı. {gun} gün süreyle verildi.");
                    devamEt = false;
                }

            }




        }
    }
}
