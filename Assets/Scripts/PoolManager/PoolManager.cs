using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    private List<GameObject> createdObjects;
    public GameObject prefabToCreate;
    // Start is called before the first frame update
    void Start()
    {
        createdObjects = new List<GameObject>();
        StartCoroutine(RoutineSpawn());
    }

    private void Update()
    {
    }

    public GameObject CreateObject(Vector3 startPos)
    {
        GameObject createdObject =Instantiate(prefabToCreate, startPos, Quaternion.identity);
        createdObjects.Add(createdObject);
        return createdObject;
    }

    public GameObject AskForObject(Vector3 defaultPos)
    {
        for (int i = 0; i < createdObjects.Count; i++)
        {
            if (!createdObjects[i].activeInHierarchy)
            {
                createdObjects[i].transform.position = defaultPos;
                createdObjects[i].SetActive(true);
                return createdObjects[i];
            }
        }

        return CreateObject(defaultPos);
    }

    IEnumerator RoutineSpawn()
    {
        while (true)
        {
            Debug.Log("Comienza la rutina");
            yield return new WaitForSeconds(3);
            Debug.Log("Termino la rutina");
            // Continuar con este punto del codigo
            AskForObject(Vector3.forward * 5f);    
        }
    }
}
