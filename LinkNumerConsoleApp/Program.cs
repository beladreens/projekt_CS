using System;
using System.Reflection;
using System.Threading.Tasks;
using LinkNumberLib;
using System.Collections.Generic;
using System.Linq;

namespace LinkNumerConsoleApp
{
    class MainApp
    {
        public static List<string> MainMethodArgs = new List<string>();
        static void Main(string[] args)
        {
            MainMethodArgs = args.ToList();
            Runm.Run(MainMethodArgs.ToArray());
        }
    }
}
