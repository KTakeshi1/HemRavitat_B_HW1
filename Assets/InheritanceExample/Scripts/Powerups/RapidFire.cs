using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFire : PowerupBase
{

    protected override void PowerUp()
    {
        StartCoroutine(IncreaseRate());
        
        
    }


    IEnumerator IncreaseRate()
    {
        turretRef.FireCooldown = 0.25f;
        colliderRef.enabled = false;
        renderRef.enabled = false;

        yield return new WaitForSeconds(PowerupDuration);

        turretRef.FireCooldown = 0.5f;
        PowerDown();
    }
}
