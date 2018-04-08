using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	  var json = Resources.Load<TextAsset>("UnityCloudBuildManifest.json");
	  GetComponent<Text>().text = json == null ? "null" : json.text;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
