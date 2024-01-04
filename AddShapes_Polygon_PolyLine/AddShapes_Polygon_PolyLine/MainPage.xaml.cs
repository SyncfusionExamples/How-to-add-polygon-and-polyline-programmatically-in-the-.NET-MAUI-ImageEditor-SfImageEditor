using Syncfusion.Maui.ImageEditor;

namespace AddShapes_Polygon_PolyLine;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private void OnPolygonClicked(object sender, EventArgs e)
    {
        this.imageEditor.AddShape(AnnotationShape.Polygon,
            new ImageEditorShapeSettings()
            {
                StrokeThickness = 5,

                Points = new PointCollection
                {
                    new Point(100, 100),
                    new Point(200, 100),
                    new Point(250, 175),
                    new Point(200, 250),
                    new Point(100, 250),
                    new Point(50, 175)
                },
            });
    }
    private void OnPolylineClicked(object sender, EventArgs e)
    {
        this.imageEditor.AddShape(AnnotationShape.Polyline,
            new ImageEditorShapeSettings()
            {
                Points = new PointCollection
                {
                    new Point(500, 100),
                    new Point(550, 250),
                    new Point(575, 100),
                    new Point(590, 400),
                    new Point(615, 250),
                    new Point(675, 250),
                    new Point(700, 100),
                    new Point(715, 400),
                    new Point(740, 250),
                    new Point(800, 250)
                },
            });
    }
}