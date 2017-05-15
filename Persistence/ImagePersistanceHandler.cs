﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class ImagePersistanceHandler : ImagePersistenceProvider
    {
        public Repository systemCollection;

        public ImagePersistanceHandler(Repository collection)
        {
            systemCollection = collection;
        }

        public void AddElement(Element element)
        {
            element.blackboardOwner.elementsInBlackboard.Add(element);
        }

        public Element GetElementFromCollection(int idElement, Blackboard blackboardOwner)
        {
            Element image = new Image();
            return image;
        }
    }
}