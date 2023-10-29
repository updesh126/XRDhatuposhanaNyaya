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

    [SerializeField]
    GameObject PourCurdMsg;
    [SerializeField]
    GameObject CurdDoneMsg;
    [SerializeField]
    GameObject TurnRightMsg;
    [SerializeField]
    GameObject VideoCanvas;

    [SerializeField]
    GameObject CurdSpoon;

    [SerializeField]
    GameObject CurdPot;

    private bool isMilkActive;
    private bool isCurdActive;
    private bool isMilkDone;

    private void Start()
    {
        isMilkActive = false;
        isCurdActive = false;
        isMilkDone = false;
        PourMilkmsg.SetActive(false);
        Turnoff.SetActive(false);
        milk.SetActive(false);
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (isMilkActive == false && other.CompareTag("Milk"))
        {
            yield return new WaitForSeconds(5.0f);
            milk.SetActive(true);
            PourMilkmsg.SetActive(false);
            isMilkActive = true;
            Turnon.SetActive(true);
            //StartCoroutine(MilkSet());
        }   
        if(isCurdActive== true &&other.CompareTag("Curd"))
        {
            PourCurdMsg.SetActive(false);
            yield return new WaitForSeconds(2.0f);
            TurnRightMsg.SetActive(true);
            CurdSpoon.SetActive(false);
            VideoCanvas.SetActive(true);
            yield return new WaitForSeconds(7.0f);
            milk.SetActive(false);
            CurdPot.SetActive(true);
            CurdDoneMsg.SetActive(true);
            TurnRightMsg.SetActive(false);

        }
        /*if(isMilkDone == true){
            yield return new WaitForSeconds(7.0f);
            Turnoff.SetActive(true);
            isCurdActive = true;
        }*/
        
    }
    public void MilkDone()
    {
        StartCoroutine(MilkSet());
        MilkSet();
        isMilkDone = true;
    }
    public IEnumerator MilkSet()
    {
        yield return new WaitForSeconds(7.0f);
        Turnoff.SetActive(true);
        isCurdActive = true;
    }
    
}
