using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotHide : MonoBehaviour
{
    public bool blood =false;
    [SerializeField]
    GameObject Abase;

    [SerializeField]
    Material Mat;
    private IEnumerator OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("spot"))
        {
            yield return new WaitForSeconds(1.0f);
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("alcohol"))
        {
            yield return new WaitForSeconds(3.0f);
            Abase.SetActive(false);
        }
        if ( blood == true && other.CompareTag("blood") )
        {
            yield return new WaitForSeconds(6.0f);
            other.gameObject.SetActive(false);
            Mat.color = Color.red;
        }
    }
}
