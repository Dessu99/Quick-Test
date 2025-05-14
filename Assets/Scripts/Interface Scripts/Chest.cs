using UnityEngine;
using AG3959;
namespace AG3959
{

    public class Chest : MonoBehaviour, IInteractable
    {
        public Transform lid;
        public Vector3 slideOffset = new Vector3(0f, 1f, 0f);
        public float slideSpeed = 2f;

        private Vector3 closedPosition;
        private Vector3 openPosition;
        private bool shouldOpen = false;

        void Start()
        {
            closedPosition = lid.localPosition;
            openPosition = closedPosition + slideOffset;
        }

        public void InteractLogic()
        {
            shouldOpen = true;
        }

        public void StopInteraction()
        {
            shouldOpen = false;
        }

        void Update()
        {
            Vector3 target = shouldOpen ? openPosition : closedPosition;
            lid.localPosition = Vector3.Lerp(lid.localPosition, target, Time.deltaTime * slideSpeed);
        }
    }
}

    