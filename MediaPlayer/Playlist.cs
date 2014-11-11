using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

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
                SqlCommand delete = new SqlCommand("DELETE FROM PlaylistSongs WHERE playlistID = " + id.ToString() + ";", SQLManager.getInstance().connection);
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
                SqlCommand select = new SqlCommand("SELECT * FROM Playlists WHERE playlistName = '" + HttpUtility.UrlEncode(name) + "';", SQLManager.getInstance().connection);
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
                SqlCommand create = new SqlCommand("INSERT INTO Playlists (playlistName) VALUES ('" + HttpUtility.UrlEncode(name) + "');", SQLManager.getInstance().connection);
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
                    playlists.Add(HttpUtility.UrlDecode(reader["playlistName"].ToString()));
                }

                reader.Close();
            }
            catch
            { }

            return playlists;
        }

        public static void addToPlalist(string listName, int songID)
        {
            addToPlalist(getPlaylistID(listName), songID);
        }

        public static void addToPlalist(int listID, int songID)
        {
            SQLManager.getInstance().Execute("INSERT INTO PlaylistSongs (playlistID, songID) VALUES (" + listID + ", " + songID + ");");
        }

        public static List<Song> getPlaylistContents(string name)
        {
            List<Song> SongList = new List<Song>();
            int id = getPlaylistID(name);

            SqlCommand select = new SqlCommand("SELECT * FROM PlaylistSongs WHERE playlistID = " + id + ";", SQLManager.getInstance().connection);
            SqlDataReader reader = select.ExecuteReader();

            List<int> SongIDSList = new List<int>();

            while (reader.Read())
            {
                SongIDSList.Add(Convert.ToInt32(reader["songID"]));
            }

            reader.Close();

            for (int i = 0; i < SongIDSList.Count; i++)
            {
                SongList.Add(SQLManager.getInstance().getSongByID(SongIDSList[i]));
            }

            return SongList;
        }
    }
}
