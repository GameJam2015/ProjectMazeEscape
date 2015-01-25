using UnityEngine;
using System.Collections;
using florida.controller;

public class ChestController : MonoBehaviour
{

    public int movementsToAdd;

    public GameController gameController;

    public float groundRadius;
    
    public LayerMask whatIsPlayer; 
    
    // Update is called once per frame
    void Update()
    {
        Vector2 gameObjectLocation = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        bool isPlayerClose = Physics2D.OverlapCircle(gameObjectLocation, groundRadius, whatIsPlayer);
        if (isPlayerClose)
        {
            gameController.addMovementsLeft(movementsToAdd);
            Destroy(gameObject);
        }
    }

}
