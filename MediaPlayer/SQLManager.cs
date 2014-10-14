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

        private SqlConnection connection;
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

        public List<Song> getSongs()
        {
            List<Song> SongList = new List<Song>();

            SqlCommand select = new SqlCommand("SELECT * FROM Songs;", connection);
            SqlDataReader reader = select.ExecuteReader();

            while (reader.Read())
            {
                Song a = new Song();
                a.File = reader["filePath"].ToString();
                a.Title = reader["title"].ToString();
                a.Artist = reader["artist"].ToString();
                a.Album = reader["album"].ToString();
                a.Year = Convert.ToInt32(reader["year"].ToString());
                a.Comment = reader["comment"].ToString();
                a.Genre = reader["genre"].ToString();

                SongList.Add(a);
            }

            reader.Close();

            return SongList;
        }
        
        public bool deleteFile(string file)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connectToDB();
            }

            try
            {
                SqlCommand delete = new SqlCommand("DELETE FROM Songs WHERE filePath = '" + file + "';", connection);
                delete.ExecuteNonQuery();
            }
            catch { return false; }

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
