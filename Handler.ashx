<%@ WebHandler Language="C#" Class="Handler" %>

using System.Web;
using System.Web.Script.Serialization;

public class Handler : IHttpHandler {
    
    public void ProcessRequest (HttpContext context)
    {

        var json = Globals.Instance;



        var serializer = new JavaScriptSerializer();
        var jsonString = serializer.Serialize(json);
                
        // need to change a property (ugly code)
        if (! string.IsNullOrEmpty(json.Properties.p))
        { 
            jsonString = jsonString.Replace("fakevalue", json.Properties.v);
            jsonString = jsonString.Replace("fake", json.Properties.p);
        }
        
        context.Response.ContentType = "application/json";     
        context.Response.Write(jsonString);
        context.Response.Flush();
        context.Response.End();


    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}