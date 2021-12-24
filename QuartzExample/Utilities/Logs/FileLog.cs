using System.IO;
namespace QuartzExample.Utilities.Logs
{
    public class FileLog
    {
        public static void Logs(string message, string fileName)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "MyLogs");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path = Path.Combine(path, fileName);
            using FileStream stream = new FileStream(path, FileMode.Create);
            using TextWriter textWriter = new StreamWriter(stream);
            textWriter.WriteLine(message);
        }
    }
}
