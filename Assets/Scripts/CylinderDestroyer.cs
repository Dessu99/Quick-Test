using System.Collections.Generic;
using UnityEngine;

namespace AG395
{
    public class CylinderDestroyer : MonoBehaviour
    {
        private bool playerInside = false;
        public GameObject textpop;


        public void Start()
        {
            textpop.SetActive(false);
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                playerInside = true;

            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                playerInside = false;
            }
        }

        private void Update()
        {
            if(playerInside)
            {
                textpop.SetActive(true);
            }
            else
            {
                textpop.SetActive(false);
            }
            if (playerInside && Input.GetKeyDown(KeyCode.K))
            {
                DestroyNearbyCylinders();
            }
        }

        private void DestroyNearbyCylinders()
        {
            Collider[] hits = Physics.OverlapBox(transform.position, transform.localScale / 2, transform.rotation);

            foreach (var hit in hits)
            {
                if (hit.CompareTag("Cylinder"))
                {
                    Destroy(hit.gameObject);
                    Debug.Log("Cylinder destroyed by key press.");
                }
            }
        }
    }
}
