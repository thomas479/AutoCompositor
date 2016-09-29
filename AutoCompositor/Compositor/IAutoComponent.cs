using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCompositor.Compositor
{
    interface IAutoComponent
    {
        void Add(IAutoComponent autoComponent);
        void Remove(IAutoComponent autoComponent);
        void GetChild(IAutoComponent autoComponent);

        /// <summary>
        /// Set the color of the IAutoComponent
        /// </summary>
        /// <param name="color">The color</param>
        void SetColor(Color color);

        /// <summary>
        /// Move the IAutoComponent to a new location. The x and y coordinate is the location of the mouse.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void Move(int x, int y);
    }
}
