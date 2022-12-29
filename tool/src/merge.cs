using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        string filelist = args[0];
        string mergedName = args[1];
        
        File.Delete(mergedName);
        using (StreamWriter sw = new StreamWriter(mergedName, true))
        {
            foreach (string fileName in File.ReadLines(filelist))
            {
                foreach (string line in File.ReadLines(fileName.Trim()))
                {
                    sw.WriteLine(line);
                }
            }
        }
    }
}
