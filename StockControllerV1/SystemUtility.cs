using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControllerV1
{
	public class SystemUtility
	{
		public static string GetDatabaseConnection(int DatabaseType)
		{
			if (DatabaseType == 1)
			{
				return @"Initial Catalog=DMHStockMasterV2021;Data Source=.\\SQLEXPRESS;Persist Security=False;Integrated Security=true;";
			}
			else if (DatabaseType == 2)
			{
				return @"Initial Catalog=DMHStockv5;Data Source=.\\SQLEXPRESS;Persist Security=False;Integrated Security=true;";
			}
			else if (DatabaseType == 3)
			{
				return @"Initial Catalog=master;Data Source=.\\SQLEXPRESS;Persist Security=False;Integrated Security=true;";
			}
			else
			{
				return @"Initial Catalog=master;Data Source=.\\SQLEXPRESS;Persist Security=False;Integrated Security=true;";
			}
		}
	}
}
