using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Behavioural.Memento;
using System.Threading;

namespace Patterns.Tests.Behavioural
{
	/// <summary>
	/// The memento pattern is a design pattern that permits the current state of an object to be stored 
	/// without breaking the rules of encapsulation. The originating object can be modified as required 
	/// but can be restored to the saved state at any time.
	/// </summary>
	[TestClass]
	public class Memento
	{
		[TestMethod]
		public void TestMethod1()
		{
			Book book = new Book();
			book.ISBN = "0450488357";
			book.Title = "The Tommyknockers";
			book.Author = "Stephen King";
			book.ShowBook();

			book.SaveUndo();

			Thread.Sleep(1000);

			// Modify book
			book.ISBN = "0330376144";
			book.Title = "The Rats";
			book.Author = "James Herbert";
			book.ShowBook();

			book.SaveUndo();
			
			book.PrintHistory();

			book.RestoreToVersion(1);
			book.ShowBook();
		}
	}
}
