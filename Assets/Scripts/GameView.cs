using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameView : TeddyElement
{

    private Vector2 _moveInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _moveInput = new Vector2(Input.GetAxisRaw("Horizontal"),
                                        Input.GetAxisRaw("Vertical"));
        App.Notify(TeddyAppNotification.MoveAttempt, this, _moveInput);
    }

    public void MovePlayer(Vector2 moveDirection)
    {
        PlayerView.Instance.Move(moveDirection);
    }
}
