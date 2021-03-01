using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class MyTwoParameters<TKey, TValue>
    {
        public TKey Key
        {
            get; set;
        }
        public TValue Value
        {
            get; set;
        }

        public MyTwoParameters()
        {
            Key = default;
            Value = default;
        }

        public MyTwoParameters(TKey key, TValue val)
        {
            Key = key;
            Value = val;
        }
        public override string ToString()
        {
            return $"Key: {Key}; \nValue: {Value};";
        }
    }
}
