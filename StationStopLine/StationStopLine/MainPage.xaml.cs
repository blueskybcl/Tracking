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
        private bool isDrawPolyComplete = false;

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
                    GeneralGraphic(e.Location);
                    break;

                case SKTouchAction.Moved:
                    SetSecondPoint(e.Location);
                    break;

                case SKTouchAction.Released:
                    SetSecondPoint(e.Location);
                    CompeteDraw(e.Location);
                    break;

                case SKTouchAction.Cancelled:
                    _currentGraphic = null;
                    break;
            }

            e.Handled = true;
            ((SKCanvasView) sender).InvalidateSurface();
        }
        
        private void GeneralGraphic(SKPoint location)
        {
            switch (_geometryType)
            {
                case GeometryType.Text:
                case GeometryType.Line:
                case GeometryType.ArrowLine:
                case GeometryType.SemiRectArrowLine:
                case GeometryType.SemiRectLine:
                    _currentGraphic = new Graphic();
                    break;

                case GeometryType.PolyLine:
                case GeometryType.PolyArrowLine:
                case GeometryType.PolySemiRectArrowLine:
                case GeometryType.PolySemiRectLine:
                    if (_currentGraphic == null)
                    {
                        isDrawPolyComplete = false;
                        _currentGraphic = new Graphic();
                    }
                    else
                    {
                        Line endLine = _currentGraphic.Lines[_currentGraphic.Lines.Count - 1];
                        _currentGraphic.Lines.Add(new Line { StartPoint = endLine.EndPoint, EndPoint = location });
                    }
                    
                    break;
            }

            _currentGraphic.Id = DateTime.Now.Ticks;
            _currentGraphic.GeometryType = _geometryType;
            _currentGraphic.Lines.Add(new Line { StartPoint = location });
        }

        private void CompeteDraw(SKPoint eLocation)
        {
            switch (_geometryType)
            {
                case GeometryType.Text:
                case GeometryType.Line:
                case GeometryType.ArrowLine:
                case GeometryType.SemiRectArrowLine:
                case GeometryType.SemiRectLine:
                    _diagram.Graphics.Add(_currentGraphic);
                    break;

                case GeometryType.PolyLine:
                case GeometryType.PolyArrowLine:
                case GeometryType.PolySemiRectArrowLine:
                case GeometryType.PolySemiRectLine:
                    if (isDrawPolyComplete)
                    {
                        _diagram.Graphics.Add(_currentGraphic);
                        _currentGraphic = null;
                    }
                    break;
            }
        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            isDrawPolyComplete = true;
        }

        private void StationLineView_OnPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;
            canvas.Clear();

            DrawCurrentGraphic(canvas);
            DrawGraphics(canvas);
        }
        
        private void SetSecondPoint(SKPoint location)
        {
            switch (_geometryType)
            {
                case GeometryType.Line:
                case GeometryType.ArrowLine:
                case GeometryType.SemiRectArrowLine:
                case GeometryType.SemiRectLine:
                    Line tempLine = _currentGraphic.Lines[0];
                    tempLine.EndPoint = location;
                    
                    break;

                case GeometryType.PolyLine:
                case GeometryType.PolyArrowLine:
                case GeometryType.PolySemiRectArrowLine:
                case GeometryType.PolySemiRectLine:
                    Line endLine = _currentGraphic.Lines[_currentGraphic.Lines.Count - 1];
                    endLine.EndPoint = location;
                    break;
            }
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
            if (graphic == null || graphic.Lines.Count == 0) return;

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
                    DrawText(canvas, graphic, pen);
                    break;

                case GeometryType.Line:
                    DrawLine(canvas, graphic, pen);
                    break;

                case GeometryType.ArrowLine:
                    DrawArrowLine(canvas, graphic, pen);
                    break;

                case GeometryType.PolyLine:
                    DrawPolyLine(canvas, graphic, pen);
                    break;

                case GeometryType.PolyArrowLine:
                    DrawPolyArrowLine(canvas, graphic, pen);
                    break;

                case GeometryType.SemiRectArrowLine:
                    DrawSemiRectArrowLine(canvas, graphic, pen);
                    break;

                case GeometryType.SemiRectLine:
                    DrawSemiRectLine(canvas, graphic, pen);
                    break;

                case GeometryType.PolySemiRectArrowLine:
                    DrawPolySemiRectArrowLine(canvas, graphic, pen);
                    break;

                case GeometryType.PolySemiRectLine:
                    DrawPolySemiRectLine(canvas, graphic, pen);
                    break;
            }
        }
        
        private void DrawText(SKCanvas canvas, Graphic graphic, SKPaint pen)
        {
            pen.TextSize = 28;
            SKPoint position = graphic.Lines[0].StartPoint;
            canvas.DrawText(" Test ", position.X, position.Y, pen);
        }

        private void DrawLine(SKCanvas canvas, Graphic graphic, SKPaint pen)
        {
            if (graphic.Lines.Count != 1) return;

            Line tempLine = graphic.Lines[0];
            SKPoint startPoint = tempLine.StartPoint;
            SKPoint endPoint = tempLine.EndPoint;
            if (endPoint.IsEmpty) return;

            canvas.DrawLine(startPoint.X, startPoint.Y, endPoint.X, startPoint.Y, pen);
        }

        private void DrawArrowLine(SKCanvas canvas, Graphic graphic, SKPaint pen)
        {
            if (graphic.Lines.Count != 1) return;

            Line tempLine = graphic.Lines[0];
            SKPoint startPoint = tempLine.StartPoint;
            SKPoint endPoint = tempLine.EndPoint;
            if (endPoint.IsEmpty) return;

            canvas.DrawLine(startPoint.X, startPoint.Y, endPoint.X, startPoint.Y, pen);
            canvas.DrawArrow(endPoint.X, startPoint.Y, pen, SKColors.Black, ltr: startPoint.X < endPoint.X);
        }

        private void DrawSemiRectLine(SKCanvas canvas, Graphic graphic, SKPaint pen)
        {
            if (graphic.Lines.Count != 1) return;

            Line tempLine = graphic.Lines[0];
            SKPoint startPoint = tempLine.StartPoint;
            SKPoint endPoint = tempLine.EndPoint;
            if (endPoint.IsEmpty) return;

            bool ltr = startPoint.X < endPoint.X;
            canvas.DrawSemiRect(startPoint.X, startPoint.Y, pen, ltr: !ltr);
            canvas.DrawLine(startPoint.X, startPoint.Y, endPoint.X, startPoint.Y, pen);
            canvas.DrawSemiRect(endPoint.X, startPoint.Y, pen, ltr: ltr);
        }

        private void DrawPolySemiRectLine(SKCanvas canvas, Graphic graphic, SKPaint pen)
        {
            if (graphic.Lines.Count < 2) return;

            Line startLine = graphic.Lines[0];
            SKPoint startPoint = startLine.StartPoint;
            Line endLine = graphic.Lines[graphic.Lines.Count - 1];
            if (endLine.EndPoint.IsEmpty)
            {
                endLine = graphic.Lines[graphic.Lines.Count - 2];
            }

            SKPoint endPoint = endLine.EndPoint;
            canvas.DrawSemiRect(startPoint.X, startPoint.Y, pen, ltr: startLine.StartPoint.X > startLine.EndPoint.X);
            canvas.DrawPolyLine(graphic.Lines, pen);
            canvas.DrawSemiRect(endPoint.X, endPoint.Y, pen, ltr: endLine.StartPoint.X < endLine.EndPoint.X);
        }

        private void DrawPolySemiRectArrowLine(SKCanvas canvas, Graphic graphic, SKPaint pen)
        {
            if (graphic.Lines.Count < 2) return;

            Line startLine = graphic.Lines[0];
            Line endLine = graphic.Lines[graphic.Lines.Count - 1];
            SKPoint startPoint = startLine.StartPoint;
            SKPoint endPoint = endLine.EndPoint;
            canvas.DrawSemiRect(startPoint.X, startPoint.Y, pen, ltr: startLine.StartPoint.X > startLine.EndPoint.X);
            canvas.DrawPolyLine(graphic.Lines, pen);
            canvas.DrawArrow(endPoint.X, endPoint.Y, pen, graphic.FillColor, ltr: endLine.StartPoint.X < endLine.EndPoint.X);
        }
        
        private void DrawPolyArrowLine(SKCanvas canvas, Graphic graphic, SKPaint pen)
        {
            if (graphic.Lines.Count < 2) return;
            
            Line endLine = graphic.Lines[graphic.Lines.Count - 1];
            SKPoint endPoint = endLine.EndPoint;
            canvas.DrawPolyLine(graphic.Lines, pen);
            canvas.DrawArrow(endPoint.X, endPoint.Y, pen, graphic.FillColor, ltr: endLine.StartPoint.X < endLine.EndPoint.X);
        }

        private void DrawPolyLine(SKCanvas canvas, Graphic graphic, SKPaint pen)
        {
            if (graphic.Lines.Count < 2) return;

            canvas.DrawPolyLine(graphic.Lines, pen);
        }

        private void DrawSemiRectArrowLine(SKCanvas canvas, Graphic graphic, SKPaint pen)
        {
            if (graphic.Lines.Count < 1) return;

            Line startLine = graphic.Lines[0];
            Line endLine = graphic.Lines[graphic.Lines.Count - 1];
            SKPoint startPoint = startLine.StartPoint;
            SKPoint endPoint = endLine.EndPoint;
            if (endPoint.IsEmpty) return;

            bool ltr = startPoint.X < endPoint.X;
            canvas.DrawSemiRect(startPoint.X, startPoint.Y, pen, ltr: !ltr);
            canvas.DrawLine(startPoint.X, startPoint.Y, endPoint.X, startPoint.Y, pen);
            canvas.DrawArrow(endPoint.X, startPoint.Y, pen, graphic.FillColor, ltr: ltr);
        }
    }
}
