using Foundation;
using System;
using UIKit;

namespace myCocktailApp
{
    public partial class ZutatenViewController : UIViewController
    {
        public Zutaten zutat { get; set; }

        public ZutatenViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            lblZutatenName.Text = zutat.strIngredient;
            txtBeschreibung.Text = zutat.strDescription;
            lbltyp.Text = zutat.strType;

            //setzt den Switch entsprechend ob die Zutat alkoholisch ist oder nicht
            if (zutat.strAlcohol == "Yes")
                switchAlkohol.On = true;
            else
                switchAlkohol.On = false;

            imageZutat.Image = zutat.uiZutatenImage;
        }
    }
}