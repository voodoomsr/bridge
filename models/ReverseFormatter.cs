using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace models
{
    public class ReverseFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return string.Format("{0}: {1}", key, new string(value.Reverse().ToArray()));
        }
    }   
}