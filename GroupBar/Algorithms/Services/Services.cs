using System.Collections.Generic;

namespace Algorithms.Services
{
    public class Services
    {
        readonly List<string> _algorithmSteps = new List<string>();

        public List<string> FillProcess(string step)
        {
            _algorithmSteps.Add(step);
            return _algorithmSteps;
        }
    }
}
