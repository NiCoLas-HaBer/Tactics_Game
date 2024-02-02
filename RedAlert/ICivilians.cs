using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedAlert
{
    public interface ICivilians<T, TT, TResult> : ICivil
    {
        //TResult? Mission(T TOBJECT);
        TResult? Mission(T TOBJECT, TT? ObJect);
        

    }
}
