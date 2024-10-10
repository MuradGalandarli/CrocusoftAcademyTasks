using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace String_StringBuilder
{
    public class Notebook:Product
    {
        /*Notebook classi yaradirsiz Product-dan miras alib, 
         * Product ctorun teleb etdiyi deyerleri gondermelidir.
        Notebook class-da:
        OpSystem,
        Processor,
        HasGraphicCard(boolean titpinden)
        fieldleri olur ctor ishe dushdukde.HasGraphicCard-dan bashqa butun deyerler gonderilmelidir.
                    HasGraphic gonderilsede olar gonderilmesede(overload).*/
        string OpSystem;
        string Processor;
        bool HasGraphicCard;
        public Notebook(string BrandName, string Model, decimal Price,
            decimal Cost, int Count, string OpSystem, string Processor, bool hasGraphicCard) :
            base(BrandName, Model, Price, Cost, Count)
        {
            this.OpSystem = OpSystem;
            this.Processor = Processor;
            this.HasGraphicCard = hasGraphicCard;
        }

    }
}
