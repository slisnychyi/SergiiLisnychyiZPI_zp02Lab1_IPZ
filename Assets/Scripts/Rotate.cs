using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    [SerializeField] float sppedX;
    [SerializeField] float sppedY;
    [SerializeField] float sppedZ;

    void Update()
    {
        transform.Rotate(360 * sppedX * Time.deltaTime, 360 * sppedY * Time.deltaTime, 360 * sppedZ * Time.deltaTime);
    }
}
