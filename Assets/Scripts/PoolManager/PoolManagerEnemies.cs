using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManagerEnemies : PoolManager
{
    public override void StartFunction()
    {
        StartCoroutine(RoutineSpawn());
    }
    
    IEnumerator RoutineSpawn()
    {
        while (true)
        {
            Debug.Log("Comienza la rutina");
            yield return new WaitForSeconds(3);
            Debug.Log("Termino la rutina");
            // Continuar con este punto del codigo
            AskForObject(new Vector3
                (
                    5 * Mathf.Cos(UnityEngine.Random.Range(0f,360f)), 
                    0,
                    5 * Mathf.Sin(UnityEngine.Random.Range(0f,360f)))
            );    
        }
    }
}
