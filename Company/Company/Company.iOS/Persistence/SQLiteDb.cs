using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using Company.iOS.Persistence;
using Company.Persistance;

[assembly: Dependency(typeof(SQLiteDb))]

namespace Company.iOS.Persistence
{
	public class SQLiteDb : ISQLiteDb
	{
		public SQLiteAsyncConnection GetConnection()
		{
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			var path = Path.Combine(documentsPath, "Company.db3");

			return new SQLiteAsyncConnection(path);
		}
	}
}