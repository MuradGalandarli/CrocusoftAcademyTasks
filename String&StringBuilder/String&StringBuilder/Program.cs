
/*
1.Istifadeci terefinden bir cumle daxil olunur cumleni duzgun formata getiren method yazin.
    Cumlenin ortalarinda yalniz bir boshluq olmalidir ve her soz boyuk herfle bashlamali 
    diger herfleri kicik olmalidir. Yaddasha mumkun qeder qenaet etmeye clashin. Meselen:
input: "        EverytHing i neeD,is a CuP of CoFFee    "
output: "Everything I Need, Is A Cup Of Coffee"

*/


/*string input =  "        EverytHing  i neeD,    is a CuP   of       CoFFee    ";
Edit(input);
void Edit(string input)
{
    var trim = input.Trim();
    var data = trim.Split(' ');
 

    foreach (var item in data)
    {  
        var trim1 = item.Trim();
        var toLower = trim1.ToLower();
        var subString = toLower.Substring(1);
        var Uppper = subString.Insert(0, trim1[0].ToString().ToUpper());
        Console.Write($"{Uppper} ");
    }
}
*/









/*

2. Product classi yaradirsiz:
 Id
 BrandName, 
 Model,
 Price,
 Cost , - xercleri   
 Income, - umumi gelir
 Count - mehsulun sayi
 fieldleri olur. Constructor ishe dushdukde Income ve Id-den bashqa butun deyerleri qebul edir.
(Income 0-dan bashliyib mehsul satildiqca artacaq. Count menfi ola bilmez. Menfi gonderilerse 0 verilsin).
Id-ni ctor ishe dushdukde(yəni constructorun icerisinde) BrandName ilk 2 simvolunu Modelin ilk 2 
simvolunu birleshdirerek teyin edirsiz. Meselen( Brand adi : Apple, Model:Iphone13 dirse Id:ApIp olmalidir )
 
GetInfo() methodu olur.

Sale() methodu olur.Eger kifayet qeder mehsul varsa Satishi heyata kecirir satilan qiymetden xercler
cixilaraq gelire elave edir ve mehsul sayini azaldir.
----------------------------------------------------------------------------
Phone classi yaradirsiz Product-dan miras alib, Product ctorun teleb etdiyi deyerleri gondermelidir.
Phone class-da:
 
RAM,
Color,
Balance
fieldleri var.Balance constructor ishe dushdukde 0-a beraber olur.Color gonderilmese default 
olaraq BLack deyerini goturur gonderilirse gonderilen deyeri menimsedilir. Diger deyerler 
gonderilmemish yarana bilmez

Call( seconds) methodu yaradirsiz. Seconds qebul edir danishigin saniyesinden asili olaraq 
her saniyeye gore balansdan 0.1 deyer cixilir.Zengden evvel balansda zeng ucun kifayet qeder
vesait varmi yoxlanmalidir eger varsa ekrana zeng edildi yoxdursa balansda kifayet qeder vesait 
qalmiyib yazisini cixarin.

Pay(money) methodu yaradirsiz. Money qebul edir balansi gonderilen deyer qeder artirir
-------------------------------------------------------------------------------
-------------------------------------------------------------------------------
Notebookclassi yaradirsiz Product-dan miras alib, Product ctorun teleb etdiyi deyerleri gondermelidir.
Notebook class-da:


OpSystem,
Processor,
HasGraphicCard    (boolean titpinden)
fieldleri olur ctor ishe dushdukde. HasGraphicCard-dan bashqa butun deyerler gonderilmelidir.
HasGraphic gonderilsede olar gonderilmesede(overload).*/

using String_StringBuilder;

Product product = new Product("Apple","Iphone15",1360,1000,5);
product.GetInfo();
product.Sale("Apple", "Iphone15", 1205, 1);

// void Sale(string BrandName, string Model, decimal Price, int sellCount)

/*
string BrandName = "";
string Model = "";
decimal Price = 0;
decimal Cost = 0; // Cost, - xercleri
public int Count = 0;  // - mehsulun sayi*/

Phone phone = new Phone("Apple", "Iphone15", 1360, 1000, 5,"16ax","Ag");
phone.GetInfo();
phone.Call(50);
phone.Pay(1);
phone.Call(50);
phone.Sale("Apple", "Iphone15", 1205, 1);
phone.GetInfo();
//Notebook notebook = new Notebook("Apple", "Iphone15", 1360, 1000, 5, "Window","XRW78",true);

/*string OpSystem;
string Processor;
bool HasGraphicCard;
*/

/*notebook.GetInfo();*/