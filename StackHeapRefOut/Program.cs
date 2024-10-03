using System.Text;

namespace StackHeapRefOut
{
    internal class Program
    {
        static  void Main(string[] args)
        {


            #region Stack
            //int a = 100;
            //int b = a;

            //Console.WriteLine(a);//100
            //Console.WriteLine(b);//100

            //a = 99;

            //Console.WriteLine(b);//100

            //b = a;
            //Console.WriteLine(b);//50
            ////Value Type //Int, double , float,bool ve s.
            ////Referance Type
            //bool istrue = false;

            //bool isnull = istrue;


            //if(!istrue)//istru trudur
            //{
            //    Console.WriteLine("IsTrue truedur");
            //}
            //else
            //{
            //    Console.WriteLine("Istrue Falsedir");
            //}

            //if (isnull)//falsedir 
            //{
            //    Console.WriteLine("isnull truedur");
            //}
            //else
            //{
            //    Console.WriteLine("isnull Falsedir");
            //}

            //istrue = true;



            //if (!isnull)//
            //{
            //    Console.WriteLine("isnull truedur");
            //}
            //else
            //{
            //    Console.WriteLine("isnull Falsedir");
            //}
            #endregion

            #region Heap
            //937573214792
            //816596903000

            //string Car = "Mercedes";

            //string ElectroCar = "Tesla";

            //string* Car1 = &Car;

            //int a = 5;
            //int* aa = &a;

            ////Console.WriteLine(( ulong)Car1);
            //Console.WriteLine("Adres (Car): {0:X}", (ulong)&Car); 
            //Console.WriteLine("Adres (a): {0:X}", (ulong)aa);
            //int  = 42;          


            //int a = 5;
            //int* ptr = &a;

            //Console.WriteLine("Adres (hexadecimal format): {0:X}", (ulong)ptr);


            //Console.WriteLine("Adres (orijinal format): {0}", (ulong)ptr);
            //Console.WriteLine($"Adres (binary format): {Convert.ToString((long)(IntPtr)ptr, 2)}");

            //Console.WriteLine($"Adres (orijinal format): {((long)(IntPtr)ptr).ToString("b")}");



            //Console.WriteLine("Değer: {0}, Adres: {1:X}", *ptr, (ulong)(IntPtr)ptr);

            //string a = "Salam";//0001

            //string b = a;//0001

            //Console.WriteLine(a);//salam /fgrgrg
            //Console.WriteLine(b);//salam

            //a = "Sagol";//0002
            //Console.WriteLine(a);//sagol
            //Console.WriteLine(b);//salam




            //int[] arr = { 6, 2, 3, 4, 5 };
            //int[] abbb = { 1, 2, 3, 4, 6 };

            //arr = abbb;
            //abbb[0] = 5;
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(abbb[0]);


            //StringBuilder sb = new StringBuilder("salam"); 

            //StringBuilder sbs = sb;

            //sb.Append("mmm");

            //Console.WriteLine(sbs);
            //Console.WriteLine(sb);            
            #endregion




        }


      
    }
}