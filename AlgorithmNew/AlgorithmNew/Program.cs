/*
Userden daxil edilən 25 ədəd arasında mənfi ədədlərin cəmi,
Cüt ədədlərin hasilini və 7-yə bərabər olan ədədlərin sayını tapın və onları ekranda göstərin.
Çap proqramının alqoritmini və hərəkət sxemini(Flowchart) çəkin.
*/
/*
int input = 0;
bool IsSuccess = false;

int negative = 0;
int productOfMultiples = 1;
int counter = 0;

var result = (0, 0, 0);

var data = Console.ReadLine();
var a = data.Split(",").ToArray();

foreach (var i in a.ToArray())
{
     IsSuccess = int.TryParse(i, out input);
    if (IsSuccess)
    result = mathFunction(input);
}
Console.WriteLine($"Menfi ededlerin cemi: {result.Item1},Cut ededlerin hasili {result.Item2},7- ye beraber olan ededlerin sayi {result.Item3}");



(int negative, int productOfMultiples, int counter) mathFunction(params int[] arr)
{
    for (int i = 0; i <= arr.Length-1; i++)
    {
        if (arr[i] < 1)
        {
            negative += arr[i];
        }
        if (arr[i] % 2 == 0 && arr[i] > 0)
        {
            productOfMultiples *= arr[i];
        }
            if (arr[i] == 7)
            {
                counter++;
            }
        

    }
    return (negative, productOfMultiples, counter);
}

*/

/*10 elementli arrayda bu arrayin ən kiçik elementi hansıdır?
Elementi tapan proqramın alqoritmi və hərəkət sxemi
çəkmək(Flowchart).
*/

///////////////////////////////////////////////////////////////////
/*
int[] ar = {4,8,9,78,5,6,8,3,45,2 };

Console.WriteLine(Min(ar));
int Min(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}*/

//////////////////////////////////////////////////////////////////////

/*
10 ilə 1000 arasında kvadrat ədədləri çap edən proqram
*/
/*Square();

void Square()
{
   for (int i = 10; i < 1000; i++)
    {
        Console.WriteLine($"Eded: {i}");
        Console.WriteLine($"Kvadrati: {i*i}");
    }
}*/

//////////////////////////////////////////////////////////////////////////////
///
/*
Quick Sort(Tez çeşidləmə/siralama) alqoritmini yerinə yetirən proqram
*/
/*
 * int[] ar = { 4, 8, 9, 78, 5, 6, 8, 3, 45, 2 };


for (int i =0;i<ar.Length;i++)
{
    int pivot = ar[i];
    for(int j =0;j<ar.Length;j++)
    {
        if (ar[j] < pivot)
        {
            int temp;
            temp = ar[j];
            ar[j] = ar[i];
            ar[i] = temp;

        }
        if (ar[j] > pivot)
        {
            int temp;
            temp = ar[j];
            ar[j] = ar[i];
            ar[i] = temp;
        }
    }

}
*//*
2
6
3
5
9
4
8
8
45
78
*//*
foreach (int i in ar)
{
    Console.WriteLine(i);
}*/

/*int[] ar = { 4, 8, 9, 78, 5, 6, 8, 3, 45, 2 };


for (int i = 0; i < ar.Length; i++)
{
    int pivot = ar[0];
    for (int j = 0; j < ar.Length; j++)
    {
        if (ar[j] < pivot)
        {
            int temp;
            temp = ar[i];
            ar[i] = ar[j];
            ar[j] = temp;

        }
        if (ar[j] > pivot)
        {
            int temp;
            temp = ar[j];
            ar[j] = ar[i];
            ar[i] = temp;
        }
    }

}
*//*
2
6
3
5
9
4
8
8
45
78
*//*
foreach (int i in ar)
{*/
 /*   Console.WriteLine(i);
}*/