using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tracking.Core.Controls
{
    /// <summary>
    /// Flow layout class.
    /// </summary>
    public class FlowLayout : BaseLayout
    {
        public static readonly BindableProperty ColumnSpacingProperty =
                BindableProperty.Create(
                    "ColumnSpacing",
                    typeof(double),
                    typeof(FlowLayout),
                    6.0,
                    propertyChanged: (bindable, oldvalue, newvalue) =>
                    {
                        ((FlowLayout)bindable).InvalidateLayout();
                    });

        public static readonly BindableProperty RowSpacingProperty =
                BindableProperty.Create(
                    "RowSpacing",
                    typeof(double),
                    typeof(FlowLayout),
                    6.0,
                    propertyChanged: (bindable, oldvalue, newvalue) =>
                    {
                        ((FlowLayout)bindable).InvalidateLayout();
                    });

        /// <summary>
        /// Gets or sets the column spacing.
        /// </summary>
        /// <value>The column spacing.</value>
        public double ColumnSpacing
        {
            set => SetValue(ColumnSpacingProperty, value);
            get => (double)GetValue(ColumnSpacingProperty);
        }

        /// <summary>
        /// Gets or sets the row spacing.
        /// </summary>
        /// <value>The row spacing.</value>
        public double RowSpacing
        {
            set => SetValue(RowSpacingProperty, value);
            get => (double)GetValue(RowSpacingProperty);
        }

        protected override void LayoutChildren(double x, double y, double width, double height)
        {
            if (!HasVisibileChildren())
            {
                return;
            }

            double xChild = 0, yChild = 0;
            foreach (View child in Children)
            {
                if (!child.IsVisible)
                {
                    continue;
                }

                SizeRequest childSizeRequest = child.Measure(width, height);

                double childWidth = childSizeRequest.Request.Width;
                double childHeight = childSizeRequest.Request.Height;

                if (xChild + childWidth > width)
                {
                    xChild = 0;
                    yChild += childHeight + RowSpacing;
                }

                LayoutChildIntoBoundingRegion(child, new Rectangle(xChild, yChild, width, height));

                xChild = xChild + childWidth + ColumnSpacing;
            }
        }

        protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
        {
            if (!HasVisibileChildren())
            {
                return new SizeRequest();
            }

            Size size = new Size();
            double rowWidth = 0.0;

            foreach (View child in Children)
            {
                if (!child.IsVisible)
                {
                    continue;
                }

                SizeRequest childSizeRequest = child.Measure(widthConstraint, double.PositiveInfinity);
                double childWidth = childSizeRequest.Request.Width;
                double childHeight = childSizeRequest.Request.Height;

                size.Height = Math.Max(size.Height, childHeight);
                rowWidth += childWidth + ColumnSpacing;
                if (rowWidth > widthConstraint)
                {
                    size.Height += childHeight + RowSpacing;
                    rowWidth = childWidth;
                }

                size.Width = Math.Max(size.Width, rowWidth);
            }

            return new SizeRequest(size);
        }

        protected override bool ShouldInvalidateOnChildAdded(View child)
        {
            return false;
        }
    }
}
