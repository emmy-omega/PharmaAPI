using System;
using System.Collections.Generic;

namespace PharmaAPI.Model
{
  public class Bill
  {

    public DateTime IssueDate { get; set; }
    public decimal SubTotal { get; set; }
    public Visit Visit { get; set; }
    public int VisitId { get; set; }
    public List<Dispense> Dispenses { get; set; }
  }
}