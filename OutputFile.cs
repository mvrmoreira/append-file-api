using System.IO;

namespace append_file_api
{
    public class OutputFile
    {
        public void AppendLine(string fileName, string line)
        {
            using (var streamWriter = File.AppendText(fileName))
            {
                streamWriter.WriteLine(line);
            }
        }
    }
}