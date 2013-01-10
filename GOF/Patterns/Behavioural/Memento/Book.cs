using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Patterns.Behavioural.Memento
{
	public class Book
	{
		private string _isbn;
		private string _title;
		private string _author;
		private DateTime _lastEdited;
		private int _versionNumber;

		private BookHistory _history = new BookHistory();

		#region Constructors

		public Book()
		{
			SetLastEdited();
			_versionNumber = 0;
		}

		#endregion //Constructors

		#region Properties

		public string ISBN
		{
			get { return _isbn; }
			set 
			{ 
				_isbn = value;
				SetLastEdited();
			}
		}

		public string Title
		{
			get { return _title; }
			set 
			{
				_title = value;
				SetLastEdited();
			}
		}
		
		public string Author
		{
			get { return _author; }
			set 
			{
				SetLastEdited();
				_author = value; 
			}
		}

		public DateTime LastEdited
		{
			get { return _lastEdited; }
		}

		#endregion //Properties

		public void SaveUndo()
		{
			_history.SaveUndo(this);
		}

		public void RestoreToVersion(int versionNumber)
		{
			_history.RestoreToVersion(this, versionNumber);
		}
		
		public void RestoreToLatestVersion()
		{
			_history.RestoreToLatestVersion(this);
		}		

		public Memento CreateUndo()
		{
			_versionNumber++;

			return new Memento(this) { VersionNumber = _versionNumber };
		}

		public void RestoreFromUndo(Memento memento)
		{
			_title = memento.Title;
			_author = memento.Author;
			_isbn = memento.ISBN;
			_lastEdited = memento.LastEdited;
		}

		public void PrintHistory()
		{
			_history.PrintHistory();
		}
		
		public void ShowBook()
		{
			Debug.WriteLine(
				 "{0} - '{1}' by {2}, edited {3}.", ISBN, Title, Author, _lastEdited);
		}
		
		private void SetLastEdited()
		{
			_lastEdited = DateTime.UtcNow;
		}
	}
}
