using System;
using System.Data;

namespace Final_IPS
{
    class opMedicos
    {
        public static DataTable ListarMedicos()
        {
            DataTable dtCitas = new DataTable();

            using (var con = new System.Data.OleDb.OleDbConnection(BD.access))
            {
                con.Open();

                string sql = "SELECT * FROM tb_Medicos ;";

                using (var adaptador = new System.Data.OleDb.OleDbDataAdapter(sql, con))
                {
                    adaptador.Fill(dtCitas);
                }
            }

            return dtCitas;
        }


        public static void Actualizar(string idmed, int salario, string years)
        {

            DataTable dtCitas = new DataTable();

            using (var con = new System.Data.OleDb.OleDbConnection(BD.access))
            {
                con.Open();

                string sql = @"UPDATE tb_Medicos SET Salario= '" + salario + "', Años_Exp = '" + years + "' WHERE Id_Medico= '" + idmed + "';";

                using (var adaptador = new System.Data.OleDb.OleDbDataAdapter(sql, con))
                {
                    adaptador.Fill(dtCitas);
                }
            }

        }

        public static int SalarioCita(string idmed)
        {
            int salario = 0;
            using (var con = new System.Data.OleDb.OleDbConnection(BD.access))
            {
                con.Open();

                string sql = "SELECT Salario FROM tb_Medicos AS C WHERE C.Id_Medico = @idmed ;";

                using (var command = new System.Data.OleDb.OleDbCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@idmed", idmed);
                    
                    salario = (Convert.ToInt32(command.ExecuteScalar())) ;
                }
            }

            return salario;
        }


        public static int Sueldo(string idmed)
        {
            int salario = SalarioCita(idmed);
            int sueldo = 0;
            using (var con = new System.Data.OleDb.OleDbConnection(BD.access))
            {
                con.Open();

                string sql = "SELECT COUNT (*) FROM tb_Citas AS C WHERE C.Id_Medico = @idmed ;";

                using (var command = new System.Data.OleDb.OleDbCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@idmed", idmed);

                    sueldo = (Convert.ToInt32(command.ExecuteScalar()))*salario;
                }
            }

            return sueldo;
        }
    }
}
