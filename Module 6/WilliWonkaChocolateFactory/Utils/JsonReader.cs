using System.IO;

namespace WilliWonkaChocolateFactory.Utils
{
    public static class JsonReader
    {
        public static string ReadJson(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}