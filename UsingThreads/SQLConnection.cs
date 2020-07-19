using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace UsingThreads
{
    internal static class SQLConnection
    {
        internal static bool _Connection { get; set; } = false;
        internal static string _DataSourse { get; set; }
        internal static string _InitialCatalog { get; set; }
        internal static bool _IntegratedSecurity { get; set; }

        //internal static Thread MyThread = new Thread(TestSQLCOnnection);

        static internal bool TestSQLCOnnection()
        {
            //MyThread.Name = "TestSQLCOnnection";
            SqlConnectionStringBuilder SQLStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = _DataSourse,
                InitialCatalog = _InitialCatalog,
                IntegratedSecurity = _IntegratedSecurity
            };
            SqlConnection connection = new SqlConnection(SQLStringBuilder.ConnectionString);
            try
            {
                // Открываем подключение
                connection.Open();
                Console.WriteLine(connection.State);
                return true;
                // получаем текущий поток
                //MessageBox.Show($"Имя потока: {MyThread.Name}\n" +
                //                $"Запущен ли поток: {MyThread.IsAlive}\n" +
                //                $"Приоритет потока: {MyThread.Priority}\n" +
                //                $"Статус потока: {MyThread.ThreadState}\n" +
                //                $"Фоновый ли поток: {MyThread.IsBackground}", "Информация о потоке", MessageBoxButtons.OK);
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
                //MessageBox.Show("Подключение не выполнено\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //MyThread.Abort();
                //MyThread.Join();
                connection.Close();
                Console.WriteLine(connection.State);
            }
        }

        static internal DataTable ExecuteProcedure(string sqlExpression, string[] NameParameters, DbType[] DbType, ArrayList ValueParemeters)
        {
            //ArrayList list = new ArrayList();
            DataTable dt = new DataTable();

            SqlConnectionStringBuilder SQLStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = _DataSourse,
                InitialCatalog = _InitialCatalog,
                IntegratedSecurity = _IntegratedSecurity
            };
            SqlConnection connection = new SqlConnection(SQLStringBuilder.ConnectionString);
            
            try
            {
                connection.Open();
                Console.WriteLine(connection.State);
                SqlCommand command = new SqlCommand(sqlExpression, connection)
                {
                    /// указываем, что команда представляет хранимую процедуру
                    CommandType = CommandType.StoredProcedure
                };
                /// Добавляем параметры
                for (int i = 0; i < ValueParemeters.Count; i++)
                {
                    SqlParameter Param = new SqlParameter
                    {
                        ParameterName = NameParameters[i],
                        DbType = DbType[i],
                        Value = ValueParemeters[i]
                    };
                    command.Parameters.Add(Param);
                }
                /// Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                /// Заполняем datatable
                adapter.Fill(dt);
                return dt;
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return dt = null;
            }
            finally
            {
                connection.Close();
                Console.WriteLine(connection.State);
            }
        }
    }
}
