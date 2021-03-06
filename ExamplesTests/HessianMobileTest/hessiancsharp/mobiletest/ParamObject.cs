/*
***************************************************************************************************** 
* HessianCharp - The .Net implementation of the Hessian Binary Web Service Protocol (www.caucho.com) 
* Copyright (C) 2004-2005  by D. Minich, V. Byelyenkiy, A. Voltmann
* http://www.hessiancsharp.com
*
* This program is free software; you can redistribute it and/or
* modify it under the terms of the GNU General Public License
* as published by the Free Software Foundation; either version 2
* of the License, or any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
* 
* You can find the GNU General Public License here
* http://www.gnu.org/licenses/gpl.html
* or in the license.txt file in your source directory.
******************************************************************************************************   
* The GNU Public License does not permit the integration of the libraries in proprietary programs. 
* On request we'll also offer another licence for an appropriate royalty for integration in proprietary 
* (commercial) applications.
******************************************************************************************************  
* You can find all contact information on http://www.hessiancsharp.com	
******************************************************************************************************
*
*
******************************************************************************************************
* Last change: 2004-11-20
* By LosAndros	
* Added comments.
******************************************************************************************************
*
*/

using System.Collections;

namespace com.hessiannet.hessian.test
{
	/// <summary>
	/// Zusammenfassung f�r ParamObject.
	/// </summary>
	public class ParamObject 
	{
		public static string test = "Hallo Welt";
		private string stringVar = null;
		public Hashtable hashVar = null;

		/**
		 * @return
		 */
		public Hashtable getHashVar() 
		{
			return hashVar;
		}

		/**
		 * @param hashVar
		 */
		public void setHashVar(Hashtable hashVar) 
		{
			this.hashVar = hashVar;
		}

		/**
		 * @return
		 */
		public string getStringVar() 
		{
			return stringVar;
		}

		/**
		 * @param stringVar
		 */
		public void setStringVar(string stringVar) 
		{
			this.stringVar = stringVar;
		}


	}
}
