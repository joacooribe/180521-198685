using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public interface IImagePersistance
    {
        void AddImage(Image image);
        Image GetImage(int id, Blackboard blackboard);
        void DeleteImage(Image image);
    }
}
