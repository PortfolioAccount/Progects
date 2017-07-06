using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6.Core.Declaration;
using Task6.Core;


namespace Task6.DAL
{
    public class AwardProvider : IAwardProvider
    {
        private List<Award> awards = new List<Award>();

        public List<Award> Get()
        {
            if (awards.Count != 0)
            {
                return awards;
            }

            using (FileStream file2 = new FileStream(Utilites.CheckFilePath2("Awards"), FileMode.Open))
            {
                StreamReader reader2 = new StreamReader(file2);
                string line2 = reader2.ReadToEnd();
                string[] mas2 = line2.Split('\n');
                foreach (var item in mas2)
                {
                    if (string.IsNullOrWhiteSpace(item))
                    {
                        continue;
                    }
                    int id;
                    string[] masUser = item.Split('|');
                    awards.Add(new Award()
                    {
                        Id = int.TryParse(masUser[0], out id) ? id : 0,
                        Title = masUser[1]
                    });
                }
            }
            return awards;
        }

        public void Save(List<Award> awards)
        {//сохранить в файл и сохранить в локальную переменную users
         // using (StreamWriter sw = File(@"D:\User\Users.txt"))
            string spice2 = string.Empty;

            foreach (var item in awards)
            {
                spice2 += (item.Id + "|" + item.Title + Environment.NewLine);
            }

            File.WriteAllText(Utilites.CheckFilePath2("Awards"), spice2);
            this.awards = awards;
        }
    }
}
