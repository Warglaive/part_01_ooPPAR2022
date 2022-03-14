using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Interfaces
{
    public interface IXmlDBManager
    {
        void SaveObjectToXML(object? obj);
        int ReadLastIdFromXML();
    }
}
