using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryGenericClass
{
    internal class MyDictionary<T1, T2>
    {
        private T1[] _arrayKey;
        private T2[] _arrayValue;
        private T1[] _tempKey;
        private T2[] _tempValue;


        public MyDictionary()
        {
            _arrayKey = new T1[0];
            _arrayValue = new T2[0];
        }

        public void Add(T1 item1, T2 item2)
        {
            _tempKey = _arrayKey;
            _tempValue = _arrayValue;
            _arrayKey = new T1[_arrayKey.Length + 1];
            _arrayValue = new T2[_arrayValue.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                _arrayKey[i] = _tempKey[i];
            }

            for (int i = 0; i < _tempValue.Length; i++)
            {
                _arrayValue[i] = _tempValue[i];
            }

            _arrayKey[_arrayKey.Length - 1] = item1;
            _arrayValue[_arrayValue.Length - 1] = item2;

        }

        public int Count
        {
            get { return _arrayKey.Length; }
        }
    }
}
