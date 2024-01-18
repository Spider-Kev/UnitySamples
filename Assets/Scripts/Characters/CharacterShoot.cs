using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShoot : PoolManager
{
    [Header("Propiedades de disparos")]
    public Transform shootPoint; 
    
    public void Shoot()
    {
        AskForObject(shootPoint.position).transform.rotation = shootPoint.rotation;
    }
}
