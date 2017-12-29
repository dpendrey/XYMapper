using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XYMapperCore
{
    public class DisplaySystem
    {
        private string name;
        private List<DisplayItem> items = new List<DisplayItem>();

        public string Name { get { return name; } set { name = value; } }

        public int NumberItems { get { return items.Count; } }

        public IEnumerator<DisplayItem> ListItems { get { return items.GetEnumerator(); } }

        public void AddDisplayItem(DisplayItem DisplayItem)
        {
            if (!items.Contains(DisplayItem))
                items.Add(DisplayItem);
        }

        public void RemoveDisplayItem(DisplayItem DisplayItem)
        {
            items.Remove(DisplayItem);
        }

        internal void Render(System.Windows.Media.DrawingContext Context)
        {
            foreach (DisplayItem item in items)
                item.Render(Context);
        }
    }
}
