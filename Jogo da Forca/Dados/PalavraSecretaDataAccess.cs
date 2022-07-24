using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;
using Jogo_da_Forca.Model;
using System.IO;

namespace Jogo_da_Forca.Dados
{
    class PalavraSecretaDataAccess
    {
        private static SqlCeConnection con = new SqlCeConnection("Data Source="+ Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Dados\\banco.sdf");

        public static bool SalvarPalavraSecreta(Jogo_da_Forca.Model.PalavraSecretaBanco palavraSecreta)
        {
            string sql = "INSERT INTO [PalavraSecreta](Palavra,Dica) VALUES(@Palavra,@Dica)";
           

            SqlCeCommand comando = new SqlCeCommand(sql, con);
            comando.Parameters.Add("@Palavra", palavraSecreta.PalavraSecreta);
            comando.Parameters.Add("@Dica", palavraSecreta.Dica );

            con.Open();
            if (comando.ExecuteNonQuery() > 0) {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }



        }
        public static List<PalavraSecretaBanco> ColetarPalavasSecretas()
        {
            List<PalavraSecretaBanco> listDados = new List<PalavraSecretaBanco>();

            SqlCeDataAdapter adapter = new SqlCeDataAdapter("SELECT * FROM PalavraSecreta",con);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];

            foreach(DataRow row in dataTable.Rows)
            {
                
                    PalavraSecretaBanco palavra = new PalavraSecretaBanco() { Id = (int)row["Id"], PalavraSecreta = (string)row["Palavra"], Dica = (string)row["Dica"] };
                    listDados.Add(palavra);
                
            }
            return listDados;
        }


    }

}

