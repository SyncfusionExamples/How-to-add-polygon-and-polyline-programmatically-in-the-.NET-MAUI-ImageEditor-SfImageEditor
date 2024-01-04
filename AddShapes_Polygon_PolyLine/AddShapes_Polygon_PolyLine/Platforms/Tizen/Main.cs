using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace AddShapes_Polygon_PolyLine;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
