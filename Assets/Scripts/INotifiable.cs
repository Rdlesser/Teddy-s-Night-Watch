using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface INotifiable
{ 
    void OnNotification(TeddyAppNotification eventNotification, Object target, object[] data);
}
