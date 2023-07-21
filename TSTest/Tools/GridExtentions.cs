using System.Windows.Controls;
using System.Windows;

namespace TSTest.Tools
{
    public static class GridExtentions
    {
        public static void AddColumn(this Grid grid)
        {
            var colDefinition = new ColumnDefinition();
            colDefinition.Width = new GridLength(1, GridUnitType.Star);
            grid.ColumnDefinitions.Add(colDefinition);
        }

        public static void AddRow(this Grid grid)
        {
            var rowDefinition = new RowDefinition();
            rowDefinition.Height = new GridLength(1, GridUnitType.Star);
            grid.RowDefinitions.Add(rowDefinition);
        }
    }
}
