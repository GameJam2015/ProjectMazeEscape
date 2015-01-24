using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour
{
	
		private bool facingRight = true;
	
		private Animator anim;
	
		// The wall layer
		public LayerMask whatIsWall;

		// Movement available options
		private bool leftMove, rightMove, upMove, downMove;
		public Vector2 leftVector, rightVector, upVector, downVector;

	
		// Use this for initialization
		void Start ()
		{
				anim = GetComponent<Animator> ();
		}
	
		// Update is called in a fixed time
		void FixedUpdate ()
		{
				// anim.SetBool ("Ground", grounded);

				// Character position
				Vector2 characterPosition = new Vector2 (gameObject.transform.position.x, gameObject.transform.position.y);
				// Detect Walls collider
				leftMove = Physics2D.Linecast (characterPosition, characterPosition + leftVector, whatIsWall);
				rightMove = Physics2D.Linecast (characterPosition, characterPosition + rightVector, whatIsWall);
				upMove = Physics2D.Linecast (characterPosition, characterPosition + upVector, whatIsWall);
				downMove = Physics2D.Linecast (characterPosition, characterPosition + downVector, whatIsWall);				
		}
	

		void Update ()
		{

		}
	
		// It will negatively scale horizontally
		// It will save time to duplicate the animations right and left
		void Flip ()
		{
				facingRight = !facingRight;
				Vector3 theScale = transform.localScale;
		
				theScale.x *= -1;
				transform.localScale = theScale;
		
		}
}
