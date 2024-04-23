using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragControls : MonoBehaviour
{
    private bool DragActive;

    private Vector2 ScreenPosition;
    private Vector3 WorldPosition;
    private Draggable LastDragged;

    private void Awake()
    {
        DragControls[] controller = FindObjectOfType<DragControls>();
    }

    void Update()
    {

    }

    void Initdrag()
    {

    }

    void Drag()
    {

    }

    void Drop()
    {

    }
}
