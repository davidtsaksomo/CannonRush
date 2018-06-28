using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SwipeDetector : MonoBehaviour 
{
	
	public float minSwipeDistY;
	
	public float minSwipeDistX;
	
	private Vector2 startPos;
	public Vector2 newPos;
	public float posX = 0;
	void Update(){

	    if (Input.touchCount == 0) {
			newPos = new Vector2 (posX,transform.position.y);
			transform.position = Vector2.Lerp (transform.position, newPos, 5 * Time.deltaTime);
				}
		posX = Mathf.Clamp(posX, -27, 0);
		//#if UNITY_ANDROID
		if (Input.touchCount > 0) 
			
		{
			
			Touch touch = Input.touches[0];
			
			
			
			switch (touch.phase) 
				
			{
				
			case TouchPhase.Began:
				
				startPos = touch.position;
				
				break;
				
			case TouchPhase.Moved:
				transform.position = transform.position + new Vector3(touch.deltaPosition.x/45, 0, 0);
				break;

			case TouchPhase.Ended:
				
	
				
				float swipeDistHorizontal = (new Vector3(touch.position.x,0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;
				
				if (swipeDistHorizontal > minSwipeDistX) 
					
				{
					
					float swipeValue = Mathf.Sign(touch.position.x - startPos.x);
					
					if (swipeValue > 0)//right swipe
					{
						posX = posX +9;
					}
						else if (swipeValue < 0)//left swipe
					{
						posX = posX-9;
					}
				}
				break;
			
			}
		}
	}
}