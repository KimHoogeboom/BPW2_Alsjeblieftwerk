using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalDestruction : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "TriggerSpot")
        {
            Destroy(col.gameObject);
            Destroy(GameObject.FindWithTag("TriggerObject")); 
        }
    }
}