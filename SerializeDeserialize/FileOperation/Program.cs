using System.IO.Enumeration;
using System.Numerics;

namespace FileOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            elave olaraq File ve Directorynin metodlari ile emeliyatlar aparirsiz(yarat sil yaz oxu ve s.)
*/

            string filePath = @"C:\\TaskCreateFile/test";
            
            var folderName = Path.GetDirectoryName(filePath);

            if(!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);    
            }
            string fileName = Path.GetFileName(filePath);
            if(!File.Exists(fileName))
            {
                File.CreateText(fileName);
            }
            //File.WriteAllText(filePath, "Salam");
            File.Delete(filePath);




        }
    }
}
