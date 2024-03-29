using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_自訂義特性
{   //AttributeUsage (Class 表示這個特性只能用在類別上，AllowMultiple= false 只能用一次)
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal class InformationAttribute:Attribute
    {
        public string Name { get; private set; }
        public string Version { get; private set; }
        public string Description { get; private set; }

        public InformationAttribute(string name, string version, string description)
        {
            Name = name;
            Version = version;
            Description = description;
        }
    }
}
