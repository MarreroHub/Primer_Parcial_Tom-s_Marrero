using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public Transform PlayerCapsule;
    public float walkSpeed;
    public float rotationSpeed;


    void Update()
    {
        Walk();
        LeftRight();

    }

    void Walk()
    {
        Vector3 vec_forward = Vector3.zero;
        vec_forward.z = Input.GetAxis("Vertical");
        Vector3 v = new Vector3(0, 0, vec_forward.z) * Time.deltaTime * 5.0f * walkSpeed;
        PlayerCapsule.Translate(v, Space.Self);

    }


    void LeftRight()

    {
        Vector3 vec_left = Vector3.zero;
        vec_left.x = Input.GetAxis("Horizontal");
        Vector3 v = new Vector3(vec_left.x, 0, 0) * Time.deltaTime * 5.0f * walkSpeed;
        PlayerCapsule.Translate(v, Space.Self);
    }



}
