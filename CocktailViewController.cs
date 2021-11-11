using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace myCocktailApp
{
    public partial class CocktailViewController : UITableViewController
    {
        public  List<Cocktail> cocktailList { get; set; }
        public CocktailViewDataSource cocktailViewDataSource;

        public CocktailViewController(IntPtr handle) : base(handle)
        {

            TableView.RegisterClassForCellReuse(typeof(UITableViewCell), "CellId");
            TableView.Source = new CocktailViewDataSource(this);
            cocktailViewDataSource = new CocktailViewDataSource(this);

        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
       
        }


    }
}