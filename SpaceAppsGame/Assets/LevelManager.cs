using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider colision)
    {
        if (colision.tag == "Level1")
        {
            SceneManager.LoadScene("Level2");
        }

        if (colision.tag == "Level2")
        {
            SceneManager.LoadScene("Level3");
        }

        if (colision.tag == "Level3")
        {
            SceneManager.LoadScene("Level4");
        }

        if (colision.tag == "Level4")
        {
            SceneManager.LoadScene("Level5");
        }

        if (colision.tag == "Level5")
        {
            SceneManager.LoadScene("Level6");
        }

        if (colision.tag == "Level6")
        {
            SceneManager.LoadScene("Level7");
        }

        if (colision.tag == "Level7")
        {
            SceneManager.LoadScene("Level8");
        }

        if (colision.tag == "Level8")
        {
            SceneManager.LoadScene("Level9");
        }



        if (colision.tag == "level_2")
        {
            SceneManager.LoadScene("Level1");
        }

        if (colision.tag == "level_3")
        {
            SceneManager.LoadScene("Level2");
        }

        if (colision.tag == "level_4")
        {
            SceneManager.LoadScene("Level3");
        }

        if (colision.tag == "level_5")
        {
            SceneManager.LoadScene("Level4");
        }

        if (colision.tag == "level_6")
        {
            SceneManager.LoadScene("Level5");
        }

        if (colision.tag == "level_7")
        {
            SceneManager.LoadScene("Level6");
        }

        if (colision.tag == "level_8")
        {
            SceneManager.LoadScene("Level7");
        }

        if (colision.tag == "level_9")
        {
            SceneManager.LoadScene("Level8");
        }
    }
}
