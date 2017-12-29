using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace GardenMapper
{
    public class Concrete : XYMapperCore.DisplayItem
    {
        public Concrete(string Name, Point[] Points) : base(Name, Points, new SolidColorBrush(Colors.Silver), null)
        {

        }
    }
}
