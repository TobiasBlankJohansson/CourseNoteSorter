using CourseNoteSorter.Abstrect;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNoteSorter.Managers
{
    internal class FilePathManager
    {
        private Dictionary<string, string> _FilePath;
        public IEnumerable<string> FilePathList { get { return _FilePath.Values; }}
        public FilePathManager()
        {
            _FilePath = new Dictionary<string, string>();
        }
        public string FilePath(string key) 
        {
            _FilePath.TryGetValue(key, out var path);
            return (path);
        }
        public void Add(string key, string value)
        {
            if (!_FilePath.TryAdd(key, value))
                throw new Exception();
        }
        public void Remove(string key)
        {
            _FilePath.Remove(key);
        }
        public void ChangePath(string key, string newValue)
        {
            if (!_FilePath.ContainsKey(key))
                throw new Exception();
            _FilePath[key] = newValue;
        }
    }
}
