﻿using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using ContactBook.Droid;
using ContactBook.Persistence;

[assembly: Dependency(typeof(SQLiteDb))]

namespace ContactBook.Droid
{
	public class SQLiteDb : ISQLiteDb
	{
		public SQLiteAsyncConnection GetConnection()
		{
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			var path = Path.Combine(documentsPath, "MySQLite.db3");

			return new SQLiteAsyncConnection(path);
		}
	}
}

