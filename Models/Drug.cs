using System;
using System.Collections.Generic;

namespace PharmaAPI.Model
{
  public class Drug
  {
    public int Number { get; set; }
    public string Name { get; set; }
    public string Dose { get; set; }
    public string DiplayName
    {
      get { return $" {Name} {Dose}"; }
    }
    public string Classificaton { get; set; }
    public decimal Price { get; set; }

    public List<Dispense> Dispenses { get; set; }

  }
}