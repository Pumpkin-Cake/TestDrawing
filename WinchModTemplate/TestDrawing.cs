using UnityEngine;
using Winch.Core;

namespace TestDrawing
{
	public class TestDrawing : MonoBehaviour
	{
		public void Awake()
		{
			WinchCore.Log.Debug($"{nameof(TestDrawing)} has loaded!");
		}
	}
}
