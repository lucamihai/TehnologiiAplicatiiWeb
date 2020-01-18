using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class StartPage : System.Web.UI.Page
    {
        protected const string IdTextLifeCycle = "textBoxLifeCycle";
        protected const string IdTextControls = "textBoxControls";

        private string lifeCycleString = string.Empty;

        protected override void OnInit(EventArgs e)
        {
            lifeCycleString += $"Page.Init has been called{Environment.NewLine}";

            base.OnInit(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            lifeCycleString += $"Page.Load has been called{Environment.NewLine}";

            base.OnLoad(e);
        }

        protected override void OnPreRender(EventArgs e)
        {
            lifeCycleString += $"Page.PreRender has been called{Environment.NewLine}";
            
            base.OnPreRender(e);
        }

        protected override void OnUnload(EventArgs e)
        {
            lifeCycleString += $"Page.Init has been called{Environment.NewLine}";

            base.OnUnload(e);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            lifeCycleString += $"Page.Load has been called{Environment.NewLine}";
        }

        protected void ButtonClick(object sender, EventArgs e)
        {
            lifeCycleString += $"Button has been clicked{Environment.NewLine}";

            var stringControls = string.Empty;

            foreach (Control control in Controls)
            {
                stringControls += $"{control.ID}{Environment.NewLine}";
            }

            foreach (Control formControl in mainForm.Controls)
            {
                if (formControl.ID == IdTextLifeCycle)
                {
                    var controlAsTextBox = formControl as TextBox;
                    controlAsTextBox.Text = lifeCycleString;
                }

                if (formControl.ID == IdTextControls)
                {
                    var controlAsTextBox = formControl as TextBox;
                    controlAsTextBox.Text = stringControls;
                }
            }
        }

    }
}