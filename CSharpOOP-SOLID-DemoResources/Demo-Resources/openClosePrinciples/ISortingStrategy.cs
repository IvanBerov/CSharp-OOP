using System;
using System.Collections.Generic;
using System.Text;

namespace openClosePrinciples
{
    public interface ISortingStrategy
    {
        List<int> Sort(List<int> list);
    }
}
