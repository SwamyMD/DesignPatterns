namespace UndoOperation
{
	// Originator Class
	internal class Editor
	{
		private string Content;

		//Editor has a Dependency relationship(Uses) with EditorState
		public EditorState Create()
		{
			return new EditorState(Content);
		}

		//Editor has a Dependency relationship with EditorState
		public void Restore(EditorState state)
		{
			this.Content = state.GetContent();
		}

		public void SetContent(string content)
		{
			this.Content = content;
		}
		public string GetContent()
		{
			return Content;
		}
	}
}
