using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Wp.Data.Entities;

namespace Wp.Data
{
    public class TheOptions : WpRepository, IReadOnlyDictionary<string, string>
    {
        private readonly WpContext _context;

        private readonly Dictionary<string, string> _dictionary;

        public TheOptions(WpContext context)
        {
            _context = context;

            _dictionary = _context.Options
                .Where(x => x.Autoload == "yes")
                .ToDictionary(x => x.Name, x => x.Value);
        }

        #region IReadOnlyDictionary<string, string>

        public string this[string name] => _dictionary.TryGetValue(name, out string value) ? value : LoadEntity(name).Value;

        public IEnumerable<string> Keys => _dictionary.Keys;

        public IEnumerable<string> Values => _dictionary.Values;

        public int Count => _dictionary.Count;

        public bool ContainsKey(string name)
        {
            return _dictionary.ContainsKey(name);
        }

        public bool TryGetValue(string name, out string value)
        {
            try
            {
                value = this[name];

                return true;
            }
            catch (Exception)
            {
                value = null;
            }

            return false;
        }

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            return _dictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _dictionary.GetEnumerator();
        }

        #endregion

        private WpOptions LoadEntity(string name)
        {
            var entity = _context.Options.FirstOrDefault(x => x.Name == name);

            _dictionary.Add(entity.Name, entity.Value);

            return entity;
        }
    }
}
