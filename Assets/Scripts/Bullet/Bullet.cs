using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    public int damage = 10;
    private void OnTriggerEnter(Collider other)
    {
        IDamagable damagedObject = other.GetComponent<IDamagable>();
        if (damagedObject!=null)
            damagedObject.Damage(damage);
        gameObject.SetActive(false);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
