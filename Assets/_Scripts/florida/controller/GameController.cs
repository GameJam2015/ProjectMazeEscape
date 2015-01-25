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

        public int collisionMargin;
        //public Vector2 leftVector, rightVector, upVector, downVector;

        public int movementsLeft;

        // Validates y the character can move
        public void move(string direction)
        {
            // Debug.Log("MOVE:" + direction);
            // anim.SetBool ("Ground", grounded);
			
            // Character position
            Vector2 characterPosition = new Vector2(mainCharacter.transform.position.x, mainCharacter.transform.position.y);

            // Detect Walls collider
            bool leftMove = !Physics2D.Linecast(characterPosition, characterPosition + new Vector2(-collisionMargin, 0), whatIsWall);
            bool rightMove = !Physics2D.Linecast(characterPosition, characterPosition + new Vector2(collisionMargin, 0), whatIsWall);
            bool upMove = !Physics2D.Linecast(characterPosition, characterPosition + new Vector2(0, collisionMargin), whatIsWall);
            bool downMove = !Physics2D.Linecast(characterPosition, characterPosition + new Vector2(0, -collisionMargin), whatIsWall);

            CharacterController charController = mainCharacter.GetComponent<CharacterController>();

            if (direction == "NOACTION")
            {
                // Pseudo-Random the movement of the main character
                if (leftMove)
                {
                    charController.move("LEFT");
                } else if (upMove)
                {
                    charController.move("UP");
                } else if (downMove)
                {
                    charController.move("DOWN");
                } else if (rightMove)
                {
                    charController.move("RIGHT");
                }
							
            } else
            {
                // Check if the player can move into that direction
                bool isMoveAllowed = 
									(direction == "LEFT" && leftMove) || 
                    (direction == "RIGHT" && rightMove) || 
                    (direction == "UP" && upMove) || 
                    (direction == "DOWN" && downMove);

                //Debug.Log ("isMoveAllowed:" + isMoveAllowed);
                if (isMoveAllowed)
                {
                    charController.move(direction);
                }
            }
            movementsLeft--;

            if (movementsLeft == 0)
            {
                GameCore.getInstance().gameOver();
            }
        }
				
        public int getMovementsLeft()
        {
            return movementsLeft;
        }

        public void addMovementsLeft(int num)
        {
            movementsLeft += num;
        }

    }

}
