using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomMouseCursor : MonoBehaviour
{
    public Texture2D mouseCursor;

    Vector2 hotSpot = new Vector2(0,0); //es donde los click son registrados. el 0,0 es la ubicaci[on]
    CursorMode cursorMode = CursorMode.Auto; //define el como queremos que se rendere

    private void Start()
    {
    	Cursor.SetCursor(mouseCursor, hotSpot, cursorMode); //lo que activa el cursor. 
    }
}
