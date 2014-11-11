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

        public Song getSongByID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Songs WHERE SongID = " + id + ";", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            Song a = new Song();
            a.File = reader["filePath"].ToString();
            a.Title = reader["title"].ToString();
            a.Artist = reader["artist"].ToString();
            a.Album = reader["album"].ToString();
            a.Year = Convert.ToInt32(reader["year"].ToString());
            a.Comment = reader["comment"].ToString();
            a.Genre = reader["genre"].ToString();

            reader.Close();
            return a;

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

        public int getSongID(string path)
        {
            int SongID = 0;
            SqlCommand command = new SqlCommand("SELECT * FROM Songs WHERE filePath = '" + path + "';", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            SongID = Convert.ToInt32(reader["SongID"].ToString());

            reader.Close();

            return SongID;
        }


    }
}
