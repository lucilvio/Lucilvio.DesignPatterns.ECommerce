using System.Collections.Generic;

namespace Lucilvio.DesignPatterns.ECommerce.Problematic
{
    internal class Tracking
    {
        public Tracking(IEnumerable<string> path)
        {
            Path = path;
        }

        public IEnumerable<string> Path { get; }
    }
}