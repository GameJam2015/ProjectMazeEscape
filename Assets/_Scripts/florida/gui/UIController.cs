﻿using UnityEngine;
using System.Collections;
using florida.controller;

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
						gameController.move (action);

				
				}


		}

}