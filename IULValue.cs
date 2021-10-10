using System;
using System.Collections.Generic;
using System.Text;

namespace IUL
{
    class IULValue
    {
        public IULValue(string code, string codeIUL, string nameDoc, Staff author) 
        {
            _code = code;
            _codeIUL = codeIUL;
            _nameDoc = nameDoc;
            _AuthorTeam.Add(author);
        }
        public IULValue(string code, string codeIUL, string nameDoc, List<Staff> authorTeam)
        {
            _code = code;
            _codeIUL = codeIUL;
            _nameDoc = nameDoc;
            foreach(var author in authorTeam) 
            {
                _AuthorTeam.Add(author);
            }
        }
        private string _code;
        private string _codeIUL;
        private string _nameDoc;
        private List<Staff> _AuthorTeam= new List<Staff>();
        public List<Staff> AuthorTeam
        {
            get 
            {
                return _AuthorTeam;
            }
        }
        public string Code 
        {
            get 
            {
                return _code;
            }
            set 
            {
                _code = value;
            }
        }
        public string CodeIUL
        {
            get
            {
                return _codeIUL;
            }
            set
            {
                _codeIUL = value;
            }
        }
        public string NameDoc 
        {
            get
            {
                return _nameDoc;
            }
            set 
            {
                _nameDoc = value;
            }
        }
    }
}
