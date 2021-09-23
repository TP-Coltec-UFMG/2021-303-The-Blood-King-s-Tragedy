using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public Button buttonNewGame;
    public string cena;
    // Start is called before the first frame update
    void Start()
    {
        buttonNewGame.Select();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame(){

        
        SceneManager.LoadScene(cena);

    }

    public void QuitGame(){

        UnityEditor.EditorApplication.isPlaying = false;
        //Application.Quit();

    } 
}