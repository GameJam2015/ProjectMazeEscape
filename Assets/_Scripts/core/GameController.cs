using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{

		public GameObject mainCharacter;

		public int step;

		private Vector2 mainCharacterPosition;

		private int[][] maze;

		// Use this for initialization
		void Start ()
		{

		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		public void move (string direction)
		{
				Vector3 destination = new Vector3 (mainCharacter.transform.position.x, mainCharacter.transform.position.y, mainCharacter.transform.position.z);
				switch (direction) {
				case "UP":
						destination.y += step;
						break;
				case "DOWN": 
						destination.y -= step;
						break;
				case "RIGHT":
						destination.x += step;
						break;
				case "LEFT":
						destination.x -= step;
						break;
				}
				mainCharacter.transform.position = destination;
		}
}
