using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterWingRotate: MonoBehaviour
{
    public float yax;
    void Update()
    {
        Vector3 vet = new Vector3 (0,yax,0);
        transform.Rotate(vet*Time.deltaTime);
    }
}
