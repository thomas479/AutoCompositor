using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCompositor.Compositor
{
    class AutoGroup : IAutoComponent
    {
        public List<IAutoComponent> AutoComponents { get; set; }

        public AutoGroup()
        {
            AutoComponents = new List<IAutoComponent>();
        }

        public void Add(IAutoComponent autoComponent)
        {
            AutoComponents.Add(autoComponent);
        }

        public AutoGroup Selected(PointF startPoint, PointF endPoint)
        {
            AutoGroup selection = new AutoGroup();

            var temp = AutoComponents.Where(auto =>
                ((auto.Location.X > startPoint.X && auto.Location.X < endPoint.X) ||
                (auto.Location.X < startPoint.X && auto.Location.X > endPoint.X)) &&
                ((auto.Location.Y > startPoint.Y && auto.Location.Y < endPoint.Y) ||
                (auto.Location.Y < startPoint.Y && auto.Location.Y > endPoint.Y))
            );

            foreach (var auto in temp)
            {
                selection.Add(auto);
            }

            return selection;
        }

        public void Move(PointF location)
        {
            foreach (IAutoComponent auto in AutoComponents)
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

        public void MarkSelected()
        {
            foreach (IAutoComponent auto in AutoComponents)
            {
                auto.MarkSelected();
            }
        }
        public void UnmarkSelected()
        {
            foreach (IAutoComponent auto in AutoComponents)
            {
                auto.UnmarkSelected();
            }
        }


        public PointF Location
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Color color
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public PictureBox image
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        internal IAutoComponent IAutoComponent
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
