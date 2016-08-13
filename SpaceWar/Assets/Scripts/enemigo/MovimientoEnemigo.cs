using UnityEngine;
using System.Collections;

public class MovimientoEnemigo : MonoBehaviour {
	public float velocidadMovi = 0.5f;
	private float tiempo =  0.5f;
	private float aux;
	private bool v = false;
	// Use this for initialization
	void Start () {
		aux = tiempo;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (v) {
			transform.Translate (Vector3.right * velocidadMovi * Time.deltaTime);
		} else {
			transform.Translate (Vector3.left * velocidadMovi * Time.deltaTime);
		}
	
		tiempo = tiempo - Time.deltaTime;
		if (tiempo <= 0) {
		
			if (v) {
				v = false;
			} else {
				v = true;
			}
			tiempo = aux;
		}


	}
}
