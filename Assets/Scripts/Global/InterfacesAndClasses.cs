using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable
{
    public int health { get; set; }
    
    public void Damage(int damageCount);
}

public interface IMove
{
    public void Move();
}
