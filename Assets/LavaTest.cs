using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaTest : MonoBehaviour
{
    [SerializeField] private float _damage = 1f;
    private void OnTriggerStay(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            var health = col.gameObject.GetComponent<HealthController>();
            health.TakeDamage(_damage);
        }
    }

}
