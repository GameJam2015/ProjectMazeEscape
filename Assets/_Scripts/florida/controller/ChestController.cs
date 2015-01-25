using UnityEngine;
using System.Collections;
using florida.controller;

public class ChestController : MonoBehaviour
{

    public int movementsToAdd;

    public GameController gameController;


    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("CHEST - OnCollisionEnter2D");
        if (coll.gameObject.tag == "Player")
        {
            gameController.addMovementsLeft(movementsToAdd);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("CHEST - OnCollisionEnter2D");
    }


}
