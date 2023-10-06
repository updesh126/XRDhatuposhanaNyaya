using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Bandage : MonoBehaviour
{
    [SerializeField] GameObject Place, Done;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bandage"))
        {
            Debug.Log("heelo");
            other.gameObject.SetActive(false);
            gameObject.GetComponent<Renderer>().enabled = true;
            Place.SetActive(false);
            Done.SetActive(true);
        }
    }
}
