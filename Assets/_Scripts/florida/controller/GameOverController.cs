using UnityEngine;
using florida.core;
using System.Collections;

public class GameOverController : MonoBehaviour
{

		public void tryAgain ()
		{
				GameCore.getInstance ().loadScene ("Main");
		}

		public void exit ()
		{
				Application.Quit ();
		}
}
