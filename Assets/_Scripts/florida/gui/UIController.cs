using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using florida.controller;
using florida.core;

namespace florida.gui
{

    public class UIController : MonoBehaviour
    {
        public GameController gameController;

        public Slider slider;

        public Text movementsLeft;
		
        public float timePerMovement;
		
        private float timeElapsed;

        public void actionSelected(string action)
        {
            timeElapsed = 0.0f;
            // reset the time elapsed
            if (gameController == null)
            {
                GameObject controllerObject = GameObject.FindGameObjectWithTag("GameController");
                gameController = controllerObject.GetComponent<GameController>();
            }
            gameController.move(action);
            movementsLeft.text = "Movements left: " + gameController.getMovementsLeft();
        }


        void Update()
        {
            timeElapsed += Time.deltaTime;
            if (timeElapsed > timePerMovement)
            {
                // No action selected
                slider.normalizedValue = 1.0f;
                timeElapsed = 0.0f;
                // reset the time elapsed
                if (gameController == null)
                {
                    GameObject controllerObject = GameObject.FindGameObjectWithTag("GameController");
                    gameController = controllerObject.GetComponent<GameController>();
                }
                gameController.move("NOACTION");
                movementsLeft.text = "Movements left: " + gameController.getMovementsLeft();
            } else
            {
                slider.normalizedValue = (timePerMovement - timeElapsed) / timePerMovement;
            }
        }

        public void updateMovementsLeftText()
        {
            movementsLeft.text = "Movements left: " + gameController.getMovementsLeft();
        }
    }

}