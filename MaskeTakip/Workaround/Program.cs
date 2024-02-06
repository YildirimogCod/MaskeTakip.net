
//SelamVer("Oğuzhan");
//SelamVer("Kağan");
//SelamVer();
//int sonuc = Topla();
//int sonuc2 = Topla2(3,4);
//Console.WriteLine(sonuc2);
//Console.WriteLine(sonuc);

//List<string> list = new List<string>();
//list.Add("İstanbul");
//list.Add("Ankara");

//foreach (string city in list)
//{
//    Console.WriteLine(city);
//}

using Business.Concrete;
using Entities.Concrete;


Person person = new Person();
person.Name = "Oğuzhan";
person.LastName = "Yıldırım";
person.DateOfBirthYear = 2000;
person.NationalIdentity = 469691048;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);
//static void SelamVer(string name = "undefined")
//{
//    Console.WriteLine("Merhaba " + name);
//}

//static int Topla()
//{
//    return 5;
//}

//static int Topla2(int n1,int n2)
//{
//    return n1 + n2;
//}