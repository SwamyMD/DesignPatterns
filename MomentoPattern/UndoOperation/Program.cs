using System;

namespace UndoOperation
{
	internal class Program
	{
		/*
		 * Memento helps to follow SRP. Editor is taking care of maintaining state resposibility
		 * Memento helps to follow OCP. EditorState maintains the state object instead of previous state fieds in Editor
		 */
		private static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			// Main has a dependency relationship(Uses) Editor and EditorHistory
			Editor editor = new();
			EditorHistory history = new();

			editor.SetContent("A");
			EditorState state = editor.Create();
			history.Push(state);
			Console.WriteLine($"Create - {editor.GetContent()}");


			editor.SetContent("B");
			state = editor.Create();
			history.Push(state);
			Console.WriteLine($"Create - {editor.GetContent()}");

			editor.SetContent("C");
			state = editor.Create();
			history.Push(state);
			Console.WriteLine($"Create - {editor.GetContent()}");

			//Console.WriteLine(editor.GetContent());
			editor.Restore(history.Pop());
			Console.WriteLine($"Undo - {editor.GetContent()}");
			editor.Restore(history.Pop());
			Console.WriteLine($"Undo - {editor.GetContent()}");
		}
	}
}
