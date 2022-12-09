using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.ComponentModel;

namespace b3bsa
{
    public class RJ_button : Button
    {
        private int bordersize = 0;
        private int borderRadius = 40;
        private Color bordercolor = Color.Transparent;


        public RJ_button()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectsurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectborder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (borderRadius > 2)
            {

                using (GraphicsPath pathsurface = GetFigurePath(rectsurface, borderRadius))
                using (GraphicsPath pathborder = GetFigurePath(rectborder, borderRadius - 1F))
                using (Pen pensurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penborder = new Pen(bordercolor, bordersize))
                {
                    penborder.Alignment = PenAlignment.Inset;
                    //button surface
                    this.Region = new Region(pathsurface);
                    //draw surface border for HD result
                    pevent.Graphics.DrawPath(penborder, pathborder);

                }

            }
            else //normal button
            {
                //button surface
                this.Region = new Region(rectsurface);
                //button border
                if (bordersize >= 1)
                {
                    using (Pen penborder = new Pen(bordercolor, bordersize))
                    {
                        penborder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penborder, 0, 0, this.Width - 1, this.Height - 1);
                    }

                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}