using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class MilkHit : MonoBehaviour
{
    [SerializeField]
    GameObject milk;

    [SerializeField]
    GameObject PourMilkmsg;

    [SerializeField]
    GameObject Turnoff;

    [SerializeField]
    GameObject Turnon;

    private bool isMilkActive;

    private void Start()
    {
        isMilkActive = false;
        PourMilkmsg.SetActive(false);
        Turnoff.SetActive(false);
        milk.SetActive(false);
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (isMilkActive== false &&other.CompareTag("Milk"))
        {
            yield return new WaitForSeconds(5.0f);
            milk.SetActive(true);
            PourMilkmsg.SetActive(false);
            isMilkActive=true;
            Turnon.SetActive(true);
            MilkDone();
        }
        
    }
    public IEnumerator MilkDone()
    {
        yield return new WaitForSeconds(7.0f);
        Turnoff.SetActive(true);

    }
}
