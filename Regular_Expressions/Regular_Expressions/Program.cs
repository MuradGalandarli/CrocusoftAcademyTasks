using System.Globalization;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Tapşırıq 1: Rəqəmləri tapmaq
            Məqsəd: Verilən mətndəki bütün rəqəmləri tapmaq.*/

            /*  string search =  @"[\d/]";
              Regex regex = new Regex(search);
              string text = "Salam5 dunya";
              Match match = regex.Match(text);
              Console.WriteLine(match.Success);*/

            //////////////////////////////////////////////////////////////////////////////////
            ///

            /* Tapşırıq 2: Azərbaycan dilində e - poçt ünvanını doğrulamaq
             Məqsəd: Verilən e-poçt ünvanının düzgün formatda olub olmadığını yoxlamaq.*/
            /*
                        //string checkEmail2 = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                        string checkEmail1 = @"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                        string email1 = "mqelenderliq25     @gmail.com";
                        /// string email2 = "mqelenderliq25@ gmail.coma  ";
                        Regex regex = new Regex(checkEmail1);
                        Match match = regex.Match(email1);
                        Console.WriteLine(match.Success);*/

            //////////////////////////////////////////////////////////////////////////////////////////
            /*
                        Tapşırıq 3: Azərbaycan mobil nömrələrini yoxlamaq
                        Məqsəd: Verilən nömrənin Azərbaycan mobil nömrə formatına uyğun olub olmadığını yoxlamaq.
            */

            /*string search = "^(?:\\+994)?\\s?\\(?\\d{2}\\)?[-.\\s]?\\d{3}[-.\\s]?\\d{4}$";
            Regex regex = new Regex(search);
            string text = "+994556468623";
            Match match = regex.Match(text);
            Console.WriteLine(match.Success);
*/

            /////////////////////////////////////////////////////////////////////////////////////////////////

            /* Tapşırıq 4: Müəyyən sözü mətndə tapmaq
             Məqsəd: Mətndə müəyyən bir sözün olub - olmadığını yoxlamaq(məsələn, “salam”).*/

            /*string searchWord = " find";
            string pattern = @"\b\" + searchWord + @"\b";   
            Regex rgx = new Regex(pattern);
            var sentence = "I need to find a string in this sentence!";
            Match match = rgx.Match(sentence);
            Console.WriteLine(match.Success);*/

            //////////////////////////////////////////////////////////////////////////////


            /*Tapşırıq 6: Tarix formatı yoxlama
            Məqsəd: Verilən tarix dəyərinin dd/ MM / yyyy formatında olub olmadığını yoxlamaq.*/


            /*string checkTime = "30/11/2024";
            string validationFormat = "^(0?[1-9]|[12][0-9]|3[01])[\\/\\-](0?[1-9]|1[012])[\\/\\-]\\d{4}$";
            Regex regex = new Regex(validationFormat); 
            Match match = regex.Match(checkTime);
            Console.WriteLine(match.Success);*/





        }
    }
}
