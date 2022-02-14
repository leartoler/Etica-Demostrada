using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    
    
    public void Scene()
    {
    	SceneManager.LoadScene("Scene02");
    	Debug.Log("aber si funciona");
    }
}
        
        
  
    
