using UnityEngine;

namespace TestDrawing
{
	public class Loader
	{
		/// <summary>
		/// This method is run by Winch to initialize your mod
		/// </summary>
		public static void Initialize()
		{
			var gameObject = new GameObject(nameof(TestDrawing));
			gameObject.AddComponent<TestDrawing>();
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
}