using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAirport.Pim.Models
{
    public class Natif : AbstractDefinition
    {


        public override Entities.BagageDefinition GetBagage(int idBagage)
        {

            List<Entities.BagageDefinition> bagageList; string strCnx = ConfigurationManager.ConnectionStrings["MyAiport.Pim.Settings.DbConnect"].ConnectionString;
            /* fill list 
            bagageList = new List<Entities.BagageDefinition>();

            for (int i = 0; i < 5000; i++)
            {
                Entities.BagageDefinition newBagage = new Entities.BagageDefinition();
                newBagage.IdBagage = i;
                newBagage.Ligne = "ligne " + i % 3;
                bagageList.Add(newBagage);
            }



            foreach (Entities.BagageDefinition bagage in bagageList)
            {
                if (bagage.IdBagage == idBagage) return bagage;
            }

            return null;*/

            throw new NotImplementedException();


        }

        public override List<Entities.BagageDefinition> GetBagage(string codeIataBagage)
        {
            /*List<Entities.BagageDefinition> ReturnedBagageList;

            foreach (Entities.BagageDefinition bagage in bagageList) {
                if (bagage.IdBagage == idBagage) ReturnedBagageList.Add(bagage);
            }

            return ReturnedBagageList;*/
            throw new NotImplementedException();
        }

        public override void CreateBagage(Entities.BagageDefinition bag)
        {
            throw new NotImplementedException();
        }
    }

}
