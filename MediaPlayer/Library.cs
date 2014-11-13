using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    class Library
    {
        public Library()
        { }

        public static List<Song> getSongs()
        {
            List<Song> SongList = new List<Song>();

            SqlCommand select = new SqlCommand("SELECT * FROM Songs;", SQLManager.getInstance().connection);
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

        public static int getSongID(string path)
        {
            int SongID = 0;
            SqlCommand command = new SqlCommand("SELECT * FROM Songs WHERE filePath = '" + path + "';", SQLManager.getInstance().connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            SongID = Convert.ToInt32(reader["SongID"].ToString());

            reader.Close();

            return SongID;
        }

        public static Song getSongByID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Songs WHERE SongID = " + id + ";", SQLManager.getInstance().connection);
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

        public static void insert(string f)
        {
            SQLManager.getInstance().Insert(f);
        }

        public static void deleteSong(string file)
        {
            int id = 0;

            SqlCommand select = new SqlCommand("SELECT * FROM Songs WHERE filePath = '" + file + "';", SQLManager.getInstance().connection);
            SqlDataReader reader = select.ExecuteReader();
            reader.Read();
            id = Convert.ToInt32(reader["SongID"].ToString());
            reader.Close();
            delete(id);
        }

        private static void delete(int id)
        {
            if (SQLManager.getInstance().connection.State == ConnectionState.Closed)
            {
                throw new Exception("Not connected to the Database.");
            }

            try
            {
                SqlCommand delete = new SqlCommand("DELETE FROM Songs WHERE SongID = " + id.ToString() + ";", SQLManager.getInstance().connection);
                delete.ExecuteNonQuery();

                delete = new SqlCommand("DELETE FROM PlaylistSongs WHERE songID = " + id.ToString() + ";", SQLManager.getInstance().connection);
                delete.ExecuteNonQuery();
            }
            catch { }
        }
    }
}
