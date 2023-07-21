using System;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace TSTest.Tools
{
    public class GridShapeAdder
    {
        private readonly Grid _grid;

        public GridShapeAdder(Grid grid) { 
            _grid = grid;
            if(_grid.RowDefinitions.Count == 0) { _grid.AddRow(); }
            if (_grid.ColumnDefinitions.Count == 0) { _grid.AddColumn(); }
        }

        public void Add(Shape shape)
        {
            _grid.Children.Add(shape);

            if (_grid.Children.Count > 1)
            {
                DistributeOnGrid();
            }
        }

        private void DistributeOnGrid()
        {
            var calculatedValue = Math.Sqrt(_grid.Children.Count);
            var rows = (int)Math.Round(calculatedValue);
            if (_grid.RowDefinitions.Count < rows) { _grid.AddRow(); }

            var cols = (int)Math.Ceiling(calculatedValue);
            if (_grid.ColumnDefinitions.Count < cols) { _grid.AddColumn(); }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    var index = cols * row + col;
                    if (index >= _grid.Children.Count) { break; }

                    var item = _grid.Children[index];
                    Grid.SetRow(item, row);
                    Grid.SetColumn(item, col);
                }
            }
        }
    }
}
