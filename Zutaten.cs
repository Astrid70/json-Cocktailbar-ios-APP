using System;
using UIKit;

namespace myCocktailApp
{
    public class Zutaten
    {
        //Attribute
        public string idIngredient { get; set; }
        public string strIngredient { get; set; }
        public string strDescription { get; set; }
        public string strType { get; set; }
        public string strAlcohol { get; set; }
        public string strABV { get; set; }

        public UIImage uiZutatenImage { get; set; }

        public Zutaten()
        {
        }

        public Zutaten(string idIngredient, string strIngredient, string strDescription, string strType, string strAlcohol, string strABV)
        {
            this.idIngredient = idIngredient;
            this.strIngredient = strIngredient;
            this.strDescription = strDescription;
            this.strType = strType;
            this.strAlcohol = strAlcohol;
            this.strABV = strABV;
        }
    }
}
