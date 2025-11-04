using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System.Collections.ObjectModel;

namespace net9.ViewModels
{
    public partial class ChartsViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ISeries> _lineSeries = null!;

        [ObservableProperty]
   private ObservableCollection<ISeries> _columnSeries = null!;

     [ObservableProperty]
      private ObservableCollection<ISeries> _pieSeries = null!;

[ObservableProperty]
 private ObservableCollection<ISeries> _stackedColumnSeries = null!;

        [ObservableProperty]
   private Axis[] _xAxes = null!;

   [ObservableProperty]
        private Axis[] _yAxes = null!;

        public ChartsViewModel()
     {
      InitializeLineSeries();
         InitializeColumnSeries();
            InitializePieSeries();
     InitializeStackedColumnSeries();
     InitializeAxes();
        }

        private void InitializeLineSeries()
        {
  LineSeries = new ObservableCollection<ISeries>
       {
    new LineSeries<double>
      {
       Name = "Sales",
   Values = new double[] { 2, 5, 4, 6, 8, 3, 7, 9 },
           Fill = null,
        Stroke = new SolidColorPaint(SKColors.Blue) { StrokeThickness = 3 },
      GeometrySize = 8,
         GeometryStroke = new SolidColorPaint(SKColors.Blue) { StrokeThickness = 3 },
         GeometryFill = new SolidColorPaint(SKColors.White)
  },
                new LineSeries<double>
      {
                 Name = "Revenue",
  Values = new double[] { 3, 4, 6, 5, 7, 9, 8, 11 },
         Fill = null,
      Stroke = new SolidColorPaint(SKColors.Green) { StrokeThickness = 3 },
            GeometrySize = 8,
    GeometryStroke = new SolidColorPaint(SKColors.Green) { StrokeThickness = 3 },
    GeometryFill = new SolidColorPaint(SKColors.White)
    }
            };
 }

        private void InitializeColumnSeries()
        {
            ColumnSeries = new ObservableCollection<ISeries>
 {
           new ColumnSeries<double>
         {
 Name = "Product A",
 Values = new double[] { 15, 25, 30, 22, 18, 28 },
   Fill = new SolidColorPaint(SKColors.DodgerBlue),
        Stroke = null,
       MaxBarWidth = 50
         },
   new ColumnSeries<double>
        {
   Name = "Product B",
      Values = new double[] { 20, 18, 25, 30, 24, 20 },
   Fill = new SolidColorPaint(SKColors.Orange),
     Stroke = null,
         MaxBarWidth = 50
             }
         };
        }

        private void InitializePieSeries()
        {
            PieSeries = new ObservableCollection<ISeries>
  {
      new PieSeries<double>
      {
        Name = "Chrome",
        Values = new double[] { 45 },
              DataLabelsPaint = new SolidColorPaint(SKColors.White),
          DataLabelsSize = 14,
 DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
         Fill = new SolidColorPaint(SKColors.Blue)
   },
       new PieSeries<double>
     {
  Name = "Firefox",
                    Values = new double[] { 25 },
         DataLabelsPaint = new SolidColorPaint(SKColors.White),
     DataLabelsSize = 14,
        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
           Fill = new SolidColorPaint(SKColors.Orange)
      },
       new PieSeries<double>
         {
    Name = "Edge",
         Values = new double[] { 20 },
          DataLabelsPaint = new SolidColorPaint(SKColors.White),
   DataLabelsSize = 14,
             DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
    Fill = new SolidColorPaint(SKColors.Green)
          },
           new PieSeries<double>
                {
     Name = "Safari",
           Values = new double[] { 10 },
          DataLabelsPaint = new SolidColorPaint(SKColors.White),
         DataLabelsSize = 14,
          DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
             Fill = new SolidColorPaint(SKColors.Purple)
 }
  };
        }

        private void InitializeStackedColumnSeries()
  {
   StackedColumnSeries = new ObservableCollection<ISeries>
     {
     new StackedColumnSeries<double>
    {
          Name = "Q1",
         Values = new double[] { 30, 40, 35, 50 },
         Fill = new SolidColorPaint(SKColors.CornflowerBlue),
   Stroke = null,
      MaxBarWidth = 60
    },
      new StackedColumnSeries<double>
              {
                Name = "Q2",
        Values = new double[] { 40, 35, 45, 40 },
              Fill = new SolidColorPaint(SKColors.MediumSeaGreen),
              Stroke = null,
      MaxBarWidth = 60
    },
    new StackedColumnSeries<double>
         {
         Name = "Q3",
 Values = new double[] { 35, 45, 40, 35 },
         Fill = new SolidColorPaint(SKColors.Coral),
   Stroke = null,
    MaxBarWidth = 60
             },
       new StackedColumnSeries<double>
         {
          Name = "Q4",
    Values = new double[] { 45, 40, 50, 45 },
         Fill = new SolidColorPaint(SKColors.Gold),
   Stroke = null,
       MaxBarWidth = 60
     }
     };
    }

   private void InitializeAxes()
  {
            XAxes = new Axis[]
            {
                new Axis
 {
               Name = "Time Period",
           Labels = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug" },
      LabelsRotation = 0,
  TextSize = 12,
   SeparatorsPaint = new SolidColorPaint(SKColors.LightGray) { StrokeThickness = 1 }
      }
     };

         YAxes = new Axis[]
            {
   new Axis
                {
     Name = "Values",
                TextSize = 12,
         SeparatorsPaint = new SolidColorPaint(SKColors.LightGray) { StrokeThickness = 1 }
     }
            };
        }
    }
}
