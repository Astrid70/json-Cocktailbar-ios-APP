// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace myCocktailApp
{
    [Register ("ZutatenViewController")]
    partial class ZutatenViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imageZutat { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lbltyp { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblZutatenName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch switchAlkohol { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView txtBeschreibung { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imageZutat != null) {
                imageZutat.Dispose ();
                imageZutat = null;
            }

            if (lbltyp != null) {
                lbltyp.Dispose ();
                lbltyp = null;
            }

            if (lblZutatenName != null) {
                lblZutatenName.Dispose ();
                lblZutatenName = null;
            }

            if (switchAlkohol != null) {
                switchAlkohol.Dispose ();
                switchAlkohol = null;
            }

            if (txtBeschreibung != null) {
                txtBeschreibung.Dispose ();
                txtBeschreibung = null;
            }
        }
    }
}