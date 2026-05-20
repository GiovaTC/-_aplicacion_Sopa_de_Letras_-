using Oracle.ManagedDataAccess.Client;

namespace SopaLetrasOracle.Conexion
{
    public class ConexionOracle
    {
        private string conexion =
            "DATA SOURCE=localhost:1521/orcl;USER ID=system;PASSWORD=Tapiero123";
        
        public OracleConnection ObtenerConexion()
        {
            OracleConnection cn = new OracleConnection(conexion);
            cn.Open();
            return cn;
        }   
    }
}
