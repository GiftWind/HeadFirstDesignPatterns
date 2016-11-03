using System.Globalization;
using System.IO;
using System.Net;
using System.Xml;

namespace Observer
{
    static class OpenWeatherApiWeatherData
    {
        private static readonly string _apiKey = "5a5ac575b8e4c0619b72873772512467";
        private static readonly string _currentUrl = "http://api.openweathermap.org/data/2.5/weather?" + "id=498817&mode=xml&units=metric&APPID=" + _apiKey;
        private static readonly string _forecastUrl = "http://api.openweathermap.org/data/2.5/forecast?" + "id=498817&mode=xml&units=metric&APPID=" + _apiKey;

        public static XmlDocument GetFormattedXml(string url)
        {
            // Create a web client.
            using (WebClient client = new WebClient())
            {
                // Get the response string from the URL.
                string xml = client.DownloadString(url);

                // Load the response into an XML document.
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xml);
                return xmlDocument;

                // Format the XML.
//                using (StringWriter stringWriter = new StringWriter())
//                {
//                    XmlTextWriter xmlTextWriter =
//                        new XmlTextWriter(stringWriter);
//                    xmlTextWriter.Formatting = Formatting.Indented;
//                    xmlDocument.WriteTo(xmlTextWriter);
//
//                    // Return the result.
//                    return stringWriter.ToString();
//                }
            }
        }

        
        

    }
}
