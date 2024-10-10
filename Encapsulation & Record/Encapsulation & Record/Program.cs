namespace Encapsulation___Record
{
    /*
     * Animal yaradirsiz:   
        Gender, BirthYear property-leri olur.Gender dəyərini constructordan gələn dəyərdən
        götürməlidir.BirthYear ise constructor işə düşdükdə dinamik olaraq hal-hazırdakı 
        ili(2023 yazmaginiz kifayetdir) götürməlidir və təyin olunduqdan sonra dəyişdirilə bilməz.

    Dog yaradırsız: 
    Name, Breed(yəni sortu  misal: Golden Retriever) property-ləri olur.Animal-dan inheritence alır.
        Name və Breed constructordan gəlir.
    Breed təyin olunduqdan sonra dəyişdirilə bilməməlidir.
    Qeyd: Butun propertylere uygun fieldler yaradin.Duzgun yoxlamalari aparin.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
          //  Animal animal = new Animal();
            Dog dog = new Dog("Male", "Golden", "Retriever");
            dog.DogInfo();
            Animal animal = new Animal("Male");
            animal.AnimalInfo();
        }
    }
}