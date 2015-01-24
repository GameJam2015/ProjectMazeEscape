using UnityEngine;
using System.Collections;
using florida.controller;
using florida.core;

namespace florida.gui
{

		public class UIController : MonoBehaviour
		{

				public GameController gameController;

				// Use this for initialization
				void Start ()
				{
				}
	
				// Update is called once per frame
				void Update ()
				{
	
				}

				public void actionSelected (string action)
				{
						Debug.Log ("actionSelected: " + action);
						if (gameController == null) {
								GameObject controllerObject = GameObject.FindGameObjectWithTag ("GameController");
								gameController = controllerObject.GetComponent<GameController> ();
						}
						gameController.move (action);
				}


		}

}