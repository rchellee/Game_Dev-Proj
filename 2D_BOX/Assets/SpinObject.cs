using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObject : MonoBehaviour
{

    public float spinSpeed = 5f;
 
    private void Update()
    {
        transform.Rotate(Vector3.back* spinSpeed * Time.deltaTime);
    }
   
}