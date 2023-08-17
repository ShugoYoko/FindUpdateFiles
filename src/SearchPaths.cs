using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    internal class SearchPaths
    {
        private List<string> _paths;

        private DateTime _startDate;
        private DateTime _endDate;

        public SearchPaths(string? targetPath, string? startDate, string? endDate)
        {
            _paths = new List<string>();
            if (targetPath == string.Empty)
            {
                _paths.Add("Please check the file path.");
            }

            if (!DateTime.TryParse(startDate, out _startDate)
                || !DateTime.TryParse(endDate, out _endDate))
            {
                _paths.Add("Please check date format");
            }

            _paths = Directory.GetFiles(targetPath, "*", SearchOption.AllDirectories).ToList();

        }

        public IEnumerable<string> GetAllFiles()
        {
            foreach (var path in _paths)
            {
                var updateTime = File.GetLastWriteTime(path);
                if (_startDate <= updateTime && updateTime <= _endDate)
                    yield return path;
            }

        }


    }
}
