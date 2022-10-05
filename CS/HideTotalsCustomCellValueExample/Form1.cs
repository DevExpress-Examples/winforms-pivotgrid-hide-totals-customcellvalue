using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using System.ComponentModel;
using System.Linq;

namespace HideTotalsCustomCellValueExample {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            pivotGridControl1.CustomCellValue += pivotGridControl1_CustomCellValue;
            BindingList<PivotData> data = new BindingList<PivotData>();
            for (int i = 0; i < 100; i++)
                data.Add(new PivotData() { Group = "Group " + i % 4, Row = "Row " + i % 5, 
                    Column = "Column" + i % 3, Value = i });
            pivotGridControl1.DataSource = data;
            pivotGridControl1.BestFitDataHeaders(true);
        }

        private void pivotGridControl1_CustomCellValue(object sender, PivotCellValueEventArgs e) {
            if (e.DataField == fieldLowLevel) {
                PivotGridField lastLevelField = 
                    pivotGridControl1.GetFieldsByArea(PivotArea.RowArea).Last();
                if(e.RowValueType == PivotGridValueType.Total 
                    || e.RowValueType == PivotGridValueType.GrandTotal 
                    || e.RowField != lastLevelField)
                    e.Value = null;
            } 
        }
    }
    class PivotData {
        public string Group { get; set; }
        public string Row { get; set; }
        public string Column { get; set; }
        public decimal Value { get; set; }
    }
}
