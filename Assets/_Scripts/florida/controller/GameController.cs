using UnityEngine;
using System.Collections;
using florida.core;

namespace florida.controller
{

		public class GameController : MonoBehaviour
		{

				public GameObject mainCharacter;

				// The wall layer
				public LayerMask whatIsWall;
		
				// Movement available options
				private bool leftMove, rightMove, upMove, downMove;
				public Vector2 leftVector, rightVector, upVector, downVector;

				// Use this for initialization
				void Start ()
				{
				}
	
				// Update is called once per frame
				void Update ()
				{
				}

				// Validates y the character can move
				public void move (string direction)
				{
						// anim.SetBool ("Ground", grounded);
			
						// Character position
						Vector2 characterPosition = new Vector2 (mainCharacter.transform.position.x, mainCharacter.transform.position.y);
						// Detect Walls collider
						bool leftMove = Physics2D.Linecast (characterPosition, characterPosition + leftVector, whatIsWall);
						bool rightMove = Physics2D.Linecast (characterPosition, characterPosition + rightVector, whatIsWall);
						bool upMove = Physics2D.Linecast (characterPosition, characterPosition + upVector, whatIsWall);
						bool downMove = Physics2D.Linecast (characterPosition, characterPosition + downVector, whatIsWall);
			
						Debug.Log ("LEFT DEBUG:" + leftMove);
						Debug.Log ("RIGHT DEBUG:" + rightMove);
						Debug.Log ("UP DEBUG:" + upMove);
						Debug.Log ("DOWN DEBUG:" + downMove);

						CharacterController charController = mainCharacter.GetComponent<CharacterController> ();
						charController.move (direction);

				}
		}

}
