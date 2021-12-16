using System;
using System.Data;

namespace Final_IPS
{
    class opPacientes
    {

        public static bool RegistrarPaciente(string idPaciente, string nombres, string apellidos, DateTime fechaNac, string direccion, string telefono, DateTime fechaReg)
        {
            int multa = 0;
            try
            {
                using (var con = new System.Data.OleDb.OleDbConnection(BD.access))
                {
                    con.Open();

                    string query = @"INSERT INTO tb_Pacientes (Id_Paciente, Nombre, Apellidos, Fech_Nac, Direccion, Telefono, Fech_Reg,Multas) 
                               VALUES (@id_paciente, @nombres, @apellidos, @fechNac, @direccion, @telefono, @fechReg,@multa);";

                    using (var command = new System.Data.OleDb.OleDbCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@id_paciente", idPaciente);
                        command.Parameters.AddWithValue("@nombres", nombres);
                        command.Parameters.AddWithValue("@apellidos", apellidos);
                        command.Parameters.AddWithValue("@fechNac", fechaNac);
                        command.Parameters.AddWithValue("@direccion", direccion);
                        command.Parameters.AddWithValue("@telefono", telefono);
                        command.Parameters.AddWithValue("@fechReg", fechaReg);
                        command.Parameters.AddWithValue("@multa", multa);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static DataTable ListarPacientes()
        {
            DataTable dtPacientes = new DataTable();

            using (var con = new System.Data.OleDb.OleDbConnection(BD.access))
            {
                con.Open();

                string sql = "SELECT * FROM tb_Pacientes ;";

                using (var adaptador = new System.Data.OleDb.OleDbDataAdapter(sql, con))
                {
                    adaptador.Fill(dtPacientes);
                }
            }

            return dtPacientes;
        }

        public static DataTable CitasPaciente(string idpac)
        {

            DataTable dtCitas = new DataTable();

            using (var con = new System.Data.OleDb.OleDbConnection(BD.access))
            {
                con.Open();

                string sql = "select * from tb_Citas where Id_Paciente = '" + idpac + "'";

                using (var adaptador = new System.Data.OleDb.OleDbDataAdapter(sql, con))
                {
                    adaptador.Fill(dtCitas);
                }
            }

            return dtCitas;
        }

        public static DataTable MultasPacientes()
        {

            DataTable dtCitas = new DataTable();

            using (var con = new System.Data.OleDb.OleDbConnection(BD.access))
            {
                con.Open();

                string sql = "select Id_Paciente,Multas FROM tb_Pacientes ;";

                using (var adaptador = new System.Data.OleDb.OleDbDataAdapter(sql, con))
                {
                    adaptador.Fill(dtCitas);
                }
            }

            return dtCitas;
        }


        public static int ValorMulta(string idpac)
        {
            int multa = 0;
            string asist = "No";
            
                using (var con = new System.Data.OleDb.OleDbConnection(BD.access))
                {
                    con.Open();

                    string sql = "SELECT COUNT(*) FROM tb_Citas AS C WHERE C.Id_Paciente = @idpac  AND Asistencia=@asist;";

                    using (var command = new System.Data.OleDb.OleDbCommand(sql, con))
                    {
                        command.Parameters.AddWithValue("@idpac", idpac);
                        command.Parameters.AddWithValue("@asist", asist);
                        multa = (Convert.ToInt32(command.ExecuteScalar())) * 2000;
                    }
                }
            
            return multa;
        }

        public static void AsignarMulta(string idpac)
        {
            DataTable dtCitas = new DataTable();
            int multa = ValorMulta(idpac);
            using (var con = new System.Data.OleDb.OleDbConnection(BD.access))
            {
                con.Open();

                string sql = "update tb_Pacientes set Multas = '" + multa + "'where Id_Paciente = '" + idpac + "'";

                using (var adaptador = new System.Data.OleDb.OleDbDataAdapter(sql, con))
                {
                    adaptador.Fill(dtCitas);
                }
            }


        }
    }
}
