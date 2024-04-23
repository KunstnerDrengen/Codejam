using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag_drop : MonoBehaviour
{
    public bool Drag_Drop;

    public void OnMouseHold()
    {
        Drag_Drop = true;
    }

    public void OnMouseRelease()
    {
        Drag_Drop = false;
    }

    void Update()
    {
        if(Drag_Drop)
        {
            Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(MousePos);
        }
    }
}
