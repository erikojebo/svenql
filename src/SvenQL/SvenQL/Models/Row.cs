using System.Collections.Generic;
using System.Linq;

namespace SvenQL.Models
{
    public class Row
    {
        public readonly IReadOnlyList<ColumnValue> Values;

        public Row(IEnumerable<ColumnValue> values)
        {
            Values = values.ToList();
        }
    }
}