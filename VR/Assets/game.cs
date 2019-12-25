using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour {

	//
	public void ThrowPickUP()
	{
		print("撿起物件");
	}
	public void ThrowDetach(GameObject obj)
	{
		print("放開物件");

		Destroy(obj);
	}
	public void ThrowHeld()
	{
		print("拿著物件");
	}
}
