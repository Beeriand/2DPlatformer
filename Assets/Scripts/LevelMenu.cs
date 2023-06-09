using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public Canvas levelMenu;
    public Canvas mainMenu;

    private void Start()
    {
        Time.timeScale= 1.0f;
    }

    public void btnLvl1()
    {
        levelMenu.enabled = false;
        SceneManager.LoadScene("LvL1");
    }

    public void btnLvl2()
    {
        levelMenu.enabled = false;
        SceneManager.LoadScene("LvL2");
    }

    public void btnLvl3()
    {
        levelMenu.enabled = false;
        SceneManager.LoadScene("LvL3");
    }
    public void btnLvl4()
    {
        levelMenu.enabled = false;
        SceneManager.LoadScene("LvL4");
    }

    public void btnBack()
    {
        mainMenu.enabled = true;
        levelMenu.enabled = false;
    }
}
