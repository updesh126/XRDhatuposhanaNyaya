using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TriggerExample : MonoBehaviour
{
    public string name;
    public void LoadScenen(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    // This method is called when another Collider enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the trigger zone!");
            // Add your desired actions here
            LoadScenen(name);

        }
    }

    
}