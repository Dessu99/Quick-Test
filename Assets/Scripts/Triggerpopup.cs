using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace AG3959

{
    public class Triggerpopup : MonoBehaviour
    {
        public GameObject buttonPopUp_1;
        public string playerTag = "Player";
        public Rigidbody targetRigidbody_1;
        public Vector3 forceDirection = Vector3.forward; 
        public float forceStrength = 10f;
        private bool playerInRange_1 = false;
        public KeyCode[] triggerKeys;
        public ChangeColour colourChanger;



        // public bool keyPressed;
        public enum ActionMode
    {
        applyForce,
        changeColour
    }
        private void Start()
        {
            buttonPopUp_1.SetActive(false);
            // keyPressed = false;
        }

        void Update()
        {

            /* if (playerInRange_1 && Input.GetKeyUp(KeyCode.E))   //  if (playerInRange_1 && if (keyPressed == true))
            {
                Debug.Log("E pressed - applying force");
                targetRigidbody_1.AddForce(forceDirection.normalized * forceStrength, ForceMode.Impulse);
            }
            */
            /* if (playerInRange_1)
            {
                foreach (KeyCode key in triggerKeys)
                {
                    if (Input.GetKeyUp(key))
                    {
                        Debug.Log($"{key} pressed - applying force to {gameObject.name}");
                        targetRigidbody_1.AddForce(forceDirection.normalized * forceStrength, ForceMode.Impulse);
                        break; // Apply force only once per frame
                    }
                }
            } */
             if (playerInRange_1)
            {
                foreach (KeyCode key in triggerKeys)
                {
                    if (Input.GetKeyUp(key))
                    {
                        if (key == KeyCode.F && colourChanger != null)
                        {
                            Debug.Log($"{key} pressed - changing color on {gameObject.name}");
                            colourChanger.changeMaterial();
                        }
                        else
                        {
                            Debug.Log($"{key} pressed - applying force to {gameObject.name}");
                            targetRigidbody_1.AddForce(forceDirection.normalized * forceStrength, ForceMode.Impulse);
                        }

                        break; // Apply force or change color only once per frame
                    }
                }
            }
            
        }


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(playerTag))
            {
                buttonPopUp_1.SetActive(true);
                playerInRange_1 = true;
            }
            
        }
        
        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag(playerTag))
            {
                buttonPopUp_1.SetActive(false);
                playerInRange_1 = false;

            }
            
        }
    }
}
