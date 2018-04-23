Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Media

Namespace DataSouceFromTemplate

    Partial Public Class MainWindow
        Inherits Window

        Private gdps As New List(Of GDPInfo)()

        Public Sub New()
            InitializeComponent()
            gdps.Add(New GDPInfo("Russia", 1221.99, 2010, Colors.White, Color.FromRgb(0, 57, 166), Color.FromRgb(213, 43, 30)))
            gdps.Add(New GDPInfo("Germany", 3280.53, 2010, Colors.Black, Color.FromRgb(221, 0, 0), Color.FromRgb(255, 206, 0)))
            gdps.Add(New GDPInfo("Netherlands", 836.4, 2010, Color.FromRgb(174, 28, 40), Colors.White, Color.FromRgb(33, 70, 139)))
            gdps.Add(New GDPInfo("Austria", 389.7, 2010, Color.FromRgb(237, 41, 57), Colors.White, Color.FromRgb(237, 41, 57)))
            Me.DataContext = gdps
        End Sub
    End Class

    Public Class GDPInfo

        Private ReadOnly country_Renamed As String

        Private ReadOnly gdp_Renamed As Double
        Private ReadOnly flagColor1 As Color
        Private ReadOnly flagColor2 As Color
        Private ReadOnly flagColor3 As Color

        Private ReadOnly year_Renamed As Integer

        Public ReadOnly Property Country() As String
            Get
                Return country_Renamed
            End Get
        End Property
        Public ReadOnly Property GDP() As Double
            Get
                Return gdp_Renamed
            End Get
        End Property
        Public ReadOnly Property FlagBrush1() As Brush
            Get
                Return New SolidColorBrush(flagColor1)
            End Get
        End Property
        Public ReadOnly Property FlagBrush2() As Brush
            Get
                Return New SolidColorBrush(flagColor2)
            End Get
        End Property
        Public ReadOnly Property FlagBrush3() As Brush
            Get
                Return New SolidColorBrush(flagColor3)
            End Get
        End Property
        Public ReadOnly Property Year() As Integer
            Get
                Return year_Renamed
            End Get
        End Property

        Public Sub New(ByVal country As String, ByVal gdp As Double, ByVal year As Integer, ByVal flagColor1 As Color, ByVal flagColor2 As Color, ByVal flagColor3 As Color)
            Me.country_Renamed = country
            Me.gdp_Renamed = gdp
            Me.year_Renamed = year
            Me.flagColor1 = flagColor1
            Me.flagColor2 = flagColor2
            Me.flagColor3 = flagColor3
        End Sub
    End Class
End Namespace
