using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword: MonoBehaviour, IWeapon
{
    public void Attack()
    {
        Debug.Log("[Sword] Attack to target");
    }
    public void Attack(GameObject obj)
    {
        Vector3 vector3 = new Vector3(transform.position.x, transform.position.y, 0);
        GameObject sword = Instantiate(obj);
        sword.transform.position = vector3;
    }
}
