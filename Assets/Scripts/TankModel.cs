using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    private TankController tankController;
    public float movementspeed;
    public float rotationspeed;
    public TankTypes tankTypes;
    public Material color;
    public TankModel(float _movement, float _rotation, TankTypes _tankTypes, Material _color)
    {
        movementspeed = _movement;
        rotationspeed = _rotation;
        tankTypes = _tankTypes;
        color = _color;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
