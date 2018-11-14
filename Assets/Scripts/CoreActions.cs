using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoreActions : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void Accept()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    public void Decline()
    {
        Application.Quit();
    }

}
