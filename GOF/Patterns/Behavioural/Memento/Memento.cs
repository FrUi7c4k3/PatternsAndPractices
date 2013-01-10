using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Behavioural.Memento
{
	public class Memento
	{
		public string ISBN { get; private set; }
		public string Title { get; private set; }
		public string Author { get; private set; }
		public DateTime LastEdited { get; private set; }
		public int VersionNumber { get; set; }

		public Memento(Book book)
		{
			ISBN = book.ISBN;
			Title = book.Title;
			Author = book.Author;
			LastEdited = book.LastEdited;
		}
	}
}
