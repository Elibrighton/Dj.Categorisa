using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongHandlerInterface
{
    public interface ISongHandler
    {
        bool Copy(string songPath, string libraryPath);
    }
}
