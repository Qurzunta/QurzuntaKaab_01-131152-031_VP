using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;

namespace BIS_v1
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Upload_Click(object sender, EventArgs e)
        {

            String path = @"C:\Users\Qurzu\source\repos\BIS v1\BIS v1\Data\mySheet.csv";


            FileOperator obj = new FileOperator(path,true);
            ArrayList ary = obj.GetAllAttributes();
            foreach (var item in ary)
            {
                ListBox1.Items.Add(item.ToString());
            }

           // ListBox1.DataSource = ary.ToString();
            
           

           // var d = dtAll.Compute("Sum(Age)","");
         //   DataTable fdt = dr.CopyToDataTable();
         // DataTable FilteredData = dt.Select("age=20").CopyToDataTable();
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String path = @"C:\Users\Qurzu\source\repos\BIS v1\BIS v1\Data\mySheet.csv";
            FileOperator obj = new FileOperator(path, true);
            DataTable dt = obj.GetCompleteFileData();

            String selectedText = ListBox1.SelectedItem.Text.ToString();
            for (int i = 1; i <7; i++)
            {

                Chart1.Series["Series1"].Points.Add(new DataPoint(i,dt.Rows[i][selectedText].ToString().Trim()));
               // Chart1.Series["Series1"].Label = dt.Rows[i][selectedText].ToString().Trim();
            }
            Chart1.Series["Series1"].Label = "#VALY";
        }

        protected void ListBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}