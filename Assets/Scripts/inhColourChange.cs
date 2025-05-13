using UnityEngine;
namespace AG3959
{
    public class inhColourChange : MonoBehaviour
    {
        public Renderer objectRenderer;
        public Color[] colors;  // Array of colors to choose from
        private int colorIndex = 0;  

        private void Start()
        {
            if (objectRenderer == null)
            {
                objectRenderer = GetComponent<Renderer>();  // Get the Renderer component if not set
            }
        }


        public virtual void ChangeColor()
        {
            colorIndex = (colorIndex + 2) % colors.Length;
            objectRenderer.material.color = colors[colorIndex];
        }

        private void OnCollisionEnter(Collision collision)
        {
            // If the object collides with the cube or another sphere, change its color
            if (collision.gameObject.CompareTag("Cube") || collision.gameObject.CompareTag("Sphere"))
            {
                ChangeColor();
            }
        }
    }
}