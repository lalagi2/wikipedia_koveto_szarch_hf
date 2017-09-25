using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wikipedia_koveto.WikipediaAPI
{
    class WikiAPIException : Exception
    {
        public WikiAPIException(string message) : base(message) { }
    }
}
