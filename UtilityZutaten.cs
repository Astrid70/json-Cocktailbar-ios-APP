using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Foundation;
using Newtonsoft.Json.Linq;
using UIKit;

namespace myCocktailApp
{
    public class UtilityZutaten
    {

        static string imageUrl = "https://thecocktaildb.com/images/ingredients/";
        static string imageUrlsuffix = "-Small.png";

        public UtilityZutaten()
        {
        }

        //Methode liest ein jsonFile mit einer Api aus der CoktailDB

        public string getRequest(string nameZutat)
        {
            
                //Erstelt einen Request mit der gesuchten Zutat
                var request = WebRequest.Create(string.Format(@"https://thecocktaildb.com/api/json/v1/1/search.php?i={0}", nameZutat));

                request.ContentType = "application/json";
                request.Method = "GET";


                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    // StatusCode nicht OK dann Fehlermeldung
                    if (response.StatusCode != HttpStatusCode.OK)
                        return "Error fetching data. Server returns status code " + response.StatusCode;

                    else
                    {
                        using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                        {
                            //Auslesen des json Files
                            var content = reader.ReadToEnd();
                            if (string.IsNullOrWhiteSpace(content))
                                return "Respnse contained empty body";
                            else
                                return content;
                        }

                    }
                }
            
            
        }

        public List<Zutaten> jsonGetZutat(string nameZutat)
        {
            List<Zutaten> zutatenListe = new List<Zutaten>();


            var content = getRequest(nameZutat);
            var resultObjects = AllChildren(JObject.Parse(content));



            //Liest das JsonFile aus mit dem
            //Pfad mit dem Wort "ingredients"
            var firstResultObject = resultObjects.First(child => child.Type == JTokenType.Array && child.Path.Contains("ingredients"));
            firstResultObject.Children<JObject>();

            //jasonFile Elemente in Liste speichern
            foreach (JObject result in firstResultObject)
            {
                Zutaten zutat = result.ToObject<Zutaten>();
                zutat.uiZutatenImage = imageFromUrl(imageUrl + zutat.strIngredient + imageUrlsuffix);
                zutatenListe.Add(zutat);

            }

            return zutatenListe;
        }



        //alle Knotenpunkte im Objekt  erreichen
        private static IEnumerable<JToken> AllChildren(JToken jToken)
        {
            foreach (var child in jToken.Children())
            {
                yield return child;
                foreach (var childchild in AllChildren(child))
                    yield return childchild;
            }
        }


        private UIImage imageFromUrl(string uri)
        {
            //Aus String eine Url bauen
            using (var url = new NSUrl(uri))
            {
                //Daten aus Url holen
                using (var data = NSData.FromUrl(url))
                    //Rueckgabe eines UIImage anhand der Daten
                    return UIImage.LoadFromData(data);
            }
        }

    }
}
