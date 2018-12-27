using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class PublicClasses
    {
        static public string idUser { get; set; }
        static public string UserLogin { get; set; }
        static public string server { get; set; }
        static public string user { get; set; }
        static public string password { get; set; }
        static public string db { get; set; }
        static public string port { set; get; }
        static public string sql { set; get; }
        static public int selectedRowIndex { set; get; }
        static public int rowIndex{ set; get; }
        static public int privelege { set; get; }
        static public MySqlConnection connection() { MySqlConnection connection = new MySqlConnection(getDbPathFromFile()); return connection; } //объявления объекта класса MySqlConnection
        static public string getStringConnection() // формирование строки параметров соединения с базой
        { return "server=" + server + ";" + "user=" + user + ";" + "password=" + password + ";" +"database=" + db + ";" + "port=" + port; }
        static public int checkConnection() // проверка соединения с базой
        {
            MySqlConnection connection = new MySqlConnection(getDbPathFromFile());
            try
            {
                connection.Open();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally{connection.Close();}
        }
        static public void openTheConnection(){ connection().Open();} // подключение к базе
        static public void closeTheConnection(){ connection().Close(); } //разрыв соединения с базой
        static public DataSet executeSqlRequest() // выполение запроса
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection());
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
        static public void writeToFileUser(System.Windows.Forms.CheckBox chkbx) // функция "Запомнть меня" выкл
        {
            StreamWriter streamWrite = new StreamWriter("rememberMe.txt", false);
            if (chkbx.Checked) { streamWrite.WriteLine(idUser); }
            else { streamWrite.WriteLine("0"); }
            streamWrite.Close();
        }
        static public string readFromFileUser() // функция "Запомнить меня" вкл
        {
            StreamReader streamRead = new StreamReader("rememberMe.txt");
            idUser = streamRead.ReadLine();
            streamRead.Close();
            return idUser;
        }
        static public string getDbPathFromFile() //считывание параметров подключения к базе с файла
        {
            StreamReader streamRead = new StreamReader("SettingsDbPath.txt");
            string dbConnection = streamRead.ReadLine();
            streamRead.Close();
            return dbConnection;
        }
        static public void setDbPathToFile() //запись параметров подлкючения к базе в файл
        {
            StreamWriter streamWrite = new StreamWriter("SettingsDbPath.txt", false);
            streamWrite.WriteLine(getStringConnection());
            streamWrite.Close();
        }
        static public string[] loadStringsToCmbbox() //подстановка данных в combobox
        {
            string[] mas = new string[executeSqlRequest().Tables[0].Rows.Count];
            for (int i = 0; i < executeSqlRequest().Tables[0].Rows.Count; i++)
            {
                mas[i] = executeSqlRequest().Tables[0].Rows[i].ItemArray[0].ToString();
            }

            return mas;
        }
        static public void deleteSelectedRow(System.Windows.Forms.DataGridView dg, string table, string set, string column) //удаление 
        {
            sql = "update "+table+" set "+set+" where "+column+"="+selectedRowIndex+"";
            MessageBox.Show(sql);
            executeSqlRequest();
        }
        static public void insertIntoTable(string table, string columnsTable, string values) //добавление
        {
            sql = "insert into " + table + "( " + columnsTable + ") values(" + values + ")";
            MessageBox.Show(sql);
            executeSqlRequest();
        }
        static public void updateDatas(string table, string set, string idName) //обновление данных
        {
            sql = "update " + table + " set " + set + " where " + idName + "=" + selectedRowIndex + "";
            MessageBox.Show(sql);
            executeSqlRequest();
        }
        static public int[] changeRowsRequest(string sql)
        {
            PublicClasses.sql = sql;
            int[] mas = new int[executeSqlRequest().Tables[0].Rows.Count];
            for (int i = 0; i < executeSqlRequest().Tables[0].Rows.Count; i++)
            {
                mas[i] = (int)executeSqlRequest().Tables[0].Rows[i].ItemArray[0];
            }
            return mas;
        }

    }
}
