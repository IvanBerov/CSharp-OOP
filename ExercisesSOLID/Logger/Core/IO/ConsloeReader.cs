using System;
using System.Collections.Generic;
using System.Text;

namespace Loggerrr.Core.IO
{
    public class ConsloeReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
