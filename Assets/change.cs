using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    // Use this for initialization


    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        changeScene();

    }
    public void changeScene()
    {
        Invoke("LoadFirstScene", 8f);
    }

    public void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
       
    }

}
