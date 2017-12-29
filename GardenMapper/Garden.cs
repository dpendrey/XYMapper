using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace GardenMapper
{
    public class Garden : XYMapperCore.DisplayItem
    {
        public Garden(string Name, Point[] Points) : base(Name, Points, new SolidColorBrush(Colors.Brown), null)
        {

        }

        public DateTime LastWeed;
    }
}
