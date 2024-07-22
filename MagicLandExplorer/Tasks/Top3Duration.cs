using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public static class Top3Duration
    {
        public static List<(string Name, int Duration)> GetTop3LongestDurationDestinations(List<Category> categories)
        {
            return categories
                .SelectMany(c => c.Destinations)
                .OrderByDescending(d => d.Duration)
                .Take(3)
                .Select(d => (d.Name, d.Duration))
                .ToList();
        }
    }
}
