using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class List_of_managers
    {
        private int _counter = 0; // number of filled cells
        private int _capacity = 4;
        private int _current_capacity = 0; // number of cells in array - starter
        public IManager[] _managers; // array of employees

        public IManager[] Managers
        {
            get { return _managers; }
        }
        private enum ResizeChoise
        {
            INC,
            DEC
        }
        public int Count
        {
            get { return _counter; }
        }
        public List_of_managers()
        {
            _current_capacity = _capacity;
            _managers = new IManager[_current_capacity];
        }
        public List_of_managers(int capacity)
        {
            _current_capacity = capacity;
            _managers = new IManager[_current_capacity];
        }
        private void Resize(ResizeChoise rez)
        {
            IManager[] tmp;
            switch (rez)
            {
                case ResizeChoise.INC:
                    _current_capacity += _capacity;
                    _capacity *= 2;
                    break;
                case ResizeChoise.DEC:
                    if (_counter < (_current_capacity - _capacity))
                    {
                        _current_capacity -= _capacity;
                        tmp = new IManager[_current_capacity];
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Resizing is out of control");
                    }
                    break;
            }
            tmp = new IManager[_current_capacity];
            for (int i = 0; i < _counter; i++)
            {
                tmp[i] = _managers[i];
            }
            _managers = tmp;
        }
        public void AddManager(IManager manager)
        {
            if (_counter == _capacity)
            {
                Resize(ResizeChoise.INC);
            }
            _managers[_counter] = manager;
            _counter++;
        }
        public int searchManager(IManager manager)
        {
            int delIndex = -1;
            for (int i = 0; i < _counter; i++)
            {
                if (_managers[i] == manager)
                {
                    delIndex = i;
                    break;
                }
            }
            return delIndex;//return -1, if not found
        }
        public void RemoveManager(IManager manager)
        {
            if (_counter + _capacity - 1 < _current_capacity - _capacity)
            {
                Resize(ResizeChoise.DEC);
            }
            else if (_counter == 0) { return; }
            _managers[_counter - 1] = null;
        }
        public void ShowAllManagers(List_of_managers zelist)
        {
            for (int i = 0; i < zelist.Managers.Length; i++)
            {
                Console.WriteLine(Managers[i]);
            }
        }
        public void ShowSingleManager(List_of_managers zelist, int dex)
        {
            for (int i = 0; i < zelist.Managers.Length; i++)
            {
                if (dex == i)
                {
                    Console.WriteLine(Managers[i]);
                }
            }
        }
        public IManager this[int index]
        {
            get { return _managers[index]; }
            set { _managers[index] = value; }
        }
        public IManager this[IManager manager]
        {
            get { return _managers[this.searchManager(manager)]; }
            set { _managers[this.searchManager(manager)] = value; }
        }
    }
}
