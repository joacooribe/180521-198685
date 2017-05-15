using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface ElementPersistanceProvider
    {
        void AddElement(Element element);
        Element GetElementFromCollection(int idElement, Blackboard blackboardOwner);
    }
}
