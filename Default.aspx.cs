using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    readonly Globals _json = Globals.Instance;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           // _json.Firstname = "alessio";
            //_json.Lastname = "ricco";
            //_json.Color = "black";
            //_json.List = new List<string> {"alpha", "beta", "gamma"};
            Assign();
        }

    }

    protected void Assign()
    {
        this.txFirstName.Text = _json.Firstname;
        this.txLastName.Text = _json.Lastname;
        this.txColor.Text = _json.Color;

        this.txLabelText.Text = _json.Properties.text;
        this.txLabelColor.Text = _json.Properties.color;
        this.txLabelLeft.Text = _json.Properties.left;
        this.txLabelTop.Text = _json.Properties.top;

        this.txProperty.Text = _json.Properties.p;
        this.txValue.Text = _json.Properties.v;

        if (_json.List.Count > 0) this.txItem1.Text = _json.List[0];
        if (_json.List.Count > 1) this.txItem2.Text = _json.List[1];
        if (_json.List.Count > 2) this.txItem3.Text = _json.List[2];      
    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        _json.Firstname = this.txFirstName.Text;
        _json.Lastname = this.txLastName.Text;
        _json.Color = this.txColor.Text;
        _json.List.Clear();
        _json.List.Add(this.txItem1.Text);
        _json.List.Add(this.txItem2.Text);
        _json.List.Add(this.txItem3.Text);
        _json.Properties.text = this.txLabelText.Text;
        _json.Properties.color = this.txLabelColor.Text;
        _json.Properties.left = this.txLabelLeft.Text;
        _json.Properties.top = this.txLabelTop.Text;

        _json.Properties.p = this.txProperty.Text;
        _json.Properties.v = this.txValue.Text;

        Assign();

    }
}