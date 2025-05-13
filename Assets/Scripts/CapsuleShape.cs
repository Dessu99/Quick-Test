using UnityEngine;
using AG3959;
public class CapsuleShape : ShapeBase
{
    public float radius = 0.5f;
    public float height = 2f;

    public override void DrawShape()
    {
        float defaultHeight = 2f;
        float defaultRadius = 0.5f;

        float scaleX = radius / defaultRadius;
        float scaleZ = radius / defaultRadius;
        float scaleY = height / defaultHeight;

        transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
    }

    void Start()
    {
        DrawShape();
    }
}
