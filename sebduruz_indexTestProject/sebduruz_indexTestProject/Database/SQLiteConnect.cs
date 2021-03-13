/// ETML
/// Autor : Sébastien Duruz
/// Date : 12.03.2021
/// Description : Connect to SQLite components

using Microsoft.Data.Sqlite; //Use Sqlite database
using System;
using System.Collections.Generic;

namespace sebduruz_indexTestProject.Database
{
    /// <summary>
    /// Class ConnectDatabase
    /// </summary>
    public class SQLiteConnect
    {
        /// <summary>
        /// Class Atributs
        /// </summary>
        private string _dbPath;
        private SqliteConnection _connexion;
        private SqliteCommand _command;

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="dbPath">The path of the DB to load</param>
        public SQLiteConnect(string dbPath)
        {
            this._dbPath = dbPath;
            this.Connect();
        }

        /// <summary>
        /// Connect to database
        /// </summary>
        private void Connect()
        {
            this._connexion = new SqliteConnection($"Data Source={this._dbPath}");

            //Try to establish the connexion
            this._connexion.Open();
        }

        /// <summary>
        /// Execute and return Select request
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public void ExecSelect(string command)
        {
            this._command = new SqliteCommand(command , this._connexion);

            SqliteDataReader reader = this._command.ExecuteReader();

            //Get the infos from reader
            while (reader.Read())
            {
                Console.WriteLine($"{reader.GetName(0)} {reader.GetName(1)} {reader.GetName(2)} {reader.GetName(3)}");
                Console.WriteLine($"{reader.GetValue(0)} {reader.GetValue(1)} {reader.GetValue(2)} {reader.GetValue(3)}");
            }
        }

        /// <summary>
        /// Close the connexion with the Database
        /// </summary>
        public void CloseConnexion()
        {
            this._connexion.Close();
        }
    }
}
