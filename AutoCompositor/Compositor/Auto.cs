using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCompositor.Compositor
{
    class Auto : IAutoComponent
    {
        public void Add(IAutoComponent autoComponent)
        {
            throw new NotImplementedException();
        }

        public void GetChild(IAutoComponent autoComponent)
        {
            throw new NotImplementedException();
        }

        public void Move(int x, int y)
        {
            //Do move logic
        }

        public void Remove(IAutoComponent autoComponent)
        {
            throw new NotImplementedException();
        }

        public void SetColor(Color color)
        {
            //Do color change logic
        }
    }
}
