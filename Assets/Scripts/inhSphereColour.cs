using UnityEngine;
namespace AG3959

{
    public class inhSphereColour : inhColourChange
    {
        public override void ChangeColor()
        {
            base.ChangeColor();
            Debug.Log("Sphere1 changed color");
        }
    }
}