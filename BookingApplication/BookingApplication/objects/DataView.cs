using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.objects
{
    class DataView
    {
        private List<string> columnNames;
        private List<List<string>> rows;

        public DataView(List<string> colNames, List<List<string>> rows)
        {
            ColumnNames = colNames;
            Rows = rows;
        }

        public List<string> ColumnNames
        {
            get { return columnNames; }
            set { columnNames = value; }
        }

        public List<List<string>> Rows
        {
            get { return rows; }
            set { rows = value; }
        }
    }
}
