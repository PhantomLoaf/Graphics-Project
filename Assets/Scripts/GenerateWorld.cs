using UnityEngine;
using System.Collections;

public class GenerateWorld : MonoBehaviour {
    public int limit = 10;
    public GameObject root;
	// Use this for initialization
	void Start () {
        for (int i = 0; i < limit; i++)
        {
            GameObject go = Instantiate(root);
            go.transform.position = new Vector3(i * 1.0f, 0, 0);
            go.transform.rotation = Quaternion.identity;
            go.transform.SetParent(root.transform);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
