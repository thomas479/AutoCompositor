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
            AutoComponents.Add(autoComponent);
        }
        
        public void Move(PointF location)
        {
            foreach(IAutoComponent auto in AutoComponents)
            {
                //Do move logic on all the autos
            }

        }

        public void Remove(IAutoComponent autoComponent)
        {
            AutoComponents.Remove(autoComponent);
            //Do remove logic
        }

        public void SetColor(Color color)
        {
            foreach (IAutoComponent auto in AutoComponents)
            {
                auto.SetColor(color);
                //Set color of autos
            }
        }
    }
}
