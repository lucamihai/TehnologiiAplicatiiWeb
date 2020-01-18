using System;
using System.Web.UI.WebControls;
using WebApplication1.Models;
using WebApplication1.Models.Repository;

namespace WebApplication1
{
    public partial class Catalogs : System.Web.UI.Page
    {
        private readonly Repository repository = new Repository();

        protected void Page_Load(object sender, EventArgs e)
        {
            UpdateCatalogsTableContents();
        }

        protected void ButtonUpdateCatalogsTableClick(object sender, EventArgs e)
        {
            UpdateCatalogsTableContents();
        }

        protected void ButtonUpdateCatalogClick(object sender, EventArgs e)
        {
            var catalogId = ((TextBox) formUpdateCatalog.FindControl("textBoxCatalogId")).Text;
            var catalogFirstName = ((TextBox) formUpdateCatalog.FindControl("textBoxCatalogFirstName")).Text;
            var catalogLastName = ((TextBox) formUpdateCatalog.FindControl("textBoxCatalogLastName")).Text;
            var catalogMark = ((TextBox) formUpdateCatalog.FindControl("textBoxCatalogMark")).Text;
            var catalogFirstGrade = ((TextBox) formUpdateCatalog.FindControl("textBoxCatalogFirstGrade")).Text;
            var catalogSecondGrade = ((TextBox) formUpdateCatalog.FindControl("textBoxCatalogSecondGrade")).Text;

            var newCatalog = new Catalog
            {
                Id = Convert.ToInt32(catalogId),
                FirstName = catalogFirstName,
                LastName = catalogLastName,
                Mark = catalogMark,
                FirstGrade = Convert.ToInt32(catalogFirstGrade),
                SecondGrade = Convert.ToInt32(catalogSecondGrade),

            };

            repository.UpdateCatalog(newCatalog);
        }

        private void UpdateCatalogsTableContents()
        {
            var catalogs = repository.Catalogs;
            
            catalogsTable.Rows.Clear();
            catalogsTable.Rows.Add(CatalogsTableHeaderRow());

            foreach (var catalog in catalogs)
            {
                catalogsTable.Rows.Add(GetTableRowForCatalog(catalog));
            }
        }

        private TableRow GetTableRowForCatalog(Catalog catalog)
        {
            var row = new TableRow();

            row.Cells.Add(GetTableCellWithText(catalog.Id.ToString()));
            row.Cells.Add(GetTableCellWithText(catalog.FirstName));
            row.Cells.Add(GetTableCellWithText(catalog.LastName));
            row.Cells.Add(GetTableCellWithText(catalog.Mark));
            row.Cells.Add(GetTableCellWithText(catalog.FirstGrade.ToString()));
            row.Cells.Add(GetTableCellWithText(catalog.SecondGrade.ToString()));

            return row;

        }

        private TableCell GetTableCellWithText(string text)
        {
            var cell = new TableCell
            {
                Text = text,
                BorderStyle = BorderStyle.Solid
            };

            return cell;
        }

        private static TableHeaderRow CatalogsTableHeaderRow()
        {
            var tableHeaderRow = new TableHeaderRow
            {
                BorderStyle = BorderStyle.Solid
            };

            tableHeaderRow.Cells.Add(GetTableHeaderCellWithText("ID"));
            tableHeaderRow.Cells.Add(GetTableHeaderCellWithText("First Name"));
            tableHeaderRow.Cells.Add(GetTableHeaderCellWithText("Last Name"));
            tableHeaderRow.Cells.Add(GetTableHeaderCellWithText("Mark"));
            tableHeaderRow.Cells.Add(GetTableHeaderCellWithText("First Grade"));
            tableHeaderRow.Cells.Add(GetTableHeaderCellWithText("Second Grade"));

            return tableHeaderRow;
        }

        private static TableHeaderCell GetTableHeaderCellWithText(string text)
        {
            var cell = new TableHeaderCell
            {
                Text = text,
                BorderStyle = BorderStyle.Solid
            };

            return cell;
        }
    }
}