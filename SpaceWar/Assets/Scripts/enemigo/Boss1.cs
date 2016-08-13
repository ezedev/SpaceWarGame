using UnityEngine;
using System.Collections;

public class Boss1 : MonoBehaviour {

	public float vida;
	public GameObject enemigoA;
	// Use this for initialization
	private float tiempoDeBajada = 3.0f;
	private bool vulnerable= false;
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {

		if (tiempoDeBajada > 0) {
			tiempoDeBajada = tiempoDeBajada - Time.deltaTime;
			transform.Translate (Vector3.down * 2 * Time.deltaTime);
		}
		//posX = (int)Random.Range (-7.60f, 7.60f);

	}

	public void activarSecuaces(int cantidad)
	{
		
	}
}
