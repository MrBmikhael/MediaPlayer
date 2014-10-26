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

            try
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
            catch
            {
                return false;
            }
            return true;

        }


    }
}
