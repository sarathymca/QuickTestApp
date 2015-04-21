using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuickTestApp
{
    public class Path
    {
        public string CurrentPath { get; private set; }

        public Path(string path)
        {
            this.CurrentPath = path;
        }

        public Path Cd(string newPath)
        {
            foreach (string getPath in newPath.Split('/'))
            {
                if (getPath == "..")
                {
                    if (CurrentPath.IndexOf('/') >= 0)
                        CurrentPath = CurrentPath.Remove(CurrentPath.LastIndexOf("/"));
                }
                else
                {
                    if (Regex.IsMatch(getPath, @"^[a-zA-Z]+$"))
                        CurrentPath += "/" + getPath;
                    else
                        CurrentPath = "Special character not allowed";
                }
            }

            return new Path(CurrentPath);
        }
       
        
        public static void Main(string[] args)
        {
            Path path = new Path("/a/b/c/d");
            Console.WriteLine(path.Cd("../a").CurrentPath);

            Path path1 = new Path("/a/b/c/d");
            Console.WriteLine(path1.Cd("../../x").CurrentPath);

            Path path2 = new Path("/a");
            Console.WriteLine(path2.Cd("../x").CurrentPath);

            Path path3 = new Path("/a/b");
            Console.Write(path3.Cd("../folder1").CurrentPath);

            Console.Read();
        }
         
    }
}
