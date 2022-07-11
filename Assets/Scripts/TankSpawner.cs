using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankView;

    private void Start()
    {
        CreateTank();
    }
    public void CreateTank()
    {
        TankModel tankModel = new TankModel();
        TankController tankController = new TankController(tankModel,tankView);
    }
}
