using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    class UniversalSort
    {
        public delegate int Comparator(Object currentElement, Object nextElement);
        public static void Sort(ref ArrayList _list, Comparator _comparatorA, Comparator _comparatorB) {

            bool isSorted;
            do
            {
                isSorted = true;
                for (int i = 0; i < _list.Count - 1; i++)
                {
                    if (_comparatorA.Invoke(_list[i], _list[i + 1]) > 0)
                    {
                        Object tmp = _list[i];
                        _list[i] = _list[i + 1];
                        _list[i + 1] = tmp;
                        isSorted = false;
                    }
                }
            } while (!isSorted);

            do
            {
                isSorted = true;
                for (int i = 0; i < _list.Count - 1; i++)
                {
                    if (_comparatorA.Invoke(_list[i], _list[i + 1]) == 0 && _comparatorB.Invoke(_list[i], _list[i + 1]) > 0)
                    {
                        Object tmp = _list[i];
                        _list[i] = _list[i + 1];
                        _list[i + 1] = tmp;
                        isSorted = false;
                    }
                }
            } while (!isSorted);
        }
    }
}
