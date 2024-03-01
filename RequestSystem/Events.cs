using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestSystem;

public static class Events
{
    public static event Action<List<object>> OnCollectionRefresh;
}
