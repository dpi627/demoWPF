# LiveCharts2 Demo Window

## Overview
This is a comprehensive demo window showcasing LiveCharts2 (v2.0.0-rc3.3) integration in a WPF application using the MVVM pattern.

## Files Created

### ViewModel
- **net9\ViewModels\ChartsViewModel.cs**
  - Implements MVVM pattern using CommunityToolkit.Mvvm
- Contains mock data for all chart types
  - Four different chart series: Line, Column, Pie, and Stacked Column
  - Configurable axes with labels and styling

### View
- **net9\Views\ChartsWindow.xaml**
  - Material Design styled window
  - Four chart types displayed in a 2x2 grid
  - Responsive layout with ScrollViewer
  - Uses Material Design Cards for each chart

- **net9\Views\ChartsWindow.xaml.cs**
  - Simple code-behind file
  - DataContext is set via XAML

### Integration
- **Updated net9\Views\MainWindow.xaml**
  - Added "Open Charts Demo" button
  - Button launches the ChartsWindow

- **Updated net9\Views\MainWindow.xaml.cs**
  - Added click event handler to open ChartsWindow

## Chart Types Demonstrated

### 1. Line Chart - Sales & Revenue
- Two line series with different colors
- Smooth lines with point markers
- Shows trend data over 8 months

### 2. Column Chart - Product Comparison
- Two product series (Product A & B)
- Grouped columns for easy comparison
- 6 data points per product

### 3. Pie Chart - Browser Market Share
- Four browser categories
- Color-coded segments
- Shows percentage distribution
- Data labels displayed in the middle of each slice

### 4. Stacked Column Chart - Quarterly Performance
- Four quarters (Q1-Q4) stacked
- Four regions for comparison
- Shows cumulative values

## Mock Data
All data is generated in the ViewModel constructor:
- Line series: Sales and Revenue trends
- Column series: Product performance metrics
- Pie series: Browser market share percentages
- Stacked series: Quarterly regional performance

## Dependencies
- LiveChartsCore.SkiaSharpView.WPF: 2.0.0-rc3.3
- MaterialDesignThemes: 5.3.0
- CommunityToolkit.Mvvm: 8.4.0

## How to Run
1. Build the project
2. Run the application
3. Click the "Open Charts Demo" button on the main window
4. The ChartsWindow will open displaying all four chart types

## MVVM Pattern
The implementation follows clean MVVM principles:
- **Model**: Simple data arrays (mock data)
- **ViewModel**: ChartsViewModel with ObservableProperty attributes
- **View**: ChartsWindow.xaml with data binding
- No business logic in code-behind
- All chart configurations in ViewModel

## Styling
- Uses Material Design theme for consistent UI
- Cards with rounded corners for each chart
- Proper spacing and margins
- Clean, professional appearance
- Responsive layout that adapts to window size
