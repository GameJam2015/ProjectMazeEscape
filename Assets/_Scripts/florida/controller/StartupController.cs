using UnityEngine;
using System.Collections;
using florida.core;

namespace florida.controller
{
		public class StartupController : MonoBehaviour
		{

				// Use this for initialization
				void Start ()
				{
						GameCore.getInstance ().addScene ("Maze");
				}
		}
}