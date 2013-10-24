using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Properties
{
    public string text { get; set; }
    public string top { get; set; }
    public string left { get; set; }
    public string color { get; set; }
}
/// <summary>
/// Summary description for globals
/// </summary>
public class Globals
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Color { get; set; }
    public List<string> List { get; set; }
    public Properties Properties { get; set; }

    public Globals()
    {
        this.Firstname = "Mario";
        this.Lastname = "Rossi";
        this.Color = "black";
        this.List = new List<string>(){"Qui","Quo","Qua"};
        this.Properties = new Properties()
            {
               text = "Welcome",
               color = "blue",
               top = "",
               left = ""
            };
    }

    private static readonly Globals _Instance = new Globals();
    public static Globals Instance { get { return _Instance; } }
}