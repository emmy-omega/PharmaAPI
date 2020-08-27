using System;

namespace PharmaAPI.Model
{
  public class Visit
  {
    public int VisitNumber { get; set; }
    public DateTime Date { get; set; }
    public string Type { get; set; }
    public string ClientName { get; set; }
    public Bill Bill { get; set; }

  }
}