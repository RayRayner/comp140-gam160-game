using UnityEngine;
using System.Collections;

public class ResourceSpawn : MonoBehaviour {
	//Setting our favourite variables
	public int ResourceCount;
	public Controlling cont;
	public GameObject Res;

	// No, you cant start with any
	void Start () {
		ResourceCount = 0;

	}

	void Update () {
		//Tells the main script how many wincons you have
		cont.ResourceCount = ResourceCount;
		//Creates new resource if none are found
		if (GameObject.FindGameObjectWithTag ("Resource") == null) {
			Instantiate (Res, new Vector3 (Random.Range(0,GameObject.FindGameObjectWithTag ("Player").transform.position.x * 10), 5,Random.Range(0, GameObject.FindGameObjectWithTag ("Player").transform.position.z * 10)), Quaternion.identity);
			//Adding to the amount of resources spawned already
			ResourceCount++;
		}
	}
}
