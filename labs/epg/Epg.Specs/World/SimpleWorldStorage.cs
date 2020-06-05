using System;
using System.Collections.Generic;
using System.Text;

namespace Epg.World
{
    public class SimpleWorldStorage
        : IWorldStorage
    {
        private Dictionary<string, object> _entities = new Dictionary<string, object>();

        void IWorldStorage.Add(string name, object entity) => _entities.Add(name, entity);

        object IWorldStorage.Get(string name) => _entities[name];
    }
}
