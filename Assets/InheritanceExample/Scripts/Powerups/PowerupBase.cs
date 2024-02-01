using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerupBase : MonoBehaviour
{
    [SerializeField] public float PowerupDuration = 2.0f;
    public TurretController turretRef;
    public MeshRenderer renderRef;
    public BoxCollider colliderRef;

    protected abstract void PowerUp();

    public void Start() 
    {
        turretRef = FindObjectOfType<TurretController>();    
    }

    private void OnTriggerEnter(Collider other)
    {
        Projectile projectile = other.GetComponent<Projectile>();
        if (projectile != null)
        {
            PowerUp();
            
        }
    }

    public void PowerDown()
    {
        Destroy(gameObject);
    }
}
