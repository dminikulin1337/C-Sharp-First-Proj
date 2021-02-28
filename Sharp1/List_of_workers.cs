using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class List_of_workers : IEnumerable
    {
        private int _counter = 0; // number of filled cells
        private int _capacity = 8;
        private int _current_capacity = 0; // number of cells in array - starter
        public IWorker[] _workers; // array of employees
        public IWorker[] Workers
        {
            get
            {
                IWorker[] tmp = new IWorker[Count];
                Array.Copy(_workers, tmp, Count);
                return tmp;
            }
        }
        private enum ChoiseResize
        {
            increase,
            decrease
        }
        public int Count
        {
            get
            {
                return _counter;
            }
        }
        public List_of_workers()
        {
            _current_capacity = _capacity;
            _workers = new IWorker[_current_capacity];
        }
        public List_of_workers(int capacity)
        {
            _current_capacity = capacity;
            _workers = new IWorker[_current_capacity];
        }
        public void AddWorker(IWorker worker)
        {
            if (_counter == _capacity)
            {
                resize(ChoiseResize.increase);
            }
            _workers[_counter] = worker;
            _counter++;
        }
        public int searchWorker(IWorker worker)
        {
            int delIndex = -1;
            for (int i = 0; i < _counter; i++)
            {
                if (_workers[i] == worker)
                {
                    delIndex = i;
                    break;
                }
            }
            return delIndex;//return -1, if not found
        }
        public void RemoveWorker(IWorker worker)
        {
            if (_counter + _capacity - 1 < _current_capacity - _capacity)
            {
                resize(ChoiseResize.decrease);
            }
            else if (_counter == 0) { return; }
            _workers[_counter - 1] = null;
            _counter--;
        }

        private void resize(ChoiseResize resize)
        {
            IWorker[] tmp;
            switch (resize)
            {
                case ChoiseResize.increase:
                    _current_capacity += _capacity;
                    _capacity *= 2;
                    break;
                case ChoiseResize.decrease:
                    if (_counter < (_current_capacity - _capacity))
                    {
                        _current_capacity -= _capacity;
                        tmp = new IWorker[_current_capacity];
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Resizing is out of control");
                    }
                    break;
            }
            tmp = new IWorker[_current_capacity];
            for (int i = 0; i < _counter; i++)
            {
                tmp[i] = _workers[i];
            }
            _workers = tmp;
        }
        public void ShowAllWorkers(List_of_workers zelist)
        {
            for (int i = 0; i < zelist.Workers.Length; i++)
            {
                Console.WriteLine(Workers[i]);
            }
        }
        public void ShowSingleWorker(List_of_workers zelist, int dex)
        {
            for (int i = 0; i < zelist.Workers.Length; i++)
            {
                if (dex == i)
                {
                    Console.WriteLine(Workers[i]);
                }
            }
        }
        public IEnumerator GetEnumerator()
        {
            return new ListOfWorkersEnumerator(this);
        }

        public IWorker this[int index]
        {
            get { return _workers[index]; }
            set { _workers[index] = value; }
        }
        public IWorker this[IWorker worker]
        {
            get { return _workers[this.searchWorker(worker)]; }
            set { _workers[this.searchWorker(worker)] = value; }
        }
    }
}
