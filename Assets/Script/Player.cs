using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private Rigidbody rb;
    [SerializeField]
    private float speed;

    private Animator anim;

    float lengthinZaxis = 7.6f;
    Vector3 lastposition;

    [SerializeField]
    GameObject platform;

    [SerializeField]
    Transform firstobject;

    //[SerializeField]
    //MeshRenderer platformmesh;


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0f, 0f, speed);
        lastposition = firstobject.transform.position;
        //Debug.Log(platformmesh.bounds.size);

        InvokeRepeating("Spawning",0f, 0.3f);

	}
	
    private void Spawning()
    {
        GameObject _object = Instantiate(platform) as GameObject;
        _object.transform.position = lastposition + new Vector3(0f, 0f, lengthinZaxis);
        lastposition = _object.transform.position;

    }
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0))
        {
            rb.AddForce(0f,07, 0f,ForceMode.Impulse);
            anim.Play("Jumping");
        }
		
	}
}
