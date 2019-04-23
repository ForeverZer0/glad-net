using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace Glad
{
    public abstract class EntryCollection<T> : Entry, ICollection<T> where T : Entry
    {
        private readonly ICollection<T> values;

        protected EntryCollection(XmlElement node) : base(node)
        {
            values = new List<T>();
        }

        public IEnumerator<T> GetEnumerator() => values.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable) values).GetEnumerator();

        public void Add(T item) => values.Add(item);

        public void Clear() => values.Clear();

        public bool Contains(T item) => values.Contains(item);

        public void CopyTo(T[] array, int arrayIndex) => values.CopyTo(array, arrayIndex);

        public bool Remove(T item) => values.Remove(item);

        public int Count => values.Count;

        public bool IsReadOnly => values.IsReadOnly;

        public override string ToString() => $"{GetType().Name} [{Count}]";
    }
}