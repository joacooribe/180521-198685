using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Logic
{
    public class ImageHandler
    {
        public ImagePersistenceProvider imageFunctions { get; set; }

        public void AddImage(Image image)
        {
            ValidateImage(image);
            imageFunctions.AddElement(image);
        }

        private void ValidateImage(Image image)
        {
            throw new NotImplementedException();
        }
    }
}
