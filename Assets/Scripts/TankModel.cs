using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    private TankController tankController;
    public float movementspeed;
    public float rotationspeed;
    public TankModel(float _movement, float _rotation)
    {
        movementspeed = _movement;
        rotationspeed = _rotation;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
