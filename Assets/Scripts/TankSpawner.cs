using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementspeed;
        public float rotationspeed;
        public TankTypes tankTypes;
        public Material color;
    }
    public List<Tank> tankList;
    public TankView tankView;

    private void Start()
    {
        CreateTank();
    }
    public void CreateTank()
    {
        TankModel tankModel = new TankModel(tankList[2].movementspeed, tankList[2].rotationspeed,tankList[2].tankTypes,tankList[2].color);
        TankController tankController = new TankController(tankModel,tankView);
    }

}
