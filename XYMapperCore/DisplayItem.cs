using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace XYMapperCore
{
    public class DisplayItem
    {
        private string name;
        private Point[] xyPoints;
        private Brush backFill;
        private Pen border;
        private DisplayItem[] children;

        public DisplayItem(string Name, Point[] Points, Brush BackFill, Pen Border)
        {
            name = Name;
            xyPoints = Points;
            backFill = BackFill;
            border = Border;
        }

        public string Name { get { return name; } set { name = value; } }

        public Brush BackFill { get { return backFill; } set { backFill = value; } }

        public Pen Border { get { return border; } set { border = value; } }

        public void SetPoints(Point[] Points)
        {
            xyPoints = Points;
        }

        public void Render(DrawingContext Context)
        {
            StreamGeometry streamGeometry = new StreamGeometry();
            using (StreamGeometryContext geometryContext = streamGeometry.Open())
            {
                geometryContext.BeginFigure(xyPoints[0], true, true);


                for (int i = 1; i < xyPoints.Length; i++)
                {
                    /*if (radius[i] > 0)
                    {
                        geometryContext.ArcTo(
                            new Point(
                                ((points[i].X + offsetX) * Scale) + OffsetXPixels,
                                ((points[i].Y + offsetY) * Scale) + OffsetYPixels
                                ),
                                new Size(radius[i] * Scale, radius[i] * Scale),
                                0,
                                false,
                                 SweepDirection.Clockwise,
                                 true,
                                 true);
                    }
                    else if (radius[i] < 0)
                    {
                        geometryContext.ArcTo(
                            new Point(
                                ((points[i].X + offsetX) * Scale) + OffsetXPixels,
                                ((points[i].Y + offsetY) * Scale) + OffsetYPixels
                                ),
                                new Size(-radius[i] * Scale, -radius[i] * Scale),
                                0,
                                false,
                                 SweepDirection.Counterclockwise,
                                 true,
                                 true);
                    }
                    else
                    */
                    {
                        geometryContext.LineTo(
                            xyPoints[i],
                            true,
                            true);
                    }
                }

            }
            streamGeometry.Freeze();
            Context.DrawGeometry(backFill, border, streamGeometry);
        }
    }
}
