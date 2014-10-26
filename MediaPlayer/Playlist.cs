using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    class Playlist
    {
        public int listID;
        public Playlist()
        {

        }

        public void addSong(int id)
        {
            try
            {
                SqlCommand delete = new SqlCommand("DELETE * FROM PlaylistSongs WHERE playlistID = " + id.ToString() + ";", SQLManager.getInstance().connection);
                delete.ExecuteNonQuery();

                delete = new SqlCommand("DELETE FROM Playlists WHERE id = " + id.ToString() + ";", SQLManager.getInstance().connection);
                delete.ExecuteNonQuery();
            }
            catch { }
        }

        private static int getPlaylistID(string name)
        {
            int id = 0;

            try
            {
                SqlCommand select = new SqlCommand("SELECT * FROM Playlists WHERE playlistName = '" + name + "';", SQLManager.getInstance().connection);
                SqlDataReader reader = select.ExecuteReader();
                reader.Read();
                id = Convert.ToInt32(reader["Id"].ToString());
                reader.Close();
            }
            catch { }

            return id;
        }

        public static void createPlaylist(string name)
        {
            try
            {
                SqlCommand create = new SqlCommand("INSERT INTO Playlists (playlistName) VALUES ('" + name + "');", SQLManager.getInstance().connection);
                create.ExecuteNonQuery();
            }
            catch { }
        }
        public static void deletePlaylist(string name)
        {
            deletePlaylist(getPlaylistID(name));
        }
        public static void deletePlaylist(int id)
        {
            try
            {
                SqlCommand delete = new SqlCommand("DELETE FROM PlaylistSongs WHERE playlistID = " + id.ToString() + ";", SQLManager.getInstance().connection);
                delete.ExecuteNonQuery();

                delete = new SqlCommand("DELETE FROM Playlists WHERE Id = " + id.ToString() + ";", SQLManager.getInstance().connection);
                delete.ExecuteNonQuery();
            }
            catch { }
        }

        public static List<string> getAllPlaylists()
        {
            List<string> playlists = new List<string>();
            try
            {
                SqlCommand select = new SqlCommand("SELECT * FROM Playlists;", SQLManager.getInstance().connection);
                SqlDataReader reader = select.ExecuteReader();

                while(reader.Read())
                {
                    playlists.Add(reader["playlistName"].ToString());
                }

                reader.Close();
            }
            catch
            { }

            return playlists;
        }
    }
}
