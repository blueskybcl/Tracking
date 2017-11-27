using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tracking.Core.Controls
{
    /// <summary>
    /// Base layout class.
    /// </summary>
    public class BaseLayout : Layout<View>
    {
        protected bool HasVisibileChildren()
        {
            foreach (View child in Children)
            {
                if (child.IsVisible)
                {
                    return true;
                }
            }

            return false;
        }

        protected override void LayoutChildren(double x, double y, double width, double height) { }
    }
}
