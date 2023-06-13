using Unity;
using Zinnia.Action;
using WebXR;
public class WebFloatY : FloatAction
{
    public WebXRController controller;
    public float yAxis;
    void Update()
    {
        var vector2 = controller.GetAxis2D(WebXRController.Axis2DTypes.Thumbstick);
        yAxis = vector2.y;

        Receive(yAxis);

    }
}