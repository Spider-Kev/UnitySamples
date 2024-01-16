using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform personaje;

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }

    private void Awake()
    {
        personaje = FindObjectOfType<Player>().transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(personaje);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
        
    }
}
