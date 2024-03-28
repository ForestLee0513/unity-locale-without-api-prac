using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet: MonoBehaviour, IWeapon
{
    public void Attack()
    {
        Debug.Log("[Bullet] Attack to target");
    }

    public void Attack(GameObject obj)
    {
        Vector3 vector3 = new Vector3(transform.position.x, transform.position.y, 0);
        GameObject bullet = Instantiate(obj);
        bullet.transform.position = vector3;
    }
}
