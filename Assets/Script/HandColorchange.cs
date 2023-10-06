using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandColorchange : MonoBehaviour
{
    public void ChangeColor()
    {
       GetComponent<Material>().color = Color.blue;
    }

}
