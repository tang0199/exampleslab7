using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CurrencyConvertor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
            drpCurrency.Items.Add(new ListItem("US Dollar", "0.9"));
            drpCurrency.Items.Add(new ListItem("Euros", "0.75"));
            drpCurrency.Items.Add(new ListItem("Japanese Yen", "110.33"));
            drpCurrency.Items.Add(new ListItem("Chinese RMB", "5.2"));
        }		
    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        decimal oldAmount;
        
        bool success = Decimal.TryParse(txtCanadianDollar.Text, out oldAmount);

        if (success)
        {
            // Retrieve the selected ListItem object by its index number.
            //ListItem item = drpCurrency.Items[drpCurrency.SelectedIndex];

            // Retrieve the selected ListItem object by SelectedItem property.
            ListItem item = drpCurrency.SelectedItem; 

            decimal newAmount = oldAmount * Decimal.Parse(item.Value);
            
            ltrResult.Text = oldAmount.ToString() + " Canadian dollars = ";
            ltrResult.Text += newAmount.ToString() + " " + item.Text;
        }
        else
        {
            ltrResult.Text = "The number you typed in was not in the correct format. ";
            ltrResult.Text += "Use only numbers.";
        }
    }
}