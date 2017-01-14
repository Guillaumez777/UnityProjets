using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallaxScript : MonoBehaviour {

    private float offset;
    public int speed;
    public GameObject Player;

	void Update () {
        offset = Player.transform.position.x / speed;
        GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
	}
}
