using SongHandlerInterface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongHandler
{
    public class SongHandler : ISongHandler
    {
        public bool Copy(string songPath, string libraryPath)
        {
            var isCopied = false;

            if (File.Exists(songPath))
            {
                if (!Directory.Exists(libraryPath))
                {
                    Directory.CreateDirectory(libraryPath);
                }
                var destinationPath = libraryPath + Path.GetFileName(songPath);

                if (!File.Exists(destinationPath))
                {
                    File.Copy(songPath, destinationPath);
                    isCopied = File.Exists(destinationPath);
                }
                else
                {
                    isCopied = true;
                }
            }

            return isCopied;
        }
    }
}
