using System;
using System.Collections.Generic;
using System.Text;

namespace LabGesture.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        TapDemo,
        PinchDemo,
        PanDemo,
        SwipeDemo,
        SwipeBinding
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
