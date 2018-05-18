using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;

namespace BIS_v1
{
    public class FileOperator
    {
        ArrayList attributes;
        string path;
        bool isFirstRowHeader;

        public FileOperator(string Path,bool IsFirstRowHeader)
        {
            attributes = new ArrayList();
            this.path = Path;
            this.isFirstRowHeader = IsFirstRowHeader;
        }
        public DataTable GetCompleteFileData()
        {
            string header = isFirstRowHeader ? "Yes" : "No";
            string pathOnly = Path.GetDirectoryName(path);
            string fileName = Path.GetFileName(path);
            string sql = "";
            {
                sql = @"SELECT * FROM [" + fileName + "] ";
            }
            // string sql = @"SELECT * FROM [" + fileName + "]";
            using (OleDbConnection connection = new OleDbConnection(
                      @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathOnly +
                      ";Extended Properties=\"Text;HDR=" + header + "\""))
            using (OleDbCommand command = new OleDbCommand(sql, connection))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                dataTable.Locale = CultureInfo.CurrentCulture;
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        public ArrayList GetAllAttributes()
        {
            string header = isFirstRowHeader ? "Yes" : "No";
            string pathOnly = Path.GetDirectoryName(path);
            string fileName = Path.GetFileName(path);
            string sql = "";
            {
                sql = @"SELECT TOP 1 * FROM [" + fileName + "] ";
            }
            // string sql = @"SELECT * FROM [" + fileName + "]";
            using (OleDbConnection connection = new OleDbConnection(
                      @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathOnly +
                      ";Extended Properties=\"Text;HDR=" + header + "\""))
            using (OleDbCommand command = new OleDbCommand(sql, connection))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                dataTable.Locale = CultureInfo.CurrentCulture;
                adapter.Fill(dataTable);
                foreach (DataColumn column in dataTable.Columns)
                {
                    attributes.Add(column.ToString());
                }

            }
            return attributes;
       
        }

    }
}