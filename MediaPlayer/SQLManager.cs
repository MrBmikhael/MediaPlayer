using HundredMilesSoftware.UltraID3Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    class SQLManager
    {
        private static SQLManager Instance = null;

        private SqlCeConnection connection;
        private DataSet data;
        private SqlCeDataAdapter adapter;

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

        public bool connectToDB()
        {
            string dbfile = new System.IO.FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).DirectoryName + "\\Songs.sdf";
            connection = new SqlCeConnection("datasource=" + dbfile);

            // Read all rows from the table test_table into a dataset (note, the adapter automatically opens the connection)
            SqlCeDataAdapter adapter = new SqlCeDataAdapter("select * from test_table", connection);
            DataSet data = new DataSet();
            adapter.Fill(data);
            

            // Add a row to the test_table (assume that table consists of a text column)
            //data.Tables[0].Rows.Add(new object[] { "New row added by code" });

            // Save data back to the databasefile
            //adapter.Update(data);

            // Close 
            //connection.Close();
            return true;
        }

        public bool SaveDB()
        {

            return true;
        }

        public bool Insert(string file)
        {
            UltraID3 tagReader = new UltraID3();
            tagReader.Read(file);

            if (tagReader.ID3v2Tag.ExistsInFile)
            {
                //MessageBox.Show("ID3V2 Tags Found");
                try
                {
                    //SongsDBDataSetTableAdapters.SongsTableAdapter s = new SongsDBDataSetTableAdapters.SongsTableAdapter();
                    //s.Insert(0, file, tagReader.ID3v2Tag.Title, tagReader.ID3v2Tag.Artist, tagReader.ID3v2Tag.Album, (int)tagReader.ID3v2Tag.Year, tagReader.ID3v2Tag.Comments, tagReader.ID3v2Tag.Genre);

                }
                catch
                {
                    return false;
                }

                //int count = s.GetData().Count;

            }
            else if (tagReader.ID3v1Tag.ExistsInFile)
            {
                //MessageBox.Show("ID3V1 Tags Found");
            }
            else
            {
                //MessageBox.Show("No Tags Found");
            }

            return true;
        }
    }
}
