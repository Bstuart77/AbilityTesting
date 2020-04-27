using System.Collections;
using UnityEngine;
using Bolt;

public class ServerSwitchGuns : Bolt.EntityBehaviour<ICustomCubeState>
{
    public GameObject[] WeaponObjects;

    public override void Attached()
    {
        if (entity.IsOwner)
        {
            for (int i = 0; i < state.WeaponArray.Length; ++i)
            {
                state.WeaponArray[i].WeaponId = i;
                state.WeaponArray[i].WeaponAmmo = Random.Range(50, 100);
            }
        }
        state.AddCallback("WeaponActiveIndex", WeaponActiveIndexChanged);
    }

    void WeaponActiveIndexChanged()
    {
        for (int i = 0; i < WeaponObjects.Length; ++i)
        {
            WeaponObjects[i].SetActive(false);
        }
        if (state.WeaponActiveIndex >= 0)
        {
            int objectId = state.WeaponArray[state.WeaponActiveIndex].WeaponId;
            WeaponObjects[objectId].SetActive(true);
        }
    }
}
