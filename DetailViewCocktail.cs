using Foundation;
using System;
using UIKit;

namespace myCocktailApp
{
    public partial class DetailViewCocktail : UIViewController
    {
        public Cocktail cocktail { get; set; }
        

        public DetailViewCocktail(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            //befuellt alle Felder der View

            txtzubereitung.Text = cocktail.strInstructionsDE;

            // baut einen String fuer das Textfeld Zutaten
            string zutaten =
                cocktail.strIngredient1 + "\t" + cocktail.strMeasure1 + "\n" +
                cocktail.strIngredient2 + "\t" + cocktail.strMeasure2 + "\n" +
                cocktail.strIngredient3 + "\t" + cocktail.strMeasure3 + "\n" +
                cocktail.strIngredient4 + "\t" + cocktail.strMeasure4 + "\n" +
                cocktail.strIngredient5 + "\t" + cocktail.strMeasure5 + "\n" +
                cocktail.strIngredient6 + "\t" + cocktail.strMeasure6 + "\n" +
                cocktail.strIngredient7 + "\t" + cocktail.strMeasure7 + "\n" +
                cocktail.strIngredient8 + "\t" + cocktail.strMeasure8 + "\n" +
                cocktail.strIngredient9 + "\t" + cocktail.strMeasure9 + "\n" +
                cocktail.strIngredient10 + "\t" + cocktail.strMeasure10 + "\n" +
                cocktail.strIngredient11 + "\t" + cocktail.strMeasure11 + "\n" +
                cocktail.strIngredient12 + "\t" + cocktail.strMeasure12 + "\n" +
                cocktail.strIngredient13 + "\t" + cocktail.strMeasure13 + "\n" +
                cocktail.strIngredient14 + "\t" + cocktail.strMeasure14 + "\n" +
                cocktail.strIngredient15 + "\t" + cocktail.strMeasure15 + "\n";


            txtZutaten.Text = zutaten;
            imgCocktail.Image = cocktail.uiCoktailImage;

       
        }
    }
}