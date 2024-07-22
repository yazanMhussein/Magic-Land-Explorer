using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public static class FilterDestinations
    {
        public static List<string> GetDestinationsWithShortDuration(List<Category> categories, int maxDuration)
        {
            return categories
                .SelectMany(c => c.Destinations)
                .Where(d => d.Duration < maxDuration)
                .Select(d => d.Name)
                .ToList();
        }
    }
}
