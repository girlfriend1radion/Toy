using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Toy.Components
{
    internal class DBConnect
    {
        public static ArkadeevaEntities2 db = new ArkadeevaEntities2();
    }
}
