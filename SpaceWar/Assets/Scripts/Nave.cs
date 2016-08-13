using UnityEngine;
using System.Collections;

public class Nave : MonoBehaviour {
	private float velocidad = 5.0f;
	public GameObject Proyectil;
	public GameObject Bala1;
	public GameObject Bala2;
	public GameObject Bala3;
	public GameObject puntoSalida;
	private int numeroDeArma = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate(Time.deltaTime * velocidad, 0, 0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate(-Time.deltaTime * velocidad, 0, 0);
		}
		if (Input.GetKeyDown("space")) {
			//GameObject balaNueva = Instantiate(bala,puntoSalida.transform.position, Quaternion.identity) as GameObject;
			//balaNueva.GetComponent<Rigidbody2D>().velocity = puntoSalida.transform.TransformDirection(Vector3.right *potenciaDeSalida);

			GameObject bala = Instantiate (Proyectil, puntoSalida.transform.position, Quaternion.identity)as GameObject;
			bala.GetComponent<Rigidbody2D> ().velocity = puntoSalida.transform.TransformDirection (Vector3.up * 20);
		}
	}

	void OnTriggerEnter2D(Collider2D other) {


		if (other.gameObject.tag == "powerUp") {

			Debug.Log ("si toca la mierda");
			Destroy (other.gameObject);
			if (numeroDeArma == 1) {
				Proyectil = Bala2;
				numeroDeArma = 2;
			}
			else if (numeroDeArma == 2) {
				Proyectil = Bala3;
				numeroDeArma = 3;
			}
		}
	}

}
