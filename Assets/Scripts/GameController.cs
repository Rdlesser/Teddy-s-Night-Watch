using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : TeddyElement, INotifiable
{

    public void OnNotification(TeddyAppNotification eventNotification, Object target, object[] data)
    {
        switch (eventNotification)
        {
            case TeddyAppNotification.MoveAttempt:
                if (data[0] != null && data[0].GetType() == typeof(Vector2))
                {
                    OnMoveAttempt((Vector2) data[0]);
                }
                break;
        }
    }

    private void OnMoveAttempt(Vector2 moveDirection)
    {
        App.view.MovePlayer(moveDirection);
    }
}
