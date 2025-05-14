using AG3959;
using UnityEngine;


    public class InteractionTrigger : MonoBehaviour
    {
        private IInteractable interactable;

    private Chest chest;

    void Start()
    {
        chest = GetComponentInParent<Chest>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && chest != null)
        {
            chest.InteractLogic();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && chest != null)
        {
            chest.StopInteraction();
        }
    }
}

