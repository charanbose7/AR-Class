using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotating_scaling : MonoBehaviour
{
    public GameObject cube;
    private Vector3 scaleChange;

    private void Awake()
    {
        Camera.main.clearFlags = CameraClearFlags.SolidColor;

        scaleChange = new Vector3(-.05f, -.05f, -.05f);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0f,.5f,0f);
        this.transform.localScale += scaleChange;

        //Move upwards when sphere hits the floor or downwards
        //when the sphere scale extends 1.0f
        if (this.transform.localScale.y < 0.5f || this.transform.localScale.y > 2f)
        {
            scaleChange = -scaleChange;
            
        }

    }
}