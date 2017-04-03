using UnityEngine;
using System.Collections;

public class ResourceSpawn : MonoBehaviour {

	public int ResourceCount;
	public Controlling cont;
	public GameObject Res;

	// Use this for initialization
	void Start () {
		ResourceCount = 0;

	}
	
	// Update is called once per frame
	void Update () {
		cont.ResourceCount = ResourceCount;
		if (GameObject.FindGameObjectWithTag ("Resource") == null) {
			Instantiate (Res, new Vector3 (Random.Range(0,GameObject.FindGameObjectWithTag ("Player").transform.position.x * 10), 5,Random.Range(0, GameObject.FindGameObjectWithTag ("Player").transform.position.z * 10)), Quaternion.identity);
			ResourceCount++;
		}
	}
}
