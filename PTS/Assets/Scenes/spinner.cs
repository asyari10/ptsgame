using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour
{
    public float staSpeed;
    public float endSpeed;
    public bool isSpinning = false;


    // Update is called once per frame
    void Update()
    {
        if (isSpinning == true)
        {
            transform.Rotate(0, 0, staSpeed, Space.World);
            staSpeed -= endSpeed;
        }

        if (staSpeed <= 0)
        {
            staSpeed = 0;
            isSpinning = false;
        }
    }

    public void SpinWheel()
    {
        staSpeed = UnityEngine.Random.Range(5.000f, 9.000f);
        endSpeed = UnityEngine.Random.Range(0.003f, 0.009f);
        isSpinning = true;
    }
}
