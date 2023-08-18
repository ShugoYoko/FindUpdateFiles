using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("FindUpdateFiles.Tests")]

namespace FindUpdateFiles.Con
{
    internal class SearchPaths
    {
        private List<string> _paths;

        private DateTime _startDate;
        private DateTime _endDate;

        private const string _errEmpty= "Please check the file path.";
        private const string _dateError = "Please check date format";


        public SearchPaths(string? targetPath, string? startDate, string? endDate)
        {
            _paths = new List<string>();
            if (targetPath == string.Empty)
            {
                _paths.Add(_errEmpty);
            }

            if (!DateTime.TryParse(startDate, out _startDate)
                || !DateTime.TryParse(endDate, out _endDate))
            {
                _paths.Add(_dateError);
            }

            if (Directory.Exists(targetPath))
            {
                _paths = Directory.GetFiles(targetPath, "*", SearchOption.AllDirectories).ToList();
            }

        }

        public IEnumerable<string> GetAllFiles()
        {
            foreach (var path in _paths)
            {
                var updateTime = File.GetLastWriteTime(path);
                if (_startDate <= updateTime && updateTime <= _endDate)
                {
                    yield return path;
                }
                else if(path==_errEmpty||path== _dateError)
                {
                    yield return path;
                }

            }

        }


    }
}
