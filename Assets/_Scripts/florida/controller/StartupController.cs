using UnityEngine;
using System.Collections;
using florida.core;

namespace florida.controller
{
		public class StartupController : MonoBehaviour
		{
				public float timePerMovement;
		
				private float timeElapsed;

				// Use this for initialization
				void Start ()
				{
						GameCore.getInstance ().addScene ("Maze");
				}

		}
}