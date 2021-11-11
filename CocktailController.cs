using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace myCocktailApp
{
    public partial class CocktailController : UIViewController
    {

        public Utility utility;
        public UtilityZutaten utilityZutaten;
        public NSUserDefaults pList;
        public static List<Cocktail> cocktailListstatic { get; set; }
        public List<Zutaten> zutatenListe { get; set; }
        public static int jasonTodoFlag;

        public CocktailController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
          
            utility = new Utility();
            utilityZutaten = new UtilityZutaten();
         // dieses flag bestimmt welche Verarbeitung bzw. was aus dem Jason-File gelesen werden soll
            jasonTodoFlag = 0;
            this.View.BackgroundColor = UIColor.Purple;
            txtCocktailBuchstabe.BackgroundColor = UIColor.LightGray;
            txtCocktailName.BackgroundColor = UIColor.LightGray;
            btnCocktailSuche.BackgroundColor = UIColor.DarkGray;
            btnNichtAlkoholisch.BackgroundColor = UIColor.DarkGray;
            btnAlkoholisch.BackgroundColor = UIColor.DarkGray;
            btnSucheBuchstabe.BackgroundColor = UIColor.DarkGray;
            btnZutatCocktail.BackgroundColor = UIColor.DarkGray;
            btnZutat.BackgroundColor = UIColor.DarkGray;
            txtCocktailZutat.BackgroundColor = UIColor.LightGray;
            txtZutat.BackgroundColor = UIColor.LightGray;
            btnRandom.BackgroundColor = UIColor.DarkGray;


            //lese Bilder aus Url
            imageTop.Image = imageFromUrl("https://thecocktaildb.com/images/ingredients/rum-Medium.png");
            imageTop2.Image = imageFromUrl("https://thecocktaildb.com/images/ingredients/wine-Medium.png");


        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
                       
        }   
        

        partial void BtnCocktailSuche_TouchUpInside(UIButton sender)
        {

            if (txtCocktailName.Text == "")
            {
                //Infodialog erstellen
                errrDialog();
            }

            else
            {
                jasonTodoFlag = 1;
                cocktailListstatic = new List<Cocktail>();
                try
                {
                    cocktailListstatic = utility.jsonGetCocktail(txtCocktailName.Text);
                }
                catch
                {
                    noCocktailsFoundDialog();

                }
            }
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            CocktailViewController cocktailViewController = segue.DestinationViewController as CocktailViewController;

            if (cocktailViewController != null)
                cocktailViewController.cocktailList = cocktailListstatic;



        }

        partial void BtnSucheBuchstabe_TouchUpInside(UIButton sender)
        {
            if (txtCocktailBuchstabe.Text == "")
            {
                //Infodialog erstellen
                errrDialog();
            }

            else
            {
                try
                {
                    // pruft ob nur eine Buchstabe eingegeben wurde, also ob das Paren funktioniert
                    char buchstabe = char.Parse(txtCocktailBuchstabe.Text);
                    jasonTodoFlag = 2;
                    cocktailListstatic = new List<Cocktail>();
                    cocktailListstatic = utility.jsonGetCocktail(txtCocktailBuchstabe.Text);
                }
                catch
                {
                    //Infodialog erstellen
                    var alert = UIAlertController.Create("Fehler", "Bitte  geben Sie nur einen Buchstaben ein!",
                                                        UIAlertControllerStyle.Alert);
                    alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
                    PresentViewController(alert, true, () =>
                    {
                        Console.WriteLine("Infodialog geöffnet");
                    });
                }
            }
        }
        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            //gibt die Tastatur fuer die Textfelder frei oder entfernt sie bei klich auf eine ander Fl>che als die Textfelder
            txtCocktailBuchstabe.ResignFirstResponder();
            txtCocktailName.ResignFirstResponder();
            txtCocktailZutat.ResignFirstResponder();
            txtZutat.ResignFirstResponder();

        }

        partial void BtnZutatCocktail_TouchUpInside(UIButton sender)
        {
            if (txtCocktailZutat.Text == "")
            {
                //Infodialog erstellen
                errrDialog();
            }

            else
            {
                jasonTodoFlag = 3;
                cocktailListstatic = new List<Cocktail>();
                try
                {

                    cocktailListstatic = utility.jsonGetCocktail(txtCocktailZutat.Text);
                }
                catch
                {
                    noCocktailsFoundDialog();

                }
            }

        }

        partial void BtnZutat_TouchUpInside(UIButton sender)
        {
            if (txtZutat.Text == "")
            {
                //Infodialog erstellen
                errrDialog();
            }

            else
            {
                zutatenListe = new List<Zutaten>();
                try
                {
                    zutatenListe = utilityZutaten.jsonGetZutat(txtZutat.Text);

                    if (zutatenListe.Count != 0)
                    {
                        // wude die Zutat gefunden wird die Detailview der Zutat ge<ffnet
                        ZutatenViewController zutatenViewCocktail = this.Storyboard.InstantiateViewController("ZutatenViewController") as ZutatenViewController;
                        zutatenViewCocktail.zutat = zutatenListe[0];
                        this.NavigationController.PushViewController(zutatenViewCocktail, true);
                    }
                    else
                    {
                        noZutatFoundDialog();
                    }
                }

                catch
                {
                    noZutatFoundDialog();

                }
            }
            

        }

        public void errrDialog()
        {
            //Infodialog erstellen
            var alert = UIAlertController.Create("Fehler", "Bitte  geben Sie einen Wert ein!",
                                                UIAlertControllerStyle.Alert);
            alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            PresentViewController(alert, true, () =>
            {
                Console.WriteLine("Infodialog geöffnet");
            });

        }

        public void noCocktailsFoundDialog()
        {
            var alert = UIAlertController.Create("Fehler", "Es wurde kein Cocktail gefunden!",
                                                                       UIAlertControllerStyle.Alert);
            alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            PresentViewController(alert, true, () =>
            {
                Console.WriteLine("Infodialog geöffnet");
            });
        }

        public void noZutatFoundDialog()
        {
            var alert = UIAlertController.Create("Fehler", "Die Zutat wurde nicht gefunden!",
                                                                        UIAlertControllerStyle.Alert);
            alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            PresentViewController(alert, true, () =>
            {
                Console.WriteLine("Infodialog geöffnet");
            });

        }

        partial void BtnRandom_TouchUpInside(UIButton sender)
        {
            jasonTodoFlag = 5;
            cocktailListstatic = new List<Cocktail>();
            cocktailListstatic = utility.jsonGetCocktail(txtCocktailBuchstabe.Text);
        }

        partial void BtnNichtAlkoholisch_TouchUpInside(UIButton sender)
        {
            jasonTodoFlag = 6;
            cocktailListstatic = new List<Cocktail>();
            cocktailListstatic = utility.jsonGetCocktail(txtCocktailBuchstabe.Text);
        }

        partial void BtnAlkoholisch_TouchUpInside(UIButton sender)
        {
            jasonTodoFlag = 7;
            cocktailListstatic = new List<Cocktail>();
            cocktailListstatic = utility.jsonGetCocktail(txtCocktailBuchstabe.Text);
        }


        private UIImage imageFromUrl(string uri)
        {
            //Aus String eine Url erstellen
            using (var url = new NSUrl(uri))
            {
                //Daten aus Url holen
                using (var data = NSData.FromUrl(url))
                    //Rueckgabe eines UIImage 
                    return UIImage.LoadFromData(data);
            }
        }
    }
    }