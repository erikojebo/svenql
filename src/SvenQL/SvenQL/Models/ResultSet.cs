using System.Collections.Generic;
using System.Linq;

namespace SvenQL.Models
{
    public class ResultSet
    {
        private readonly List<Column> _columns;
        private readonly List<Row> _rows;

        public ResultSet(IEnumerable<Column> columns)
        {
            _columns = columns.ToList();
            _rows = new List<Row>();
        }

        public IReadOnlyList<Column> Columns
        {
            get { return _columns; }
        }

        public IReadOnlyList<Row> Rows
        {
            get { return _rows; }
        }

        public void AddRow(object[] rowValues)
        {
            var values = new List<ColumnValue>();

            for (int i = 0; i < rowValues.Length; i++)
            {
                var column = Columns[i];
                var value = new ColumnValue(column, rowValues[i]);
                values.Add(value);
            }

            _rows.Add(new Row(values));
        }
    }
}