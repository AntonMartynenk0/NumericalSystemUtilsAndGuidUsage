using System.IO;

namespace GuidUsage
{
    class FileCreator
    {
        public static void WriteFile(string path, string text)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine(text);
            }
        }
    }
}
