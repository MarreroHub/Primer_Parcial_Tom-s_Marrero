using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour
{

    Vector3 startPos_ship;
    public Transform ship;
    public float shipSpeed;
    public float rotationSpeed;


    private void Awake()
    {
        startPos_ship = ship.position;
    }
    void Update()
    {
        MoveForwardBack();
        MoveRotate();
        MoveLeftRight();
        MoveAltitude();
        MoveTurn();
    }

    void MoveForwardBack()
    {
        Vector3 vec_forward = Vector3.zero;
        vec_forward.z = Input.GetAxis("Vertical");
        Vector3 v = new Vector3(0, 0, vec_forward.z) * Time.deltaTime * 10.0f * shipSpeed;
        ship.Translate(v, Space.Self);
    }

    void MoveRotate()
    {
        Vector3 vec_rotate = Vector3.zero;
        vec_rotate.y = Input.GetAxis("Rotation");
        Vector3 v = new Vector3(0, vec_rotate.y, 0) * Time.deltaTime * 15.0f * rotationSpeed;
        ship.Rotate(v, Space.Self);
    }
    void MoveLeftRight()
    {
        Vector3 vec_left = Vector3.zero;
        vec_left.x = Input.GetAxis("Horizontal");
        Vector3 v = new Vector3(vec_left.x, 0, 0) * Time.deltaTime * 15.0f * shipSpeed;
        ship.Translate(v, Space.Self);
    }
    void MoveAltitude()
    {
        Vector3 vec_altitude = Vector3.zero;
        vec_altitude.x = Input.GetAxis("Altitude");
        Vector3 v = new Vector3(vec_altitude.x, 0, 0) * Time.deltaTime * 15.0f * rotationSpeed;
        ship.Rotate(v, Space.Self);
    }
    void MoveTurn()
    {
        Vector3 vec_turn = Vector3.zero;
        vec_turn.z = Input.GetAxis("Turn");
        Vector3 v = new Vector3(0, 0, vec_turn.z) * Time.deltaTime * 15.0f * rotationSpeed;
        ship.Rotate(v, Space.Self);
    }
}
