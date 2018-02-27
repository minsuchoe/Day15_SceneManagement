using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;      //Scene 로딩시 필요

public class GameManager : MonoBehaviour {
    public static GameManager instance = null;
    public int level = 1;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        InitGame();
    }

    private void InitGame()
    {

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.L))
            SceneManager.LoadScene("Lobby");
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene("Room");
        if (Input.GetKeyDown(KeyCode.P))
            SceneManager.LoadScene("Play");
    }
}
