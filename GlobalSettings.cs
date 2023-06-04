using System.Net;

namespace fur_ever_homes
{
    internal class GlobalSettings
    {
        public static string URI { get; } = "http://192.168.68.111/IT140P/fureverhomes-api/"; //Change this according to your IP address and directory

        public static string ResponseIntoString(HttpWebResponse response)
        {
            StreamReader reader = new(response.GetResponseStream());
            return reader.ReadToEnd();
        }
    }
}
