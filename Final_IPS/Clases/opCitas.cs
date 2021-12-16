using System;
using System.Data;
using System.Windows.Forms;

namespace Final_IPS
{
    class opCitas
    {
        //Validar que no se den 2 citas del mismo especialista
        public static bool ValidarIgual(string idpac, string idmed)
        {

            using (var con = new System.Data.OleDb.OleDbConnection(BD.access))
            {
                con.Open();

                string sql = "SELECT COUNT(*) FROM tb_Citas AS C WHERE C.Id_Paciente = @idpac AND C.Id_Medico=@idmed;";

                using (var command = new System.Data.OleDb.OleDbCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@idpac", idpac);
                    command.Parameters.AddWithValue("@idmed", idmed);
                    return Convert.ToInt32(command.ExecuteScalar()) >= 1 ? false : true;
                }
            }
        }

        // Validar que el paciente no tenga multas
        public static bool ValidarMulta(string idpac)
        {
            int multa = 0;


            using (var con = new System.Data.OleDb.OleDbConnection(BD.access))
            {
                con.Open();

                string sql = "SELECT COUNT(*) FROM tb_Pacientes AS C WHERE C.Id_Paciente = @idpac AND C.Multas=@multa;";

                using (var command = new System.Data.OleDb.OleDbCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@idpac", idpac);
                    command.Parameters.AddWithValue("@multa", multa);
                    return Convert.ToInt32(command.ExecuteScalar()) == 0 ? false : true;
                }
            }
        }

        //Validar que no se den más de dos citas de diferente especialista

        public static bool ValidarDosCitas(string idpac)
        {

            using (var con = new System.Data.OleDb.OleDbConnection(BD.access))
            {
                con.Open();

                string sql = "SELECT COUNT(*) FROM tb_Citas AS C WHERE C.Id_Paciente = @idpac;";

                using (var command = new System.Data.OleDb.OleDbCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@idpac", idpac);
                    return Convert.ToInt32(command.ExecuteScalar()) >= 2 ? false : true;
                }
            }
        }


        //Registrar cita con las tres validaciones
        public static bool RegistrarCita(string idPac, string idMed, DateTime fechaNac)
        {
            if (ValidarIgual(idPac, idMed) == false)
            {
                MessageBox.Show("No se pueden realizar dos citas del mismo especialista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (ValidarDosCitas(idPac) == false)
            {
                MessageBox.Show("No se pueden realizar mas de dos citas de diferente tipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (ValidarMulta(idPac) == false)
            {
                MessageBox.Show("No se pueden realizar citas a pacientes con multas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (ValidarIgual(idPac, idMed) == true && ValidarDosCitas(idPac) == true && ValidarMulta(idPac) == true)
            {
                try
                {
                    using (var con = new System.Data.OleDb.OleDbConnection(BD.access))
                    {
                        con.Open();

                        string query = @"INSERT INTO tb_Citas (Id_Paciente,Id_Medico,Fec_Cita) 
                               VALUES (@id_pac, @id_med, @fechNac);";

                        using (var command = new System.Data.OleDb.OleDbCommand(query, con))
                        {
                            command.Parameters.AddWithValue("@id_pac", idPac);
                            command.Parameters.AddWithValue("@id_med", idMed);
                            command.Parameters.AddWithValue("@fechcita", fechaNac);
                            
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
            return false;
        }

        //Tomar asistencia

        public static DataTable Asistencia(string idpac, string asist, string idmed)
        {
            DataTable dtCitas = new DataTable();

            using (var con = new System.Data.OleDb.OleDbConnection(BD.access))
            {
                con.Open();

                string sql = "update tb_Citas set Asistencia = '" + asist + "'WHERE Id_Paciente='" + idpac +
                           "' AND Id_Medico='" + idmed + "'";

                using (var adaptador = new System.Data.OleDb.OleDbDataAdapter(sql, con))
                {
                    adaptador.Fill(dtCitas);
                }
            }

            return dtCitas;
        }

        //Citas incumplidas
        public static DataTable CitasIncumplidas()
        {
            string asist = "No";
            DataTable dtCitas = new DataTable();

            using (var con = new System.Data.OleDb.OleDbConnection(BD.access))
            {
                con.Open();

                string sql = "select * from tb_Citas where Asistencia = '" + asist + "'";

                using (var adaptador = new System.Data.OleDb.OleDbDataAdapter(sql, con))
                {
                    adaptador.Fill(dtCitas);
                }
            }

            return dtCitas;
        }


        //Mostrar todas las citas
        public static DataTable ListarCitas()
        {
            DataTable dtCitas = new DataTable();

            using (var con = new System.Data.OleDb.OleDbConnection(BD.access))
            {
                con.Open();

                string sql = "SELECT * FROM tb_Citas ;";

                using (var adaptador = new System.Data.OleDb.OleDbDataAdapter(sql, con))
                {
                    adaptador.Fill(dtCitas);
                }
            }

            return dtCitas;
        }
    }
}
