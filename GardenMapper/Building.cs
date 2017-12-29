using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace GardenMapper
{
    public class Building : XYMapperCore.DisplayItem
    {
        public Building(string Name, Point[] Points) : base(Name, Points, new SolidColorBrush(Colors.Brown), new Pen(Brushes.Black, 1))
        {

        }
    }
}