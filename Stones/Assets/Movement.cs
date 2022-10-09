using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{   
    private Vector3 startPosition;
 
    private Vector3 position1;


    [SerializeField]
    private float frequency = 5f;
    [SerializeField]
    private float magnitude = 5f;
    [SerializeField]
    private float offset = 0f;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startPosition + transform.right * Mathf.Sin(Time.time * frequency + offset) * magnitude;
        {

        }
    }
}
