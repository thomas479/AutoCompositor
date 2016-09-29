using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCompositor.Compositor
{
    class AutoGroup : IAutoComponent
    {
        public List<IAutoComponent> AutoComponents { get; set; }

        public void Add(IAutoComponent autoComponent)
        {
            //Do add logic
        }

        public void GetChild(IAutoComponent autoComponent)
        {
            //Do child logic
        }

        public void Move(int x, int y)
        {
            //Do move logic on all the autos
        }

        public void Remove(IAutoComponent autoComponent)
        {
            //Do remove logic
        }

        public void SetColor(Color color)
        {
            //Set color of autos
        }
    }
}
