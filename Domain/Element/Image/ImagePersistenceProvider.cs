﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface ImagePersistenceProvider : ElementPersistanceProvider
    {
        new void AddElement(Element element);
        new Element GetElementFromCollection(int idElement, Blackboard blackboardOwner);
    }
}
