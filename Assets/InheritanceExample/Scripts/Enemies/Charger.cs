using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : EnemyBase
{
    public GameObject pickupPrefab;
    protected override void OnHit()
    {
        MoveSpeed *= 2;
    }

    public override void Kill()
    {
        Instantiate(pickupPrefab, transform.position, transform.rotation);

        // this runs the base method AND what's above it here
        base.Kill();
    }
}
