using UnityEngine;

// Base class for all elements in this application
public class TeddyElement : MonoBehaviour
{
    protected static TeddyApp App => FindObjectOfType<TeddyApp>();
}
public class TeddyApp : MonoBehaviour
{
    // Reference to the root instances of the MVC.
    public GameModel model;
    public GameView view;
    public GameController controller;

    public void Notify(TeddyAppNotification eventNotification, Object target, params object[] data)
    {
        controller.OnNotification(eventNotification, target, data);
    }
}

