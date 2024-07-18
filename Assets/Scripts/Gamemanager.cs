using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    bool hasGameEnded = false;
    public void Endgame()
    {
        if(hasGameEnded == false)
        {
            hasGameEnded = true;
            Invoke("Restart",0.6f);

        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
