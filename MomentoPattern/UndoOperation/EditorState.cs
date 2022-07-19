namespace UndoOperation
{
	// Momento Class
	internal class EditorState
	{
		private readonly string content;

		public EditorState(string content)
		{
			this.content = content;
		}

		public string GetContent()
		{
			return content;
		}
	}
}
