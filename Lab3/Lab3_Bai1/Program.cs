using System;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        string path = "../../../example.txt";   // ../ ra thu muc cha
                                                // C:\\ duong dan tuong doi 

        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        
        {
            using (StreamWriter sw = new StreamWriter(fs)) 
            {
                sw.WriteLine("UserName: myUserName");
                sw.WriteLine("Password: myPassword");
            }
        }
        using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            using (StreamReader sr = new StreamReader(fs))
            { 
                Console.WriteLine(sr.ReadToEnd());
            }
        }
        Console.ReadLine();
    }
}