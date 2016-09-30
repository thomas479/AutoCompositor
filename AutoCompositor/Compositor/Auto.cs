using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCompositor.Compositor
{
    class Auto : IAutoComponent
    {
        public PointF Location { get; set; }
        public Color color { get; set; }
        PictureBox image;

        public Auto(Form1 form)
        {
            color = Color.BurlyWood;
            image = new PictureBox();
            {
                image.Image = Image.FromFile(System.Environment.CurrentDirectory + "\\ovlov.png");
                image.Visible = true;
                image.Height = 100;
                image.Width = 100;
                image.SizeMode = PictureBoxSizeMode.Zoom;
                image.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                image.BackColor = Color.Transparent;
                Random r = new Random();
                image.Location = new Point(r.Next(form.Width - 150), r.Next(form.Height - 150));
            }
            form.Controls.Add(image);
        }

        public void Add(IAutoComponent autoComponent)
        {
            throw new NotImplementedException();
        }

        public void Move(PointF location)
        {
            Location = location;
        }

        public void Remove(IAutoComponent autoComponent)
        {
            throw new NotImplementedException();
        }

        public void SetColor(Color color)
        {
            this.color = color;
            Bitmap bitmap = new Bitmap(System.Environment.CurrentDirectory + "\\ovlov.png");
            BitmapExt.ChangeColour(bitmap, 255, 0, 255, color.R, color.G, color.B);
            image.Image = bitmap;
        }
    }
}
