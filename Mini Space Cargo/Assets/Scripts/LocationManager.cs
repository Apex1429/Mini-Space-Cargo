using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;

public class LocationManager : MonoBehaviour
{
   [Serializable]
    public struct Locations
    {
        public int LocationID;
        public int SystemID;
        
        public string LocationName;
        public string SystemName;
        public string DockType;
        public string IndustryType;

        public Sprite LocationImage;

        public float DistanceFromStar; 
    } 

    [SerializeField] Locations[] allLocations; 

    void Start()
    {
        GameObject MapSelectorTemplate = transform.GetChild (0).gameObject;
        GameObject g;
        int N = allLocations.Length;
        for (int i = 0; i < N; i++)
        {
            g = Instantiate (MapSelectorTemplate, transform);
            g.transform.GetChild (0).GetComponent <Image> ().sprite = allLocations [i].LocationImage;
            g.transform.GetChild (1).GetComponent <Text> ().text = allLocations [i].SystemName;
            g.transform.GetChild (2).GetComponent <Text> ().text = allLocations [i].LocationName;
            g.transform.GetChild (3).GetComponent <Text> ().text = allLocations [i].DockType;
            g.transform.GetChild (4).GetComponent <Text> ().text = allLocations [i].IndustryType;
            g.transform.GetChild (5).GetComponent <Text> ().text = allLocations [i].SystemName;  

            
        }
        Destroy (MapSelectorTemplate);
    }


}
