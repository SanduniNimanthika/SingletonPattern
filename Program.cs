using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
	public class Program
	{
		private static Program instance;
		private Program()
		{

		}
		public static Program Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new Program();
				}
				return instance;
			}
		}
	}
		}