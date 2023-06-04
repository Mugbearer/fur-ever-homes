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

        public static Dictionary<string, string>[] GetData(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URI + uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string result = reader.ReadToEnd();
            return JsonSerializer.Deserialize<Dictionary<string, string>[]>(result);
        }
    }
}
