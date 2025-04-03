using System;
using System.Collections.ObjectModel;

namespace ColumnCustomCorners;

public class ViewModel
{
    public ObservableCollection<Model> SalesData { get; set; }

    public ViewModel()
    {
        SalesData = new ObservableCollection<Model>();
        SalesData.Add(new Model("Jan",5000));
        SalesData.Add(new Model("Feb",-3000));
        SalesData.Add(new Model("Mar",10000));
        SalesData.Add(new Model("Apr",-4000));
        SalesData.Add(new Model("May",5000));
        SalesData.Add(new Model("Jul",-5000));
    }
}
