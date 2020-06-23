using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using Company.Droid.Persistence;
using Company.Persistance;

[assembly: Dependency(typeof(SQLiteDb))]

namespace Company.Droid.Persistence
{
	public class SQLiteDb : ISQLiteDb
	{
		public SQLiteAsyncConnection GetConnection()
		{
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			var path = Path.Combine(documentsPath, "MySQLite.db3");

			return new SQLiteAsyncConnection(path);
		}
	}
}