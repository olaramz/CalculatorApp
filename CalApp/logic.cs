using MyLogic;
using MyModel;
using System;

namespace CalApp
{
    public class logic : ILogic
    {
        public double Area1(RectangleViewModel model)
        {
            var reply = model.lenght * model.bredth;
            return (reply);
        }

        public double Area2(TriangleViewModel model)
        {
            var respond = 1 / 2 * model.Base * model.height;
            return (respond);
        }
    }
}
