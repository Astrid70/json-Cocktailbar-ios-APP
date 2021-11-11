using System;
using UIKit;

namespace myCocktailApp
{
    public class Cocktail
    {

        //Attribute
        public string idDrink { get; set; }
        public string strDrink { get; set; }
        public string strDrinkAlternate { get; set; }
        public string strTag { get; set; }
        public string strVideo { get; set; }
        public string strCategory { get; set; }
        public string strIBA { get; set; }
        public string strAlcoholic { get; set; }
        public string strGlass { get; set; }
        public string strInstructions { get; set; }
        public string strInstructionsES { get; set; }
        public string strInstructionsDE { get; set; }
        public string strInstructionsFR { get; set; }
        public string strInstructionsIT { get; set; }
        public string strInstructionsZH_HANS { get; set; }
        public string strInstructionsZH_HANT { get; set; }
        public string strDrinkThumb { get; set; }
        public string strIngredient1 { get; set; }
        public string strIngredient2 { get; set; }
        public string strIngredient3 { get; set; }
        public string strIngredient4 { get; set; }
        public string strIngredient5 { get; set; }
        public string strIngredient6 { get; set; }
        public string strIngredient7 { get; set; }
        public string strIngredient8 { get; set; }
        public string strIngredient9 { get; set; }
        public string strIngredient10 { get; set; }
        public string strIngredient11 { get; set; }
        public string strIngredient12 { get; set; }
        public string strIngredient13 { get; set; }
        public string strIngredient14 { get; set; }
        public string strIngredient15 { get; set; }
        public string strMeasure1 { get; set; }
        public string strMeasure2 { get; set; }
        public string strMeasure3 { get; set; }
        public string strMeasure4 { get; set; }
        public string strMeasure5 { get; set; }
        public string strMeasure6 { get; set; }
        public string strMeasure7 { get; set; }
        public string strMeasure8 { get; set; }
        public string strMeasure9 { get; set; }
        public string strMeasure10 { get; set; }
        public string strMeasure11 { get; set; }
        public string strMeasure12 { get; set; }
        public string strMeasure13 { get; set; }
        public string strMeasure14 { get; set; }
        public string strMeasure15 { get; set; }
        public string strImageSource { get; set; }
        public string strImageAttribution { get; set; }
        public string strCreativeCommonsComfirmed { get; set; }
        public string dateModified {get;set;}

        public UIImage uiCoktailImage { get; set; }

        public Cocktail()
        {
        }

        public Cocktail(string idDrink, string strDrink, string strDrinkAlternate, string strTag, string strVideo, string strCategory, string strIBA, string strAlcoholic, string strGlass, string strInstructions, string strInstructionsES, string strInstructionsDE, string strInstructionsFR, string strInstructionsIT, string strInstructionsZH_HANS, string strInstructionsZH_HANT, string strDrinkThumb, string strIngredient1, string strIngredient2, string strIngredient3, string strIngredient4, string strIngredient5, string strIngredient6, string strIngredient7, string strIngredient8, string strIngredient9, string strIngredient10, string strIngredient11, string strIngredient12, string strIngredient13, string strIngredient14, string strIngredient15, string strMeasure1, string strMeasure2, string strMeasure3, string strMeasure4, string strMeasure5, string strMeasure6, string strMeasure7, string strMeasure8, string strMeasure9, string strMeasure10, string strMeasure11, string strMeasure12, string strMeasure13, string strMeasure14, string strMeasure15, string strImageSource, string strImageAttribution, string strCreativeCommonsComfirmed, string dateModified)
        {
            this.idDrink = idDrink;
            this.strDrink = strDrink;
            this.strDrinkAlternate = strDrinkAlternate;
            this.strTag = strTag;
            this.strVideo = strVideo;
            this.strCategory = strCategory;
            this.strIBA = strIBA;
            this.strAlcoholic = strAlcoholic;
            this.strGlass = strGlass;
            this.strInstructions = strInstructions;
            this.strInstructionsES = strInstructionsES;
            this.strInstructionsDE = strInstructionsDE;
            this.strInstructionsFR = strInstructionsFR;
            this.strInstructionsIT = strInstructionsIT;
            this.strInstructionsZH_HANS = strInstructionsZH_HANS;
            this.strInstructionsZH_HANT = strInstructionsZH_HANT;
            this.strDrinkThumb = strDrinkThumb;
            this.strIngredient1 = strIngredient1;
            this.strIngredient2 = strIngredient2;
            this.strIngredient3 = strIngredient3;
            this.strIngredient4 = strIngredient4;
            this.strIngredient5 = strIngredient5;
            this.strIngredient6 = strIngredient6;
            this.strIngredient7 = strIngredient7;
            this.strIngredient8 = strIngredient8;
            this.strIngredient9 = strIngredient9;
            this.strIngredient10 = strIngredient10;
            this.strIngredient11 = strIngredient11;
            this.strIngredient12 = strIngredient12;
            this.strIngredient13 = strIngredient13;
            this.strIngredient14 = strIngredient14;
            this.strIngredient15 = strIngredient15;
            this.strMeasure1 = strMeasure1;
            this.strMeasure2 = strMeasure2;
            this.strMeasure3 = strMeasure3;
            this.strMeasure4 = strMeasure4;
            this.strMeasure5 = strMeasure5;
            this.strMeasure6 = strMeasure6;
            this.strMeasure7 = strMeasure7;
            this.strMeasure8 = strMeasure8;
            this.strMeasure9 = strMeasure9;
            this.strMeasure10 = strMeasure10;
            this.strMeasure11 = strMeasure11;
            this.strMeasure12 = strMeasure12;
            this.strMeasure13 = strMeasure13;
            this.strMeasure14 = strMeasure14;
            this.strMeasure15 = strMeasure15;
            this.strImageSource = strImageSource;
            this.strImageAttribution = strImageAttribution;
            this.strCreativeCommonsComfirmed = strCreativeCommonsComfirmed;
            this.dateModified = dateModified;
        }
    }
    
}
