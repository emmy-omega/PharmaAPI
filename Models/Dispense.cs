using System;

namespace PharmaAPI.Model
{
  public class Dispense
  {
    public Bill Bill { get; set; }
    public int BillId { get; set; }
    public Drug Drug { get; set; }
    public int DrugId { get; set; }
    public int Quantity { get; set; }
    public decimal Amount { get; set; }
  }
}