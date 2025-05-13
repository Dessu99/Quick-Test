using UnityEngine;
using AG3959;
public class CapsuleShape : ShapeBase
{
    public float radius = 0.5f; // These set the default settings for the target in this case Capsule
    public float height = 2f;

    public float pulseSpeed = 1f;   // This one changes the speed of the pulsin
    public float pulseAmount = 0.2f;    // Changes the frequency of the pulses

    private float defaultRadius;
    private float defaultHeight;

    void Start()
    {
        defaultRadius = radius;
        defaultHeight = height;
    }

    void Update()
    {
        // This animates the radius and height using a sine wave
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
