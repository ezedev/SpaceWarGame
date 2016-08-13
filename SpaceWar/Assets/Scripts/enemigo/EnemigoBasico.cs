using UnityEngine;
using System.Collections;

public class EnemigoBasico : MonoBehaviour {

	public int vida = 100;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (vida <= 0) {
			this.transform.parent.GetComponent<GrupoManager> ().cantidad = this.transform.parent.GetComponent<GrupoManager> ().cantidad - 1;
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		
		if (other.gameObject.tag == "Bala") {

			vida = vida - 25;
		}

	}
}
