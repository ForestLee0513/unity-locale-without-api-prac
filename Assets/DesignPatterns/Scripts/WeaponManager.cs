using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class WeaponManager : MonoBehaviour
{
    public enum WeaponType
    {
        Arrow,
        Bullet,
        Sword
    }

    public GameObject bullet;
    public GameObject sword;
    public GameObject arrow;
    GameObject selectedWeapon;
    WeaponSelector weaponSelector;
    private IWeapon iwp;
    // Start is called before the first frame update
    void Start()
    {
        weaponSelector = new WeaponSelector();
        ChangeWeapon(WeaponType.Bullet);
    }

    public void ChangeBullet()
    {
        ChangeWeapon(WeaponType.Bullet);
    }

    public void ChangeSword()
    {
        ChangeWeapon(WeaponType.Sword);
    }

    public void ChangeArrow()
    {
        ChangeWeapon(WeaponType.Arrow);
    }

    public void ChangeWeapon(WeaponType weaponType)
    {
        Component component = gameObject.GetComponent<IWeapon>() as Component;
        if (component!= null) 
        {
            Destroy(component);
        }

        switch(weaponType)
        {
            case WeaponType.Arrow:
                iwp = gameObject.AddComponent<Arrow>();
                selectedWeapon = arrow;
                break;
            case WeaponType.Bullet:
                iwp = gameObject.AddComponent<Bullet>();
                selectedWeapon = bullet;
                break;
            case WeaponType.Sword:
                iwp = gameObject.AddComponent<Sword>();
                selectedWeapon = sword;
                break;
            default:
                break;
        }
    }

    public void Attack()
    {
        iwp.Attack(selectedWeapon);
    }
}
