using System;
using System.Collections.Generic;
using System.Text;
using SkiaSharp;
using SkiaSharp.Extended;

namespace StationStopLine.Extensions
{
    public static class SKCanvasExtension
    {
        public static void DrawSemiRect(this SKCanvas canvas, float cx, float cy,
            SKPaint paint, float width = 40, float height = 30)
        {
            SKPath skPath = new SKPath();
            float x1 = cx - width;
            float y1 = cy - height / 2f;
            float y2 = cy + height / 2f;
            skPath.MoveTo(x1, y1);
            skPath.LineTo(cx, y1);
            skPath.LineTo(cx, y2);
            skPath.LineTo(x1, y2);
            canvas.DrawPath(skPath, paint);
        }

        public static void DrawArrow(this SKCanvas canvas, float cx, float cy,
            SKPaint paint, SKColor fillColor, float width = 40, float height = 30)
        {
            SKPath skPath = new SKPath();
            float y1 = cy - height / 2f;
            float y2 = cy + height / 2f;
            skPath.MoveTo(cx, y1);
            skPath.LineTo(cx + width, cy);
            skPath.LineTo(cx, y2);
            skPath.Close();

            SKPaint fillPaint = new SKPaint
            {
                Style = SKPaintStyle.Fill,
                Color = fillColor
            };
            canvas.DrawPath(skPath, paint);
            canvas.DrawPath(skPath, fillPaint);
        }
    }
}
