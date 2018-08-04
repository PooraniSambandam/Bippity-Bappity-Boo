using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    [SerializeField]
    Transform target;
    Vector3 offset;
	// Use this for initialization
	void Start () {

       offset = target.transform.position - transform.position;

	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = target.transform.position - offset;
        this.transform.position = Vector3.Lerp(this.transform.position, pos, 1.5f);

	}
}
