using UnityEngine;
using System.Collections;
using System.IO.Ports;


/*
Messy code for Unity in C# to communicate and interpret data from the arduino. The arduino is reading data from users fingers using sensors than sending it to Unity through the SerialPort.
*/



public class script : MonoBehaviour {


	public GameObject obj;
	// Connect to correct Port that is connected to the Arduino
	SerialPort sp =  new SerialPort("/dev/cu.usbmodem1411",9600);
	private Color originalColor;


	// Use this for initialization
	void Start () {
		
		//Open connection
		sp.Open();
		//Throws exception if nothing is passed through stream for x time.
		sp.ReadTimeout = 80000;

	}
	// Update is called once per frame
	void Update () {

		if (sp.IsOpen) {
			try {
				int i = sp.ReadByte();
				Event(i);
			}
			catch (System.Exception) {
				throw;
			}
		}
	}

	void Event(int Value) {
		obj = GameObject.Find ("Cube1");
		originalColor = obj.GetComponent<Renderer>().material.GetColor("_Color");
		if (Value == 1 || Value == 11 || Value == 31)  {
			obj = GameObject.Find ("Cube1");
			if (Value == 11) {
				obj.GetComponent<Renderer>().material.color = Color.red;
			} if (Value == 1) {
				obj.GetComponent<Renderer>().material.color = Color.green;
			}
			if (Value == 31) {
				obj.GetComponent<Renderer>().material.color = originalColor;
			  }
		}
		if (Value == 2 || Value == 22 || Value == 32)  {
			obj = GameObject.Find ("Cube2");
			if (Value == 22) {
				obj.GetComponent<Renderer>().material.color = Color.red;
			} if (Value == 2) {
				obj.GetComponent<Renderer>().material.color = Color.green;
			}
			if (Value == 32) {
				obj.GetComponent<Renderer>().material.color = originalColor;
			}
		}
		if (Value == 3 || Value == 33 || Value == 43)  {
			obj = GameObject.Find ("Cube3");
			if (Value == 33) {
				obj.GetComponent<Renderer>().material.color = Color.red;
			} if (Value == 3) {
				obj.GetComponent<Renderer>().material.color = Color.green;
			} if (Value == 43) {
				obj.GetComponent<Renderer>().material.color = originalColor;
			}
		}
		if (Value == 4 || Value == 44 || Value == 34)  {
			obj = GameObject.Find ("Cube4");
			if (Value == 44) {
				obj.GetComponent<Renderer>().material.color = Color.red;
			} if (Value == 4) {
				obj.GetComponent<Renderer>().material.color = Color.green;
			}
			if (Value == 34) {
				obj.GetComponent<Renderer> ().material.color = originalColor;
			}
		}
		if (Value == 5 || Value == 55 || Value == 35)  {
			obj = GameObject.Find ("Cube");
			if (Value == 55) {
				obj.GetComponent<Renderer>().material.color = Color.red;
			} if (Value == 5) {
				obj.GetComponent<Renderer>().material.color = Color.green;
			}
			if (Value == 35) {
				obj.GetComponent<Renderer>().material.color = originalColor;
			}
		}
		if (Value == 6 || Value == 66 || Value == 36)  {
			obj = GameObject.Find ("Cube6");
			if (Value == 66) {
				obj.GetComponent<Renderer>().material.color = Color.red;
			} if (Value == 6) {
				obj.GetComponent<Renderer>().material.color = Color.green;
			}
			if (Value == 36) {
				obj.GetComponent<Renderer>().material.color = originalColor;
			}
		}
		if (Value == 7 || Value == 77 || Value == 37)  {
			obj = GameObject.Find ("Cube7");
			if (Value == 77) {
				obj.GetComponent<Renderer>().material.color = Color.red;
			} if (Value == 7) {
				obj.GetComponent<Renderer>().material.color = Color.green;
			}
			if (Value == 37) {
				obj.GetComponent<Renderer>().material.color = originalColor;
			}
		}
		if (Value == 8 || Value == 88 || Value == 38)  {
			obj = GameObject.Find ("Cube8");
			if (Value == 88) {
				obj.GetComponent<Renderer>().material.color = Color.red;
			} if (Value == 8) {
				obj.GetComponent<Renderer>().material.color = Color.green;
			}
			if (Value == 38) {
				obj.GetComponent<Renderer>().material.color = originalColor;
			}
		}
		if (Value == 19 || Value == 99 || Value == 39)  {
			obj = GameObject.Find ("Cube9");
			if (Value == 99) {
				obj.GetComponent<Renderer>().material.color = Color.red;
			} if (Value == 19) {
				obj.GetComponent<Renderer>().material.color = Color.green;
			}
			if (Value == 39) {
				obj.GetComponent<Renderer>().material.color = originalColor;
			}
		}
	}
}