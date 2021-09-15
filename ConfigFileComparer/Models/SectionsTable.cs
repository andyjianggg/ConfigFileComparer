using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigFileComparer.Models
{
    class SectionsTable
    {
        private Dictionary<string, SectionsTable> _table;
        private string _identity;
        private string _tag;

        public SectionsTable(string tag)
        {
            _table = new Dictionary<string, SectionsTable>();
            _tag = tag;
            _identity = "";
        }

        public SectionsTable(string tag, string identity)
        {
            _table = new Dictionary<string, SectionsTable>();
            _identity = identity;
            _tag = tag;
        }

        public Dictionary<string, SectionsTable> Table
        {
            get
            {
                return _table;
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

        public string Tag
        {
            get
            {
                return _tag;
            }
            set
            {
                _tag = value;
            }
        }

        public void Add(string sectionName, string tag, string identity)
        {
            _table.Add(sectionName, new SectionsTable(tag, identity));
        }

        public void Add(string sectionName, string tag)
        {
            _table.Add(sectionName, new SectionsTable(tag));
        }
    }
}