using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour {

    public bool haveKey;

	//公開並且參數零或一個
	public void ThrowPickUP()
	{
		print("撿起物件");
	}
	public void ThrowDetach(GameObject obj)
	{
		print("放開物件");
        haveKey = true;
		Destroy(obj);
	}
	public void ThrowHeld()
	{
		print("拿著物件");
	}
}
