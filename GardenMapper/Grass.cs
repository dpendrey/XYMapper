using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace GardenMapper
{
    public class Grass : XYMapperCore.DisplayItem
    {
        public Grass(string Name, Point[] Points) : base(Name, Points, new SolidColorBrush(Colors.LightGreen), null)
        {

        }

        public DateTime LastMow;
        public DateTime LastWeedNFeed;
    }
}
