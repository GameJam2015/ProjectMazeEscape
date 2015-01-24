using UnityEngine;
using System.Collections;

namespace florida.core
{

		public class GameCore : MonoBehaviour
		{

				private static GameCore core;

				public static GameCore getInstance ()
				{
						if (core == null) {
								core = new GameCore ();
						}
						return core;
				}

				public void loadScene (string sceneName)
				{
						Application.LoadLevel (sceneName);
				}

				public void addScene (string sceneName)
				{
						Application.LoadLevelAdditive (sceneName);
				}
		}

}
