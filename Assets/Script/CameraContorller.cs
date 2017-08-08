using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContorller : MonoBehaviour {

    [Header("玩家物件")]
    public GameObject player;

    [Header("相對位移")]
    public Vector3 offset;

    [Header("推力")]
    public float push;

    // Use this for initialization
    void Start () {

        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {

        transform.position = player.transform.position + offset;

    }
}
