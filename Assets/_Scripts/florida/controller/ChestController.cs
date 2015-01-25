using UnityEngine;
using System.Collections;
using florida.controller;

public class ChestController : MonoBehaviour
{

    public int movementsToAdd;

    public GameController gameController;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("CHEST - OnCollisionEnter2D");
        if (other.gameObject.tag == "Player")
        {
            gameController.addMovementsLeft(movementsToAdd);
        }
    }


}
