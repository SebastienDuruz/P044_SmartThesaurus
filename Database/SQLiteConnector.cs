/// ETML
/// Autor : Sébastien Duruz
/// Date : 12.03.2021
/// Description : Connect to SQLite components

using Microsoft.Data.Sqlite; //Use Sqlite database
using sebduruz_Index_FormTestProject.Models.ObjectsIndex;
using System;
using System.Collections.Generic;

namespace sebduruz_Index_FormTestProject.Models
{
    /// <summary>
    /// Class ConnectDatabase
    /// </summary>
    public class SQLiteConnector
    {
        /// <summary>
        /// Class Atributs
        /// </summary>
        private readonly string _dbPath;
        private SqliteConnection _connexion;
        private SqliteCommand _command;

        /// <summary>
        /// Class Properties
        /// </summary>
        public List<IObjectsIndex> CurrentResults { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="dbPath">The path of the DB to load</param>
        public SQLiteConnector(string dbPath)
        {
            this._dbPath = dbPath;
            this.Connect();
        }

        /// <summary>
        /// Connect to database
        /// </summary>
        private void Connect()
        {
            try
            {
                this._connexion = new SqliteConnection($"Data Source={this._dbPath}");

                //Try to establish the connexion
                this._connexion.Open();
            }
            catch
            {
                throw new Exception("Impossible de se connecter à la base de donnée.");
            }
        }

        /// <summary>
        /// TODO : Code the method
        /// Execute and return Select request
        /// </summary>
        /// <param name="command">The command to execute</param>
        /// <returns>A list containing all the results</returns>
        public List<IObjectsIndex> SelectFromDatabase(string command)
        {
            this._command = new SqliteCommand(command, this._connexion);
            _ = this._command.ExecuteReader();

            return new List<IObjectsIndex>();
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
