using HundredMilesSoftware.UltraID3Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MediaPlayer
{
    public class SQLManager
    {
        private static SQLManager Instance = null;

        public SqlConnection connection;
        public static SQLManager getInstance()
        {
            if (Instance == null)
                Instance = new SQLManager();
            return Instance;
        }

        private SQLManager()
        {
            connectToDB();
        }

        private bool connectToDB()
        {
            string dbfile = new System.IO.FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).DirectoryName + "\\Database.mdf";

            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + dbfile + ";Integrated Security=True";
                connection.Open();
            }
            catch
            { return false; }

            return true;
        }

        public void UpdateSettings(int[] newSet)
        {
            string q = "UPDATE Settings SET ";
            q += "Artist='" + newSet[0];
            q += "', Album='" + newSet[1];
            q += "', Year='" + newSet[2];
            q += "', Comment='" + newSet[3];
            q += "', Genre='" + newSet[4] + "' WHERE Id = '1';";

            Execute(q);
        }

        public int[] loadSettings()
        {
            int[] sett = new int[5];

            SqlCommand SettingsCommand = new SqlCommand("SELECT * FROM Settings;", connection);

            SqlDataReader reader = SettingsCommand.ExecuteReader();

            reader.Read();

            sett[0] = (reader["Artist"].ToString() == "False") ? 0 : 1;
            sett[1] = (reader["Album"].ToString() == "False") ? 0 : 1;
            sett[2] = (reader["Year"].ToString() == "False") ? 0 : 1;
            sett[3] = (reader["Comment"].ToString() == "False") ? 0 : 1;
            sett[4] = (reader["Genre"].ToString() == "False") ? 0 : 1;

            reader.Close();

            return sett;
        }

        public void Execute(string q)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connectToDB();
            }

            SqlCommand insertCommand = new SqlCommand(q, connection);
            insertCommand.ExecuteNonQuery();
        }

        public bool CloseDB()
        {
            connection.Close();
            return true;
        }
        
        public bool Insert(string file)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connectToDB();
            }

            UltraID3 tagReader = new UltraID3();
            tagReader.Read(file);

            List<Song> sList = Library.getSongs();

            bool Exist = false;

            for (int i = 0; i < sList.Count; i++ )
            {
                if (sList[i].File == file)
                    Exist = true;
            }

            try
            {

                if (!Exist)
                {
                    string q = "INSERT INTO Songs (filePath, title, artist, album, year, comment, genre) VALUES ('" + file;
                    q += "', '" + tagReader.Title.ToString();
                    q += "', '" + tagReader.Artist.ToString();
                    q += "', '" + tagReader.Album.ToString();
                    q += "', '" + tagReader.Year.ToString();
                    q += "', '" + tagReader.Comments.ToString();
                    q += "', '" + tagReader.Genre.ToString() + "');";

                    SqlCommand insertCommand = new SqlCommand(q, connection);
                    insertCommand.ExecuteNonQuery();
                }
            }
            catch
            {
                return false;
            }

            return true;

        }

    }
}
