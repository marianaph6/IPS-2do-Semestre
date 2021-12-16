using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_IPS
{
    class opEmpleados
    {
        public static bool PermitirIngreso(string idEmpleado, string password)
        {
            using (var con = new System.Data.OleDb.OleDbConnection(BD.access))
            {
                con.Open();

                string sql = "SELECT COUNT(*) FROM tb_Empleados AS A WHERE Id_Empleado = @idEmpleado AND Password = @password";

                using (var command = new System.Data.OleDb.OleDbCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    command.Parameters.AddWithValue("@password", password);

                    return Convert.ToBoolean((int)command.ExecuteScalar());
                }
            }
        }
    }
}
