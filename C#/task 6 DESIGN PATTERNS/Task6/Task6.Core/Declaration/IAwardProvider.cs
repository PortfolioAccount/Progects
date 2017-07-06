using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Core.Declaration
{
    public interface IAwardProvider
    {
        List<Award> Get();
        void Save(List<Award> awards);
    }
}
