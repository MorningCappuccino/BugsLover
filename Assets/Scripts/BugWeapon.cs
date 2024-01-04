using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugWeapon : MonoBehaviour
{
    [SerializeField] private GameObject _bugBulletPrefab;
    [SerializeField] private Transform _firePoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && GameManager.Instance.GetBugsCount() >= 1)
        {
            Instantiate(_bugBulletPrefab, _firePoint.position, _bugBulletPrefab.transform.rotation);
            GameManager.Instance.AddBugs(-1);
        }
    }
}
