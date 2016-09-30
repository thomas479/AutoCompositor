using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCompositor
{
    public partial class Form1 : Form
    {        
        Point selectionStart;
        Point selectionEnd;
        Rectangle selection;
        Compositor.AutoGroup autoList, selectedList;
        bool mouseDown;
        bool buttonClick = false;

        public Form1()
        {
            InitializeComponent();            
        }

        private void AddAutoButton_Click(object sender, EventArgs e)
        {
            Compositor.IAutoComponent auto = new Compositor.Auto(this);
            autoList.Add(auto);
        }

        private void ChangeColourButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Color rand = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            selectedList.SetColor(rand);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            selectionStart = PointToClient(MousePosition);
            mouseDown = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseDown)
            {
                return;
            }else
            {
                selectionEnd = PointToClient(MousePosition);
                SetSelectionRect();
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (mouseDown)
            {
                    e.Graphics.FillRectangle(Brushes.Salmon, selection);                
            }
        }

        private void SetSelectionRect()
        {
            int x, y;
            int width, height;

            x = selectionStart.X > selectionEnd.X ? selectionEnd.X : selectionStart.X;
            y = selectionStart.Y > selectionEnd.Y ? selectionEnd.Y : selectionStart.Y;

            width = selectionStart.X > selectionEnd.X ? selectionStart.X - selectionEnd.X : selectionEnd.X - selectionStart.X;
            height = selectionStart.Y > selectionEnd.Y ? selectionStart.Y - selectionEnd.Y : selectionEnd.Y - selectionStart.Y;

            selection = new Rectangle(x, y, width, height);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                selectedList = autoList;
                selectedList.UnmarkSelected();
                selectedList = autoList.Selected(selectionStart, selectionEnd);
                selectedList.MarkSelected();
            }
            mouseDown = false;
            SetSelectionRect();

            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            autoList = new Compositor.AutoGroup();
        }

        private void DiscoButton_Click(object sender, EventArgs e)
        {
            buttonClick = !buttonClick;
            if(buttonClick)
                backgroundWorker1.RunWorkerAsync();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Random r = new Random();
            while(buttonClick)
            {
                foreach (var auto in selectedList.AutoComponents)
                {
                    Color rand = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                    auto.SetColor(rand);
                }
            }
        }
    }
}
