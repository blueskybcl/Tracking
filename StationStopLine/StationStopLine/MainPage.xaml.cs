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
	    private GeometryType _geometryType = GeometryType.ArrowLine;
	    private SKPoint _startPoit, _endPoint;

		public MainPage()
		{
			InitializeComponent();
		}

	    private void StationLineView_OnTouch(object sender, SKTouchEventArgs e)
	    {
	        switch (e.ActionType)
	        {
	            case SKTouchAction.Pressed:
	                _startPoit = e.Location;
	                break;

	            case SKTouchAction.Moved:
	                _endPoint = e.Location;
	                break;

	            case SKTouchAction.Released:
	                //_paths.Add(_temporaryPaths[e.Id]);
	                //_temporaryPaths.Remove(e.Id);
	                break;

	            case SKTouchAction.Cancelled:
	                //_temporaryPaths.Remove(e.Id);
	                break;
	        }

	        e.Handled = true;
	        ((SKCanvasView)sender).InvalidateSurface();
        }

        private void StationLineView_OnPaintSurface(object sender, SKPaintSurfaceEventArgs e)
	    {
	        SKSurface surface = e.Surface;
	        SKCanvas canvas = surface.Canvas;
            canvas.Clear();
            
	        DrawGraphics(canvas);
	    }

	    private void DrawGraphics(SKCanvas canvas)
	    {
	        //foreach (var VARIABLE in COLLECTION)
	        {
	            SKPaint pen = new SKPaint
	            {
	                IsAntialias = true,
	                Style = SKPaintStyle.Stroke,
	                Color = SKColors.Black,
	                StrokeWidth = 5
	            };

	            Draw(canvas, _geometryType, pen);
	        }
	    }

	    private void Draw(SKCanvas canvas, GeometryType geometryType, SKPaint pen)
	    {
	        switch (geometryType)
	        {
	            case GeometryType.Text:
	                break;

	            case GeometryType.Line:
	                break;

	            case GeometryType.ArrowLine:
	                DrawArrowLine(canvas, pen);
	                break;

	            case GeometryType.PolyLine:
	                break;

	            case GeometryType.PolyArrowLine:
	                break;

	            case GeometryType.SemiRectArrowLine:
	                DrawSemiRectArrowLine(canvas, pen);
                    break;

	            case GeometryType.SemiRectLine:
	                break;

	            case GeometryType.PolySemiRectArrowLine:
	                break;

	            case GeometryType.PolySemiRectLine:
	                break;
	        }
        }

	    private void DrawSemiRectArrowLine(SKCanvas canvas, SKPaint pen)
	    {
	        if (_startPoit.IsEmpty || _endPoint.IsEmpty) return;

	        canvas.DrawSemiRect(_startPoit.X, _startPoit.Y, pen);
	        canvas.DrawLine(_startPoit.X, _startPoit.Y, _endPoint.X, _startPoit.Y, pen);
	        canvas.DrawArrow(_endPoint.X, _startPoit.Y, pen, SKColors.Black);
	    }

	    private void DrawArrowLine(SKCanvas canvas, SKPaint pen)
	    {
	        if (_startPoit.IsEmpty || _endPoint.IsEmpty) return;

            canvas.DrawLine(_startPoit.X, _startPoit.Y, _endPoint.X, _startPoit.Y, pen);
	        canvas.DrawArrow(_endPoint.X, _startPoit.Y, pen, SKColors.Black);
        }
	}
}
