using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable, IMove
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
        health = 10;
    }


    public int health { get; set; }
    public void Damage(int damageCount)
    {
        health -= damageCount;
        if (health<=0)
            gameObject.SetActive(false);
    }

    public void Move()
    {
    }
}
