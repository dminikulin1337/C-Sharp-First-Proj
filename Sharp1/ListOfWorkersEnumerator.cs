using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class ListOfWorkersEnumerator : IEnumerator
    {
        private List_of_workers _list_of_workers;
        private int _position = -1;//out of range of collection

        public ListOfWorkersEnumerator(List_of_workers list_of_workers)
        {
            this._list_of_workers = list_of_workers;
        }

        public object Current
        {
            get
            {
                if (_position == -1 || _position >= _list_of_workers.Count)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    return _list_of_workers.Workers[_position];
                }
            }
        }

        public bool MoveNext()
        {
            if (_position < _list_of_workers.Count - 1)
            {
                _position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}