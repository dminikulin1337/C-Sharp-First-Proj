using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Company
    {
        private string _name;
        private string _direction;
        private List_of_workers _allWorkers;
        private List_of_managers _allManagers;
        private Director _director;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }
        public List_of_workers AllWorkers
        {
            get { return _allWorkers; }
            set { _allWorkers = value; }
        }
        public List_of_managers AllManagers
        {
            get { return _allManagers; }
            set { _allManagers = value; }
        }
        public Director Director
        {
            get { return _director; }
            set { _director = value; }
        }
        public void ChangeDirector(Director director)
        {
            _director = director;
        }

        public Company()
        {
            Name = "Company";
            Direction = "Making tableware";
            AllWorkers = new List_of_workers();
            AllManagers = new List_of_managers();
            Director = new Director();
        }
        public Company(string name, string dir, List_of_workers LOW, List_of_managers LOM, Director DIRECT)
        {
            Name = name;
            Direction = dir;
            AllWorkers = LOW;
            AllManagers = LOM;
            Director = DIRECT;
        }
        public override string ToString()
        {
            return $"Company" +
                $"\nName: {Name}" + 
                $"\nDirection: {Direction}" + 
                $"\nDirector: {Director.getSurname()} {Director.getName()} {Director.getPatronimic()}" + 
                $"\nManagers in company: {AllManagers.Managers.Length}" + 
                $"\nWorkers in company: {AllWorkers.Workers.Length}";
        }
    }
}
