using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace BIS_v1
{
    public partial class home : System.Web.UI.Page
    {
        static RadioButton[] radioButtonYaxis;
        static RadioButton[] radioButtonXaxis;
        static String[] attributes;
        static int counter;
        static String myWords;
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Upload_Click(object sender, EventArgs e)
        {

            String path = @"C:\Users\Qurzu\source\repos\BIS v1\BIS v1\Data\mySheet.csv";


            FileOperator obj = new FileOperator(path, true);
            ArrayList ary = obj.GetAllAttributes();
            attributes = new String[ary.Count];
            int k = 0;
            foreach (var item in ary)
            {
                attributes[k] = item.ToString();
                k++;
            }
            counter = k;

            // ListBox1.DataSource = ary.ToString();



            // var d = dtAll.Compute("Sum(Age)","");
            //   DataTable fdt = dr.CopyToDataTable();
            // DataTable FilteredData = dt.Select("age=20").CopyToDataTable();


            radioButtonYaxis = new RadioButton[8];
            Panel[] ppl = new Panel[8];
            for (int i = 0; i < k; i++)
            {

                radioButtonYaxis[i] = new RadioButton();
                radioButtonYaxis[i].GroupName = "myGroup";
                radioButtonYaxis[i].ID = "id1" + i;
                radioButtonYaxis[i].Text = "   " + attributes[i];
                pnlYAxis.Controls.Add(radioButtonYaxis[i]);
                radioButtonYaxis[i].CheckedChanged += Home_CheckedChanged;
                ppl[i] = new Panel();
                pnlYAxis.Controls.Add(ppl[i]);

            }
            radioButtonXaxis = new RadioButton[8];
           
            for (int i = 0; i < k; i++)
            {

                radioButtonXaxis[i] = new RadioButton();

                radioButtonXaxis[i].ID = "id2" + i;
                radioButtonXaxis[i].Text = attributes[i];
                pnlXAxis.Controls.Add(radioButtonXaxis[i]);
                ppl[i] = new Panel();
                pnlXAxis.Controls.Add(ppl[i]);

            }
        }
        private void Home_CheckedChanged(object sender, EventArgs e)
        {
            myWords = sender.ToString();
        }
        protected void ListBox1_TextChanged(object sender, EventArgs e)
        {

        }
        protected void btn_CreateChart_Click(object sender, EventArgs e)
        {
            String path = @"C:\Users\Qurzu\source\repos\BIS v1\BIS v1\Data\mySheet.csv";
            FileOperator obj = new FileOperator(path, true);
            DataTable dt = obj.GetCompleteFileData();

            String selectedText = getRadioButtonSelected_For_Y();
            for (int i = 1; i < 7; i++)
            {
                Chart1.Series["Series1"].Points.Add(new DataPoint(i, dt.Rows[i][selectedText].ToString().Trim()));
                Chart1.Series["Series1"].Label = dt.Rows[i][selectedText].ToString().Trim();
            }
            Chart1.Series["Series1"].Label = "#VALY";
        }
        private String getRadioButtonSelected_For_Y()
        {
            CheckRadioButton(myform); //or whichever form it is..
            for (int i = 0; i < counter; i++)
            {
                if (radioButtonYaxis[i].Checked == true)
                {
                    return (radioButtonYaxis[i].Text.ToString());
                }
                //First Problem occur 
                //at index checking of array
                // Error Solved !...
                //
            }
            return "";
        }
        private static void CheckRadioButton(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.ClientID =="id10")
                {
                    
                }
                else if (c.Controls.Count > 0)
                    CheckRadioButton(c);
            }
        }
    }
}