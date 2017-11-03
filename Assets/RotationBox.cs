using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBox : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(45 * Time.deltaTime, 15, 0);
    }
}