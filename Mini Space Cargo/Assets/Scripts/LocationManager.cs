using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;



public class LocationManager : MonoBehaviour
{
    
    [Serializable]
    public struct MapLocations
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
    
    [SerializeField] MapLocations[] allMapLocations; 

    void Start()
    {
        
        GameObject mapSelectorTemplate = transform.GetChild (0).gameObject;
        GameObject g;
        int N = allMapLocations.Length;
        for (int i = 0; i < N; i++)
        {
            g = Instantiate (mapSelectorTemplate, transform);
            g.transform.GetChild (0).GetComponent <Image> ().sprite = allMapLocations [i].locationImage;
            g.transform.GetChild (1).GetComponent <TextMeshProUGUI> ().text = allMapLocations [i].systemName;
            g.transform.GetChild (2).GetComponent <TextMeshProUGUI> ().text = allMapLocations [i].locationName;
            g.transform.GetChild (3).GetComponent <TextMeshProUGUI> ().text = allMapLocations [i].dockType;
            g.transform.GetChild (4).GetComponent <TextMeshProUGUI> ().text = allMapLocations [i].industryType;

            
        }
        Destroy (mapSelectorTemplate);
    }


}
