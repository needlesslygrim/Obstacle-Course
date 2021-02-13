using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Rigidbody rigidbody;
    
    [SerializeField] private float waitTime = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= waitTime)
        {
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
