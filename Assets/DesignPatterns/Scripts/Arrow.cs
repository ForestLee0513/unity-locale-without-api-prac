using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow: MonoBehaviour, IWeapon
{
    public void Attack()
    {
        Debug.Log("[Arrow] Attack to target");
    }
    public void Attack(GameObject obj)
    {
        Vector3 vector3 = new Vector3(transform.position.x, transform.position.y, 0);
        GameObject arrow = Instantiate(obj);
        arrow.transform.position = vector3;
    }
}
