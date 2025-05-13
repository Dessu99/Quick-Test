using UnityEngine;

namespace AG3959
{
    public class ChangeColour : MonoBehaviour
    {

        public GameObject cube;
        public Renderer cubeRenderer;
        [SerializeField] private Color newColour;
        // creates a list I can make to change through the colours
        [SerializeField] private Color[] colours;

        private int colourValue;

        void Start()
        {
            cubeRenderer = cube.GetComponent<Renderer>();
        }


        public void changeMaterial()
        {

            colourValue++;
            if (colourValue > 2)
            {
                colourValue = 0;
            }
            
            
            cubeRenderer.material.color = colours[colourValue];
        }
        private void OnCollisionEnter(Collision collision)
        {
             if (collision.gameObject.CompareTag("Cube"))
            {
                Debug.Log("Sphere hit by box — changing color");
                changeMaterial();
            } 
            ChangeColour other = collision.gameObject.GetComponent<ChangeColour>();
            if (other != null)
            {
                Debug.Log("Two color spheres collided!");
                changeMaterial();      // This sphere
                other.changeMaterial(); // The other sphere
            }
        }
    }
}
