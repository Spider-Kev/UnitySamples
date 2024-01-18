using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManagerParticles : PoolManager
{
    public override void StartFunction()
    {
        Debug.Log("Ola k ase, voy a crear un nuevo objeto");
        AskForObject(Vector3.zero);
    }
}
