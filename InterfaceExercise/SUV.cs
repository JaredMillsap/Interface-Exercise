using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : ICompany
    {
        public int RoadTrips { get; set; }
        public int Family { get; set; }
        public int Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Logo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
