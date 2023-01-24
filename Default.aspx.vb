Imports System.Drawing

Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DefineChart1()
    End Sub

    Sub DefineChart1()
        With Chart1
            'General behaviour...
            .Debug = True
            .Mentor = False
            .TempDirectory = "~\temp\30min"
            .CleanupPeriod = 10
            .CleanupMinimumAge = 30
            .NoDataLabel.Text = "No Defects"

            'Appearance...
            '.OverlapFooter = True   'Maintains vertical chart size with Demo message in footer.
            '.Size = "970x367"
            '.Type = dotnetCHARTING.ChartType.Combo
            '.ShadingEffect = False
            '.Use3D = False
            '.Background.Mode = dotnetCHARTING.BackgroundMode.Color
            '.BackColor = Color.White

            'Title Box
            '.TitleBox.Position = dotnetCHARTING.TitleBoxPosition.None   'Hide Title

            'Legend
            '.LegendBox.Background.Color = Color.FromArgb(237, 237, 242)
            '.LegendBox.LabelStyle.Font = New Font("Arial", 9, GraphicsUnit.Pixel)
            '.LegendBox.Padding = 2

            'Labels...
            '.DefaultSeries.DefaultElement.ShowValue = False     'Show count in block areas within a stack?
            '.DefaultSeries.DefaultElement.SmartLabel.Alignment = dotnetCHARTING.LabelAlignment.Top
            '.DefaultSeries.DefaultElement.ToolTip = "%Value %SeriesName"

            'X Axis
            '.ChartArea.XAxis.Label.Text = "Mould No"
            .ChartArea.XAxis.SpacingPercentage = 0
            '.ChartArea.XAxis.StaticColumnWidth = 40
            '.ChartArea.XAxis.DefaultTick.Label.Text = "%Name"
            '.ChartArea.XAxis.DefaultTick.Label.Font = New Font("Arial", 9, GraphicsUnit.Pixel)
            '.Series.Sort(dotnetCHARTING.ElementValue.YValue, "Asc")

            'Y Axis...
            '.ChartArea.YAxis.Label.Text = "Count"
            '.ChartArea.YAxis.MinimumInterval = 1
            '.ChartArea.YAxis.FormatString = "{0:0}"
            .ChartArea.YAxis.Scale = dotnetCHARTING.Scale.Stacked

            'Add series...
            Dim de As New dotnetCHARTING.DataEngine
            de.Data = BuildDummyDatatable()

            Dim sc As dotnetCHARTING.SeriesCollection
            sc = de.GetSeries()
            Dim test = de.Data()

            .SeriesCollection.Add(sc)
        End With
    End Sub
    Protected Function BuildDummyDatatable() As DataTable
        Dim dtb As New DataTable
        dtb.Columns.Add("Mld", System.Type.GetType("System.Int32"))
        dtb.Columns.Add("N", System.Type.GetType("System.Int32"))
        dtb.Columns.Add("Defect", System.Type.GetType("System.String"))
        dtb.Rows.Add(1, 1, "Check thread")
        dtb.Rows.Add(1, 2, "Slope over max")
        dtb.Rows.Add(2, 1, "Check thread")
        dtb.Rows.Add(2, 3, "Overlap baffle")
        dtb.Rows.Add(2, 1, "Blown out finish")
        dtb.Rows.Add(6, 2, "Slope over max")
        dtb.Rows.Add(6, 1, "Check thread")
        dtb.Rows.Add(6, 3, "Overlap baffle")
        dtb.Rows.Add(6, 9, "Blown out finish")
        dtb.Rows.Add(10, 1, "Check thread")
        dtb.Rows.Add(10, 2, "Slope over max")
        dtb.Rows.Add(26, 1, "Check thread")
        dtb.Rows.Add(26, 3, "Overlap baffle")
        dtb.Rows.Add(26, 1, "Blown out finish")
        dtb.Rows.Add(46, 2, "Slope over max")
        dtb.Rows.Add(46, 1, "Check thread")
        dtb.Rows.Add(46, 3, "Overlap baffle")
        dtb.Rows.Add(49, 5, "Blown out finish")
        dtb.Rows.Add(49, 2, "Slope over max")
        dtb.Rows.Add(49, 1, "Check thread")
        dtb.Rows.Add(49, 3, "Overlap baffle")
        dtb.Rows.Add(90, 5, "Blown out finish")
        Return dtb
    End Function
End Class