using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;
    public Rigidbody rb;
    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;
        tankView = GameObject.Instantiate<TankView>(_tankView);
        rb = tankView.GetRigidbody();

        tankView.SetTankController(this);
        tankModel.SetTankController(this);

        tankView.ChangeColor(tankModel.color);
    }

    public void Move(float movement, float movementspeed)
    {
        rb.velocity = tankView.transform.forward * movement * movementspeed;
    }
    public void Rotate(float rotation, float rotationspeed)
    {
        Vector3 vector = new Vector3(0f, rotation * rotationspeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
    public TankModel GetTankModel()
    {
        return tankModel;
    }
}
