using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kakeibo1
{
    public partial class Form1 : Form
    {
        public int total = 0;
        public Series graf = new Series();
        public string[] category_name = { "食費", "雑費", "住居" };
        public int[] category_withdraw = { 0, 0, 0 };

        public Form1()
        {
            InitializeComponent();
        }

        private void 追加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("給料", "入金");
            categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("食費", "出金");
            categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("雑費", "出金");
            categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("住居", "出金");
        }

        private void AddData()
        {
            ItemForm frmItem = new ItemForm(categoryDataSet1);
            DialogResult drRet = frmItem.ShowDialog();

            if (drRet == DialogResult.OK)
            {
                moneyDataSet.moneyDataTable.AddmoneyDataTableRow(
                    frmItem.monCalendar.SelectionRange.Start,
                    frmItem.cmbCategory.Text,
                    frmItem.txtItem.Text,
                    int.Parse(frmItem.mtxtMoney.Text),
                    frmItem.txtRemarks.Text);
            }

            // グラフの計算
            switch ( frmItem.cmbCategory.Text ) {
                        case "食費": category_withdraw[0] += int.Parse(frmItem.mtxtMoney.Text); break;
                        case "雑費": category_withdraw[1] += int.Parse(frmItem.mtxtMoney.Text); break;
                        case "住居": category_withdraw[2] += int.Parse(frmItem.mtxtMoney.Text); break;
            }
            // グラフの描画
            switch (frmItem.cmbCategory.Text)
            {
                case "食費": 
                case "雑費":
                case "住居": graf.Points.Clear(); create_chart(category_name, category_withdraw); break;
            }
            
            // 出費の計算
            if (frmItem.mtxtMoney.Text != "")
            {
                if (frmItem.cmbCategory.Text == "給料")
                {
                    total -= int.Parse(frmItem.mtxtMoney.Text);
                }
                else
                {
                    total += int.Parse(frmItem.mtxtMoney.Text);
                }
            }
            total_label.Text = "出費："+ total + "円";
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveData()
        {
            string path = "MoneyData.csv";
            string strData = "";
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                path,
                false,
                System.Text.Encoding.Default);
            foreach (MoneyDataSet.moneyDataTableRow drMoney
                in moneyDataSet.moneyDataTable)
            {
                strData = drMoney.日付.ToShortDateString() + ","
                    + drMoney.分類 + ","
                    + drMoney.品名 + ","
                    + drMoney.金額.ToString() + ","
                    + drMoney.備考;
                sw.WriteLine(strData);
            }
            sw.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void LoadData()
        {
            string path = "MoneyData.csv";
            string delimStr = ",";
            char[] delimiter = delimStr.ToCharArray();
            string[] strData;
            string strLine;
            bool fileExists = System.IO.File.Exists(path);
            
            graf.ChartType = SeriesChartType.Pie;

            if (fileExists)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(
                    path,
                    System.Text.Encoding.Default);
                while (sr.Peek() >= 0)
                {
                    strLine = sr.ReadLine();
                    strData = strLine.Split(delimiter);
                    moneyDataSet.moneyDataTable.AddmoneyDataTableRow(
                        DateTime.Parse(strData[0]),
                        strData[1],
                        strData[2],
                        int.Parse(strData[3]),
                        strData[4]);

                    // グラフの値
                    switch ( strData[1] ) {
                        case "食費": category_withdraw[0] += int.Parse(strData[3]); break;
                        case "雑費": category_withdraw[1] += int.Parse(strData[3]); break;
                        case "住居": category_withdraw[2] += int.Parse(strData[3]); break;
                    }
                   
                    // 出費の計算
                    if (strData[1] == "給料")
                    {
                        total -= int.Parse(strData[3]);
                    }
                    else
                    {
                        total += int.Parse(strData[3]);
                    }
                }
                sr.Close();
                create_chart( category_name , category_withdraw);
                total_label.Text = "出費：" + total + "円";
            }
        }

        private void UpdateData()
        {
            int nowRow = dgv.CurrentRow.Index;
            DateTime oldDate
                = DateTime.Parse(dgv.Rows[nowRow].Cells[0].Value.ToString());
            string oldCategory = dgv.Rows[nowRow].Cells[1].Value.ToString();
            string oldItem = dgv.Rows[nowRow].Cells[2].Value.ToString();
            int oldMoney
                = int.Parse(dgv.Rows[nowRow].Cells[3].Value.ToString());
            string oldRemarks = dgv.Rows[nowRow].Cells[4].Value.ToString();
            ItemForm frmItem = new ItemForm(categoryDataSet1,
                                            oldDate,
                                            oldCategory,
                                            oldItem,
                                            oldMoney,
                                            oldRemarks);
            DialogResult drRet = frmItem.ShowDialog();
            if (drRet == DialogResult.OK)
            {
                dgv.Rows[nowRow].Cells[0].Value
                    = frmItem.monCalendar.SelectionRange.Start;
                dgv.Rows[nowRow].Cells[1].Value = frmItem.cmbCategory.Text;
                dgv.Rows[nowRow].Cells[2].Value = frmItem.txtItem.Text;
                dgv.Rows[nowRow].Cells[3].Value = int.Parse(frmItem.mtxtMoney.Text);
                dgv.Rows[nowRow].Cells[4].Value = frmItem.txtRemarks.Text;
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void 変更CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void DeleteData()
        {
            int nowRow = dgv.CurrentRow.Index;
            if ( dgv.Rows[nowRow].Cells[1].Value.ToString() == "給料" )
            {
                total += int.Parse(dgv.Rows[nowRow].Cells[3].Value.ToString());
            }
            else
            {
                total -= int.Parse(dgv.Rows[nowRow].Cells[3].Value.ToString());
            }

            switch (dgv.Rows[nowRow].Cells[1].Value.ToString())
            {
                case "食費": category_withdraw[0] -= int.Parse(dgv.Rows[nowRow].Cells[3].Value.ToString()); break;
                case "雑費": category_withdraw[1] -= int.Parse(dgv.Rows[nowRow].Cells[3].Value.ToString()); break;
                case "住居": category_withdraw[2] -= int.Parse(dgv.Rows[nowRow].Cells[3].Value.ToString()); break;
            }

            // グラフの描画
            graf.Points.Clear();
            create_chart(category_name, category_withdraw);

            dgv.Rows.RemoveAt(nowRow); // 現在行を削除
            total_label.Text = "出費：" + total + "円";
        }

        private void 削除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void create_chart(string[] category_name, int[] value)
        {
            withdraw_chart.Series.Remove(graf);
            for (int i = 0; i < 3; i++)
			{
			    graf.Points.AddXY(category_name[i], value[i]); 
			}
            withdraw_chart.Series.Add(graf);    
        }
    }
}
