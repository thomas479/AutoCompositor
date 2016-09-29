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
        public int xPosition { get; set; }
        public int yPosition { get; set; }
        public Color color { get; set; }

        public Auto()
        {
            color = Color.BurlyWood;
        }

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
            xPosition = x;
            yPosition = y;
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
