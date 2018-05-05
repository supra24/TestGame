using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public GameObject hexPrefab;

    int width = 5;
    int height = 5;

    float xOffset = 0.882f;
    float zOffset = 0.764f;

	// Use this for initialization
	void Start () {
		
        for (int x = - width; x < width; x ++){
            for (int y = - height; y < height; y ++){

                float xPos = x * xOffset;

                if ( Mathf.Abs( y) % 2 == 1)
                {
                    xPos += xOffset / 2;
                }

                GameObject hex_go = (GameObject) Instantiate(hexPrefab, new Vector3( xPos , 0, y * zOffset), Quaternion.identity);

                hex_go.name = "Surface_" + x + "_" + y;
                hex_go.transform.SetParent(transform);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
