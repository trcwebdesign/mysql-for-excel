﻿// 
// Copyright (c) 2012, Oracle and/or its affiliates. All rights reserved.
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License as
// published by the Free Software Foundation; version 2 of the
// License.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA
// 02110-1301  USA
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySQL.Utility;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace MySQL.ForExcel
{
  public partial class ImportTableViewForm : AutoStyleableBaseDialog
  {
    private MySqlWorkbenchConnection wbConnection;
    private DBObject importDBObject;
    private DataTable previewDataTable = null;
    private bool allColumnsSelected { get { return (grdPreviewData.SelectedColumns.Count == grdPreviewData.Columns.Count); } }

    public DataTable ImportDataTable = null;
    public bool ImportHeaders { get { return chkIncludeHeaders.Checked; } }
    public long TotalRowsCount { get; set; }
    private bool hasError = false;

    public ImportTableViewForm(MySqlWorkbenchConnection wbConnection, DBObject importDBObject, string importToWorksheetName)
    {
      this.wbConnection = wbConnection;
      this.importDBObject = importDBObject;

      InitializeComponent();
      grdPreviewData.DataError += new DataGridViewDataErrorEventHandler(grdPreviewData_DataError);

      chkIncludeHeaders.Checked = true;
      chkLimitRows.Checked = false;
      lblTableNameMain.Text = String.Format("{0} Name:", importDBObject.Type.ToString());
      Text = String.Format("Import Data - {0}", importToWorksheetName);
      lblTableNameSub.Text = importDBObject.Name;
      fillPreviewGrid();
    }

    void grdPreviewData_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {      
       if (grdPreviewData.Rows[e.RowIndex].Cells[e.ColumnIndex].ValueType == Type.GetType("System.Byte[]"))
       {
         try
         {
           var img = (byte[])(grdPreviewData.Rows[e.RowIndex].Cells[e.ColumnIndex]).Value;
           using (MemoryStream ms = new MemoryStream(img))
             Image.FromStream(ms);
         }
         catch (ArgumentException)
         {
         }
         catch (Exception ex)
         {
           MessageBox.Show("Loading Data Error " + ex.Message);
         }
       }           
    }

    private void fillPreviewGrid()
    {
      previewDataTable = MySQLDataUtilities.GetDataFromTableOrView(wbConnection, importDBObject, null, 0, 10);
      TotalRowsCount = MySQLDataUtilities.GetRowsCountFromTableOrView(wbConnection, importDBObject);
      lblRowsCountSub.Text = TotalRowsCount.ToString();
      grdPreviewData.DataSource = previewDataTable;
      foreach (DataGridViewColumn gridCol in grdPreviewData.Columns)
      {
        gridCol.SortMode = DataGridViewColumnSortMode.NotSortable;
      }
      grdPreviewData.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
      numFromRow.Maximum = TotalRowsCount;
      numRowsToReturn.Maximum = TotalRowsCount - numFromRow.Value + 1;
    }

    private void btnImport_Click(object sender, EventArgs e)
    {
      List<string> importColumns = new List<string>();
      List<DataGridViewColumn> selectedColumns = new List<DataGridViewColumn>();
      foreach (DataGridViewColumn selCol in grdPreviewData.SelectedColumns)
      {
        selectedColumns.Add(selCol);
      }
      if (selectedColumns.Count > 1)
        selectedColumns.Sort(delegate(DataGridViewColumn c1, DataGridViewColumn c2)
        {
          return c1.Index.CompareTo(c2.Index);
        });
      foreach (DataGridViewColumn selCol in selectedColumns)
      {
        importColumns.Add(selCol.HeaderText);
      }
      try
      {
        if (chkLimitRows.Checked)
          ImportDataTable = MySQLDataUtilities.GetDataFromTableOrView(wbConnection, importDBObject, importColumns, Convert.ToInt32(numFromRow.Value) - 1, Convert.ToInt32(numRowsToReturn.Value));
        else
          ImportDataTable = MySQLDataUtilities.GetDataFromTableOrView(wbConnection, importDBObject, importColumns);
      }
      catch (Exception ex)
      {
        InfoDialog dialog = new InfoDialog(false, ex.Message, null);
        dialog.ShowDialog();
        hasError = true;
      }
    }

    private void chkLimitRows_CheckedChanged(object sender, EventArgs e)
    {
      numRowsToReturn.Enabled = numFromRow.Enabled = chkLimitRows.Checked;
    }

    private void grdPreviewData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
      grdPreviewData.SelectAll();
    }

    private void grdPreviewData_SelectionChanged(object sender, EventArgs e)
    {
      contextMenuForGrid.Items[0].Text = (allColumnsSelected ? "Select None" : "Select All");
      btnImport.Enabled = grdPreviewData.SelectedColumns.Count > 0;
    }

    private void numFromRow_ValueChanged(object sender, EventArgs e)
    {
      numRowsToReturn.Maximum = TotalRowsCount - numFromRow.Value + 1;
    }

    private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (allColumnsSelected)
        grdPreviewData.ClearSelection();
      else
        grdPreviewData.SelectAll();
    }

    private void ImportTableViewForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = hasError;
      hasError = false;
    }

  }
}
