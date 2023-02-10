using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public void ShipList()
    {
        SceneManager.LoadScene(1);
    }

    public void SelectShipTemp()
    {
        SceneManager.LoadScene(0);
    }

    public void JobList()
    {
        SceneManager.LoadScene(3);
    }

    public void Map()
    {
        SceneManager.LoadScene(4);
    }
    

}
