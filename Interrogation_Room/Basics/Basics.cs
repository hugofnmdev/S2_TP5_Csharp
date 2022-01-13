using System;
using System.IO;
using System.Collections;

namespace Basics
{
    public class Basics
    {
        public static void FileOrDir(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine(path + " is a file !");
            }
            else if (path[(path.Length)-1] == '/')
            {
                Console.WriteLine(path + " is a directory !");
            }
            else
            {
                Console.WriteLine(path + " is neither a file nor a directory !");
            }
        }

        public static void DisplayFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader sr = File.OpenText(path);
                string s;
                int a = 1;
                while ((s = sr.ReadLine()) != null) 
                {
                    Console.WriteLine("Line " + a + ": " + s);
                    a++;
                }
            }
            else
            {
                Console.Error.WriteLine("Error: No such file or directory !");
            }
        }

        public static void WriteInFile(string path, string content)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(content);
                }
            }
            else
            {
                StreamWriter sw = new StreamWriter(path, true);
                sw.WriteLine(content);
                sw.Close();
            }
        }

        public static int CopyFile(string source, string dest)
        {
            if (!File.Exists(source))
            {
                return -1;
            }
            else
            {
                StreamReader sr = File.OpenText(source);
                string s;
                while ((s = sr.ReadLine()) != null) 
                {
                    WriteInFile(dest,s);
                }
                return 0;
            }
        }

        public static void PrintReformStr(string path)
        {
            // TODO
            throw new NotImplementedException();
        }

        public static void MiniLs(string path)
        {
            if ((path[(path.Length)-1] != '/' && !File.Exists(path)) || !Directory.Exists(path))
            {
                Console.WriteLine("Error: No such file or directory");   
            }
            else if (File.Exists(path))
            {
                Console.WriteLine(Path.GetFileName(path));
            }
            else
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                foreach (DirectoryInfo d in dir.GetDirectories())
                {
                    Console.Write(d.Name + ' ');
                }
                foreach (FileInfo f in dir.GetFiles())
                {
                    Console.Write(f.Name + ' ');
                }
            }
        }

        public static void ConstructLine(string path, string branch)
        {
            // TODO
            throw new NotImplementedException();
        }

        public static void ConstructTree(string path, string branch)
        {
            // TODO
            throw new NotImplementedException();
        }

        public static void MyTree(string path)
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine("Error: No such file or directory");   
            }
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                Console.WriteLine(Path.GetFileName(path));
                foreach (FileInfo f in dir.GetFiles())
                {
                    Console.WriteLine('|' + f.Name);
                }
                foreach (DirectoryInfo d in dir.GetDirectories())
                {
                    MyTree(path + '/' + d.Name);
                }
            }
        }
    
    }
}