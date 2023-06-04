using System.Net;
using System.Text.Json;

namespace fur_ever_homes
{
    internal class Global
    {
        public static string URI { get; } = "http://192.168.68.111/IT140P/fureverhomes-api/"; //Change this according to your IP address and directory

        public static string ResponseIntoString(HttpWebResponse response)
        {
            StreamReader reader = new(response.GetResponseStream());
            return reader.ReadToEnd();
        }

        public static JsonElement GetData(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Global.URI + uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            var result = reader.ReadToEnd();
            using JsonDocument doc = JsonDocument.Parse(result);
            JsonElement root = doc.RootElement;

            return root;
        }
    }
}
