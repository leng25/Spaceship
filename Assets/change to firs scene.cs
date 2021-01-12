using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changetofirsscene : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
           		
	}
	
	// Update is called once per frame
	void Update ()
    {
        change();

   }

    public void change()
    {
        Invoke("LoadFirstScene", 8f);
    }

    public void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
