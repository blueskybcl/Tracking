using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkiaSharp;
using SkiaSharp.Extended;
using SkiaSharp.Views.Forms;
using StationStopLine.Extensions;
using StationStopLine.Models;
using Xamarin.Forms;

namespace StationStopLine
{
    public partial class MainPage : ContentPage
    {
        private GeometryType _geometryType;
        private LineDiagram _diagram;
        private Graphic _currentGraphic;

        public MainPage()
        {
            InitializeComponent();
            Init();

        }

        private void Init()
        {
            _diagram = new LineDiagram();
        }

        private void GeometryTypeTab_Tapped(object sender, int e)
        {
            switch (e)
            {
                case 0:
                    _geometryType = GeometryType.Text;
                    break;

                case 1:
                    _geometryType = GeometryType.Line;
                    break;

                case 2:
                    _geometryType = GeometryType.ArrowLine;
                    break;

                case 3:
                    _geometryType = GeometryType.PolyLine;
                    break;

                case 4:
                    _geometryType = GeometryType.PolyArrowLine;
                    break;

                case 5:
                    _geometryType = GeometryType.SemiRectArrowLine;
                    break;

                case 6:
                    _geometryType = GeometryType.SemiRectLine;
                    break;

                case 7:
                    _geometryType = GeometryType.PolySemiRectArrowLine;
                    break;

                case 8:
                    _geometryType = GeometryType.PolySemiRectLine;
                    break;


            }
        }

        private void StationLineView_OnTouch(object sender, SKTouchEventArgs e)
        {
            switch (e.ActionType)
            {
                case SKTouchAction.Pressed:
                    _currentGraphic = new Graphic();
                    _currentGraphic.Id = DateTime.Now.Ticks;
                    _currentGraphic.GeometryType = _geometryType;
                    _currentGraphic.Points = GeneralSKPointArray();
                    if (_currentGraphic.Points.Length > 0)
                    {
                        _currentGraphic.Points[0] = e.Location;
                    }
                    
                    break;

                case SKTouchAction.Moved:
                    SetSecondPoint(e.Location);
                    break;

                case SKTouchAction.Released:
                    SetSecondPoint(e.Location);
                    _diagram.Graphics.Add(_currentGraphic); 
                    break;

                case SKTouchAction.Cancelled:
                    _currentGraphic = null;
                    break;
            }

            e.Handled = true;
            ((SKCanvasView) sender).InvalidateSurface();
        }

        private void SetSecondPoint(SKPoint location)
        {
            switch (_geometryType)
            {
                case GeometryType.Line:
                case GeometryType.ArrowLine:
                case GeometryType.SemiRectArrowLine:
                case GeometryType.SemiRectLine:
                    _currentGraphic.Points[1] = location;
                    break;

                case GeometryType.PolyLine:
                case GeometryType.PolyArrowLine:
                case GeometryType.PolySemiRectArrowLine:
                case GeometryType.PolySemiRectLine:
                    //_currentGraphic.Points[1] = location;
                    break;
            }
        }

        private void StationLineView_OnPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;
            canvas.Clear();

            DrawCurrentGraphic(canvas);
            DrawGraphics(canvas);
        }

        private void DrawCurrentGraphic(SKCanvas canvas)
        {
            Draw(canvas, _currentGraphic);
        }

        private void DrawGraphics(SKCanvas canvas)
        {
            foreach (Graphic graphic in _diagram.Graphics)
            {
                Draw(canvas, graphic);
            }
        }

        private void Draw(SKCanvas canvas, Graphic graphic)
        {
            if (graphic == null) return;

            SKPaint pen = new SKPaint
            {
                IsAntialias = true,
                Style = SKPaintStyle.Stroke,
                Color = graphic.FillColor,
                StrokeWidth = graphic.StrokeWidth
            };

            switch (graphic.GeometryType)
            {
                case GeometryType.Text:
                    break;

                case GeometryType.Line:
                    break;

                case GeometryType.ArrowLine:
                    DrawArrowLine(canvas, graphic.Points[0], graphic.Points[1], pen);
                    break;

                case GeometryType.PolyLine:
                    break;

                case GeometryType.PolyArrowLine:
                    break;

                case GeometryType.SemiRectArrowLine:
                    DrawSemiRectArrowLine(canvas, graphic.Points[0], graphic.Points[1], pen);
                    break;

                case GeometryType.SemiRectLine:
                    break;

                case GeometryType.PolySemiRectArrowLine:
                    break;

                case GeometryType.PolySemiRectLine:
                    break;
            }
        }

        private void DrawSemiRectArrowLine(SKCanvas canvas, SKPoint startPoint, SKPoint endPoint, SKPaint pen)
        {
            if (startPoint.IsEmpty || endPoint.IsEmpty) return;

            canvas.DrawSemiRect(startPoint.X, startPoint.Y, pen);
            canvas.DrawLine(startPoint.X, startPoint.Y, endPoint.X, startPoint.Y, pen);
            canvas.DrawArrow(endPoint.X, startPoint.Y, pen, SKColors.Black);
        }

        private void DrawArrowLine(SKCanvas canvas, SKPoint startPoint, SKPoint endPoint, SKPaint pen)
        {
            if (startPoint.IsEmpty || endPoint.IsEmpty) return;

            canvas.DrawLine(startPoint.X, startPoint.Y, endPoint.X, startPoint.Y, pen);
            canvas.DrawArrow(endPoint.X, startPoint.Y, pen, SKColors.Black);
        }

        private SKPoint[] GeneralSKPointArray()
        {
            switch (_geometryType)
            {
                case GeometryType.Text:
                    return new SKPoint[1];

                case GeometryType.Line:
                case GeometryType.ArrowLine:
                case GeometryType.SemiRectArrowLine:
                case GeometryType.SemiRectLine:
                    return new SKPoint[2];

                case GeometryType.PolyLine:
                case GeometryType.PolyArrowLine:
                case GeometryType.PolySemiRectArrowLine:
                case GeometryType.PolySemiRectLine:
                    return new SKPoint[6];
            }

            return new SKPoint[0];
        }
    }
}
