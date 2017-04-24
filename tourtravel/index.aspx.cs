using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class preview_dotnet_templates_newlook_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
"dependencies": {
...
    "Microsoft.AspNet.Server.Kestrel": "1.0.0-beta8",
},
"commands": {
...
    "kestrel": "Microsoft.AspNet.Hosting --server Microsoft.AspNet.Server.Kestrel"
},
"frameworks": {
    "dnxcore50": { }
}
    }
}