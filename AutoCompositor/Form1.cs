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

        // Colors
        ColourChanger CreamYellow = new ColourChanger("Cream Yellow", "255,254,151");
        ColourChanger BlackStone = new ColourChanger("Black Stone", "21,22,24");
        ColourChanger DarkOlivePearl = new ColourChanger("Dark Olive Pearl", "7,65,17");
        ColourChanger Turquoise = new ColourChanger("Turquoise", "58,131,140");
        ColourChanger White = new ColourChanger("White", "253,253,241");
        ColourChanger BrilliantRed = new ColourChanger("Brilliant Red", "196,19,45");
        ColourChanger GunMetalGrey = new ColourChanger("Gun Metal Grey", "103,99,98");

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
            //
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
            colorCombo.Items.Add(CreamYellow);
            colorCombo.Items.Add(BlackStone);
            colorCombo.Items.Add(DarkOlivePearl);
            colorCombo.Items.Add(Turquoise);
            colorCombo.Items.Add(White);
            colorCombo.Items.Add(BrilliantRed);
            colorCombo.Items.Add(GunMetalGrey);
        }

        private void DiscoButton_Click(object sender, EventArgs e)
        {
            buttonClick = !buttonClick;
            if(buttonClick)
                backgroundWorker1.RunWorkerAsync();

        }

        private void colorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            ColourChanger colorCode = (ColourChanger)combo.SelectedItem;
            var rgbCodeString = colorCode.Value.Split(',');
            int[] rgbCode = new int[3];
            rgbCode[0] = Convert.ToInt32(rgbCodeString[0]);
            rgbCode[1] = Convert.ToInt32(rgbCodeString[1]);
            rgbCode[2] = Convert.ToInt32(rgbCodeString[2]);
        
            Color rand = Color.FromArgb(rgbCode[0], rgbCode[1], rgbCode[2]);
            foreach (var auto in selectedList.AutoComponents)
            {
                auto.SetColor(rand);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Random r = new Random();
            while(buttonClick)
            {
                var colorCode = (ColourChanger)colorCombo.Items[r.Next(colorCombo.Items.Count)];
                var rgbCodeString = colorCode.Value.Split(',');
                int[] rgbCode = new int[3];
                rgbCode[0] = Convert.ToInt32(rgbCodeString[0]);
                rgbCode[1] = Convert.ToInt32(rgbCodeString[1]);
                rgbCode[2] = Convert.ToInt32(rgbCodeString[2]);

                Color rand = Color.FromArgb(rgbCode[0], rgbCode[1], rgbCode[2]);                
                selectedList.SetColor(rand);
            }
        }
    }
}
