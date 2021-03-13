/// ETML
/// Autor : Sébastien Duruz
/// Date : 19.02.2021
/// Description : A basic test project, try to use indexation functions.

using sebduruz_indexTestProject.Database;
using sebduruz_indexTestProject.Indexation;
using System;

namespace sebduruz_indexTestProject
{
    /// <summary>
    /// Class Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main Method
        /// </summary>
        static void Main()
        {
            //Create the file indexator and exec
            FileIndexation indexator = new FileIndexation(Environment.CurrentDirectory);
            indexator.ExecIndexation();

            //Connect to database and exec a request
            SQLiteConnect database = new SQLiteConnect($"{Environment.CurrentDirectory}\\myDatabase.db");
            database.ExecSelect("SELECT * from t_file;");

            Console.ReadLine();
        }
    }
}
