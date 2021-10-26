using System;
using System.Collections.Generic;
using System.Text;

namespace IUL
{
    class IULs
    {
        private string _MD5;
        private DateTime _dateChange;
        private int _sizeFile;
        private string _GIP;
        private string _NKontr;
        /// <summary>
        /// Словарь _chapters хранит информацию об том или ином разделе.
        /// Ключом выступает код раздела.
        /// Значением выступает объект класса IUL.
        /// </summary>
        private Dictionary<string, IUL> _chapters;
        private DateTime _dateSign;
    }
}
