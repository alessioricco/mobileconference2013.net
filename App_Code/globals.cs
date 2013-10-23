using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for globals
/// </summary>
public class Globals
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Color { get; set; }
    public List<string> List { get; set; }

    private static readonly Globals _Instance = new Globals();
    public static Globals Instance { get { return _Instance; } }
}