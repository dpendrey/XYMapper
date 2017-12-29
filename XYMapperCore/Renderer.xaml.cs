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

namespace XYMapperCore
{
    /// <summary>
    /// Interaction logic for Renderer.xaml
    /// </summary>
    public partial class Renderer : UserControl
    {
        public Renderer()
        {
            
            InitializeComponent();
        }

        private DisplaySystem displaySystem = null;

        public DisplaySystem DisplaySystem { get { return displaySystem; } set { displaySystem = value; } }

        protected override void OnRender(DrawingContext drawingContext)
        {
            if (displaySystem != null)
            {
                drawingContext.PushTransform(new ScaleTransform(5, 5));

                displaySystem.Render(drawingContext);

                drawingContext.Pop();
            }
        }
    }
}
