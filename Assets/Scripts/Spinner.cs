using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xSpinSpeed = 0f;
    [SerializeField] float ySpinSpeed = 10f;
    [SerializeField] float zSpinSpeed = 0f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate((xSpinSpeed * Time.deltaTime * 10), (ySpinSpeed * Time.deltaTime * 10), (zSpinSpeed * Time.deltaTime * 10));
    }
}
