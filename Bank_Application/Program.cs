using System;
using System.Net.WebSockets;
using System.Xml;

namespace Bank_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Static useriniz olacaq username : "admin"; password: "admin"
 User login olduqda kredit menusu acilacaq
 3 secim olacaq : Kredit goturmek, Kredit odemek , hesabat
 Sizdə məbləğ , ay , faiz , ümumi ödəniləcək məbləğ və aylıq ödəniş deyə variable olacaq(kim istəsə özündən əlavə edə bilər).
 User Ay daxil edəcək . Daha sonra console userə faiz dərəcəsini göstərəcək
 İlk öncə proqram aylar üçün faizi hesablamalıdır, əgər userin daxil etdiyi müddət bir
 ildən azdırsa 12 % bir ildən çoxdursa 18 % ilə hesablanacaq.
 Daha sonra user məbləğ daxil edəcək.  
 Daha sonra console - da ümumi ödəniləcək məbləğ və aylıq ödəniş ekranda görünəcək.
 Əgər user kredit ödəmək seçsə , ekrana "kredit ödəmək üçün 1-i seçin" və user 1 - ə clicklədikdə ümumi məbləğdən aylıq ödəniş çıxılmalıdır və 
                 qalan ay bir vahid azalmalıdır.
 Əgər user Hesabat bölməsinə keçsə 1.Ümumi ödəniləcək məbləğ
 2.Qalan ay
 3.Aylıq ödəniş məlumatlarını görməlidir.
 Əlavə funksiya yazmaq istəyən olsa yaza bilər.Amma minimum bu tələblər qarşılanmalıdır.
 Bunun flowchartları da yazılmalıdır.*/


            string userName = "admin";
            string password = "admin";

            Console.WriteLine("Istifadeci adinizi girin");
            string UserName = Console.ReadLine();
            Console.WriteLine("Sifrenizi girin");
            string Password = Console.ReadLine();
            int month = 0;
            int interest = 0;
            decimal totalAmount = 0;
            decimal totalAmountReport = 0;
            decimal paid = 0;
            decimal montmonthlyPaymenth = 0;



            if (UserName == userName && Password == password)
            {
                int operation = 0;
                bool IsSuccess = false;
                bool IsContinue = true;

                while (IsContinue)
                {
                    InfoMessage();


                    IsSuccess = int.TryParse(Console.ReadLine(), out operation);
                    IsContinue = false;


                    if (IsSuccess && operation <= 3)
                    {
                        switch (operation)
                        {
                            case 1:
                                {
                                    bool IsOkey = true;

                                    while (IsOkey)
                                    {
                                        Console.WriteLine("Kredit muddetini 1 - 12 ay araliginda secseniz 12% ile alacaqsiz,eks hallda 18% ile alacaqsiniz ");
                                        Console.WriteLine("Kredit muddetini girin");
                                        bool isSuccessMonth = int.TryParse(Console.ReadLine(), out month);
                                        Console.WriteLine("Almaq istediyiniz meblegi girin");
                                        bool isSuccessPaid = decimal.TryParse(Console.ReadLine(), out paid);
                                        (bool Passes, decimal prezent, decimal pay) accruedInterest = (false, 0, 0);
                                        if (isSuccessMonth && isSuccessPaid)
                                        {
                                            accruedInterest = TakeCredit(month, paid);
                                        }
                                        if (accruedInterest.Passes)
                                        {
                                            totalAmountReport = accruedInterest.prezent;
                                            Console.WriteLine($"Nece ay muddetine: {month}");
                                            Console.WriteLine($"Ayliq denis: {accruedInterest.pay}");
                                            Console.WriteLine($"Odenilecek total mebleg: {accruedInterest.prezent}");
                                            Console.WriteLine("*********************************************************");
                                            Console.WriteLine("Kredit verilsin: He ve ya yox qeyd edin ");
                                            string TrueOrFalse = Console.ReadLine();

                                            if (TrueOrFalse.ToUpper() == "HE")
                                            {
                                                IsOkey = false;
                                                IsContinue = true;
                                                Console.WriteLine("Program baglansin: He ve ya yox girin");
                                                string isContinuePay = Console.ReadLine();

                                                if (isContinuePay.ToUpper() == "HE")
                                                {
                                                    IsContinue = false;

                                                }
                                                else
                                                {
                                                    IsContinue = true;
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Xeta oldu");
                                                IsOkey = false;
                                                IsContinue = true;
                                            }


                                        }
                                    }
                                    break;
                                }

                            case 2:
                                {

                                    Console.WriteLine("Xayis edirik ayliq odenisnizden az olmayaraq odenis edesiz");
                                    Console.WriteLine($"Odenilecek mebleg :{montmonthlyPaymenth}");
                                }
                                Console.WriteLine("Zehmet olmasa meblegi daxil edin ");
                                decimal pay = 0;
                                bool ISuccessPay = decimal.TryParse(Console.ReadLine(), out pay);
                                if (pay >= montmonthlyPaymenth && ISuccessPay)
                                {
                                    Console.WriteLine("Odenis olundu");
                                    Console.WriteLine($"Daxil edilen mebleg: {pay}");
                                    Console.WriteLine($"Qaliq borcunuz: {totalAmount -= montmonthlyPaymenth}");

                                }
                                else
                                {
                                    Console.WriteLine("Odenis olunmadi");
                                    Console.WriteLine("Zehmet olmasa odenis miqdarini duzgun edin");
                                }



                                IsContinue = true;
                                Console.WriteLine("Program baglansin: He ve ya yox girin");
                                string isContinue = Console.ReadLine();

                                if (isContinue.ToUpper() == "HE")
                                {
                                    IsContinue = false;

                                }

                                else
                                {

                                    IsContinue = true;
                                }

                                break;


                            case 3:
                                {
                                    decimal totalMonth = totalAmount / montmonthlyPaymenth;
                                    decimal totalMonthPay = totalAmountReport / montmonthlyPaymenth;

                                    Console.WriteLine("Odenis cedveli");
                                    Console.WriteLine($"Odenmeli olan toplam mebleg: {totalAmountReport}");
                                  //  Console.WriteLine($"Toplam odenis etmeli oldugunuz ay: {totalMonth}");
                                    Console.WriteLine($"Toplam odenis etmeli oldugunuz ay: {totalMonthPay}");
                                    Console.WriteLine($"Qaliq borcunuz: {totalAmount}");
                                    Console.WriteLine($"Ayliq odenisin miqdari: {montmonthlyPaymenth}");                                   
                                    Console.WriteLine($"Odenis etmeli oldugunuz aylarin sayi: {totalMonth}");
                                    Console.WriteLine($"Odenisni etdiyiniz aylarin sayi: {totalMonthPay - totalMonth}");

                                    Console.WriteLine("Program baglansin: He ve ya yox girin");
                                    string isContinueReport = Console.ReadLine();

                                    if (isContinueReport.ToUpper() == "HE")
                                    {
                                        IsContinue = false;

                                    }

                                    else
                                    {

                                        IsContinue = true;
                                    }
                                }
                                break;
                        }
                    }
                }

            }


            (bool Passes, decimal prezent, decimal monthlyPay) TakeCredit(int month, decimal paid)
            {
                bool Passes = false;
                if (month <= 12)
                {
                    totalAmount = paid + (paid * 12) / 100; //1.2
                    Passes = true;
                }
                else
                {
                    totalAmount = paid + (paid * 18 / 100);
                    Passes = true;
                }
                montmonthlyPaymenth = totalAmount / month;
                return (Passes, totalAmount, montmonthlyPaymenth);
            }

            void InfoMessage()
            {
                Console.WriteLine(" Kredit goturmek ucun 1 duymesini sixin");
                Console.WriteLine(" Kredit odemek ucun 2 duymesini sixin");
                Console.WriteLine(" Hesabat almaq ucun 3 duymesini sixin");
            }




        }
    }
}