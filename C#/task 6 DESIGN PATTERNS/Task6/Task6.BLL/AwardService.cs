using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6.Core.Declaration;
using Task6.Core;
using Task6.DAL;

namespace Task6.BLL
{
   public class AwardService : IAwardService
    {
        public AwardService()
        {
            this.awardProvider = new AwardProvider();
        }

        private Core.Declaration.IAwardProvider awardProvider;

        public void CreateOrUpdate(Award award)
        {
            List<Award> list = awardProvider.Get();

            if (award.Id == 0)
            {
                int newID = list.Count > 0 ? list.Max(p => p.Id) : 0;
                award.Id = newID + 1;
                list.Add(award);
            }
            else
            {
                var updated = list.FirstOrDefault(p => p.Id == award.Id);
                updated.Title = award.Title;
            }

            awardProvider.Save(list);
        }

        public List<Award> Get()
        {
            return awardProvider.Get();
        }

        public Award Get(int id)
        {
            return awardProvider.Get().FirstOrDefault(p => p.Id == id);
        }

        public void Remove(int id)
        {
            var awards = Get();
            awards.RemoveAll(p => p.Id == id);
            awardProvider.Save(awards);
        }
    }
}
