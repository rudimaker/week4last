

using week4last;

Console.WriteLine("SEÇİMİNİZİ YAPINIZ 1- TELEFON 2- PC 1/2 )");
int  tercih = Convert.ToInt32(Console.ReadLine());


if (tercih == 1)
{
    Telefon tlf = new Telefon();

    Console.WriteLine("Seri no giriniz");
    tlf.SeriNo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Telefon adını giriniz");
    tlf.Ad = Console.ReadLine();

    tlf.Kayıt();


}
