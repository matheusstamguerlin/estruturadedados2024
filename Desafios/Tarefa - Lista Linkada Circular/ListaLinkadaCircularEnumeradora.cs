using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLinkadaCircular
{
    public class CircularLinkedList<T> : LinkedList<T>
    {
        public new IEnumerator GetEnumerator()
        {
            return new CircularLinkedListEnumerator<T>(this);
        }
    }
    public class CircularLinkedListEnumerator<T> : IEnumerator<T>
    {
        private LinkedListNode<T> _current;
        public T Current => _current.Value;
        object IEnumerator.Current => Current;

        public CircularLinkedListEnumerator(LinkedList<T> list)
        {
            _current = list.First;
        }
        public bool MoveNext()
        {
            if (_current == null)
                return false;

            _current = _current.Next ?? _current.List.First;
            return true;
        }

        public void Reset()
        {
            _current = _current.List.First;
        }
        public void Dispose() { }
    }

    public static class CircularLinkedListExtensions
    {
        public static LinkedListNode<T> Next <T> ( this LinkedListNode<T> node)
        {
            if (node != null && node.List != null)
                return node.Next ?? node.List.First;

            return null;
        }
    }
}