using System;
using System.Collections.Generic;
using System.Text;
using SkiaSharp;
using SkiaSharp.Extended;
using StationStopLine.Models;

namespace StationStopLine.Extensions
{
    public static class SKCanvasExtension
    {
        public static void DrawSemiRect(this SKCanvas canvas, float cx, float cy,
            SKPaint paint, float width = 40, float height = 30, bool ltr = true)
        {
            SKPath skPath = new SKPath();
            float x1 = ltr ? cx + width : cx - width;
            float y1 = cy - height / 2f;
            float y2 = cy + height / 2f;
            skPath.MoveTo(x1, y1);
            skPath.LineTo(cx, y1);
            skPath.LineTo(cx, y2);
            skPath.LineTo(x1, y2);
            canvas.DrawPath(skPath, paint);
        }

        public static void DrawArrow(this SKCanvas canvas, float cx, float cy,
            SKPaint paint, SKColor fillColor, float width = 40, float height = 30, bool ltr = true)
        {
            SKPath skPath = new SKPath();
            float y1 = cy - height / 2f;
            float y2 = cy + height / 2f;
            float x = ltr ? cx + width : cx - width;
            skPath.MoveTo(cx, y1);
            skPath.LineTo(x, cy);
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

        public static void DrawPolyLine(this SKCanvas canvas, List<Line> lines, SKPaint paint)
        {
            if (lines.Count < 1) return;

            foreach (Line line in lines)
            {
                if(line.EndPoint.IsEmpty)continue;
                ;
                canvas.DrawLine(line.StartPoint.X, line.StartPoint.Y, line.EndPoint.X, line.EndPoint.Y, paint);
            }
        }
    }
}
