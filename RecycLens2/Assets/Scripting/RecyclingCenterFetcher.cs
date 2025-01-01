using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using SimpleJSON;

public class RecyclingCenterFetcher : MonoBehaviour
{
    public string apiKey = "4bea8f4441d74daaa0c851be6c045092";
    public string location = "Chennai, India"; // Example location
    public GameObject markerPrefab; // Prefab for marker visualization

    void Start()
    {
        StartCoroutine(FetchNearbyRecyclingCenters());
    }

    IEnumerator FetchNearbyRecyclingCenters()
    {
        string url = $"https://api.opencagedata.com/geocode/v1/json?q={location}&key={apiKey}";
        UnityWebRequest request = UnityWebRequest.Get(url);
        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Error: " + request.error);
        }
        else
        {
            JSONNode response = JSON.Parse(request.downloadHandler.text);
            var results = response["results"];
            foreach (JSONNode result in results)
            {
                double lat = result["geometry"]["lat"];
                double lng = result["geometry"]["lng"];
                string name = result["formatted"];
                AddMarker(lat, lng, name);
            }
        }
    }

    void AddMarker(double lat, double lng, string name)
    {
        var mapMarker = Instantiate(markerPrefab, new Vector3((float)lng, 0, (float)lat), Quaternion.identity);
        mapMarker.name = name;
        // Customize marker appearance as needed
    }
}
