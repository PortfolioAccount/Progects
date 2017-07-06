using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Core.Declaration
{
    public interface IAwardService
    {
        void CreateOrUpdate(Award award);

        void Remove(int id);

        List<Award> Get();
        Award Get(int id);
    }
}
