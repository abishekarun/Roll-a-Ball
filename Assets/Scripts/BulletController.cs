using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	public float bulletspeed=50;
	public float count=0;

	public void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);
		gameObject.transform.position += movement * bulletspeed * Time.deltaTime;
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Wall") 
		{
			//other.gameObject.SetActive (false);
			Destroy(gameObject);
		}
		if (other.gameObject.tag == "PickUp") 
		{
			//other.gameObject.SetActive (false);
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}
	void OnCollisionEnter(Collision thecollision){
		if (thecollision.gameObject.tag == "Wall") 
		{
			//other.gameObject.SetActive (false);
			Destroy(this.gameObject);
			print ("Destroyed");
		}
	}
}
