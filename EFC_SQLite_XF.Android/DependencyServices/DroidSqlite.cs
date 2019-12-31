using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using EFC_SQLite_XF.Services;

[assembly:Dependency(typeof(EFC_SQLite_XF.Droid.DependencyServices.DroidSqlite))]
namespace EFC_SQLite_XF.Droid.DependencyServices
{
    public class DroidSqlite : ISqlConnection
    {
        public string GetSqlPath()
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "productsDB.db");
        }
    }
}