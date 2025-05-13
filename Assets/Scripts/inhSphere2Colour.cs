using AG3959;
using UnityEngine;

public class inhSphere2Colour : inhColourChange
{
    public override void ChangeColor()
    {
        base.ChangeColor(); 
        Debug.Log("Sphere2 changed color");
    }
}
