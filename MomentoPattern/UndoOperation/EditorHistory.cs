using System.Collections.Generic;

namespace UndoOperation
{
	// CareTaker Class
	internal class EditorHistory
	{
		//EditorHistory has a Aggregation Relationship with EditorState -  has 0 to Many States
		public Stack<EditorState> States = new();

		public void Push(EditorState state)
		{
			States.Push(state);
		}

		public EditorState Pop()
		{
			return States.Pop();
		}
	}
}
