using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoTEst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn() {ColumnName="序号" },
                new DataColumn() {ColumnName="名称" },
                new DataColumn() {ColumnName="功能" },
                new DataColumn() {ColumnName="是否启用" },
                new DataColumn() {ColumnName="执行次数" }

            });
            dt.Rows.Add(new object[] { "1", "JD商品数据采集", "获取商品的销售数据以及评价信息", "是", "3" });
            dt.Rows.Add(new object[] { "2", "重复数据过滤组件", "根据规则过滤已经获取过的数据", "是", "100" });
            dt.Rows.Add(new object[] { "3", "柱图生成", "生成柱状图数据", "是", "10" });
            dt.Rows.Add(new object[] { "4", "JD商品数据采集", "获取商品的销售数据以及评价信息", "是", "3" });
            dt.Rows.Add(new object[] { "5", "JD商品数据采集", "获取商品的销售数据以及评价信息", "是", "3" });

            dt.AcceptChanges();
            this.dataGridView1.DataSource = dt;



        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eXITXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn() {ColumnName="序号" },
                new DataColumn() {ColumnName="任务名称" },
                new DataColumn() {ColumnName="描述" },
                new DataColumn() {ColumnName="开始时间" },
                new DataColumn() {ColumnName="结束时间" },
                new DataColumn() {ColumnName="次数" },
                new DataColumn() {ColumnName="人员" },

            });
            dt.Rows.Add(new object[] {
                "1","获取商品的价格数据并进行存储","数据采集","09：12","10：20","3","run Role"
            });
            dt.Rows.Add(new object[] {
                "2","根据价格计算平均值","数据处理","10:30","10：40","1","run Role"
            });
            dt.Rows.Add(new object[] {
                "3","数据过滤","数据处理","10:30","—","1","run Role"
            });
            dt.Rows.Add(new object[] {
                "4","采集JD手机数据","数据采集","09：12","11：20","10","run Role"
            });
            dt.Rows.Add(new object[] {
                "5","生成报表数据","报表","10：12","11：30","6","Report Role"
            });
            dt.Rows.Add(new object[] {
                "6","生成报表数据","报表","14：00","18：20","10","Report Role"
            });

            dt.AcceptChanges();
            this.dataGridView1.DataSource = dt;

        }
    }
}
