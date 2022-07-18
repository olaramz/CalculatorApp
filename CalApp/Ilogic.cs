using CalApp;
using MyModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLogic
{
  public  interface ILogic
  {
        double Area1(RectangleViewModel model);
        double Area2(TriangleViewModel model);
  }
}
