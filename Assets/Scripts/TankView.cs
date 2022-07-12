using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    private float movement;
    private float rotation;
    public Rigidbody rb;

    private void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f, 4f, -6f);
    }
    private void Update()
    {
        Movement();
        if(movement!=0)
        {
            tankController.Move(movement, tankController.GetTankModel().movementspeed);
        }
        if (rotation != 0)
        {
            tankController.Rotate(rotation, tankController.GetTankModel().rotationspeed);
        }
    }
    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }
    public Rigidbody GetRigidbody()
    {
        return rb;
    }
}
