using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public static class ButtonExtension
{
	public static void AddEventListener<T> (this Button button, T param, Action<T> OnClick)
	{
		button.onClick.AddListener (delegate() {
			OnClick (param);
		});
	}
}


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

            g.GetComponent <Button> ().AddEventListener (i, ItemClicked);
            
        }
        Destroy (mapSelectorTemplate);
    }
    	void ItemClicked (int itemIndex)
	{
		Debug.Log ("------------item " + itemIndex + " clicked---------------");
		Debug.Log ("name " + allMapLocations [itemIndex].locationName);
		Debug.Log ("desc " + allMapLocations [itemIndex].systemName);

        if (itemIndex == 1 )
        {
            SceneManager.LoadScene(0);
        }
        else if (itemIndex == 2)
        {
            SceneManager.LoadScene(5);
        }
    }




}
