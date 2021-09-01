<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128568401/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T209933)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DataSourceFromTemplate/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DataSourceFromTemplate/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DataSourceFromTemplate/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DataSourceFromTemplate/MainWindow.xaml.vb))
<!-- default file list end -->
# How to access datasource data from a chart template


This example shows how to access datasource data using the point template for a custom bar model. The chart control is bound to a list of <strong>GDPInfo</strong> objects using series templates. <br />When the datasource data is accessed, you can customize the series appearance (e.g.,  show bars as country flags on  a diagram and colorize them with a specific color).<br /><br />To accomplish this task:<br />- Create a  <strong>System.Windows.Controls.ControlTemplate</strong> which contains a Border, three Rectangles and a grid with three column  elements. Assign the template to the <a href="https://documentation.devexpress.com/#wpf/DevExpressXpfChartsCustomBar2DModel_PointTemplatetopic">CustomBar2DModel.PointTemplate</a> property;<br />- Bind the first rectangle  <strong>Rectangle.Fill</strong> property to the <strong>SeriesPointPresentationData.SeriesPoint.Tag.FlagBrush1</strong> property, the second rectangle <strong>Rectangle.Fill</strong> property to the <strong>SeriesPointPresentationData.SeriesPoint.Tag.FlagBrush2</strong> property, and the third rectangle to <strong>SeriesPointPresentationData.SeriesPoint.Tag.FlagBrush3</strong> property. <br /><br />In addition, this example shows how to customize the appearance of series labels using the  <strong>SeriesLabel.ElementTemplate</strong> property. <br /><br /><br />

<br/>


