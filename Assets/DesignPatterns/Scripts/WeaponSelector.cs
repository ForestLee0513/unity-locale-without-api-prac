using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelector
{
    private IWeapon iwp;

    public void SetWeapon(IWeapon weapon)
    {
        iwp = weapon;
    }

    public void Attack()
    {
        iwp.Attack();
    }

    public void Attack(GameObject obj)
    {
        iwp.Attack(obj);
        obj.AddComponent<WeaponMove>();
    }
}
