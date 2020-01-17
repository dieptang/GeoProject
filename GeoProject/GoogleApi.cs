using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoProject
{
    class GoogleApi
    {
        public static string GooglePlaceAPI = "GOCo_ILPBEQAM";

        protected static string fileGetContents(string fileName)
        {
            string sContents = string.Empty;
            string me = string.Empty;
            try
            {
                if (fileName.ToLower().IndexOf("https:") > -1)
                {
                    System.Net.WebClient wc = new System.Net.WebClient();
                    byte[] response = wc.DownloadData(fileName);
                    sContents = System.Text.Encoding.UTF8.GetString(response);

                }
                else
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(fileName);
                    sContents = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch { sContents = "unable to connect to server "; }
            return sContents;
        }
    
        public static List<AutoComplete> AutoCompletes(string text)
        {
            string url = "https://maps.googleapis.com/maps/api/place/autocomplete/json?input=" + text + "&types=geocode&libraries=places&key=" + GooglePlaceAPI;
            string content = fileGetContents(url);
            JObject o = JObject.Parse(content);
            List<string> add = new List<string>();
            try
            {
                JObject jObj = (JObject)JsonConvert.DeserializeObject(content);
                var list = new List<AutoComplete>();
                foreach (var resp in jObj["predictions"])
                {
                    string obj = (string)resp["description"];
                    string placeid = (string)resp["place_id"];
                    if (!string.IsNullOrEmpty(placeid))
                    {
                        var item = new AutoComplete();
                        item.name = obj;
                        item.placeid = placeid;
                        //Console.WriteLine(obj + "-" +placeid);
                        list.Add(item);
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public static GeoLocale get_place_details(string placeid)
        {
            string url = "https://maps.googleapis.com/maps/api/place/details/json?placeid=" + placeid + "&fields=address_component&key=" + GooglePlaceAPI;
            string content = fileGetContents(url);
            JObject o = JObject.Parse(content);

            try
            {
                JObject jObj = (JObject)JsonConvert.DeserializeObject(content);
                var geo = new GeoLocale();

                foreach (var resp in jObj["result"]["address_components"])
                {
                    string type = (string)resp["types"][0].ToString();

                    if (type.Contains("street_number"))
                    {
                        geo.StreetNumber = resp["long_name"].ToString();
                        continue;
                    }
                    else if (type.Contains("country"))
                    {
                        geo.Country = resp["long_name"].ToString();
                        continue;
                    }
                    else if (type.Contains("route"))
                    {
                        geo.Route = resp["long_name"].ToString();
                        continue;
                    }
                    else if (type.Contains("locality")) // city
                    {
                        geo.City = resp["long_name"].ToString();
                        continue;
                    }
                    else if (type.Contains("postal_code")) // city
                    {
                        geo.Zipcode = resp["long_name"].ToString();
                        continue;
                    }
                    else if (type.Contains("administrative_area_level_1")) // city
                    {
                        geo.State = resp["long_name"].ToString();
                        continue;
                    }
                }

                return geo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

    }


    public class AutoComplete
    {
        public string name { get; set; }
        public string placeid { get; set; }
    }
    public class GeoLocale
    {
        public string StreetNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Country { get; set; }
        public string Route { get; set; }
    }

    
}
