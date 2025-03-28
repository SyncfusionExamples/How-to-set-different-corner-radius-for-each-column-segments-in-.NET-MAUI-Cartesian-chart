# How-to-set-different-corner-radius-for-each-column-segments-in-.NET-MAUI-Cartesian-chart
 This article shows how to set different corner radius for each column segments in .NET MAUI Cartesian chart.

 In [.NET MAUI Cartesian Charts](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CartesianSegment.html), column segments typically have uniform corner radii, but there are scenarios where customizing the radius for each segment individually enhances visualization. By extending the [ColumnSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ColumnSeries.html?tabs=tabid-1%2Ctabid-8%2Ctabid-4%2Ctabid-28%2Ctabid-6) and [ColumnSegment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ColumnSegment.html) classes, you can dynamically apply different corner radii based on data values. 

 This approach is useful in various applications, such as financial reports where key data points need emphasis, sales analysis to visually differentiate high and low performances, and progress-tracking applications where milestones can be highlighted with varying rounded corners. Additionally, in health and fitness apps, this customization helps represent activity levels more distinctly, making the data easier to interpret.

 # Output
 
![CustomCornerRadius](https://github.com/user-attachments/assets/35555558-d75c-4ae4-ae62-821fedb26d27)

# Troubleshooting
## Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
