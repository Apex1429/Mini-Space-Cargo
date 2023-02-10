using UnityEngine;
using UnityEngine.UI;
using System;



public class LocationManager : MonoBehaviour
{
    [Serializable]
    public struct Locations
    {
        public int locationID;
        public int systemID;
        
        public string locationName;
        public string systemName;
        public string dockType;
        public string industryType;

        public Sprite locationImage;

        public float distanceFromStar; 

    
    } 
    
    [SerializeField] Locations[] allLocations; 

    void Start()
    {
        
        GameObject mapSelectorTemplate = transform.GetChild (0).gameObject;
        GameObject g;
        int N = allLocations.Length;
        for (int i = 0; i < N; i++)
        {
            g = Instantiate (mapSelectorTemplate, transform);
            g.transform.GetChild (0).GetComponent <Image> ().sprite = allLocations [i].locationImage;
            g.transform.GetChild (1).GetComponent <Text> ().text = allLocations [i].systemName;
            g.transform.GetChild (2).GetComponent <Text> ().text = allLocations [i].locationName;
            g.transform.GetChild (3).GetComponent <Text> ().text = allLocations [i].dockType;
            g.transform.GetChild (4).GetComponent <Text> ().text = allLocations [i].industryType;

            
        }
        Destroy (mapSelectorTemplate);
    }


}
