using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : ICompany
    {
        public int OneRow { get; set; }
        public int Hauling { get; set; }
        public int Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Logo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
