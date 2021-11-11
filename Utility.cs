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
    public class Utility
    {
        static string appid = "1";
        static string imageUrl = "https://images/media/drinks/vrwquq1478252802.jpg/preview";
        


        public Utility()
        {
        }

        //Methode liest ein jsonFile mit einer Api aus der CoktailDB
        
        public string getRequest(string nameCocktail)
        {
            if (CocktailController.jasonTodoFlag == 1)
            {
                //Erstelt einen Request mit dem gesuchten Cocktailnamen
                var request = WebRequest.Create(string.Format(@"https://thecocktaildb.com/api/json/v1/1/search.php?s={0}", nameCocktail));

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
            else if (CocktailController.jasonTodoFlag == 2)
            {
                char buchstabe = char.Parse(nameCocktail);
                //Erstelt einen Request mit dem gesuchten Buchstaben
                var request = WebRequest.Create(string.Format(@"https://thecocktaildb.com/api/json/v1/1/search.php?f={0}", buchstabe));

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

            else if (CocktailController.jasonTodoFlag == 3)
            {

                //Erstelt einen Request mit der gesuchten Zutat
                var request = WebRequest.Create(string.Format(@"https://thecocktaildb.com/api/json/v1/1/filter.php?i={0}", nameCocktail));

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

            else if (CocktailController.jasonTodoFlag == 4)
            {

                //Erstelt einen Request mit der Cocktail-ID
                var request = WebRequest.Create(string.Format(@"https://thecocktaildb.com/api/json/v1/1/lookup.php?i={0}", nameCocktail));

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

            else if (CocktailController.jasonTodoFlag == 5)
            {

                //Erstelt einen Request f|r einen zuf>lligen Coktail
                var request = WebRequest.Create(string.Format(@"https://thecocktaildb.com/api/json/v1/1/random.php"));

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

            else if (CocktailController.jasonTodoFlag == 6)
            {

                //Erstelt einen Request f|r nicht alkolische Coktails
                var request = WebRequest.Create(string.Format(@"https://thecocktaildb.com/api/json/v1/1/filter.php?a=Non_Alcoholic"));

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

            else 
            {

                //Erstelt einen Request f|r alkoholische Cktails
                var request = WebRequest.Create(string.Format(@"https://thecocktaildb.com/api/json/v1/1/filter.php?a=Alcoholic"));

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

        }

        public List<Cocktail> jsonGetCocktail(string nameCoktail)
        {
            List<Cocktail> coktailListe= new List<Cocktail>();


            var content = getRequest(nameCoktail);
           
            var resultObjects = AllChildren(JObject.Parse(content));

            

                //Liest das JsonFile aus mit dem
                //Pfad mit dem Wort "Drinks"
                var firstResultObject = resultObjects.First(child => child.Type == JTokenType.Array && child.Path.Contains("drinks"));
                firstResultObject.Children<JObject>();

                //jasonFile Elemente in Liste speichern
                foreach (JObject result in firstResultObject)
                {
                    Cocktail coktail = result.ToObject<Cocktail>();
                if (coktail.strDrinkThumb != null && CocktailController.jasonTodoFlag != 3)
                    coktail.uiCoktailImage = imageFromUrl(coktail.strDrinkThumb);
                if (CocktailController.jasonTodoFlag == 6)
                    coktail.strAlcoholic = "Non alcoholic";
                else if (CocktailController.jasonTodoFlag == 7)
                    coktail.strAlcoholic = "Alcoholic";
                    coktailListe.Add(coktail);

                }
                
                return coktailListe;
            
                            
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
