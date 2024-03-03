using System;

namespace se_csharp_iconnect.Utilities
{
    public class Util
    {
        public static string GetProjRootDir()
        {
            string currentDir = Directory.GetCurrentDirectory();
            return currentDir.Split("bin")[0];
        }
    }
}
