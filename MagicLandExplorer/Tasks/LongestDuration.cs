using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public static class LongestDuration
    {
        public static string GetLongestDurationDestination(List<Category> categories)
        {
            return categories
                .SelectMany(c => c.Destinations)
                .OrderByDescending(d => d.Duration)
                .FirstOrDefault()?.Name;
        }
    }
}
