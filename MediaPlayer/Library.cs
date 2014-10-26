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
        private int getPlaylistID(string name)
        {
            int id = 0;

            try
            {
                SqlCommand select = new SqlCommand("SELECT * FROM Playlists WHERE playlistName = '" + name + "');", SQLManager.getInstance().connection);
                SqlDataReader reader = select.ExecuteReader();
                reader.Read();
                id = Convert.ToInt32(reader["Id"].ToString());
            }
            catch { }

            return id;
        }
        public static void deleteSong(int id)
        {
            delete(id);
        }
        public static void deleteSong(string file)
        {
            int id = 0;

            try
            {
                SqlCommand select = new SqlCommand("SELECT * FROM Songs WHERE filePath = '" + file + "');", SQLManager.getInstance().connection);
                SqlDataReader reader = select.ExecuteReader();
                reader.Read();
                id = Convert.ToInt32(reader["Id"].ToString());
            }
            catch { }

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
                SqlCommand delete = new SqlCommand("DELETE FROM Songs WHERE id = " + id.ToString() + ";", SQLManager.getInstance().connection);
                delete.ExecuteNonQuery();

                delete = new SqlCommand("DELETE * FROM PlaylistSongs WHERE songID = " + id.ToString() + ";", SQLManager.getInstance().connection);
                delete.ExecuteNonQuery();
            }
            catch { }
        }
    }
}
