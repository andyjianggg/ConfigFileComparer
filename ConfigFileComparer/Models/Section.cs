using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigFileComparer.Models
{
    public class Section
    {
        private string _name;
        private string _identity;
        private bool _missing = true;

        public Section(string name)
        {
            _name = name;
        }

        public Section(string name, string identity)
        {
            _name = name;
            _identity = identity;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Identity
        {
            get
            {
                return _identity;
            }
            set
            {
                _identity = value;
            }
        }

        public bool Missing
        {
            get
            {
                return _missing;
            }
        }

        public bool Different
        {
            get
            {
                return false;
            }
        }
    }
}