using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public static class SortByName
    {
        public static List<string> GetSortedDestinationsByName(List<Category> categories)
        {
            return categories
                .SelectMany(c => c.Destinations)
                .OrderBy(d => d.Name)
                .Select(d => d.Name)
                .ToList();
        }
    }
}
