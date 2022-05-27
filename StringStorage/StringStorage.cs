using System;
using System.Collections.Generic;

namespace StringStorage
{
    public class StringStorage
    {
        private List<string> _storage = new List<string>();

        public List<string> Storage { get => _storage; }

        public string GetElement(int index)
        {
            if(index > _storage.Count)
                throw new ArgumentOutOfRangeException("index");
            return _storage[index];
        }

        public void AddElement(string elem)
        {
            _storage.Add(elem);
        }

        public int GetSize()
        {
            return _storage.Count;
        }
    }
}
