using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DhatuManager : MonoBehaviour
{
    [SerializeField] private GameObject[] Dhatu;


    private void Start()
    {
        for (int i = 0; i < Dhatu.Length; i++)
        {
            Dhatu[i].gameObject.SetActive(false);
        }
    }

    public void RasaDhatu( int number)
    {
        for (int i = 0; i < Dhatu.Length; i++)
        {
            Dhatu[i].gameObject.SetActive(false);
        }

        Dhatu[number -1].gameObject.SetActive(true);
    }
}
