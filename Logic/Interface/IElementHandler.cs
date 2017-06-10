using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Logic
{
    public interface IElementHandler
    {
        void AddElement(Element element);
        Element GetElementFromCollection(int idElement, Blackboard blackboardOwner);
        void DeleteElement(Element element);
    }
}
