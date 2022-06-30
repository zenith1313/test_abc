using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CubeClick : MonoBehaviour
{
	
    // Start is called before the first frame update
    void Start()
    {
        int[] arr = {1,2,3};
		/*int[] res1 = new int[3];
		
		for(int i=0; i<3; i++){
			res1[i] = arr[i] * 2;
		}
		
		
		string arrlog = "";
		foreach(int i in arr){
			arrlog += i + ", ";
		}
		Debug.Log("arr :" + arrlog);
		string reslog = "";
		foreach(int i in res1){
			reslog += i + ", ";
		}
		Debug.Log("res1 :" + reslog);
		
		
		List<int> res2 = new List<int>();
		foreach (int i in res1) {
			if (i > 3) res2.Add(i);
		}

		string res2log = "";
		foreach (int i in res2)
		{
			res2log += i + ", ";
		}
		Debug.Log("res2 :" + res2log);


		int res3 = res2.Sum();
		Debug.Log("res3 :" + res3);*/

		var res1 = arr.Select(x => x * 2);
		var res2 = res1.Where(x => x > 3);
		var res3 = res2.Aggregate((x, y) => x + y);

	}

    
	
}
