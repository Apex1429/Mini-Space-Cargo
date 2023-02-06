using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
public class Currencies
{
    public int credits;
    public int antiMatter;



    public Currencies()
    {
        credits = 0;
        antiMatter = 0;
    }
}

public class PlayerDetails
{
    public float playerLevel;


    public PlayerDetails()
    {
        playerLevel = 1;
    }
}
}
