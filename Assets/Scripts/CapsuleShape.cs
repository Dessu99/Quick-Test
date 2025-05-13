using UnityEngine;
using AG3959;
public class CapsuleShape : ShapeBase
{
    public float radius = 0.5f;
    public float height = 2f;

    public float pulseSpeed = 1f;
    public float pulseAmount = 0.2f;

    private float defaultRadius;
    private float defaultHeight;

    void Start()
    {
        defaultRadius = radius;
        defaultHeight = height;
    }

    void Update()
    {
        // Animate radius and height using a sine wave
        float pulse = Mathf.Sin(Time.time * pulseSpeed) * pulseAmount;

        radius = defaultRadius + pulse;
        height = defaultHeight + pulse;

        DrawShape();
    }

    public override void DrawShape()
    {
        float baseHeight = 2f;
        float baseRadius = 0.5f;

        float scaleX = radius / baseRadius;
        float scaleZ = radius / baseRadius;
        float scaleY = height / baseHeight;

        transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
    }
}
