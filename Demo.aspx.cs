using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace EducationCommunity
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tbl.BorderStyle = BorderStyle.None;
            tbl.BorderWidth = Unit.Pixel(1);
        }

     
        protected void cmdCreate_Click(object sender, EventArgs e)
        {

            int rows = Int32.Parse(txtRows.Text);
            int cols = Int32.Parse(txtCols.Text);

            for (int i = 0; i < rows; i++)
            {
                TableRow rowNew = new TableRow();
                tbl.Controls.Add(rowNew);
                for (int j = 0; j < cols; j++)
                {
                    TableCell cellNew = new TableCell();
                    Label lblNew = new Label();
                    lblNew.Text = "(" + i.ToString() + "," + j.ToString() + ")<br />";
                    cellNew.Controls.Add(lblNew);


                    cellNew.BorderStyle = BorderStyle.None;
                    cellNew.BorderWidth = Unit.Pixel(1);


                    rowNew.Controls.Add(cellNew);
                }
            }
        }
    }
}