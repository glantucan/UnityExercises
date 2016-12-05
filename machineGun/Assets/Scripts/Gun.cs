using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	[SerializeField] GameObject target;
	[SerializeField] GameObject bulletPrefab;
	[SerializeField] float v;

	private GameObject bulletInstance;
	private Vector3 direction;

	// Update is called once per frame
	void Update () {
		if (Time.frameCount % 10 == 0) {
			bulletInstance = Object.Instantiate(bulletPrefab);
			bulletInstance.transform.position = this.transform.position + this.transform.forward * 1.5F + this.transform.up; 

			Vector3 distance = target.transform.position - bulletInstance.transform.position;
			direction = distance.normalized;
		}

		if (bulletInstance != null) {
			bulletInstance.transform.position += v * direction*Time.deltaTime; 	
		}
	}
}
