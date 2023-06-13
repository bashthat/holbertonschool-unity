using WebXR;
using Zinnia.Action;

public class WebGrip : BooleanAction
{

    public WebXRController controller;
    
    // making a boolian function to check if the controller is gripping

    void Update()
    {
        Receive(controller.GetButton(WebXRController.ButtonTypes.Grip));

    }

}