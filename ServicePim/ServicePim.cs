using MyAirport.Pim.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MyAirport.Pim.Entities;

namespace ServicePim
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class ServicePim : IServicePim
    {
        public static int NbAppelTotal = 0;
        public static int NbInstance = 0;
        public static int NbAppelInstance = 0;

        public void CreateBagage(BagageDefinition bag)
        {
            // List<BagageDefinition> res = MyAirport.Pim.Models.Factory.Model.
            MyAirport.Pim.Models.Factory.Model.CreateBagage(bag);
        }
        
        public List<BagageDefinition> GetBagageByCodeIata(string codeIata)
        {
            NbAppelTotal++;
            NbAppelInstance++;
            List<BagageDefinition> res = MyAirport.Pim.Models.Factory.Model.GetBagage(codeIata);
            if (res != null)
            {
                if (res.Count == 1)
                {
                    return res;
                }
                else if (res.Count > 1)
                {
                    MultipleBagagesFault e = new MultipleBagagesFault
                    {
                        CodeIata = codeIata,
                        ListBagages = res,
                        Message = "Trop de bagages pour ce code Iata"
                    };
                    throw new FaultException<MultipleBagagesFault>(e);
                }
                else return null;
            }
            else
            {
                return null;
            }
        }

        public BagageDefinition GetBagageById(int idBagage)
        {
            return MyAirport.Pim.Models.Factory.Model.GetBagage(idBagage);
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
    }
}
