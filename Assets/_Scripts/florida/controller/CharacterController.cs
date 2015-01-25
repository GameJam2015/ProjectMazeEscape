using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour
{
	
    private bool facingRight = true;
	
    private Animator anim;

    public float step;
	
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void move(string direction)
    {
        Vector3 destination = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        switch (direction)
        {
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
        transform.position = destination;

        if (facingRight && direction == "LEFT")
        {
            Flip();
        } else if (!facingRight && direction == "RIGHT")
        {
            Flip();
        }
    }

	
    // It will negatively scale horizontally
    // It will save time to duplicate the animations right and left
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
		
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}
