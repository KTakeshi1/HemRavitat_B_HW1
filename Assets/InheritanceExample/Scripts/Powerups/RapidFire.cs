using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFire : PowerupBase
{
    protected override void PowerUp()
    {
        StartCoroutine(IncreaseRate());
        
        
    }

    protected override void PowerDown()
    {
        turretRef.FireCooldown = 0.5f;
        Destroy(gameObject);
        
        
    }


    IEnumerator IncreaseRate()
    {
        turretRef.FireCooldown = 0.25f;
        

        yield return new WaitForSeconds(PowerupDuration);

        
        PowerDown();
    }
}
