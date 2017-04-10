using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGGameSE22.Classes
{
    public static class FileAccess
    {

        public static string GetLineFromText()
        {
            string item = Directory.GetCurrentDirectory() + "//test.txt";
            if (!File.Exists(item))
            {
                try
                {
                    StreamWriter sw = new StreamWriter(item);
                    sw.WriteLine("Victory");
                    sw.Close();
                    StreamReader sr = new StreamReader(item);
                    return sr.ReadLine();
                }
                catch (UnauthorizedAccessException e)
                {
                    MessageBox.Show("The application has no access here. Try running in administrator mode");
                    return null;
                }
            }
            else
            {
                try
                {
                    StreamReader sr = new StreamReader(item);
                    return sr.ReadLine();
                }
                catch (PathTooLongException e)
                {
                    MessageBox.Show("Given path is too long.");
                    return null;
                }
            }
        }
        public static List<string> GetMap()
        {
            List<string> map = new List<string>();
            string item = Directory.GetCurrentDirectory() + "//map.txt";
            if (File.Exists(item))
            {
                try
                {
                    StreamReader sr = new StreamReader(item);
                    while (!sr.EndOfStream)
                    {
                        string woord = sr.ReadLine();
                        string[] words = woord.Split(','); //This will take the line grabbed from the file and split the string at each space. Then it will add it to the array
                        for (int i = 0; i < words.Length; i++) //loops through each element of the array
                        {
                            map.Add(words[i]); //Add each word on the array on to woorden list
                        }
                    }
                    return map;
                }
                catch (UnauthorizedAccessException e)
                {
                    MessageBox.Show("The application has no access here. Try running in administrator mode");
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
