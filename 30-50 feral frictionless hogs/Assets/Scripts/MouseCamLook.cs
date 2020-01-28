using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamLook : MonoBehaviour
{
    [SerializeField]
    public float Sensitivity = 5.0F;
    [SerializeField]
    public float Smoothing = 2.0F;
    public GameObject Character;
    private Vector2 MouseLook;
    private Vector2 SmoothV;

    void Start()
    {
        Character = this.transform.parent.gameObject;
    }

    void Update()
    {
        var MouseDelta = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        MouseDelta = Vector2.Scale(MouseDelta, new Vector2(Sensitivity * Smoothing, Sensitivity * Smoothing));
        SmoothV.x = Mathf.Lerp(SmoothV.x, MouseDelta.x, 1F / Smoothing);
        SmoothV.y = Mathf.Lerp(SmoothV.y, MouseDelta.y, 1F / Smoothing);
        MouseLook += SmoothV;

        if (MouseLook.y <= 135 && MouseLook.y >= -135)
        {
            transform.localRotation = Quaternion.AngleAxis(-MouseLook.y / 2, Vector3.right / 2);
        }
        if (MouseLook.y > 135)
        {
            MouseLook.y = 135;
        }
        if (MouseLook.y < -135)
        {
            MouseLook.y = -135;
        }
        Character.transform.localRotation = Quaternion.AngleAxis(MouseLook.x, Character.transform.up);
    }
}
