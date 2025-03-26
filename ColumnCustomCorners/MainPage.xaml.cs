using Syncfusion.Maui.Toolkit.Carousel;
using Syncfusion.Maui.Toolkit.Charts;

namespace ColumnCustomCorners;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
}

public class ColumnSeriesExt : ColumnSeries
{
    protected override ChartSegment CreateSegment()
    {
        return new ColumnSegmentExt();
    }
}

public class ColumnSegmentExt : ColumnSegment
{
    protected override void Draw(ICanvas canvas)
    {
        var rect = new Rect() { Left = Left, Top = Top, Right = Right, Bottom = Bottom };
        if (Item is Model model)
        {
            if (model.ProfitLoss > 0)
            {
                canvas.FillColor = Colors.Green;
                canvas.FillRoundedRectangle(rect, 50.0, 50.0, 0.0, 0.0);
            }
            else
            {
                canvas.FillColor = Colors.Red;
                canvas.FillRoundedRectangle(rect, 0.0, 0.0, 50.0, 50.0);
            }
        }
    }
}

