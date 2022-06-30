using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CubeJump : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetMouseButtonDown(0)){
			RaycastHit hit; 
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
			if ( Physics.Raycast (ray,out hit,100.0f)){
				if(hit.transform.gameObject.name == "Cube A"){
					hit.transform.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0), ForceMode.Impulse);
				}
			}
		}*/
    }
	
	public void OnPointerClick(PointerEventData pointerEventData)
    {
        //Debug.Log(name + " Game Object Clicked!");
		pointerEventData.pointerPress.GetComponent<Rigidbody>().AddForce(Vector3.up * 100, ForceMode.Impulse);
    }
}
