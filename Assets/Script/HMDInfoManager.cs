using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class HMDInfoManager : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Is Device Active " + XRSettings.isDeviceActive);
        Debug.Log("Device Name is : " + XRSettings.loadedDeviceName);

        if (!XRSettings.isDeviceActive)
        {
            Debug.Log("No Headset plugged");
        }
        else if (XRSettings.isDeviceActive && XRSettings.loadedDeviceName=="MockHMD Display") 
        {
            Debug.Log("Usiing Mock HMD Loader");
        }
        else
        {
            Debug.Log("We Have a headset " + XRSettings.loadedDeviceName);
        }
    }

    private void Update()
    {
        
    }
}
