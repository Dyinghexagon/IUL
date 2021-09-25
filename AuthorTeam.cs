using System;
using System.Collections.Generic;
using System.Text;

namespace IUL
{
    class AuthorTeam
    {
        public AuthorTeam(string WorkRole, string surname) 
        {
            _workRole = WorkRole;
            _surname = surname;
        }
        public AuthorTeam() 
        {
            _workRole = "Разработал";
            _surname = "Архипов";
        }
        private string _workRole;
        private string _surname;
        public string WorkRole 
        {
            get 
            {
                return _workRole;
            }
            set 
            {
                _workRole = value;
            }
        }
        public string Surname 
        {
            get 
            {
                return _surname;
            }
            set 
            {
                _surname = value;
            }
        }
    }
}
