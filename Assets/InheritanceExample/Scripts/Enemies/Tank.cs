using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : EnemyBase
{

    protected override void OnHit()
    {
        StartCoroutine(HitStop());
    }

    public override void Kill()
    {
        //TODO put code you want to happen before disable here

        // this runs the base method AND what's above it here
        base.Kill();
    }
    IEnumerator HitStop()
    {
        MoveSpeed = 0.0f;

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(1);

        MoveSpeed = 0.05f;
    }
}
