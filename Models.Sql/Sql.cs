using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Pim.Models
{
    public class Sql : AbstractDefinition
    {
        List<Entities.BagageDefinition> bagageList; string strCnx = ConfigurationManager.ConnectionStrings["MyAiport.Pim.Settings.DbConnect"].ConnectionString;
        string commandGetBagageIata =
        "SELECT DISTINCT b.ID_BAGAGE, b.CODE_IATA, b.COMPAGNIE, b.LIGNE, b.DATE_CREATION, b.DESTINATION, b.PRIORITAIRE, b.CONTINUATION,"
         + "cast(iif(bap.ID_PARTICULARITE is null, 0, 1) as bit) as 'RUSH' from BAGAGE b "
         + "LEFT OUTER JOIN BAGAGE_A_POUR_PARTICULARITE bap on bap.ID_BAGAGE = b.ID_BAGAGE and bap.ID_PARTICULARITE = 15 "
         + "LEFT OUTER JOIN BAGAGE_PARTICULARITE bp on bp.ID_PART = bap.ID_PARTICULARITE "
         + "LEFT OUTER JOIN COMPAGNIE c on c.CODE_IATA = b.COMPAGNIE "
         + "LEFT OUTER JOIN COMPAGNIE_CLASSE cc on cc.ID_COMPAGNIE = c.ID_COMPAGNIE "
         + "WHERE b.CODE_IATA = @codeIata";

        string commandGetBagageId =
        "SELECT b.ID_BAGAGE, b.CODE_IATA, b.COMPAGNIE, b.LIGNE, b.DATE_CREATION, b.DESTINATION, b.PRIORITAIRE, b.CONTINUATION, "
         + "cast(iif(bapp.id_particularite is null, 0, 1) as bit) as 'RUSH' "
         + "FROM BAGAGE b "
         + "LEFT OUTER JOIN BAGAGE_A_POUR_PARTICULARITE bapp on b.ID_BAGAGE = bapp.ID_BAGAGE and bapp.ID_PARTICULARITE = 15 "
         + "where b.ID_BAGAGE = @idBagage";

        public override Entities.BagageDefinition GetBagage(int idBagage)
        {
            using (SqlConnection cnx = new SqlConnection(strCnx))
            {
                Entities.BagageDefinition newbag = new Entities.BagageDefinition();
                SqlCommand cmd = new SqlCommand(this.commandGetBagageId, cnx);
                cmd.Parameters.AddWithValue("@idBagage", idBagage);
                cnx.Open();
                //Implémenter ici le code de récupération et de convertion
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    newbag.IdBagage = reader.GetInt32(reader.GetOrdinal("ID_BAGAGE"));
                    newbag.CodeIata = reader.GetString(reader.GetOrdinal("CODE_IATA"));
                    newbag.Compagnie = reader.GetString(reader.GetOrdinal("COMPAGNIE"));
                    newbag.Ligne = reader.GetString(reader.GetOrdinal("LIGNE"));
                    newbag.DateVol = reader.GetDateTime(reader.GetOrdinal("DATE_CREATION"));
                    newbag.Itineraire = reader.GetString(reader.GetOrdinal("DESTINATION"));
                    newbag.Prioritaire = reader.GetBoolean(reader.GetOrdinal("PRIORITAIRE"));

                    String EnContinuation = reader.GetString(reader.GetOrdinal("CONTINUATION"));
                    if (EnContinuation == "Y") newbag.EnContinuation = true;
                    else newbag.EnContinuation = false;

                    newbag.Rush = reader.GetBoolean(reader.GetOrdinal("RUSH"));
                }

                return newbag;
            }
        }

        public override List<Entities.BagageDefinition> GetBagage(string codeIataBagage)
        {
            using (SqlConnection cnx = new SqlConnection(strCnx))
            {
                List<Entities.BagageDefinition> blist = new List<Entities.BagageDefinition>();
                SqlCommand cmd = new SqlCommand(this.commandGetBagageIata, cnx);
                cmd.Parameters.AddWithValue("@codeIata", codeIataBagage);
                cnx.Open();
                //Implémenter ici le code de récupération et de convertion
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Entities.BagageDefinition newbag = new Entities.BagageDefinition();
                    newbag.IdBagage = reader.GetInt32(reader.GetOrdinal("ID_BAGAGE"));
                    newbag.CodeIata = reader.GetString(reader.GetOrdinal("CODE_IATA"));
                    newbag.Compagnie = reader.GetString(reader.GetOrdinal("COMPAGNIE"));
                    newbag.Ligne = reader.GetString(reader.GetOrdinal("LIGNE"));
                    newbag.DateVol = reader.GetDateTime(reader.GetOrdinal("DATE_CREATION"));
                    newbag.Itineraire = reader.GetString(reader.GetOrdinal("DESTINATION"));
                    newbag.Prioritaire = reader.GetBoolean(reader.GetOrdinal("PRIORITAIRE"));

                    String EnContinuation = reader.GetString(reader.GetOrdinal("CONTINUATION"));
                    if (EnContinuation == "Y") newbag.EnContinuation = true;
                    else newbag.EnContinuation = false;

                    newbag.Rush = reader.GetBoolean(reader.GetOrdinal("RUSH"));

                    blist.Add(newbag);
                }

                return blist;
            }
        }

        public override void CreateBagage(Entities.BagageDefinition bag)
        {
            string strCnx = ConfigurationManager.ConnectionStrings["MyAiport.Pim.Settings.DbConnect"].ConnectionString;
            string cmdString =
                "INSERT INTO BAGAGE(CODE_IATA, ORIGINE_CREATION, DATE_CREATION, CLASSE, PRIORITAIRE, STA, LOCAL_TRANFERT, ISUR, DESTINATION, ESCALE, EMB, RECOLE, COMPAGNIE, LIGNE, JOUR_EXPLOITATION, CONTINUATION, DCS_EMETTEUR, ORIGINE_SAFIR, EN_CONTINUATION, EN_TRANSFERT)"
                + "VALUES(@codeIata, 'D',@dateCreation, 'Y', @prioritaire, 'B', 'T', 0, @itineraire, 'MIA', 1, 0, @compagnie, @ligne, 17, @continuation, 'SB46', 0, 0, 0); SELECT SCOPE_IDENTITY()";
            string cmdString2 = "INSERT INTO BAGAGE_A_POUR_PARTICULARITE VALUES (@idBagage, @particularite)";

            using (SqlConnection cnx = new SqlConnection(strCnx))
            {

                SqlCommand cmd = new SqlCommand(cmdString, cnx);
                cmd.Parameters.AddWithValue("@codeIata", bag.CodeIata);
                cmd.Parameters.AddWithValue("@dateCreation", (bag.DateVol));

                if (bag.Prioritaire) cmd.Parameters.AddWithValue("@prioritaire", 1);
                else cmd.Parameters.AddWithValue("@prioritaire", 0);

                cmd.Parameters.AddWithValue("@itineraire", bag.Itineraire);
                cmd.Parameters.AddWithValue("@compagnie", bag.Compagnie);
                cmd.Parameters.AddWithValue("@ligne", bag.Ligne);

                if (bag.EnContinuation) cmd.Parameters.AddWithValue("@continuation", "Y");
                else cmd.Parameters.AddWithValue("@continuation", "N");

                cnx.Open();
                
                 int modified = Convert.ToInt32(cmd.ExecuteScalar());
                 SqlCommand cmd2 = new SqlCommand(cmdString2, cnx);
                 cmd2.Parameters.AddWithValue("@idBagage", modified);
                 if (bag.Rush) cmd2.Parameters.AddWithValue("@particularite", 15);
                 else cmd2.Parameters.AddWithValue("@particularite", 20);
                 cmd2.ExecuteNonQuery();
                

                

                cnx.Close();
            }
        }
    }
}
