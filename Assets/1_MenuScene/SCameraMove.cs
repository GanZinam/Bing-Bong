using UnityEngine;
using System.Collections;

public class SCameraMove : MonoBehaviour
{
    public Animator CameraAni;

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            CameraAni.enabled = true;
        }
    }
}
