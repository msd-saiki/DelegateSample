using DelegateSample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateSample
{
    public delegate void SelectDelegate(EmpModel EmpModel);

    public partial class Form2 : Form
    {

        private IEnumerable<EmpModel> EmpList;

        private SelectDelegate callback;

        public Form2(SelectDelegate selectDelegate)
        {
            callback = selectDelegate;

            InitializeComponent();
            EmpList = new List<EmpModel>
            {
                new EmpModel{ EmpNo = 1  , EmpName = "従業員0001" }
                ,new EmpModel{ EmpNo = 2  , EmpName = "従業員0002" }
                ,new EmpModel{ EmpNo = 3  , EmpName = "従業員0003" }
                ,new EmpModel{ EmpNo = 4  , EmpName = "従業員0004" }
                ,new EmpModel{ EmpNo = 5  , EmpName = "従業員0005" }
                ,new EmpModel{ EmpNo = 6  , EmpName = "従業員0006" }
                ,new EmpModel{ EmpNo = 7  , EmpName = "従業員0007" }
                ,new EmpModel{ EmpNo = 8  , EmpName = "従業員0008" }
                ,new EmpModel{ EmpNo = 9  , EmpName = "従業員0009" }
                ,new EmpModel{ EmpNo = 10 , EmpName = "従業員0010" }
                ,new EmpModel{ EmpNo = 11 , EmpName = "従業員0011" }
            };
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            empModelBindingSource.DataSource = EmpList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            if (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                callback(EmpList.ElementAt(e.RowIndex));
                Close();
            }
        }
    }
}
