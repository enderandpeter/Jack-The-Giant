using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IPointerUpHandler, IPointerDownHandler {
    private PlayerMoveJoystick playerMove;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (gameObject.name == "Left")
        {
            playerMove.SetMoveLeft(true);
        }
        else
        {
            playerMove.SetMoveLeft(false);
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        playerMove.StopMoving();
    }

    // Use this for initialization
    void Start () {
        playerMove = GameObject.Find("Player").GetComponent<PlayerMoveJoystick>();
	}
}
