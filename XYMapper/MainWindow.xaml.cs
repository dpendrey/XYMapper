using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XYMapper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            XYMapperCore.DisplaySystem yard = new XYMapperCore.DisplaySystem();
            XYMapperCore.DisplayItem footpath = new GardenMapper.Grass(
                "Footpath",
                new Point[]
                {
                    new Point(0,0),
                    new Point(20,0),
                    new Point(20,5),
                    new Point(0,5)
                });

            XYMapperCore.DisplayItem sideGarden1 = new GardenMapper.Garden(
                "Side Garden 1",
                new Point[]
                {
                    new Point(0,5),
                    new Point(1,5),
                    new Point(1,35),
                    new Point(0,35)
                });
            XYMapperCore.DisplayItem sideGarden2 = new GardenMapper.Garden(
                "Side Garden 2",
                new Point[]
                {
                    new Point(2,5),
                    new Point(2.5,5),
                    new Point(2.5,35),
                    new Point(2,35)
                });

            XYMapperCore.DisplayItem sideDriveWayConcrete1 = new GardenMapper.Concrete(
                "Side Driveway (Concrete 1)",
                new Point[]
                {
                    new Point(1,5),
                    new Point(1.2,5),
                    new Point(1.2,35),
                    new Point(1,35)
                });
            XYMapperCore.DisplayItem sideDriveWayConcrete2 = new GardenMapper.Concrete(
                "Side Driveway (Concrete 2)",
                new Point[]
                {
                    new Point(1.8,5),
                    new Point(2,5),
                    new Point(2,35),
                    new Point(1.8,35)
                });
            XYMapperCore.DisplayItem sideDriveWayGrass= new GardenMapper.Grass(
                "Side Driveway (Grass)",
                new Point[]
                {
                    new Point(1.2,5),
                    new Point(1.8,5),
                    new Point(1.8,35),
                    new Point(1.2,35)
                });


            XYMapperCore.DisplayItem house = new GardenMapper.Building(
                "House",
                new Point[]
                {
                    new Point(2.5,5),
                    new Point(15,5),
                    new Point(15,35),
                    new Point(2.5,35)
                });

            yard.AddDisplayItem(footpath);

            yard.AddDisplayItem(sideGarden1);
            yard.AddDisplayItem(sideGarden2);

            yard.AddDisplayItem(sideDriveWayConcrete1);
            yard.AddDisplayItem(sideDriveWayConcrete2);
            yard.AddDisplayItem(sideDriveWayGrass);

            yard.AddDisplayItem(house);

            displayRenderer.DisplaySystem = yard;
        }
    }
}
