using UnityEngine;
using System.Collections;
using florida.controller;
using florida.core;

namespace florida.gui
{

		public class UIController : MonoBehaviour
		{

				public GameController gameController;

				public void actionSelected (string action)
				{
						Debug.Log ("actionSelected: " + action);
						if (gameController == null) {
								GameObject controllerObject = GameObject.FindGameObjectWithTag ("GameController");
								gameController = controllerObject.GetComponent<GameController> ();
						}
						gameController.move (action);
				}


				void Update ()
				{

				}

		}

}