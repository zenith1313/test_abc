using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CubeMove : MonoBehaviour, IPointerClickHandler
{
	private bool isGoup = false, isMove = false;
	private Transform target = null;
	
    

    // Update is called once per frame
    void FixedUpdate()
    {
        /*if(Input.GetMouseButtonDown(0)){
			RaycastHit hit; 
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
			if ( Physics.Raycast (ray,out hit,100.0f)){
				if(hit.transform.gameObject.name == "Cube B"){
					target = hit.transform;
					isMove = true;
				}
			}
		}*/
		
		if(isMove){
			Vector3 oldpos = target.position;
			if(isGoup){
				if(target.position.y >= 4f)isGoup = false;
				target.position = oldpos + new Vector3(0, 0.1f, 0);
			}else{
				if(target.position.y <= -4f)isGoup = true;
				target.position = oldpos + new Vector3(0, -0.1f, 0);
			}
		}
    }
	
	public void OnPointerClick(PointerEventData pointerEventData)
    {
        //Debug.Log(name + " Game Object Clicked!");
		target = pointerEventData.pointerPress.transform;
		isMove = true;
    }
}
