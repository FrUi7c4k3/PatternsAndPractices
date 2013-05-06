﻿using System;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows.Forms;

namespace Querying
{
	public class ObservableSequences
	{
		public void Test()
		{
			//Observable.Empty<int>(); // OnCompleted
			//Observable.Return(42);	// OnNext, OnCompleted
			//Observable.Range(5, 3);	// OnNext(5), OnNext(6), OnNext(7), OnCompleted
			//Observable.Never<int>(); // Never executes OnCompleted / Never terminates
			//Observable.Generate(0, i => i < 5, i => i + 1, i => i * i);

			IObservable<int> source = Observable.Generate(
				0, i => i < 5,
				i => i + 1,
				i => i*i, i => TimeSpan.FromSeconds(i));

			// Cold run
			IDisposable subscription = source.Subscribe(x => Console.WriteLine("OnNext: {0}", x),
			                                            ex => Console.WriteLine("OnError: {0}", ex.Message),
			                                            () => Console.WriteLine("OnCompleted"));

			Console.WriteLine("Press ENTER to unsubscribe...");
			Console.ReadLine();

			subscription.Dispose();
		}

		public void Test2()
		{
			var lbl = new Label();
			var txt = new TextBox();
			var frm = new Form {Controls = {lbl, txt}};
			
			// -- OLD SCHOOL --
			frm.MouseMove += (sender, args) => { lbl.Text = args.Location.ToString(); };
			Application.Run(frm);
			// ----------------
		}

		public void Test3()
		{
			var lbl = new Label();
			var txt = new TextBox();
			var frm = new Form { Controls = { lbl, txt } };

			var moves = Observable.FromEventPattern<MouseEventArgs>(frm, "MouseMove");
			using (moves.Subscribe(evt => { lbl.Text = evt.EventArgs.Location.ToString(); }))
			{
				Application.Run(frm);
			}
		}

		public void Test4()
		{
			var lbl = new Label();
			var txt = new TextBox();
			var frm = new Form { Controls = { lbl, txt } };

			var moveEvents = Observable.FromEventPattern<MouseEventArgs>(frm, "MouseMove");
			var inputEvents = Observable.FromEventPattern<EventArgs>(txt, "TextChanged");

			var moveEventSubscription = moveEvents.Subscribe(evt => Console.WriteLine("Mouse at: " + evt.EventArgs.Location));
			var inputEventSubscription = inputEvents.Subscribe(evt => Console.WriteLine("User wrote: " + ((TextBox)evt.Sender).Text));

			using (new CompositeDisposable(moveEventSubscription, inputEventSubscription))
			{
				Application.Run(frm);
			}
		}

		public void Test5()
		{
			var lbl = new Label();
			var txt = new TextBox();
			var frm = new Form { Controls = { lbl, txt } };

			var movepoints = Observable.FromEventPattern<MouseEventArgs>(frm, "MouseMove").Select(evt => evt.EventArgs.Location);
			var inputText = Observable.FromEventPattern<EventArgs>(txt, "TextChanged").Select(evt => ((TextBox)evt.Sender).Text);

			var movepointSubscription = movepoints.Subscribe(point => Console.WriteLine("Mouse at: " + point));
			var inputTextSubscription = inputText.Subscribe(text => Console.WriteLine("User wrote: " + text));

			using (new CompositeDisposable(movepointSubscription, inputTextSubscription))
			{
				Application.Run(frm);
			}
		}

		public void Test6()
		{
			var lbl = new Label();
			var txt = new TextBox();
			var frm = new Form { Controls = { lbl, txt } };

			var movepoints = from evt in Observable.FromEventPattern<MouseEventArgs>(frm, "MouseMove")
								  select evt.EventArgs.Location;
			
			var inputText = from evt in Observable.FromEventPattern<EventArgs>(txt, "TextChanged")
								 select ((TextBox)evt.Sender).Text;

			var movepointSubscription = movepoints.Subscribe(point => Console.WriteLine("Mouse at: " + point));
			var inputTextSubscription = inputText.Subscribe(text => Console.WriteLine("User wrote: " + text));

			using (new CompositeDisposable(movepointSubscription, inputTextSubscription))
			{
				Application.Run(frm);
			}
		}

		public void Test7()
		{
			var lbl = new Label();
			var txt = new TextBox();
			var frm = new Form { Controls = { lbl, txt } };

			var movepoints = from evt in Observable.FromEventPattern<MouseEventArgs>(frm, "MouseMove")
								  select evt.EventArgs.Location;

			var bisectorPoints = from point in movepoints
			                     where point.X == point.Y
			                     select point;

			var movepointSubscription = bisectorPoints.Subscribe(point => Console.WriteLine("Mouse at: " + point));

			using (movepointSubscription)
			{
				Application.Run(frm);
			}
		}

		public void Test8()
		{
			var lbl = new Label();
			var txt = new TextBox();
			var frm = new Form { Controls = { lbl, txt } };

			var input = (from evt in Observable.FromEventPattern<EventArgs>(txt, "TextChanged") 
							 select ((TextBox)evt.Sender).Text)
							 .Do(inp => Console.WriteLine("Before DistinctUntilChanged: " + inp)) // Allows peeping into the pipeline
							 .DistinctUntilChanged();  // Filter superfluous / duplicate notifications 
			
			using (input.Subscribe(inp => Console.WriteLine("User wrote: " + inp)))
			{
				Application.Run(frm);
			}
		}


		//TODO: THROTTLING

		//void frm_MouseMove(object sender, MouseEventArgs e)
		//{
		//   throw new NotImplementedException();
		//}
	}
}