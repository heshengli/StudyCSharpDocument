using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEmun
{
    public static class EnumHelper
    {
        public static string GetEnumName(this Enum thisEnum)
        {
            return Enum.GetName(thisEnum.GetType(), thisEnum);
        }
    }
}
