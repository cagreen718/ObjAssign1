using System;
using System.Collections.Generic;
using System.Text;

namespace GameTesting
{
    public interface IPeople
    {
        int Identifier { get; }
        String FirstName { set; get; }
        String LastName { set; get; }
        String FullName { get; }
        String ToString();
    }
}
