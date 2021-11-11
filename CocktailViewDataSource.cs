using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace myCocktailApp
{
    public class CocktailViewDataSource : UITableViewSource
    {
        public List<Cocktail> cocktailListe = new List<Cocktail>();
        CocktailViewController cocktailViewController;
        string cellIdentifier = "Cocktail";
        public Cocktail cocktail { get; set; }

        public Utility utility;

        public CocktailViewDataSource(CocktailViewController cocktailViewController)
        {
            this.cocktailViewController = cocktailViewController;
            this.cocktailListe = CocktailController.cocktailListstatic;
            utility = new Utility();
        }


        //GetCell bestimmt das Layout der TableView Zellen und
        //wird automatisch aufgerufen, wenn die TableView geladen wird
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {

            //Zellen beim Scrollen nachladen
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);

            //wenn wir kein cell-Objekt da ist, wird eine neues cellObjekt angelegt
            if (cell == null)
                cell = new UITableViewCell(UITableViewCellStyle.Subtitle, cellIdentifier);

            //Ausgabe des Coktailnamens
            cell.TextLabel.Text = cocktailListe[indexPath.Row].strDrink;

            //Ausgabe des verschiedenes Eigenschaften des Coktails
            cell.DetailTextLabel.Text = cocktailListe[indexPath.Row].strCategory + " , " + cocktailListe[indexPath.Row].strGlass + " , "
                + cocktailListe[indexPath.Row].strAlcoholic;
            // setzt die Hintergrundfarbe der Zelle bei Alkoholisch auf blau und bei nicht-alkoholisch auf gruen


            if (cocktailListe[indexPath.Row].strAlcoholic == "Alcoholic")
                cell.BackgroundColor = UIColor.LinkColor;
            else if (cocktailListe[indexPath.Row].strAlcoholic == "Non alcoholic")
                cell.BackgroundColor = UIColor.Green;

            cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
            //Rueckgabe der Zelle
            return cell;
        }

        //Anzahl Zellen in der TableView
        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return cocktailListe.Count;
        }


        //wird eine zeile angeklickt wird die Detailview des Cocktails aufgerufen
        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {

            //prueft wie das JasonFile gelesen wurde, fehlen die detailView-Attribute werden diese 
            // nochmals mit der Cocktail-Id gelesen
            if (cocktailListe[indexPath.Row].strInstructions == null)
            {
                CocktailController.jasonTodoFlag = 4;
                List<Cocktail> cocktailListAdd = new List<Cocktail>();
                cocktailListAdd = utility.jsonGetCocktail(cocktailListe[indexPath.Row].idDrink);

                DetailViewCocktail detailViewCocktail = cocktailViewController.Storyboard.InstantiateViewController("DetailViewCocktail") as DetailViewCocktail;
                detailViewCocktail.cocktail = cocktailListAdd[0];
                cocktailViewController.NavigationController.PushViewController(detailViewCocktail, true);
            }
            else
            {
                DetailViewCocktail detailViewCocktail = cocktailViewController.Storyboard.InstantiateViewController("DetailViewCocktail") as DetailViewCocktail;
                detailViewCocktail.cocktail = cocktailListe[indexPath.Row];
                cocktailViewController.NavigationController.PushViewController(detailViewCocktail, true);
            }

        }

        
    }
}
