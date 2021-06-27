using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{ 
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();
      Input.gyro.enabled = true;  
      
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion deviceRotation = DeviceRotation.Get();
        deviceRotation.x =Mathf.Clamp(deviceRotation.x, -3f, 3f);
        deviceRotation.z = Mathf.Clamp(deviceRotation.z, -1.5f, 1.5f);
        transform.rotation = deviceRotation;
    }

   
}

