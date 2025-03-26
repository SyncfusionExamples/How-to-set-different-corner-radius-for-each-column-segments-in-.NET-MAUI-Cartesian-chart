using System;

namespace ColumnCustomCorners;

public class Model
{
 public string Month { get; set; }
 public double ProfitLoss { get; set; }

    public Model(string month, double profitLoss)
    {
        Month = month;
        ProfitLoss = profitLoss;
    }
}
