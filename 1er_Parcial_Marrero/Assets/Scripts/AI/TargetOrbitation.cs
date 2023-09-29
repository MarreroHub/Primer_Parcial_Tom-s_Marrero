using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetOrbitation : MonoBehaviour
{
    public GameObject target;
    public float velocity;
    public float acceleration;


    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.up, velocity * Time.deltaTime);
    }
}
