using System.Collections.Generic;
using System.Linq;

namespace Wp.Data
{
    public class TheMeta<TMeta> : WpRepository
        where TMeta : WpMeta<ulong>
    {
        private readonly WpContext _context;

        public TheMeta(WpContext context)
        {
            _context = context;
        }

        public KeyValuePair<string, string>[] Get(ulong entityId)
        {
            return _context.Set<TMeta>()
                .Where(x => x.EntityId == entityId)
                .Select(x => new KeyValuePair<string, string>(x.Key, x.Value))
                .ToArray();
        }

        public KeyValuePair<string, string>[] Get(ulong entityId, string key)
        {
            return _context.Set<TMeta>()
               .Where(x => x.EntityId == entityId && x.Key == key)
               .Select(x => new KeyValuePair<string, string>(x.Key, x.Value))
               .ToArray();
        }
    }
}
