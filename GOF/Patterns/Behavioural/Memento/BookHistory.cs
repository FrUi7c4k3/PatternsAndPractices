using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Patterns.Behavioural.Memento
{
	internal class BookHistory
	{
		#region Private Fields

		private readonly List<Memento> _history = new List<Memento>();

		#endregion //Private Fields

		#region Public Properties

		public IEnumerable<Memento> History 
		{ 
			get 
			{
				foreach (var entry in _history.OrderByDescending(entry => entry.LastEdited))
					yield return entry;
			}
		}

		#endregion //Public Properties

		#region Public Methods

		public void SaveUndo(Book book)
		{
			_history.Add(book.CreateUndo());
		}

		public void RestoreToVersion(Book book, int versionNumber)
		{
			var memento = _history.FirstOrDefault(mem => mem.VersionNumber == versionNumber);

			RestoreBook(book, memento);
		}

		public void RestoreToLatestVersion(Book book)
		{
			var memento = History.LastOrDefault();

			RestoreBook(book, memento);
		}

		public void PrintHistory()
		{
			Debug.WriteLine("Version Number		|		Last Edited");
			
			foreach (var entry in History)
			{
				Debug.WriteLine("{0}			|		{1}", entry.VersionNumber, entry.LastEdited);
			}
		}

		#endregion //Public Methods

		#region Private Methods

		private static Book RestoreBook(Book book, Memento memento)
		{
			if (memento != null && book != null)
			{
				book.RestoreFromUndo(memento);
			}

			return book;
		}

		#endregion //Private Methods
	}
}
